using UnityEngine;

namespace SampaioDias.SolidPrinciples.OpenClosed.After
{
    public class CircleShape : ShapeBehaviour
    {
        public float Radius { get; set; }

        public override float Area()
        {
            return Radius * Radius * Mathf.PI;
        }
    }
}
