namespace Qua.Utility
{
    using global::System.Text;

    public static class PathUtility
    {
        public static string Combine(params string[] paths)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < paths.Length; i++)
            {
                if (i == 0)
                {
                    builder.Append(paths[i]);
                }
                else if (paths[i - 1][paths[i - 1].Length - 1] == '/' || paths[i][0] == '/')
                {
                    builder.Append(paths[i]);
                }
                else
                {
                    builder.Append("/");
                    builder.Append(paths[i]);
                }
            }
            builder.Replace("//", "/");
            return builder.ToString();
        }
    }
}
