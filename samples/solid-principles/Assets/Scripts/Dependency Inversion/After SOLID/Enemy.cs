namespace SampaioDias.SolidPrinciples.DependencyInversion.After
{

    using UnityEngine;

    public class Enemy : MonoBehaviour
    {
        public float Health = 1;

        private void OnCollisionEnter(Collision collision)
        {
            var shot = collision.gameObject.GetComponent<ShotBehaviour>();
            if (shot != null)
            {
                Health -= shot.Damage;
            }
        }
    }
}
