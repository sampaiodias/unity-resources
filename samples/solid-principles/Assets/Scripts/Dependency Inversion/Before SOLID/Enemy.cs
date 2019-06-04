namespace SampaioDias.SolidPrinciples.DependencyInversion.Before
{

    using UnityEngine;

    public class Enemy : MonoBehaviour
    {
        public float Health = 1;

        private void OnCollisionEnter(Collision collision)
        {
            var shot = collision.gameObject.GetComponent<Shot>();
            if (shot != null)
            {
                Health -= shot.Damage;
            }

            var rocketShot = collision.gameObject.GetComponent<RocketShot>();
            if (rocketShot != null)
            {
                Health -= rocketShot.Damage;
            }
        }
    }
}
