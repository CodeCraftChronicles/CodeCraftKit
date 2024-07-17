namespace Core.Domain.Contracts;

public interface IEntity
{
}
public interface IEntity<TId> : IEntity
{
    public TId Id { get; set; }
}

public interface IAuditableEntity : IEntity
{
    string CreatedBy { get; set; }

    DateTime CreatedOn { get; set; }

    string LastModifiedBy { get; set; }

    DateTime? LastModifiedOn { get; set; }

    string DeletedBy { get; set; }
    DateTime DeletedOn { get; set; }
}
public interface IAuditableEntity<TId> : IAuditableEntity, IEntity<TId>
{
}

