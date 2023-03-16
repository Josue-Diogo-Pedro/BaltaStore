namespace BaltaShared.DOMAIN.StoreContext.Entities;

public class Customer
{
    public Customer(string firstName, string lastName, string email, string phone, string adress)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Adress = adress;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string Adress { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
