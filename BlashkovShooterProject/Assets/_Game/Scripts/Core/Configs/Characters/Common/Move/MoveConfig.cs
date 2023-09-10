using UnityEngine;

namespace _Game.Scripts.Core.Configs.Characters.Common.Move
{
    [System.Serializable]
    public class MoveConfig
    {
        [field: SerializeField] public float Speed { get; private set; }
    }
}