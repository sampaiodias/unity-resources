namespace SampaioDias.SolidItemSystem
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "Items/Artifacts/Potion")]
    public class Potion : Artifact
    {
        public CharacterStats stats;
        public float healAmount;

        public override void Use()
        {
            stats.health.Heal(healAmount);
        }
    }
}
