namespace Reporter
{
    public interface IEmployeeReportBuilder
    {
        IEmployeeReportBuilder BuildHeader();

        IEmployeeReportBuilder BuildBody();

        IEmployeeReportBuilder BuildFooter();

        EmployeeReport GetReport();
    }
}
