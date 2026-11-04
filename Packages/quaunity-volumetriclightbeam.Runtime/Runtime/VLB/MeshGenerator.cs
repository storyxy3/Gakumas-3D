namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    public static class MeshGenerator
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_0
        {
            public int numSides;
            public int vertCountSides;
            public Func<int, int> vertSidesStartFromSlide;
            public Func<int, int> vertCenterFromSlide;
            public _003C_003Ec__DisplayClass6_0()
            {
            }

            internal int _003CGenerateConeZ_Radii_DoubleCaps_003Eb__0(int slideID)
            {
                return numSides * slideID;
            }

            internal int _003CGenerateConeZ_Radii_DoubleCaps_003Eb__1(int slideID)
            {
                return vertCountSides + slideID;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_1
        {
            public int[] indices;
            public int ind;
            public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass6_1()
            {
            }

            internal void _003CGenerateConeZ_Radii_DoubleCaps_003Eb__2(int slideID, bool invert)
            {
                int start = CS_0024_003C_003E8__locals1.vertSidesStartFromSlide(slideID);
                int nextOffset = invert ? 1 : 2;
                int currentOffset = invert ? 2 : 1;
                for (int i = 0; i < CS_0024_003C_003E8__locals1.numSides - 1; i++)
                {
                    indices[ind] = CS_0024_003C_003E8__locals1.vertCenterFromSlide(slideID);
                    indices[ind + nextOffset] = start + i + 1;
                    indices[ind + currentOffset] = start + i;
                    ind += 3;
                }
                indices[ind] = CS_0024_003C_003E8__locals1.vertCenterFromSlide(slideID);
                indices[ind + nextOffset] = start;
                indices[ind + currentOffset] = start + CS_0024_003C_003E8__locals1.numSides - 1;
                ind += 3;
            }
        }

        private static float GetAngleOffset(int numSides)
        {
            return numSides == 4 ? 0.7853982f : 0f;
        }

        private static float GetRadiiScale(int numSides)
        {
            return numSides == 4 ? 1.4142135f : 1f;
        }

        public static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
        {
            var mesh = new Mesh();
            int ringSize = numSides + 1;
            int ringCount = numSegments + 2;
            bool hasCap = radiusStart > 0f && cap;
            float scale = GetRadiiScale(numSides);
            float angleOffset = GetAngleOffset(numSides);
            float startRadius = Mathf.Max(radiusStart, 0.001f) * scale;
            float endRadius = radiusEnd * scale;
            int sideVertexCount = ringCount * ringSize;
            int vertexCount = sideVertexCount + (hasCap ? numSides + 2 : 0);
            var vertices = new Vector3[vertexCount];
            for (int i = 0; i < numSides; i++)
            {
                float angle = angleOffset + i * (Mathf.PI * 2f) / numSides;
                float cosine = Mathf.Cos(angle);
                float sine = Mathf.Sin(angle);
                for (int j = 0; j < ringCount; j++)
                {
                    float t = (float)j / (numSegments + 1);
                    float radius = Mathf.Lerp(startRadius, endRadius, t);
                    vertices[j * ringSize + i] = new Vector3(cosine * radius, sine * radius, t * lengthZ);
                }
            }
            for (int j = 0; j < ringCount; j++) vertices[j * ringSize + numSides] = vertices[j * ringSize];
            if (hasCap)
            {
                vertices[sideVertexCount] = Vector3.zero;
                for (int i = 0; i < numSides; i++)
                {
                    float angle = angleOffset + i * (Mathf.PI * 2f) / numSides;
                    vertices[sideVertexCount + i + 1] = new Vector3(Mathf.Cos(angle) * startRadius, Mathf.Sin(angle) * startRadius, 0f);
                }
                vertices[sideVertexCount + numSides + 1] = vertices[sideVertexCount + 1];
            }
            if (doubleSided)
            {
                var doubled = new Vector3[vertices.Length * 2];
                vertices.CopyTo(doubled, 0);
                vertices.CopyTo(doubled, vertices.Length);
                vertices = doubled;
            }
            mesh.vertices = vertices;
            var uv = new Vector4[vertexCount];
            for (int i = 0; i < sideVertexCount; i++)
                uv[i] = new Vector4(0f, 0f, (float)(i % ringSize) / (ringSize - 1f), (i / ringSize) / (numSegments + 1f));
            if (hasCap)
            {
                for (int i = sideVertexCount; i < vertexCount; i++) uv[i] = new Vector4(1f, 0f, 0f, 0f);
            }
            if (doubleSided)
            {
                var doubled = new Vector4[uv.Length * 2];
                uv.CopyTo(doubled, 0);
                uv.CopyTo(doubled, uv.Length);
                for (int i = 0; i < uv.Length; i++) doubled[uv.Length + i].y = 1f;
                uv = doubled;
            }
            mesh.SetUVs(0, uv);
            var indices = new int[3 * ((hasCap ? numSides : 0) + 2 * numSides * Mathf.Max(1, numSegments + 1))];
            int index = 0;
            for (int i = 0; i < numSides; i++)
            {
                for (int j = 0; j < numSegments + 1; j++)
                {
                    int vertex = i + j * ringSize;
                    indices[index++] = vertex;
                    indices[index++] = vertex + 1;
                    indices[index++] = vertex + ringSize;
                    indices[index++] = vertex + ringSize + 1;
                    indices[index++] = vertex + ringSize;
                    indices[index++] = vertex + 1;
                }
            }
            if (hasCap)
            {
                for (int i = 0; i < numSides; i++)
                {
                    indices[index++] = sideVertexCount;
                    indices[index++] = sideVertexCount + i + 2;
                    indices[index++] = sideVertexCount + i + 1;
                }
                // The APK writes this closing triangle after the cap loop as well.
                indices[index++] = sideVertexCount;
                indices[index++] = sideVertexCount + 1;
                indices[index] = sideVertexCount + numSides;
            }
            if (doubleSided)
            {
                var doubled = new int[indices.Length * 2];
                indices.CopyTo(doubled, 0);
                for (int i = 0; i < indices.Length; i += 3)
                {
                    doubled[indices.Length + i] = indices[i] + vertexCount;
                    doubled[indices.Length + i + 1] = indices[i + 2] + vertexCount;
                    doubled[indices.Length + i + 2] = indices[i + 1] + vertexCount;
                }
                indices = doubled;
            }
            mesh.triangles = indices;
            mesh.bounds = ComputeBounds(lengthZ, startRadius, endRadius);
            return mesh;
        }

        public static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
        {
            var sides = new _003C_003Ec__DisplayClass6_0 { numSides = numSides };
            var mesh = new Mesh();
            radiusStart = Mathf.Max(radiusStart, 0.001f);
            sides.vertCountSides = numSides * 2;
            sides.vertSidesStartFromSlide = sides._003CGenerateConeZ_Radii_DoubleCaps_003Eb__0;
            sides.vertCenterFromSlide = sides._003CGenerateConeZ_Radii_DoubleCaps_003Eb__1;
            float angleOffset = GetAngleOffset(numSides);
            var vertices = new Vector3[sides.vertCountSides + 2];
            for (int i = 0; i < numSides; i++)
            {
                float angle = angleOffset + i * (Mathf.PI * 2f) / numSides;
                float cosine = Mathf.Cos(angle);
                float sine = Mathf.Sin(angle);
                for (int j = 0; j < 2; j++)
                {
                    float radius = Mathf.Lerp(radiusStart, radiusEnd, j);
                    vertices[sides.vertSidesStartFromSlide(j) + i] = new Vector3(cosine * radius, sine * radius, j * lengthZ);
                }
            }
            vertices[sides.vertCenterFromSlide(0)] = Vector3.zero;
            vertices[sides.vertCenterFromSlide(1)] = new Vector3(0f, 0f, lengthZ);
            mesh.vertices = vertices;
            var triangles = new _003C_003Ec__DisplayClass6_1
            {
                CS_0024_003C_003E8__locals1 = sides,
                indices = new int[12 * numSides], ind = 0
            };
            for (int i = 0; i < numSides; i++)
            {
                int next = i + 1 == numSides ? 0 : i + 1;
                triangles.indices[triangles.ind] = i;
                triangles.indices[triangles.ind + (inverted ? 1 : 2)] = next;
                triangles.indices[triangles.ind + (inverted ? 2 : 1)] = i + numSides;
                triangles.indices[triangles.ind + 3] = next + numSides;
                triangles.indices[triangles.ind + (inverted ? 4 : 5)] = i + numSides;
                triangles.indices[triangles.ind + (inverted ? 5 : 4)] = next;
                triangles.ind += 6;
            }
            Action<int, bool> fillCap = triangles._003CGenerateConeZ_Radii_DoubleCaps_003Eb__2;
            fillCap(0, inverted);
            fillCap(1, !inverted);
            mesh.triangles = triangles.indices;
            mesh.bounds = ComputeBounds(lengthZ, radiusStart, radiusEnd);
            return mesh;
        }

        public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
        {
            float radius = Mathf.Max(radiusStart, radiusEnd);
            return new Bounds(new Vector3(0f, 0f, lengthZ * 0.5f), new Vector3(radius * 2f, radius * 2f, lengthZ));
        }
    }
}
