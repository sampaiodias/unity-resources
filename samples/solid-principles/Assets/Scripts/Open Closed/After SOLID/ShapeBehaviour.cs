namespace SampaioDias.SolidPrinciples.OpenClosed.After
{

    using UnityEngine;

    public abstract class ShapeBehaviour : MonoBehaviour
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public abstract float Area();
    }
}
