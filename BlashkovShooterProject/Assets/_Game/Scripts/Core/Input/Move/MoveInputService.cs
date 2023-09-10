using System;
using UnityEngine;

namespace _Game.Scripts.Core.Input.Move
{
    public class MoveInputService : IMoveInputService
    {
        private readonly IMoveInputSystem[] _systems;

        public event Action<Vector3> OnDirectionInput;

        public MoveInputService(IMoveInputSystem[] systems)
        {
            _systems = systems;
        }

        public void Tick()
        {
            foreach (var system in _systems)
            {
                if (system.TryGetDirection(out var direction))
                {
                    OnDirectionInput?.Invoke(direction);
                }
            }
        }
    }
}