using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;

namespace Builder
{

    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeerReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"EMPLOYEES REPORT ON DATE: {DataSetDateTime.Local}\n";

            _employeeReport.Header += "\n---------------------------------------------------------------------------\n";
            return this;
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body = string.Join(Environment.NewLine,
                _employees.Select(e =>
                $"Employee: {e.Name}\t\tSalaty: {e.Salary}"));
            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer += "\n---------------------------------------------------------------------------\n";

            _employeeReport.Footer +=
                $"\n TOTAL EMPLOYEES: {_employees.Count()}, " +
                $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}";
            return this;
        }

        public EmployeerReport GetReport()
        {
            EmployeerReport employeerReport = _employeeReport;

            _employeeReport = new();

            return employeerReport;
        }
    }
}