using UnityEngine;

namespace SampaioDias.SolidPrinciples.OpenClosed.Before
{
    public class ShapeTools
    {
        public static float Area(ShapeBehaviour shape)
        {
            if (shape is RectangleShape)
            {
                return shape.Height * shape.Width;
            }

            if (shape is CircleShape)
            {
                var radius = ((CircleShape)shape).Radius;
                return radius * radius * Mathf.PI;
            }

            throw new System.NotImplementedException(shape.GetType().Name + " is not implemented yet in ShapeTools.Area()");
        }
    }
}
