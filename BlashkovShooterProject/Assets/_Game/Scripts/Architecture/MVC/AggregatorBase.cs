using UnityEngine;
using Zenject;

namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public abstract class AggregatorBase<TController, TModel, TView> : AggregatorBase
    where TController : ControllerBase<TModel>
    where TView : ViewBase<TModel>
    {
        [SerializeField] private TView view;
        protected TController Controller { get; set; }

        [Inject]
        protected virtual void InjectController(DiContainer container)
        {
            var controller = CreateController();
            container.Inject(controller);
            var model = CreateModel();
            Link(controller, model);
        }
        public abstract TController CreateController();
        public abstract TModel CreateModel();

        protected virtual void Link(TController controller, TModel model)
        {
            Controller = controller;
            
            controller.SetModel(model);
        }

        public override void Initialize()
        {
            Controller.Initialize();
            view.Initialize(Controller.Model);
        }

        public override void Deactivate()
        {
            Controller.Deactivate();
            view.Deactivate(Controller.Model);
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