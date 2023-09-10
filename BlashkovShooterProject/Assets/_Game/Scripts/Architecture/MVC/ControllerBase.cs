namespace _Game.Scripts.Architecture.MVC
{
    public abstract class ControllerBase<TModel>
    {
        public TModel Model { get; private set; }

        public void SetModel(TModel model)
        {
            Model = model;
        }
        public virtual void Initialize()
        {
        }

        public virtual void Deactivate()
        {
        }
    }
}