using System.Data.Common;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

namespace Entities
{
    public abstract class Person
    {
        private string? name {get;set;}
        private int age {get; set;}
        private int identifycation {get;set;}
        private string? mail {get;set;}
        private int phoneNumber {get;set;}

        public Person(string? name, int age, int identifycation, string? mail, int phoneNumber){
            this.name = name;
            this.age = age;
            this.identifycation = identifycation;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
        }
    }

    public sealed class Patient : Person
    {
        public Patient(string? name,int age, int identifycation, string? mail, int phoneNumber) : base(name, age, identifycation, mail, phoneNumber)
        {   
        }
    }

    public sealed class Doctor : Person
    {   
        public Doctor(string? name,int age, int identifycation, string? mail, int phoneNumber) : base(name, age, identifycation, mail, phoneNumber)
        {   
        }
    }   

    public sealed class hospitalPersonal : Person
    {
        public hospitalPersonal(string? name,int age, int identifycation, string? mail, int phoneNumber) : base(name, age, identifycation, mail, phoneNumber)
        {
        }
    }
}