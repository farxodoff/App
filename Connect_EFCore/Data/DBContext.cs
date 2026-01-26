using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Data
{
    public abstract class DBContext
    {
        public readonly AppDbContext _context;

        public DBContext(AppDbContext context)
        {
            _context = context;
        }
    }
}