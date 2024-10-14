using UnityEngine;

namespace Assets.Source.Entity.Chimps.Behaviours.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Configuration", menuName = "Configuration/ChimpBehaviour")]
    public class ChimpBehaviourConfiguration : ScriptableObject
    {
        [SerializeField] private float _walkSpeed;
        [SerializeField] private float _waitingTime;
        [SerializeField] private float _chimpsAreaRadius;

        public float WalkSpeed => _walkSpeed;
        public float WaitingTime
        {
            get
            {
                return Random.Range(0, _waitingTime);
            }
        }
        public float ChimpsAreaRadius => _chimpsAreaRadius;
    }
}