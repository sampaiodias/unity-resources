namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public abstract class Item : ScriptableObject
    {
        public Texture2D icon;

        public abstract void Config(Character character);
    }
}
