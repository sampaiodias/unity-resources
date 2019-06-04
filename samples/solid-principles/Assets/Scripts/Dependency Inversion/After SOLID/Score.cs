namespace SampaioDias.SolidPrinciples.DependencyInversion.After
{

    using UnityEngine;

    public class Score : MonoBehaviour
    {
        public float Points = 0f;

        public void ApplyDamageScore(ShotBehaviour shot)
        {
            Points += shot.Damage;
        }
    }
}
