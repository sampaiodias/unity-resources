namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    [CreateAssetMenu]
    public class CharacterItems : Items
    {
        public Weapon primary;
        public Weapon secondary;
        public Item[] inventory;

        public override bool AddToInventory(Item item)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = item;
                    return true;
                }
            }
            return false;
        }

        public override Item[] GetItems()
        {
            return inventory;
        }

        /// <summary>
        /// Use one of the equipped weapons, primary (index 0) or secondary (index 1).
        /// </summary>
        /// <param name="weaponIndex"></param>
        public override void UseWeapon(int weaponIndex)
        {
            switch (weaponIndex)
            {
                case 0:
                    primary.Use();
                    break;
                case 1:
                    secondary.Use();
                    break;
                default:
                    Debug.LogError("CharacterItems can only fire Weapon '0' or Weapon '1'");
                    break;
            }
        }
    }
}
