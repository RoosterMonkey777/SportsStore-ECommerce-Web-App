namespace SportsStore_ECommerce_Web_App.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        //maps the Products property defined by the IStoreRepository interface onto the Products property defined by the StoreDbContext class.
        public IQueryable<Product> Products => context.Products;
    }
}
