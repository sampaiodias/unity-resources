namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    [CreateAssetMenu]
    public class CharacterStats : Stats
    {
        public Health health;
        public string team;

        public override float GetHealth()
        {
            return health.Value;
        }

        public override float GetHealthPercent()
        {
            return health.Percent();
        }

        public override float GetMaxHealth()
        {
            return health.InitialValue;
        }

        public override void Heal(float value)
        {
            health.Heal(value);
        }

        public override void Damage(float value)
        {
            health.Damage(value);
        }
    }
}
