using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Core.Move;
using UnityEngine;

namespace _Game.Scripts.Characters
{
    public class Player : MVCHandlerBase
    {
        [SerializeField] private MovePlayerAggregator movePlayerAggregator;

        private void Awake()
        {
            ActivateMVCs();
        }
    }
}