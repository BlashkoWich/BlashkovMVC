using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Core.Configs.Characters.Definite;
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
            var targetPosition = positionValue + direction * ((PlayerConfig)_configCharacterService.GetConfig(CharacterType.Player)).MoveConfig.Speed * Time.deltaTime;
            Model.Position.Value = targetPosition;
            HasNearestWall(direction);
        }

        private bool HasNearestWall(Vector3 direction)
        {
            var origin = Model.Position.Value;
            var speed = ((PlayerConfig)_configCharacterService.GetConfig(CharacterType.Player)).MoveConfig.Speed * Time.deltaTime + 0.5f;
            var layerMasks = LayerMask.GetMask($"Wall", "Default");
            var ray = new Ray(origin, direction);
            var raycast = Physics.Raycast(ray, out var hit, speed, layerMasks);
            Debug.Log(raycast);
            Debug.DrawRay(ray.origin, ray.direction, raycast? Color.green : Color.red);

            return true;
        }
    }
}