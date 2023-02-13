using Hospital_Mgt_Domain.Models;

namespace Hospital_Mgt_Application.Contracts
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllPatientsAsync(bool trackChanges);
        Task<Patient> GetPatientByIdAsync(int id, bool trackChanges);
        Task<Patient> GetPatientByNameAsync(string firstName, string familyName, bool trackChanges);
        void CreatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}
