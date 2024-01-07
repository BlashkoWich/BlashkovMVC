using _Game.Scripts.Architecture.MVC;
using _Game.Scripts.Architecture.MVC.Model.Factory;
using Zenject;

namespace _Game.Scripts.Core.Characters
{
    [System.Serializable]
    public class PlayerIdentificationAggregator : AggregatorIdentificationBase
    {
        [Inject]
        protected virtual void CreateModels(IModelFactory modelFactory)
        {
            modelFactory.Create<IsPlayerModel>(GetId());
        }
    }
}