using System;

namespace Data_Base_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var user = new Users()
                {
                    name = "Вася",
                    password = "12345",
                    date = "22.10.2020"
                };

                var user_2 = new Users()
                {
                    name = "Игорь",
                    password = "1234555",
                    date = "22.10.2019"
                };

                context.Users.Add(user);
                context.Users.Add(user_2);
                context.SaveChanges();

                Console.WriteLine($"id: {user.id}, name {user.name}, password {user.password}, date of registration {user.date}");
                Console.ReadLine();
            }
        }
    }
}
