namespace SampaioDias.SolidPrinciples.DependencyInversion.Before
{

    using UnityEngine;

    public class Score : MonoBehaviour
    {
        public float Points = 0f;

        public void ApplyDamageScore(object shot)
        {
            if (shot is Shot)
                Points += ((Shot)shot).Damage;
            if (shot is RocketShot)
                Points += ((RocketShot)shot).Damage;
        }
    }
}
