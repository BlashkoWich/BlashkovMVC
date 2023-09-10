using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Core.Input.Move;
using _Game.Scripts.Core.Types.Characters;
using _Game.Scripts.Services.ConfigsServices.Characters;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Core.Move
{
    public class MoveController : ControllerBase<MoveModel>
    {
        private IMoveInputService _moveInputService;
        private IConfigCharacterService _configCharacterService;

        [Inject]
        private void InjectMe(
            IMoveInputService moveInputService,
            IConfigCharacterService configCharacterService)
        {
            _moveInputService = moveInputService;
            _configCharacterService = configCharacterService;
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

        private bool HasNearestWall(Vector3 direction)
        {
            var origin = Model.Position.Value;
            //Physics.Raycast(origin, direction, )
            
            
            return true;
        }
    }
}