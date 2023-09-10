using System;
using _Game.Scripts.Architecture.MVC;
using UnityEngine;

namespace _Game.Scripts.Core.Move
{
    [Serializable]
    public class MoveView : ViewBase<MoveModel>
    {
        [SerializeField] private Transform transform;
        
        public override void Initialize(MoveModel model)
        {
            model.Position.OnChangeValue += SetPosition;
        }

        public override void Deactivate(MoveModel model)
        {
            model.Position.OnChangeValue -= SetPosition;
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }
    }
}