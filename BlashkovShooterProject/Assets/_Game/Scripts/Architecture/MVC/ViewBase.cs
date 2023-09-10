namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public abstract class ViewBase<TModel>
    {
        public abstract void Initialize(TModel model);
        public abstract void Deactivate(TModel model);
    }
}