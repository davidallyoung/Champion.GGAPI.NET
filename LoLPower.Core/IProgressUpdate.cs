using System.Security.AccessControl;

namespace LoLPower.Core
{
    public interface IProgressUpdate
    {
         string Message { get; set; }
         int Current { get; set; }
         int Maximum { get; set; }
    }

    public class ProgressUpdateDefault : IProgressUpdate
    {
        public string Message { get; set; }
        public int Current { get; set; }
        public int Maximum { get; set; }

        public ProgressUpdateDefault()
        {
                
        }

        public ProgressUpdateDefault(string message)
        {
            Message = message;
        }

        public ProgressUpdateDefault(string message, int current, int maximum)
        {
            Message = message;
            Current = current;
            Maximum = maximum;
        }
    }
}