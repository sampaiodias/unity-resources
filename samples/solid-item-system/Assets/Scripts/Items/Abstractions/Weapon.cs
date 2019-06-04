namespace SampaioDias.SolidItemSystem
{
    public abstract class Weapon : Item, IUsable
    {
        public float Damage = 10;

        public abstract void Use();
    }
}
