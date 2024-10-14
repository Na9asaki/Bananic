using UnityEngine;

namespace Assets.Source.Player
{
    public class LookPointMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Transform _pointTransform;

        private void Awake()
        {
            _pointTransform = transform;
        }

        public void Initialize(InputSystem system)
        {
            system.Moved += OnPointMoved;
        }

        private void OnPointMoved(Vector2 direction)
        {
            Vector3 direction3 = new Vector3(direction.x, 0, direction.y);
            _pointTransform.position += direction3 * _speed * Time.deltaTime;
        }
    }
}