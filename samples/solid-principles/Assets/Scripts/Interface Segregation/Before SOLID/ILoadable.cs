namespace SampaioDias.SolidPrinciples.InterfaceSegregation.Before
{
    public interface ILoadable
    {
        string LoadAsString(string id);
        byte[] LoadAsByteArray(string id);
        object LoadAsObject(string id);
    }
}
