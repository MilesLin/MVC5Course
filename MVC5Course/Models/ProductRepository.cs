using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public override IQueryable<Product> All()
        {
            return base.All().Where(x => x.Active == true);
        }

        public override void Delete(Product entity)
        {            
            ((FabricsEntities)this.UnitOfWork.Context).OrderLine.RemoveRange(entity.OrderLine);

            base.Delete(entity);
        }

        public IQueryable<Product> All(bool isGetAll) 
        {
            if (isGetAll)
            {
                return base.All();
            }
            else
            {
                return this.All();
            }
        }

        public IQueryable<Product> Search(string search)
        {
            IQueryable<Product> result;

            if (string.IsNullOrEmpty(search))
            {
                result = this.GetTop10();
                //this.All(true);
            }
            else
            {
                result = this.Where(x => x.ProductName.Contains(search));
            }

            return result;
        }

        public Product Find(int id) 
        {
            return this.Where(x => x.ProductId == id).FirstOrDefault();
        }

        public IQueryable<Product> GetTop10()
        {
            return this.All(true).Take(10);
        }


    }

	public  interface IProductRepository : IRepository<Product>
	{

	}
}