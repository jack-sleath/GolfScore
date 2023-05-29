namespace GolfScore.Models
{
    public abstract class BaseClass
    {
        protected static T Create<T>() where T : BaseClass
        {
            T element = (T)Activator.CreateInstance(typeof(T), true);

            element.id = Guid.NewGuid();

            element.CreatedDate = DateTime.UtcNow;

            element.SetLastUpdated();

            return element;
        }

        public void SetLastUpdated()
        {
            LastUpdated = DateTime.UtcNow;
        }

        public Guid id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastUpdated { get; private set; }
    }

    public abstract class BaseCosmosEntity : BaseClass
    {
        protected static T Create<T>(string type) where T : BaseCosmosEntity
        {
            T entity = Create<T>();
            entity.Type = type;
            return entity;
        }


        public string Type { get; private set; }
    }
}
