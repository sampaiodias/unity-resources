namespace SampaioDias.SolidItemSystem
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "Items/Artifacts/Potion")]
    public class Potion : Artifact
    {
        private Character character;
        public float healAmount;

        public override void Config(Character character)
        {
            this.character = character;
        }

        public override void Use()
        {
            character.stats.Heal(healAmount);
        }
    }
}
