using _Game.Scripts.Architecture.Reactive;
using UnityEngine;

namespace _Game.Scripts.Core.Move
{
    [System.Serializable]
    public class MoveModel
    { 
        public ReactiveProperty<Vector3> Speed { get; } = new();

        public void Initialize()
        {
            Speed.Value = Vector3.zero;
        }
    }
}