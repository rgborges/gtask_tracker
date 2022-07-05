public abstract class DataEntity
{
    private Guid uuid;
    public Guid ID { get => this.uuid; }

    public DataEntity()
    {
        this.uuid = Guid.Guid.NewGuid;       
    }
    public virtual void GenerateIdToken()
    {

    }
}