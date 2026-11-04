using System;
using System.Collections.Generic;
using System.Text;

namespace opps.tasks.Data
{
    internal class Appdbcontext;
        public class AppDbContext
        {
            private Student[] students =
            {
            new Student
            {
                Id = 1,
                FullName = "Ali Veliyev",
                Age = 20,
                Email = "ali@gmail.com"
            },

            new Student
            {
                Id = 2,
                FullName = "Aysel Memmedova",
                Age = 22,
                Email = "aysel@gmail.com"
            },

            new Student
            {
                Id = 3,
                FullName = "Murad Aliyev",
                Age = 19,
                Email = "murad@gmail.com"
            },

            new Student
            {
                Id = 4,
                FullName = "Nigar Hesenova",
                Age = 21,
                Email = "nigar@gmail.com"
            },

            new Student
            {
                Id = 5,
                FullName = "Elvin Quliyev",
                Age = 18,
                Email = "elvin@gmail.com"
            }
        };

            public Student[] GetAllStudent()
            {
                return students;
            }
        }
    }