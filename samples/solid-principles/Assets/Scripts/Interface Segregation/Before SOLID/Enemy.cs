namespace SampaioDias.SolidPrinciples.InterfaceSegregation.Before
{

    using UnityEngine;

    public class Enemy : MonoBehaviour, ILoadable
    {
        public byte[] LoadAsByteArray(string id)
        {
            throw new System.NotImplementedException();
        }

        public object LoadAsObject(string id)
        {
            throw new System.NotImplementedException();
        }

        public string LoadAsString(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
