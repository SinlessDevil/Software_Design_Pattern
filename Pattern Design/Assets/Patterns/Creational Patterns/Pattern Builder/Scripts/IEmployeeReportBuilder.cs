namespace Builder
{
    public interface IEmployeeReportBuilder
    {
        IEmployeeReportBuilder BuildHeader();
        IEmployeeReportBuilder BuildBody();
        IEmployeeReportBuilder BuildFooter();

        EmployeerReport GetReport();
    }
}