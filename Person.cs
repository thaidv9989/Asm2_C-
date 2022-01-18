
namespace D2{
    public class Person{
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Gender {get; set;}

        public DateTime DOB {get; set;}

        public string PhoneNumber {get; set;}

        public string BirthPlace {get; set;}

        public int Age {
            get{
                return DateTime.Now.Year - DOB.Year;
            }
        }

        public bool IsGraduated {get; set;}

        public override string ToString(){
            return "Person: " + LastName + " " + FirstName + " - " + 
            Gender + " - " + DOB + " - " + BirthPlace + " - " + Age ;
        }


    }
}

