using System;

namespace MvcIOC.Models
{
    public class ProteinRepository
    {
        private static ProteinData data = new ProteinData();
        public ProteinData GetData(DateTime date)
        {
            return data;
        }

        public void SetTotal(DateTime date, int value)
        {
            data.Total = value;
        }

        public void SetGoal(DateTime date, int value)
        {
            data.Goal = value;
        }
    }
}