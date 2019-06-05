namespace SampaioDias.SolidItemSystem
{
    using UnityEngine;

    public class Projectile : MonoBehaviour
    {
        public float speed;
        [HideInInspector]
        public float range;
        [HideInInspector]
        public Weapon weapon;

        private void Update()
        {
            Move(Time.deltaTime);
            CheckRange();
        }

        private void CheckRange()
        {
            //if range <= 0, destroy the projectile
        }

        private void Move(float deltaTime)
        {
            transform.Translate(Vector3.forward * speed * deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            var character = other.GetComponent<Character>();
            character.stats.Damage(weapon.Damage);
        }
    }
}
