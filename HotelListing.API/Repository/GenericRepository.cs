using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly HotelListingDbContext _context;

		public GenericRepository(HotelListingDbContext context)
		{
			this._context = context;
		}
		public async Task<T> AddAsync(T entity)
		{
			await _context.AddAsync(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Exists(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public Task<T> GetASyinc(int? id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
