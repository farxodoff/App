using Connect_EFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace Connect_EFCore.Services
{
    public class BaseService<T> where T : class
    {
        public BaseService(T context)
        {

        }

    }
}