using UnityEngine;
using Zenject;

namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public abstract class AggregatorBase<TController, TModel, TView> : AggregatorBase
    where TController : ControllerBase<TModel>
    where TView : ViewBase<TModel>
    {
        [field: SerializeField] protected TView View { get; private set; }
        [field: SerializeField] protected TModel Model { get; private set; }
        protected TController Controller { get; set; }

        [Inject]
        protected virtual void InjectController(DiContainer container)
        {
            var controller = CreateController();
            container.Inject(controller);
            Link(controller, Model);
        }
        public abstract TController CreateController();

        protected virtual void Link(TController controller, TModel model)
        {
            Controller = controller;
            
            controller.SetModel(model);
        }

        public override void Initialize()
        {
            Controller.Initialize();
            View.Initialize(Controller.Model);
        }

        public override void Deactivate()
        {
            Controller.Deactivate();
            View.Deactivate(Controller.Model);
        }
    }

    public abstract class AggregatorBase
    {
        public virtual void Initialize()
        {
        }

        public virtual void Deactivate()
        {
        }
    }
}