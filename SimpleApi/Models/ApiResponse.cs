namespace SimpleApi.Models
{
    public class ApiResponse
    {
        public List<Transaction> Data { get; set; } = new List<Transaction>();
        public List<Status> Status { get; set; } = new List<Status>();
    }
}