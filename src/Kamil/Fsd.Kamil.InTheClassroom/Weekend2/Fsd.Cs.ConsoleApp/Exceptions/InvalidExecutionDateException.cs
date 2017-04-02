using System;

namespace Fsd.Cs.ConsoleApp.Exceptions
{
    public class InvalidExecutionDateException : Exception
    {
        public DateTime ExecutionDate { get; private set; }

        public InvalidExecutionDateException(DateTime executionDate)
        {
            ExecutionDate = executionDate;
        }
    }
}
