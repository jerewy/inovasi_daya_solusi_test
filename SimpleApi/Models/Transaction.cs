namespace SimpleApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string ProductID { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public int Status { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreateOn { get; set; }
    }
}