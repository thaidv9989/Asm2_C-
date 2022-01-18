// See https://aka.ms/new-console-template for more information
namespace D2
{
    class Program{
        static void Main(string[] args)
        {
            var persons  = new List<Person>(){
                new Person{
                   FirstName = "Thai",
                   LastName = "Do Van",
                   Gender = "Male",
                   DOB = new DateTime(2001, 2, 15),
                   PhoneNumber = "",
                   BirthPlace = "Thai Binh",
                   IsGraduated = false
                },
                new Person{
                    FirstName = "Hoc",
                    LastName = "Nguyen Thai",
                    Gender = "Male",
                    DOB = new DateTime(2000, 2, 15),
                    PhoneNumber = "",
                    BirthPlace = "Ha Nam",
                    IsGraduated = false
                },
                new Person{
                    FirstName = "Thanh",
                    LastName = "Do Tien",
                    Gender = "Male",
                    DOB = new DateTime(1999, 2, 15),
                    PhoneNumber = "",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Person{
                    FirstName = "Anh",
                    LastName = "Do Ngoc",
                    Gender = "Male",
                    DOB = new DateTime(1998, 3, 11),
                    PhoneNumber = "",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Person{
                    FirstName = "Duy",
                    LastName = "Pham Tran",
                    Gender = "Male",
                    DOB = new DateTime(1998, 3, 11),
                    PhoneNumber = "",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Person{
                    FirstName = "Quan",
                    LastName = "Pham Dinh",
                    Gender = "Male",
                    DOB = new DateTime(1990, 3, 11),
                    PhoneNumber = "",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Person{
                    FirstName = "Huy",
                    LastName = "Nguyen Quang",
                    Gender = "Female",
                    DOB = new DateTime(1997, 3, 11),
                    PhoneNumber = "",
                    BirthPlace = "Bac Giang",
                    IsGraduated = false
                }

            };

             

            Console.WriteLine("---Select Male member---");
            var result = from p in persons 
            where p.Gender == "Male" 
            select p;
            foreach (var person in result)
            {
                Console.WriteLine("");
                Console.WriteLine(person);
            }

            Console.WriteLine("---Select Oldest member---");
            var oldest = from p in persons
            orderby p.Age descending
            select p;
            Console.WriteLine(oldest.FirstOrDefault() == null ? new Person() : oldest.First());


            Console.WriteLine("---Select fullName member---");
            var fullName = from p in persons
            select new{
                fn = p.FirstName,
                ln = string.Join(',', p.LastName),
            };
            foreach (var full in fullName)
            {
                Console.WriteLine(full.ln + " " + full.fn);
            }
            

            Console.WriteLine("---Select Ha Noi member---");
            var place = from p in persons 
            where p.BirthPlace == "Ha Noi" 
            select p;
            foreach (var person in place)
            {
                Console.WriteLine("");
                Console.WriteLine(person);
            } 

            Console.WriteLine("--- Select list birth year:2000, >2000, <2000 ---");
            var year2000 = from p in persons
            where p.DOB.Year == 2000 
            select p;
            Console.WriteLine("-----Member birth year is 2000-----");
            foreach (var p in year2000)
            {
                
                Console.WriteLine(p.ToString());
            }

            var greater2000 = from p in persons
            where p.DOB.Year > 2000 
            select p;
            Console.WriteLine("-----Member birth year greater than 2000-----");
            foreach (var p in greater2000)
            {
                
                Console.WriteLine(p.ToString());
            }

            var less2000 = from p in persons
            where p.DOB.Year < 2000 
            select p;
            Console.WriteLine("-----Member birth year birth year less than 2000-----");
            foreach (var p in less2000)
            {
                Console.WriteLine(p.ToString());
            }
        }
    } 
}
