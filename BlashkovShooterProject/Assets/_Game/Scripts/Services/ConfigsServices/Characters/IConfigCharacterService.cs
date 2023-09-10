using _Game.Scripts.Core.Configs.Characters.Common.Type;
using _Game.Scripts.Core.Types.Characters;
using _Game.Scripts.Installers.Installers;

namespace _Game.Scripts.Services.ConfigsServices.Characters
{
    public interface IConfigCharacterService : IContainerConstructable
    {
        public CharacterConfig GetConfig(CharacterType characterType);
    }
}