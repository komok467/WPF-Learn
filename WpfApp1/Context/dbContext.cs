using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Context
{
    public class dbContext
    {
        public static bookEntities db = new bookEntities();
    }
}
