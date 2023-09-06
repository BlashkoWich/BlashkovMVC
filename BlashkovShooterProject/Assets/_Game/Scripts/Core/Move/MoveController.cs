using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Architecture.Reactive;
using UnityEngine;

namespace _Game.Scripts.Core.Move
{
    public class MoveController : ControllerBase<MoveModel>
    {
        protected override MoveModel CreateModel()
        {
            return new MoveModel
            {
                Position = new ReactiveProperty<Vector3>()
            };
        }
    }
}