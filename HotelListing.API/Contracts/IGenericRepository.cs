namespace HotelListing.API.Contracts
{
	// interface is a contract, inforcing what should happen
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetASyinc(int? id);
		Task<List<T>> GetAllAsync();
		Task<T> AddAsync(T entity);
		Task DeleteAsync(int id);
		Task UpdateAsync(T entity);
		Task<bool> Exists(int id);
	}
}
