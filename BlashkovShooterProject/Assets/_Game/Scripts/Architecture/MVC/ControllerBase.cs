namespace _Game.Scripts.Architecture.MVC
{
    public abstract class ControllerBase<TModel>
    {
        protected TModel Model { get; private set; }

        protected abstract TModel CreateModel();

        public virtual TModel Initialize()
        {
            if(Model == null)
                CreateModel();
            
            return Model;
        }
    }
}