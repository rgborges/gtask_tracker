public abstract class DataEntity
{
    private Guid uuid;
    public Guid ID { get => this.uuid; }

    public DataEntity()
    {
        
    }
    public virtual void GenerateIdToken()
    {

    }
}