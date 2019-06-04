namespace SampaioDias.SolidPrinciples.OpenClosed.After
{
    public class RectangleShape : ShapeBehaviour
    {
        public override float Area()
        {
            return Height * Width;
        }
    }
}
