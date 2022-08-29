namespace ExpressStore.Infrastructure.Payments.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id {get;}
         
    }
}