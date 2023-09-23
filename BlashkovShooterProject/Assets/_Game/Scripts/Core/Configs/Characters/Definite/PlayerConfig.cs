using _Game.Scripts.Core.Configs.Characters.Common.Move;
using UnityEngine;

namespace _Game.Scripts.Core.Configs.Characters.Definite
{
    [CreateAssetMenu(menuName = "Configs/Characters/Player")]
    public class PlayerConfig : ScriptableObject, IMovable
    {
        [field: SerializeField] public MoveConfig MoveConfig { get; set; }
    }
}