namespace SportsStore_ECommerce_Web_App.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
