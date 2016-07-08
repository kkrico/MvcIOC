using System;

namespace MvcIOC.Models
{
    public class DebugMessageService : IDebugMessageService
    {
        public string Message
        {
            get { return DateTime.Now.ToString(); }
        }
    }
}