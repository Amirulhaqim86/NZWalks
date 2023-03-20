using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RagionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RagionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
           return await nZWalksDbContext.Regions.ToListAsync(); 
        }
    }
}
