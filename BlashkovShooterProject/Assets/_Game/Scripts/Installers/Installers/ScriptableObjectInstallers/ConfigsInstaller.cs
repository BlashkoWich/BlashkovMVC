using _Game.Scripts.Core.Configs.Characters.Definite;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Installers.Installers.ScriptableObjectInstallers
{
    public class ConfigsInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig playerConfig;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerConfig>().FromInstance(playerConfig).AsSingle();
        }
    }
}