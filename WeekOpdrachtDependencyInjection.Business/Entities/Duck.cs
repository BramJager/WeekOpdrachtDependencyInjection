using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class Duck : Bird
    {
        public override string Sound()
        {
            return("quack");
        }
    }
}
