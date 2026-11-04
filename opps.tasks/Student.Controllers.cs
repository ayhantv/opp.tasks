using opps.tasks.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace opps.tasks
{     
        public class StudentServices
        {
            AppDbContext context = new AppDbContext();

            // 1. Butun telebeleri qaytarir
            public Student[] GetAllStudents()
            {
                return context.GetAllStudent();
            }

            // 2. Yaslarin cemi
            public int SumOfAges()
            {
                return GetAllStudents().Sum(m => m.Age);
            }

            // 3. Telebelerin sayi
            public int GetStudentsCount()
            {
                return GetAllStudents().Length;
            }

            // 4. Yas ortalamasi
            public double GetAverageAge()
            {
                return GetAllStudents().Average(m => m.Age);
            }

            // 5. Adina gore axtaris
            public Student GetStudentByName(string name)
            {
                return GetAllStudents()
                    .FirstOrDefault(m => m.FullName == name);
            }

            // 6. Yasa gore artan siralama
            public Student[] GetStudentsSortedByAge()
            {
                return GetAllStudents()
                    .OrderBy(m => m.Age)
                    .ToArray();
            }

            // 7. Yasa gore azalan siralama
            public Student[] GetStudentsSortedByAgeDescending()
            {
                return GetAllStudents()
                    .OrderByDescending(m => m.Age)
                    .ToArray();
            }
        }
    }