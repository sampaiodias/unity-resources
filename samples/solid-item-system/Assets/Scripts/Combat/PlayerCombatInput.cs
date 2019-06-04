namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public class PlayerCombatInput : MonoBehaviour, ICombatInput
    {

        public KeyCode primaryAttackButton;
        public KeyCode secondaryAttackButton;

        private bool inputEnabled;
        private ICombatBehaviour combatBehaviour;

        private void Awake()
        {
            combatBehaviour = GetComponent<ICombatBehaviour>();
            Enable();
        }

        private void Update()
        {
            if (inputEnabled)
            {
                if (Input.GetKeyDown(primaryAttackButton))
                {
                    combatBehaviour.PrimaryAttack();
                }
                if (Input.GetKeyDown(secondaryAttackButton))
                {
                    combatBehaviour.SecondaryAttack();
                }
            }
        }

        public void Disable()
        {
            inputEnabled = false;
        }

        public void Enable()
        {
            inputEnabled = true;
        }
    }
}
