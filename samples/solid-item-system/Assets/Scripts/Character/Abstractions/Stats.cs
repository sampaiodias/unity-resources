namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public abstract class Stats : ScriptableObject
    {
        public abstract float GetHealth();
        public abstract float GetMaxHealth();
        public abstract float GetHealthPercent();
        public abstract void Damage(float value);
        public abstract void Heal(float value);
    }
}
