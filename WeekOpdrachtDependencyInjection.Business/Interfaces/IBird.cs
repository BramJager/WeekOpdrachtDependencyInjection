namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IBird
    {
        public abstract bool CanExecute(string bird);
        public abstract string Sound();
    }
}
