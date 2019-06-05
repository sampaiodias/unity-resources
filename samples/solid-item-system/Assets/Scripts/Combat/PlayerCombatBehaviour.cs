namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    [RequireComponent(typeof(Character))]
    public class PlayerCombatBehaviour : MonoBehaviour, ICombatBehaviour
    {
        private Character character;

        private void Awake()
        {
            character = GetComponent<Character>();
        }

        public void PrimaryAttack()
        {
            character.items.UseWeapon(0);
        }

        public void SecondaryAttack()
        {
            character.items.UseWeapon(1);
        }
    }
}
