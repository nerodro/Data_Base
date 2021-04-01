using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.Sample
{
    public static class Students
    {
        public static void Initialize(StudentContext context)
        {
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new StudentModel
                    {
                        Name = "Иля",
                        Surname = "Капралов",
                        Motherland = "Максимович",
                        Speciality = "Тракторостроительный факультет, он же главный магосфабрикатор",
                        State = "Учится",
                        Course = "Т-1А",
                        DateAdd = "1.09.2020"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
