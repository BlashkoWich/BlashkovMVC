using _Game.Scripts.Core.Configs.Characters.Common.Move;
using _Game.Scripts.Core.Configs.Characters.Common.Type;
using UnityEngine;

namespace _Game.Scripts.Core.Configs.Characters.Definite
{
    [CreateAssetMenu(menuName = "Configs/Characters/Player")]
    public class PlayerConfig : CharacterConfig, IMovable
    {
        [field: SerializeField] public MoveConfig MoveConfig { get; set; }
    }
}