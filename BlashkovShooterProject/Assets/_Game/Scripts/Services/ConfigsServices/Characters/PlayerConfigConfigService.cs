using _Game.Scripts.Core.Configs.Characters.Definite;
using _Game.Scripts.Core.Types.Characters;

namespace _Game.Scripts.Services.ConfigsServices.Characters
{
    public class PlayerConfigConfigService : IPlayerConfigService
    {
        private readonly PlayerConfig _playerConfig;

        public PlayerConfigConfigService(PlayerConfig playerConfig)
        {
            _playerConfig = playerConfig;
        }

        public PlayerConfig PlayerConfig => _playerConfig;
    }
}