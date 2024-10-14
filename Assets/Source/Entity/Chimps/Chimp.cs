using Assets.Source.Entity.Chimps.Behaviours;
using Assets.Source.Entity.Chimps.Behaviours.ScriptableObjects;
using Assets.Source.Entity.Chimps.UI;
using UnityEngine;

namespace Assets.Source.Entity.Chimps
{
    public class Chimp : MonoEntity
    {
        [Header("Reference's")]
        [SerializeField] private ChimpBehaviour _behaviour;
        [SerializeField] private IndicatorsView _indicatorsView;
        [Header("Configuration")]
        [SerializeField] private ChimpIndicatorValues _indicatorsConfig;

        private Indicators _indicators;

        protected override void Initialize()
        {
            _behaviour.Initialize();
            _behaviour.EnterIn<WalkState>();

            _indicators = new Indicators(_indicatorsConfig.HungerMaxValue, _indicatorsConfig.HealthMaxValue, _indicatorsConfig.JoyMaxValue);
            _indicatorsView.Initialize(_indicators);
        }

        private void Update()
        {
            _behaviour.Update();
        }
    }
}