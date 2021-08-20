using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class Duck : IBird
    {
        public bool CanExecute(string bird)
        {
            return bird == "duck";
        }

        public string Sound()
        {
            return("quack");
        }
    }
}
