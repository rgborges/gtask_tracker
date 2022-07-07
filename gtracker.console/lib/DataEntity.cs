using System;

public abstract class Entity
{
    private Guid uuid;
    public Guid UUID { get => this.uuid; }

    public Entity()
    {
        this.uuid = Guid.NewGuid();       
    }
}