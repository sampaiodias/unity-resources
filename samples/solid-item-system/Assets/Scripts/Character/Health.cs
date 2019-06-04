using UnityEngine;

namespace SampaioDias.SolidItemSystem
{
    [System.Serializable]
    public class Health
    {
        public float InitialValue { get; private set; }
        public float Value { get; private set; }

        public Health(float initialValue)
        {
            InitialValue = initialValue;
            Value = initialValue;
        }

        public void Damage(float value)
        {
            Value = Mathf.Clamp(Value - value, 0, InitialValue);
        }

        public void Heal(float value)
        {
            Value = Mathf.Clamp(Value + value, 0, InitialValue);
        }

        public float Percent()
        {
            return Value / InitialValue;
        }

        public bool IsEmpty()
        {
            return Percent() == 0;
        }
    }
}
