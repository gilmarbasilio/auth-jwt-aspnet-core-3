using System.Collections.Generic;
using System.Linq;
using AuthJWTAspNetCore3.Models;

namespace AuthJWTAspNetCore3.Repositories
{
  public static class UserRepository
  {
    public static User Get(string username, string password)
    {
      List<User> users = new List<User>();
      users.Add(new User { Id = 1, Username = "batman", Password = "batman", Role = "manager" });
      users.Add(new User { Id = 1, Username = "robin", Password = "robin", Role = "employee" });
      return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
    }
  }
}