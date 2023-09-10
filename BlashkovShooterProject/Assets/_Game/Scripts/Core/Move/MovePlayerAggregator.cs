using _Game.Scripts.Architecture.MVC;

namespace _Game.Scripts.Core.Move
{
    [System.Serializable]
    public class MovePlayerAggregator : AggregatorBase<MoveController, MoveModel, MoveView>
    {
        public override MoveController CreateController()
        {
            return new MoveController();
        }
        public override MoveModel CreateModel()
        {
            return new MoveModel();
        }
    }
}