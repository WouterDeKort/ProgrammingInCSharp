using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Startup;

namespace Chapter3.Objective1.SavingANewCustomerToTheDatabaseWrapper
{
    [Description("Listing 3-2 Saving a new customer to the database.")]
    internal class SavingANewCustomerToTheDatabase : ISample
    {
        public void Run()
        {
            using (var ctx = new ShopContext())
            {
                var a = new Address
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };

                var c = new Customer
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a,
                };

                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }
        }
    }

    public class Address
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string AddressLine1 { get; set; }

        [Required, MaxLength(20)]
        public string AddressLine2 { get; set; }

        [Required, MaxLength(20)]
        public string City { get; set; }

        [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
        public string ZipCode { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public Address ShippingAddress { get; set; }

        [Required]
        public Address BillingAddress { get; set; }
    }

    public class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Make sure the database knows how to handle the duplicate address property
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress)
                .WithMany().WillCascadeOnDelete(false);
        }
    }
}