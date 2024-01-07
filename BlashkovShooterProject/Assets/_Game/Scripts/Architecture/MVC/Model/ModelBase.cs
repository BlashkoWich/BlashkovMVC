namespace _Game.Scripts.Architecture.MVC.Model
{
    public class ModelBase
    {
        public int Id { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}