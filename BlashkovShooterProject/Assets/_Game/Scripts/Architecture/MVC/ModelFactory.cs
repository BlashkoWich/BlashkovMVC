using _Game.Scripts.Installers.Installers;

namespace _Game.Scripts.Architecture.MVC
{
    public abstract class ModelFactory<TModel> : IContainerConstructable
    {
        public abstract TModel CreateModel();
    }
}