using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    // CRUD
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync(); // R read
        Task<Employee?> GetByIdAsync(int id); // R read
        Task AddEmployeeAsync(Employee employee); // C create
        Task UpdateEmployeeAsync(Employee employee); // U update
        Task DeleteEmployeeAsync(int id); // D delete

    }
}
// we use interfaces to create specific
// contracts so that a class which implements an interface has
// to implement all the members of that interface.
//So that we can have type safety and guarantee.
// we have not implemented them yet,here we defined them because we are in a interface

