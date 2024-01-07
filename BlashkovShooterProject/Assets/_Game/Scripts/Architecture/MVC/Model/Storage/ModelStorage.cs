using System.Collections.Generic;
using _Game.Scripts.Installers.Installers;

namespace _Game.Scripts.Architecture.MVC.Model.Storage
{
    public class ModelStorage : IModelStorage, IContainerConstructable
    {
        private readonly List<ModelBase> _models = new();

        public void Add(ModelBase model)
        {
            _models.Add(model);
        }

        #region Getters
        public T Get<T>(int id) where T : ModelBase
        {
            foreach (var model in _models)
            {
                if (model is T castModel && castModel.Id == id)
                {
                    return castModel;
                }
            }

            return null;
        }

        public void Get<TRef>(List<ModelBase> buffer) where TRef : ModelBase
        {
            foreach (var model in _models)
            {
                if (model is not TRef) 
                    continue;
                
                foreach (var modelInRef in _models)
                {
                    if (modelInRef.Id == model.Id)
                    {
                        buffer.Add(modelInRef);
                    }
                }
            }
        }
        public TOut Get<TOut, TRef>() 
            where TRef : ModelBase
            where TOut : ModelBase
        {
            foreach (var model in _models)
            {
                if (model is not TRef) 
                    continue;
                
                foreach (var modelInRef in _models)
                {
                    if (modelInRef.Id == model.Id && modelInRef is TOut @out)
                    {
                        return @out;
                    }
                }
            }

            return null;
        }

        public T Get<T>() where T : ModelBase
        {
            foreach (var model in _models)
            {
                if (model is T castModel)
                {
                    return castModel;
                }
            }

            return null;
        }
        #endregion
    }
}