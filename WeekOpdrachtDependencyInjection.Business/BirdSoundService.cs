using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class BirdSoundService : IBirdSoundService
    {
        private readonly IEnumerable<IBird> birds;

        public BirdSoundService(IEnumerable<IBird> birds)
        {
            this.birds = birds;
        }

        public string ExecuteSound(string bird)
        {
            var bird1 = birds.Single(x => x.CanExecute(bird));
            return bird1.Sound();
        }
    }
}
