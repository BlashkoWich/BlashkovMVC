using _Game.Scripts.Architecture.MVC;

namespace _Game.Scripts.Core.Move
{
    [System.Serializable]
    public class MovePlayerAggregate : AggregateBase<MoveController, MoveModel, MoveView>
    {
        protected override MoveController CreateController()
        {
            return new MoveController();
        }
    }
}