using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class Goose : IBird
    {
        public bool CanExecute(string bird)
        {
            return bird == "goose";
        }

        public string Sound()
        {
            return("honk");
        }
    }
}
