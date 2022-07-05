public abstract class Entity
{
    private Guid uuid;
    public Guid ID { get => this.uuid; }

    public DataEntity()
    {
        this.uuid = Guid.NewGuid();       
    }
}