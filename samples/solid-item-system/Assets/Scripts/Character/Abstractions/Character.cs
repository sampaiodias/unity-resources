namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public abstract class Character : MonoBehaviour, ICharacter
    {
        public Stats stats;
        public Items items;

        public abstract void OnDespawn();
        public abstract void OnSpawn();
    }
}
