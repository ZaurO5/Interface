public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public RegistrationMonth RegistrationMonth { get; set; }
    private string pin;

    public string PIN
    {
        get => pin;
        set
        {
            if (value.IsValidPIN())
            {
                pin = value;
            }
            else
            {
                throw new ArgumentException("Invalid PIN format. Your PIN must be 7 characters long and all uppercase.");
            }
        }
    }

    public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
    {
        Name = name;
        Surname = surname;
        RegistrationMonth = registrationMonth;
        PIN = pin;
    }

    public string GetDetails()
    {
        return $"Name: {Name}, Surname: {Surname}, Registration Month: {RegistrationMonth}, PIN: {PIN}";
    }
}
