namespace PayItWeb.Models;

public sealed class User
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public decimal Balance { get; set; }
    public string CardNumber { get; set; } = "";
    public string Expiry { get; set; } = "09/29";
    public string Cvv { get; set; } = "123";
    public string Pin { get; set; } = "1234";
    public bool CardActive { get; set; } = true;
    public int FailedPinAttempts { get; set; }
    public List<BankTransaction> Transactions { get; } = new();
    public string DisplayName => $"{FirstName} {LastName}";
}

public sealed class BankTransaction
{
    public DateTime Date { get; init; } = DateTime.Now;
    public string Type { get; init; } = "";
    public decimal Amount { get; init; }
    public User? Sender { get; init; }
    public User? Recipient { get; init; }
}
