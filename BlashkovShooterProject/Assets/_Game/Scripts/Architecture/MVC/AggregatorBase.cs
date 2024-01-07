using _Game.Scripts.Architecture.MVC.Model;
using _Game.Scripts.Architecture.MVC.Model.Factory;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public abstract class AggregatorBase<TController, TModel, TView> : AggregatorBase
    where TController : ControllerBase<TModel>
    where TView : ViewBase<TModel>
    where TModel : ModelBase, new()
    {
        [SerializeField] private Transform parent;
        
        [field: SerializeField] protected TView View { get; private set; }
        protected TModel Model { get; private set; }
        protected TController Controller { get; set; }

        [Inject]
        protected virtual void InjectController(DiContainer container, IModelFactory modelFactory)
        {
            var controller = CreateController();
            container.Inject(controller);

            Model = modelFactory.Create<TModel>(parent.GetInstanceID());

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