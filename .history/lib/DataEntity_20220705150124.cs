public abstract class DataEntity
{
    private Guid uuid;
    public Guid ID { get => this.uuid; }

    public DataEntity()
    {
        this.uuid = GUID;       
    }
    public virtual void GenerateIdToken()
    {

    }
}