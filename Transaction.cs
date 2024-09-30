public class Transaction
{
    public DateTime TransactionDate { get; set; }
    public string SendingAccount { get; set; }
    public string ReceivingAccount { get; set; }
    public string TransactionReference { get; set; }
    public string TransactionStatus { get; set; }
    public string Narration { get; set; }
    public decimal TransactionAmount { get; set; }
}