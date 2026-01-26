using Connect_EFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Services
{
    public class BaseService : DBContext
    {
        public BaseService(DbContext context) : base(context) { }

    }
}