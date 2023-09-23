using _Game.Scripts.Core.Configs.Characters.Definite;
using _Game.Scripts.Installers.Installers;

namespace _Game.Scripts.Services.ConfigsServices.Characters
{
    public interface IPlayerConfigService : IContainerConstructable
    {
        public PlayerConfig PlayerConfig { get; }
    }
}