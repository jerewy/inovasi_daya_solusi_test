using Microsoft.EntityFrameworkCore;
using SimpleApi.Models;

namespace SimpleApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Status data with different IDs to avoid EF Core seed conflicts
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 10, Name = "SUCCESS" },
                new Status { Id = 11, Name = "FAILED" }
            );

            // Seed Transaction data
            modelBuilder.Entity<Transaction>().HasData(
                new Transaction 
                { 
                    Id = 1372, 
                    ProductID = "10001", 
                    ProductName = "Test 1", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-07-10 11:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 11:14:52") 
                },
                new Transaction 
                { 
                    Id = 1373, 
                    ProductID = "10002", 
                    ProductName = "Test 2", 
                    Amount = "2000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-07-11 13:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 13:14:52") 
                },
                new Transaction 
                { 
                    Id = 1374, 
                    ProductID = "10001", 
                    ProductName = "Test 1", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-08-10 12:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 12:14:52") 
                },
                new Transaction 
                { 
                    Id = 1375, 
                    ProductID = "10002", 
                    ProductName = "Test 2", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 11,
                    TransactionDate = DateTime.Parse("2022-08-10 13:10:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 13:10:52") 
                },
                new Transaction 
                { 
                    Id = 1376, 
                    ProductID = "10001", 
                    ProductName = "Test 1", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-08-10 13:11:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 13:11:52") 
                },
                new Transaction 
                { 
                    Id = 1377, 
                    ProductID = "10002", 
                    ProductName = "Test 2", 
                    Amount = "2000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-08-12 13:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 13:14:52") 
                },
                new Transaction 
                { 
                    Id = 1378, 
                    ProductID = "10001", 
                    ProductName = "Test 1", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-08-12 14:11:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 14:11:52") 
                },
                new Transaction 
                { 
                    Id = 1379, 
                    ProductID = "10002", 
                    ProductName = "Test 2", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 11,
                    TransactionDate = DateTime.Parse("2022-09-13 11:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 11:14:52") 
                },
                new Transaction 
                { 
                    Id = 1380, 
                    ProductID = "10001", 
                    ProductName = "Test 1", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-09-13 13:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 13:14:52") 
                },
                new Transaction 
                { 
                    Id = 1381, 
                    ProductID = "10002", 
                    ProductName = "Test 2", 
                    Amount = "2000", 
                    CustomerName = "abc", 
                    Status = 10,
                    TransactionDate = DateTime.Parse("2022-09-14 09:11:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 09:11:52") 
                },
                new Transaction 
                { 
                    Id = 1382, 
                    ProductID = "10001", 
                    ProductName = "Test 1", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 0, 
                    TransactionDate = DateTime.Parse("2022-09-14 10:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 10:14:52") 
                },
                new Transaction 
                { 
                    Id = 1383, 
                    ProductID = "10002", 
                    ProductName = "Test 2", 
                    Amount = "1000", 
                    CustomerName = "abc", 
                    Status = 11,
                    TransactionDate = DateTime.Parse("2022-08-15 13:14:52"), 
                    CreateBy = "abc", 
                    CreateOn = DateTime.Parse("2022-07-10 13:14:52") 
                }
            );
        }
    }
}