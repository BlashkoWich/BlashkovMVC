using UnityEngine;

namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public class AggregatorIdentificationBase : AggregatorBase
    {
        [SerializeField] private Transform parent;

        protected int GetId()
        {
            return parent.GetInstanceID();
        }
    }
}