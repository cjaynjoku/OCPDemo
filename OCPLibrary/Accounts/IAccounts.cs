namespace OCPLibrary
{
    public interface IAccounts
    {
        // This Interface was created to enable the extension of the functionalities of the account class to handle various employee types,
        // rather than modify the original code.
        EmployeeModel Create(IApplicantModel person);
    }
}