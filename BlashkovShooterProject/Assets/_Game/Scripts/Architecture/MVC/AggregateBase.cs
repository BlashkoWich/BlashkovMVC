using UnityEngine;

namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public abstract class AggregateBase<TController, TModel, TView>
    where TController : ControllerBase<TModel>
    where TView : ViewBase<TModel>
    {
        [SerializeField] private TView view;
        private TController _controller;

        protected abstract TController CreateController();
        
        public void Initialize()
        {
            var controllerBase = CreateController();
            var model = controllerBase.Initialize();
            view.Initialize(model);
        }
    }
}