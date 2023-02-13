using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Mgt_Application.Contracts
{
    public interface IRepositoryManager
    {
        IPatientRepository Patient { get; }
        Task SaveAsync();
    }
}
