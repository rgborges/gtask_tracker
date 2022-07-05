public abstract class Entity
{
    private Guid uuid;
    public Guid U { get => this.uuid; }

    public Entity()
    {
        this.uuid = Guid.NewGuid();       
    }
}