using Catalog.Persistance.Database;
using CatalogServicesQueries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogServicesQueries
{
    public interface IProductQueryService {
        Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<ProductDto> GetAsync(int id);
    }
    public class ProductQueryService : IProductQueryService 
    {
        private readonly AplicationDbContext _context;
        public ProductQueryService(AplicationDbContext context)
        {
            _context = context;
        }

        public  async Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null)
        {
            var collection = await _context.Products
                                    .Where(x => products == null || products.Contains(x.ProductId))
                                    .OrderByDescending(x => x.ProductId)
                                    .GetPagedAsync(page, take);
            return collection.MapTo<DataCollection<ProductDto>>();
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            return (await _context.Products.SingleAsync(x => x.ProductId == id)).MapTo<ProductDto>();
        }
    }
}
