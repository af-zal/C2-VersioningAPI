using WebAPIVersioning.Models;

namespace WebAPIVersioning
{
    public static class UsersData
    {
        public static List<User> Get()
        {
            var users = new[]
            {
                new {Id= 1, Name= "Afzal"},
                new {Id= 2, Name= "Hussain"},
                new {Id= 3, Name= "Raj"},
                new {Id= 4, Name= "Prabha"},
                new {Id= 5, Name= "Ram"},
                new {Id= 6, Name= "Nikki"},
                new {Id= 7, Name= "Lax"},
                new {Id= 8, Name= "Rishi"},
                new {Id= 9, Name= "Mouli"},
                new {Id= 10, Name= "Jay"},
            };

            return users.Select(c=> new User { Id= c.Id, Name= c.Name}).ToList();
        }
    }
}
