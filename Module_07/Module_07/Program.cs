using Module_07;

Console.WriteLine("Creating an Employee");

Employee employee = new Employee("Shivam", "Agarwal", "@gmail.com", new DateTime(1992, 1, 17), 34);

employee.PerformWork();
employee.PerformWork();
employee.PerformWork(4);
employee.PerformWork();

Console.WriteLine(employee.RecieveWage());