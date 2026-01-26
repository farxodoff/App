using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Data
{
    public abstract class DBContext
    {
        public readonly DbContext _context;

        public DBContext(DbContext context)
        {
            _context = context;
        }
    }
}