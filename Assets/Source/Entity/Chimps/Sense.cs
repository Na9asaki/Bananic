using System;
using UnityEngine;

namespace Assets.Source.Entity.Chimps
{
    internal class Sense
    {
        public event Action<float> ChangeValuePrecent;

        private float _maxValue;
        private float _value;

        public float Value => _value;

        public Sense(float maxValue)
        {
            _maxValue = maxValue;
            _value = maxValue;
        }

        private void Change(float value)
        {
            _value = Mathf.Clamp(_value + value, 0, _maxValue);
            ChangeValuePrecent?.Invoke(value / _maxValue);
        }

        public void Increase(float value)
        {
            Change(value);
        }

        public void Decrease(float value)
        {
            Change(-value);
        }
    }
}
