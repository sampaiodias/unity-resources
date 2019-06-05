namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    [CreateAssetMenu(menuName = "Items/Weapons/Ranged Weapon")]
    public class RangedWeapon : Weapon
    {
        public float range;
        public GameObject projectile;
        private Character character;

        public override void Config(Character character)
        {
            this.character = character;
        }

        public override void Use()
        {
            var p = Instantiate(projectile, character.transform.position, projectile.transform.rotation).GetComponent<Projectile>();
            if (p != null)
            {
                p.range = range;
                p.weapon = this;
            }
            else
            {
                Debug.Log(name + " tried to shoot " + projectile + ", but it isn't a projectile!");
                Destroy(p);
            }
        }
    }
}
