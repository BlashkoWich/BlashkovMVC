using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Core.Input.Move;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Core.Move
{
    public class MoveController : ControllerBase<MoveModel>
    {
        private IMoveInputService _moveInputService;

        [Inject]
        private void InjectMe(IMoveInputService moveInputService)
        {
            _moveInputService = moveInputService;
        }

        public override void Initialize()
        {
            base.Initialize();

            _moveInputService.OnDirectionInput += DirectionHandle;
        }

        public override void Deactivate()
        {
            base.Deactivate();
            
            _moveInputService.OnDirectionInput -= DirectionHandle;
        }

        private void DirectionHandle(Vector3 direction)
        {
            var positionValue = Model.Position.Value;

            var targetPosition = positionValue + direction * Time.deltaTime;
            Model.Position.Value = targetPosition;
        }
    }
}