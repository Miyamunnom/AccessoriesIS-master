using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessoriesIS
{
    class DataBase
    {
        private static Entities1 _context;
        public static Entities1 GetContext()
        {
            if (_context == null)
                _context = new Entities1();
            return _context;
        }
    }
}
