using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Chris.Api.Entities;
using Chris.Api.Helpers;
using Chris.Api.DtoParameters;

namespace Chris.Api.services
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyAsync(Guid companyId);
        Task<IEnumerable<Company>> GetCompaniesAsync(IEnumerable<Guid> companyIds);
        Task<PagedList<Company>> GetCompaniesAsync(CompanyDtoParameters parameters);
        void AddCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
        Task<bool> CompanyExistsAsync(Guid companyId);


        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, EmployeeDtoParameters parameters);
        Task<Employee> GetEmployeeAsync(Guid companyId, Guid employeeId);
        void AddEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        Task<bool> SaveAsync();
    }
}