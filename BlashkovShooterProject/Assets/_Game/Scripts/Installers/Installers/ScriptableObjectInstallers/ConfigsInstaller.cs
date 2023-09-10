using _Game.Scripts.Core.Configs.Characters.Common.Type;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Installers.Installers.ScriptableObjectInstallers
{
    public class ConfigsInstaller : MonoInstaller
    {
        [SerializeField] private CharacterConfig[] characterConfigs;

        public override void InstallBindings()
        {
            foreach (var characterConfig in characterConfigs)
            {
                Container.BindInterfacesAndSelfTo<CharacterConfig>().FromInstance(characterConfig).AsSingle();
            }
        }
    }
}