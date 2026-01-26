using System;
using System.Collections.Generic;
using System.Text;

namespace Connect_EFCore_WebAPI.Data
{
    public abstract class Base
    {
        protected readonly AppDbContext _context;
        
        protected Base(AppDbContext context)
        {
            _context = context; 
        }
    }
}
