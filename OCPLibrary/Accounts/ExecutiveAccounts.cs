namespace OCPLibrary
{
    internal class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName }{ person.LastName }@lumina.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}