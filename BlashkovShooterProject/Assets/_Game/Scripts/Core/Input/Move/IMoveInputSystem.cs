using _Game.Scripts.Installers.Installers;
using UnityEngine;

namespace _Game.Scripts.Core.Input.Move
{
    public interface IMoveInputSystem : IContainerConstructable
    {
        public bool TryGetDirection(out Vector3 direction);
    }
}