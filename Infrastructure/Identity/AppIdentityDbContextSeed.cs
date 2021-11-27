using System.Linq;
using System.Threading.Tasks;
using Core.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> usermanager)
        {
            if (!usermanager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Bod",
                    Email = "bob@test.com",
                    UserName = "bob@test.com",
                    Address = new Address
                    {
                        FirstName = "Bob",
                        LastName = "Bonnity",
                        Street = "10 The Street",
                        City = "New York",
                        State = "NY",
                        ZipCode = "90210"
                    }
                };
            await usermanager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}