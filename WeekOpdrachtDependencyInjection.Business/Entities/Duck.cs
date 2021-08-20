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
