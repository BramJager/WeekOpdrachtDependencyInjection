using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class Chicken : IBird
    {
        public bool CanExecute(string bird)
        {
            return bird == "chicken";
        }

        public string Sound()
        {
            return("cluck");
        }
    }
}
