using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Core
{
    public class DataOperations : IDataOperations
    {
        private readonly EfCrudRepository<Customer> _customerRepo;
        private readonly EfCrudRepository<Article> _articleRepo;
        private readonly EfCrudRepository<ArticleGroup> _articleGroupRepo;
        private readonly EfCrudRepository<Order> _orderRepo;
        private readonly EfCrudRepository<Position> _positionRepo;

        public DataOperations(
            EfCrudRepository<Customer> customerRepo,
            EfCrudRepository<Article> articleRepo,
            EfCrudRepository<ArticleGroup> articleGroupRepo,
            EfCrudRepository<Order> orderRepo,
            EfCrudRepository<Position> positionRepo
        )
        {
            _customerRepo = customerRepo;
            _articleRepo = articleRepo;
            _articleGroupRepo = articleGroupRepo;
            _orderRepo = orderRepo;
            _positionRepo = positionRepo;
        }

        public async Task Create(object entity)
        {
            switch (entity)
            {
                case Article _:
                    await _articleRepo.Create((Article)entity);
                    break;
                case ArticleGroup _:
                    await _articleGroupRepo.Create((ArticleGroup)entity);
                    break;
                case Customer _:
                    await _customerRepo.Create((Customer)entity);
                    break;
                case Order _:
                    await _orderRepo.Create((Order)entity);
                    break;
                case Position _:
                    await _positionRepo.Create((Position)entity);
                    break;
            }
        }

        public async Task Delete(object entity)
        {
            switch (entity)
            {
                case Article _:
                    await _articleRepo.Delete((Article)entity);
                    break;
                case ArticleGroup _:
                    await _articleGroupRepo.Delete((ArticleGroup)entity);
                    break;
                case Customer _:
                    await _customerRepo.Delete((Customer)entity);
                    break;
                case Order _:
                    await _orderRepo.Delete((Order)entity);
                    break;
                case Position _:
                    await _positionRepo.Delete((Position)entity);
                    break;
            }
        }

        public async Task<object> Get(object entity)
        {
            var requestedEntity = new object();

            switch (entity)
            {
                case Article _:
                    var articles = await _articleRepo.GetAll();
                    return (Article)articles.Where(elem => elem == (Article)entity);
                case ArticleGroup _:
                    var articleGroups = await _articleGroupRepo.GetAll();
                    return (ArticleGroup)articleGroups.Where(elem => elem == (ArticleGroup)entity); 
                case Customer _:
                    var customers = await _customerRepo.GetAll();
                    return (Customer)customers.Where(elem => elem == (Customer)entity);
                case Order _:
                    var orders = await _orderRepo.GetAll();
                    return (Order)orders.Where(elem => elem == (Order)entity);
                case Position _:
                    var positions = await _positionRepo.GetAll();
                    return (Position)positions.Where(elem => elem == (Position)entity); 
            }

            return null;
        }

        public async Task Update(object entity)
        {
            switch (entity)
            {
                case Article _:
                    await _articleRepo.Update((Article)entity);
                    break;
                case ArticleGroup _:
                    await _articleGroupRepo.Update((ArticleGroup)entity);
                    break;
                case Customer _:
                    await _customerRepo.Update((Customer)entity);
                    break;
                case Order _:
                    await _orderRepo.Update((Order)entity);
                    break;
                case Position _:
                    await _positionRepo.Update((Position)entity);
                    break;
            }
        }
    }
}
