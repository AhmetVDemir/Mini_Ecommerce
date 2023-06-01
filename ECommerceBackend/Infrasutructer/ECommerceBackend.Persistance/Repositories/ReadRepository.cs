using ECommerceBackend.Application.Repositories;
using ECommerceBackend.Domain.Entities.Abstraction;
using ECommerceBackend.Persistance.Contexxt;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly ECommerceApiDbContext _context;

        public ReadRepository(ECommerceApiDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expressionMethod) => Table.Where(expressionMethod);

        public async Task<T> GetSingleAsyn(Expression<Func<T, bool>> expressionMethod)=> await Table.FirstAsync(expressionMethod);

        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

      
    }
}
