using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class RegisterEmployeeUseCase
    {
        private readonly ILogger _logger;

        public RegisterEmployeeUseCase(ILogger logger)
        {
            _logger = logger;
        }

        public void RegisterEntryTime(Employee employee)
        {
            employee.EntryTime = DateTime.Now;
            _logger.Log($"{employee.Name} marcó entrada a las {employee.EntryTime}.");
        }

        public void RegisterExitTime(Employee employee)
        {
            employee.ExitTime = DateTime.Now;
            _logger.Log($"{employee.Name} marcó entrada a las {employee.ExitTime}.");

        }

    }
}
