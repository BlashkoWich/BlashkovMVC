using _Game.Scripts.Architecture.MVC.Model.Storage;
using _Game.Scripts.Installers.Installers;

namespace _Game.Scripts.Architecture.MVC.Model.Factory
{
    public class ModelFactory : IModelFactory, IContainerConstructable
    {
        private readonly IModelStorage _modelStorage;

        public ModelFactory(IModelStorage modelStorage)
        {
            _modelStorage = modelStorage;
        }

        public T Create<T>(int id) where T : ModelBase, new()
        {
            var model = new T();
            model.SetId(id);
            
            _modelStorage.Add(model);

            return model;
        }
    }
}