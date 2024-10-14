using Assets.Source.Player;
using UnityEngine;

namespace Assets.Source.Boostrap
{
    public class Boostrap : MonoBehaviour
    {
        [Header("Player control reference's")]
        [SerializeField] private InputSystem _input;
        [SerializeField] private LookPointMovement _lookPoint;

        private void Awake()
        {
            Run();
        }

        public void Run()
        {
            _lookPoint.Initialize(_input);
        }
    }
}
