public abstract class Entity
{
    private Guid uuid;
    public Guid ID { get => this.uuid; }

    public Entity()
    {
        this.uuid = Guid.NewGuid();       
    }
}