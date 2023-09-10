using _Game.Scripts.Core.Configs.Characters.Common.Type;
using _Game.Scripts.Core.Types.Characters;
using UnityEngine;

namespace _Game.Scripts.Services.ConfigsServices.Characters
{
    public class ConfigCharacterService : IConfigCharacterService
    {
        private readonly CharacterConfig[] _characterConfigs;

        public ConfigCharacterService(CharacterConfig[] characterConfigs)
        {
            _characterConfigs = characterConfigs;
        }

        public CharacterConfig GetConfig(CharacterType characterType)
        {
            foreach (var characterConfig in _characterConfigs)
            {
                if (characterConfig.CharacterType == characterType)
                {
                    return characterConfig;
                }
            }

            return null;
        }
    }
}