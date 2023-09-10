using System;
using _Game.Scripts.Installers.Installers;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Core.Input.Move
{
    public interface IMoveInputService : ITickable, IContainerConstructable
    {
        public event Action<Vector3> OnDirectionInput;
    }
}