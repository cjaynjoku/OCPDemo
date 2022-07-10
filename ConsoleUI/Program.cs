// See https://aka.ms/new-console-template for more information
using OCPLibrary;
List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new PersonModel {FirstName = "Januarius", LastName = "Njoku"},
    new PersonModel {FirstName = "Jim", LastName = "Njok"},
    new ManagerModel {FirstName = "Marck", LastName = "Zucck"},
    new ExecutiveModel {FirstName = "Tom", LastName = "Welsh"},

};
List<EmployeeModel> employees = new List<EmployeeModel>();


foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach (var empl in employees)
{
    Console.WriteLine($"{ empl.FirstName } { empl.LastName } { empl.EmailAddress } IsManager: { empl.IsManager } IsExecutive:{ empl.IsExecutive }");
}

Console.ReadLine();