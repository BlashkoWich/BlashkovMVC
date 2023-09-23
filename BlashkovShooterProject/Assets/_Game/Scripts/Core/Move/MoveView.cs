using System;
using _Game.Scripts.Architecture.MVC;
using UnityEngine;

namespace _Game.Scripts.Core.Move
{
    [Serializable]
    public class MoveView : ViewBase<MoveModel>
    {
        [SerializeField] private CharacterController characterController;
        
        public override void Initialize(MoveModel model)
        {
            model.Speed.OnChangeValue += SetPosition;
        }

        public override void Deactivate(MoveModel model)
        {
            model.Speed.OnChangeValue -= SetPosition;
        }

        private void SetPosition(Vector3 speed)
        {
            characterController.Move(speed);
        }
    }
}