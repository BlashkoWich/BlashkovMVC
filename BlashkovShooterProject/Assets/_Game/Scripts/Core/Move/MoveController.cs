using System.Collections.Generic;
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
        private IPlayerConfigService _playerConfigService;
        
        private Collider[] _collidersBuffer = new Collider[1];

        public float Speed => _playerConfigService.PlayerConfig.MoveConfig.Speed * Time.deltaTime;

        [Inject]
        private void InjectMe(
            IMoveInputService moveInputService,
            IPlayerConfigService playerConfigService)
        {
            _moveInputService = moveInputService;
            _playerConfigService = playerConfigService;
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
            Model.Speed.Value = direction * Speed;
        }

        private Vector3 GetTargetPosition(Vector3 direction)
        {
            var currentPosition = Model.Speed.Value;
            return currentPosition + direction * Speed;
        }
    }
}