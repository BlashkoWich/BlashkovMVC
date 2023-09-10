using _Game.Scripts.Architecture.Reactive;
using UnityEngine;

namespace _Game.Scripts.Core.Move
{
    public class MoveModel
    {
        public ReactiveProperty<Vector3> Position { get; set; }

        public MoveModel()
        {
            Position = new ReactiveProperty<Vector3>();
        }
    }
}