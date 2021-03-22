using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ASP.NET_Core_Project_Structure.Services
{
    public interface ICustomLogger
    {
        public void LogInformation(string message);
    }
}