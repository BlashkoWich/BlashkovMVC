namespace _Game.Scripts.Architecture.MVC
{
    [System.Serializable]
    public class ViewBase<TModel>
    {
        private TModel _model;

        public void Initialize(TModel model)
        {
            _model = model;
        }
    }
}