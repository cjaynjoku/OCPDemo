namespace OCPLibrary
{
    public interface IApplicantModel
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } 
    }
}