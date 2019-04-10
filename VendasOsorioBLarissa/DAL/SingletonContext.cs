using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.DAL
{
    class SingletonContext
    {
        private SingletonContext() { }

        private static Context context;

        private static Context GetInstance()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }

       
    }
}
