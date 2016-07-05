using System;

namespace MvcIOC.Models
{
    public class ProteinTrackerService : IProteinTrackerService
    {
        private IProteinRepository repository;

        public ProteinTrackerService(IProteinRepository repository)
        {
            this.repository = repository;
        }

        public int Total
        {
            get { return repository.GetData(new DateTime().Date).Total; }
            set { repository.SetTotal(new DateTime().Date, value); }
        }

        public int Goal
        {
            get { return repository.GetData(new DateTime().Date).Goal; }
            set { repository.SetGoal(new DateTime().Date, value); }
        }

        public void AddProtein(int amount)
        {
            Total += amount;
        }
    }
}