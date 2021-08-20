using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IBird
    {
        public abstract bool CanExecute(string bird);
        public abstract string Sound();
    }
}
