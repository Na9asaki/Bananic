using UnityEngine;

namespace Assets.Source.Entity.Chimps.Behaviours.ScriptableObjects
{
    [CreateAssetMenu(fileName = "IndicatorsConfiguration", menuName = "Configuration/Indicators")]
    public class ChimpIndicatorValues : ScriptableObject
    {
        [SerializeField] private float _hungerMaxValue;
        [SerializeField] private float _healthMaxValue;
        [SerializeField] private float _joyMaxValue;

        public float HungerMaxValue => _hungerMaxValue;
        public float HealthMaxValue => _healthMaxValue;
        public float JoyMaxValue => _joyMaxValue;
    }
}