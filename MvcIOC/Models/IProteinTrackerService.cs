namespace MvcIOC.Models
{
    public interface IProteinTrackerService
    {
        int Total { get; set; }
        int Goal { get; set; }
        void AddProtein(int amount);
    }
}