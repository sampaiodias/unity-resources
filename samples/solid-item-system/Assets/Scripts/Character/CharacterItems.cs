namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    [CreateAssetMenu]
    public class CharacterItems : ScriptableObject
    {
        public Weapon primary;
        public Weapon secondary;
        public Item[] inventory;
    }
}
