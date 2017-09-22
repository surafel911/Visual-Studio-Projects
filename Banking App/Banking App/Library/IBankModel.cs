namespace Library
{
    public interface IBankModel
    {
        string FirstName { get; set; }
        string MiddleInitial { get; set; }
        string LastName { get; set; }
        string SocialSecurity { get; set; }
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }

        string GetFirstName();
    }
}
