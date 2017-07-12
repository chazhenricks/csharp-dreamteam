using System;
using System.Collections.Generic;

namespace dreamteam
{

    public interface IClassmate
    {
        string Speciality { get; set; }
        string FirstName {get; set; }
        string LastName {get; set; }
        string FullName {get;}

        void Work();
    }
    public class Eliza : IClassmate
    {
        public string Speciality{get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName => $"{this.FirstName} {this.LastName}";

        public void Work()
        {
            Console.WriteLine("Eliza will organize all the things.");
        }
    }
    public class Chaz : IClassmate
    {
        public string Speciality {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName => $"{this.FirstName} {this.LastName}";

        public void Work()
        {
            Console.WriteLine("Chaz will make all your dreams come true.");
        }
    }
    public class Andrew : IClassmate
    {
        public string Speciality { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName => $"{this.FirstName} {this.LastName}";

        public void Work()
        {
            Console.WriteLine("Andrew will smoke all the cigarettes.");
        }
    }
    public class Ryan : IClassmate
    {
        public string Speciality {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName => $"{this.FirstName} {this.LastName}";

        public void Work()
        {
            Console.WriteLine("Ryan will have all the fidget spinners.");
        }
    }
    public class Jason : IClassmate
    {
        public string Speciality {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName => $"{this.FirstName} {this.LastName}";

        public void Work()
        {
            Console.WriteLine("Jason will be sarcastic.");
        }
    }
    public class Jordan : IClassmate
    {
        public string Speciality {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Jordan will bring his lunch in multiple containers.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Eliza eliza = new Eliza();
            eliza.Speciality = "Analytical";
            eliza.FirstName = "Eliza";
            eliza.LastName = "Meeks";

            Chaz chaz = new Chaz();
            chaz.Speciality = "Enthusiastic";
            chaz.FirstName = "Chaz";
            chaz.LastName = "Henricks";

            Andrew andrew = new Andrew();
            andrew.Speciality = "Accepting";
            andrew.FirstName = "Andrew";
            andrew.LastName = "Rock";

            Ryan ryan = new Ryan();
            ryan.Speciality = "Determined";
            ryan.FirstName = "Ryan";
            ryan.LastName = "McCarty";

            Jason jason = new Jason();
           jason.Speciality = "Sarcasm";
           jason.FirstName = "Jason";
           jason.LastName = "Smith";

            Jordan jordan = new Jordan();
            jordan.Speciality = "Enjoyable";
            jordan.FirstName = "Jordan";
            jordan.LastName = "Dhaenens";

            List<IClassmate> serverSide = new List<IClassmate>();
            List<IClassmate> clientSide = new List<IClassmate>();

            serverSide.Add(eliza);
            serverSide.Add(chaz);
            serverSide.Add(andrew);

            clientSide.Add(jason);
            clientSide.Add(ryan);
            clientSide.Add(jordan);

            foreach(IClassmate server in serverSide){
                server.Work();
            }
            foreach(IClassmate client in clientSide){
                client.Work();
            }


        }
    }
}
