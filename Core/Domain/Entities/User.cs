using System.Data.Common;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

namespace SGCM.Domain.Entities
{
    public abstract class Person
    {
        protected string name {get;set;}
        protected int age {get; set;}
        protected int identifycation {get;set;}
        protected string? mail {get;set;}
        protected int? phoneNumber {get;set;}

        public Person(string name, int age, int identifycation, string? mail, int? phoneNumber){
            this.name = name;
            this.age = age;
            this.identifycation = identifycation;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
        }
    } 
}