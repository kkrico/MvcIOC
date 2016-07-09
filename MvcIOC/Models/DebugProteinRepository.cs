using System;

namespace MvcIOC.Models
{
    public class DebugProteinRepository : IProteinRepository
    {
        public ProteinData GetData(DateTime date)
        {
            return new ProteinData();
        }

        public void SetTotal(DateTime date, int value)
        {
        }

        public void SetGoal(DateTime date, int value)
        {
        }
    }
}