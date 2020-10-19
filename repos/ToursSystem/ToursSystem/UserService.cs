using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMS.Data;
using TMS.Persistance;


namespace TMS.Service

{
  public  class UserService
    {
       public List<User>GetAllUsers()

        {
            ToursDataContext context = new ToursDataContext();
            return context.Users.ToList();
            
        }
        public User GetById(int id)

        {
            ToursDataContext context = new ToursDataContext();
            return context.Users.FirstOrDefault(b => b.Id == id);
              
        }
        public User GetByEmail(string email)

        {
            ToursDataContext context = new ToursDataContext();
            return context.Users.FirstOrDefault(b => b.Email == email);

        }
        public int AddUser(User user)
        {
            ToursDataContext context = new ToursDataContext();
            context.Users.Add(user);
            context.SaveChanges();
            return user.Id;            

        }


    }
}
