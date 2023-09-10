using System;
using UnityEngine;

namespace _Game.Scripts.Core.Input.Move
{
    public class PCMoveSystem : IMoveInputSystem
    {   
        public bool TryGetDirection(out Vector3 direction)
        {
            var horizontal = UnityEngine.Input.GetAxis("Horizontal");
            var vertical = UnityEngine.Input.GetAxis("Vertical");

            direction = new Vector3(horizontal, 0, vertical);
            return true;
        }
    }
}