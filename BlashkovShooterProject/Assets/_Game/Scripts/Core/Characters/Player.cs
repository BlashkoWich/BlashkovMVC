using System;
using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Core.Move;
using UnityEngine;

namespace _Game.Scripts.Core.Characters
{
    public class Player : MVCHandlerBase
    {
        [SerializeField] private MovePlayerAggregator movePlayerAggregator;
        [SerializeField] private PlayerIdentificationAggregator _playerIdentificationAggregator;

        private void Awake()
        {
            ActivateMVCs();
        }
    }
}