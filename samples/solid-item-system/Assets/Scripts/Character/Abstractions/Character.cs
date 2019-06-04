namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public abstract class Character : MonoBehaviour, ICharacter
    {
        public CharacterStats stats;
        public CharacterItems items;

        public abstract void OnDespawn();
        public abstract void OnSpawn();
    }
}
