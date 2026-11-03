namespace Campus.Photography
{
    using global::Campus.Common;
    using global::UnityEngine;

    public class PhotographyActivityMoveController : MonoBehaviour
    {
        private const float WalkSpeed = 4f;
        [SerializeField]
        private CharacterController _collider;
        private Vector3 _startPosition;
        public CharacterController Collider
        {
            get
            {
                return null;
            }
        }

        public void SetInitializePosition(Vector3 position, float colliderY)
        {
        }

        public void SetPosition(Vector3 pos, float colliderY)
        {
        }

        public void UpdateGravity()
        {
        }

        public void Move(Vector2 diffDeltaVector)
        {
        }

        private void MoveCollider(float x, float z)
        {
        }

        public void SetActorFront(ICampusActorController actorController, Vector3 offset)
        {
        }

        public PhotographyActivityMoveController()
        {
        }
    }
}
