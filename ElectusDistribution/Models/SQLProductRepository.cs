using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectusDistribution.Models
{
	public class SQLProductRepository : IProductRepository
	{
		private readonly AppDbContext db;

		public SQLProductRepository(AppDbContext db)
		{
			this.db = db;
		}

		public Product Add(Product product)
		{
			throw new NotImplementedException();
		}

		public Product Delete(int Id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Product> GetAllProduct()
		{
			throw new NotImplementedException();
		}

		public Product GetProduct(int Id)
		{
			throw new NotImplementedException();
		}

		public Product Update(Product productChanges)
		{
			throw new NotImplementedException();
		}
	}
}
