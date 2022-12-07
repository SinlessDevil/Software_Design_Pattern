using System.Collections.Generic;
using UnityEngine;
using Builder;

public class TestBuild : MonoBehaviour
{
    private void Start()
    {
        List<Employee> employees = new()
        {
            new Employee { Name = "Guru", Salary = 100},
            new Employee { Name = "Hotu", Salary = 150 },
            new Employee { Name = "Ferd", Salary = 200 }
        };

        var builder = new EmployeeReportBuilder(employees);

        var director = new EmployeeReportDirector(builder);

        director.Build();

        var report = builder.GetReport();

        Debug.Log(report);
    }
}