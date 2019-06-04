namespace SampaioDias.SolidPrinciples.InterfaceSegregation.After
{

    using UnityEngine;

    //Only implements the Load methods this class really needs, also improves readability
    public class Enemy : MonoBehaviour, ILoadableAsObject
    {
        public object LoadAsObject(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
