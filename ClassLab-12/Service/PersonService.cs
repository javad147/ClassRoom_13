using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class PersonService
    {
        public static Person[] GetAll() 
        {
            return new Person[]
            {
                new Person {Id =  1, Name ="Javad", Surname = "Bakirli"},
                new Person {Id =  2, Name ="Zaur", Surname = "Alakbarov"},
                new Person {Id =  3, Name ="Yunis", Surname = "Aliyev"},
                new Person {Id =  4, Name ="Qoshqar", Surname = "Jafarov"},
                new Person {Id =  5, Name ="Namig", Surname = "Aliyev"},
            };


        }

        public static string GetFullName(this Person person)
        {
            return $"{person.Name} {person.Surname}";
        }
        public static int Product(this int[] array)
        {
            int result = 1;
            foreach (int number in array)
            {
                result *= number;
            }
            return result;
        }







    }
}
