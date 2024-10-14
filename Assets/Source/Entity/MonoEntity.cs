using UnityEngine;

namespace Assets.Source.Entity
{
    public abstract class MonoEntity : MonoBehaviour
    {
        private Vector3 _position;

        public Vector3 Position => transform.position;

        private void Awake()
        {
            _position = transform.position;
            Initialize();
        }

        protected abstract void Initialize();
    }
}
