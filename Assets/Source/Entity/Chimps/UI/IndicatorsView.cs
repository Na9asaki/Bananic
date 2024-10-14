using UnityEngine;
using UnityEngine.UI;

namespace Assets.Source.Entity.Chimps.UI
{
    internal class IndicatorsView : MonoBehaviour
    {
        [SerializeField] private Slider _hungerView, _healthView, _joyView;

        public void Initialize(Indicators indicators)
        {
            indicators.Hunger.ChangeValuePrecent += ChangeHungerValue;
            indicators.Health.ChangeValuePrecent += ChangeHealthValue;
            indicators.Joy.ChangeValuePrecent += ChangeJoyValue;
        }

        private void Change(Slider slider, float precentValue)
        {
            slider.value = precentValue;
        }

        private void ChangeHungerValue(float value)
        {
            Change(_hungerView, value);
        }
        private void ChangeHealthValue(float value)
        {
            Change(_healthView, value);
        }
        private void ChangeJoyValue(float value)
        {
            Change(_joyView, value);
        }
    }
}