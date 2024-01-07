using System.Collections.Generic;

namespace _Game.Scripts.Architecture.MVC.Model.Storage
{
    public interface IModelStorage
    {
        public void Add(ModelBase model);
        public T Get<T>(int id) where T : ModelBase;
        public void Get<TRef>(List<ModelBase> buffer) where TRef : ModelBase;
        public TOut Get<TOut, TRef>()
            where TRef : ModelBase
            where TOut : ModelBase;

        public T Get<T>() where T : ModelBase;
    }
}