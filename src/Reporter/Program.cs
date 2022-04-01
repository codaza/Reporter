using Reporter;

List<Employee> employees = new()
{
    new Employee { Name = "Ivan", Salary = 100 },
    new Employee { Name = "Boris", Salary = 50 },
    new Employee { Name = "Fedor", Salary = 200 }
};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);

Console.ReadKey();