namespace _Game.Scripts.Architecture.MVC.Model.Factory
{
    public interface IModelFactory
    {
        public T Create<T>(int id) where T : ModelBase, new();
    }
}