using System;
using UnityEngine;

namespace Assets.Source.Player
{
    public class InputSystem : MonoBehaviour
    {
        public event Action<Vector2> Moved;

        private Vector2 _moveVector = new Vector2();

        private void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            if (x != 0 || y != 0)
            { 
                _moveVector.Set(x, y);
                Moved?.Invoke(_moveVector);
            }
        }
    }
}
