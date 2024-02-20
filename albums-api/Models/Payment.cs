// Create a model for Payment
public class Payment
{
    public int Id { get; set; }
    public string PaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}

