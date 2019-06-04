namespace SampaioDias.SolidItemSystem
{

    using UnityEngine;

    public class Player : Character
    {

        private void OnEnable()
        {
            OnSpawn();
        }

        private void OnDisable()
        {
            OnDespawn();
        }

        public override void OnSpawn()
        {
            Debug.Log(gameObject.name + " spawned");
        }

        public override void OnDespawn()
        {
            Debug.Log(gameObject.name + " despawned");
        }
    }
}
