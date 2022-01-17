using System;
using System.Collections.Generic;

namespace assign
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
           List<Member> lsMember =  SeedingData();
           WhoMale(lsMember);
           Older(lsMember);
           FullName(lsMember);
           ListAge(lsMember);
           Born(lsMember);
          
        }
        static void  WhoMale(List<Member> members){
            Console.WriteLine("Tra Ve Gioi Tinh Nam");
            foreach (var member in members)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine(member.FistName + member.LastName);
                }
            }
        }
        static void Older(List<Member> members){
            Console.WriteLine("Tra Ve Nguoi Cao Tuoi Nhat");
            Member old =  members[0]; 
            foreach (var member in members)
            {
                if (old.Age < member.Age )
                {
                    old = member;
                    
                }
            }
            Console.WriteLine(old.FistName + old.LastName + old.Age +old.BirthPlace);
        }
        static void FullName(List<Member> fullname){
            Console.WriteLine("Tra Ve Danh Sach Ho Va Ten");
            foreach (var member in fullname)
            {
                Console.WriteLine(member.FistName + member.LastName + member.IsGraduated);
                
            }       
        }
        static void ListAge(List<Member> listage){
            Console.WriteLine("Tra Ve Danh Sach Nam Sinh");
            foreach (var listage1 in listage)
            {
                if (listage1.DateOfBirth > 2000)
                {
                    Console.WriteLine("Danh sach nguoi sinh nam >2000 la :");
                    Console.WriteLine(listage1.FistName + listage1.LastName + listage1.Gender + listage1.DateOfBirth +listage1.BirthPlace);
                }
                 if (listage1.DateOfBirth == 2000)
                {
                    Console.WriteLine("Danh sach nguoi sinh nam 2000 la :");
                    Console.WriteLine(listage1.FistName + listage1.LastName + listage1.Gender + listage1.DateOfBirth +listage1.BirthPlace);
                }
                 if (listage1.DateOfBirth < 2000)
                {
                    Console.WriteLine("Danh sach nguoi sinh nam <2000 la :");
                    Console.WriteLine(listage1.FistName + listage1.LastName + listage1.Gender + listage1.DateOfBirth +listage1.BirthPlace);
                }
        }
        }
        static void Born(List<Member> bornin){
            Console.WriteLine("Tra Ve Nguoi Sinh Ra O Ha Noi");
            
            foreach ( var lsborn in bornin)
            {
                if (  lsborn.BirthPlace == "Ha Noi")
                {

                    Console.WriteLine(lsborn.FistName + lsborn.LastName + lsborn.Gender + lsborn.DateOfBirth +lsborn.BirthPlace);
                    
                }

            }
            
        }
            
        
        
        static List<Member> SeedingData(){
            List<Member> members = new List<Member>();
            members.Add(
                new Member()
                {
                    FistName="Quan",
                    LastName="Pham",
                    Gender="Male",
                    DateOfBirth=2000,
                    PhoneNumber=012345678,
                    BirthPlace="Thai Binh",
                    Age=21,
                    IsGraduated=true
                    });
                    
            members.Add(
                new Member()
                {
                    FistName="Manh",
                    LastName="Nguyen Van",
                    Gender="FeMale",
                    DateOfBirth=1988,
                    PhoneNumber=012345678,
                    BirthPlace="Thai Binh",
                    Age=31,
                    IsGraduated=true
                    });
                members.Add(
                new Member()
                {
                    FistName="A",
                    LastName="Nguyen Van",
                    Gender="FeMale",
                    DateOfBirth=1988,
                    PhoneNumber=012345678,
                    BirthPlace="Thai Binh",
                    Age=31,
                    IsGraduated=true
                    });
                    members.Add(
                new Member()
                {
                    FistName="B",
                    LastName="Nguyen Van",
                    Gender="Male",
                    DateOfBirth=2001,
                    PhoneNumber=012345678,
                    BirthPlace="Ha Noi",
                    Age=20,
                    IsGraduated=true
                    });
                    members.Add(
                new Member()
                {
                    FistName="C",
                    LastName="Nguyen Van",
                    Gender="Male",
                    DateOfBirth=2002,
                    PhoneNumber=012345678,
                    BirthPlace="Ha Noi",
                    Age=19,
                    IsGraduated=true
                    });
                return members;
        }
        
    }
   
}
