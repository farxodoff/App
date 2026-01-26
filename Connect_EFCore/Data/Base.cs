using System;
using System.Collections.Generic;
using System.Text;

namespace Connect_EFCore.Data
{
    public abstract class Base
    {
        protected readonly AppDbContext _context;
        
        public Base(AppDbContext context)
        {
            _context = context; 
        }
    }
}
