namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public abstract class Items : ScriptableObject, IWeaponContainer
    {
        public abstract bool AddToInventory(Item item);
        public abstract Item[] GetItems();
        public abstract void UseWeapon(int weaponIndex);
    }
}
