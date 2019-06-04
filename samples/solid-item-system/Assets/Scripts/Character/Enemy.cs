namespace SampaioDias.SolidItemSystem
{
    using System.Collections.Generic;

    public class Enemy : Character
    {
        private static List<Enemy> enemies = new List<Enemy>();

        private void OnEnable()
        {
            OnSpawn();
        }

        private void OnDisable()
        {
            OnDespawn();
        }

        public override void OnDespawn()
        {
            enemies.Add(this);
            DropItemsOnTheGround();
        }

        private void DropItemsOnTheGround()
        {
            for (int i = 0; i < items.inventory.Length; i++)
            {
                //Drop the item on the ground
            }
        }

        public override void OnSpawn()
        {
            enemies.Remove(this);
        }
    }
}
