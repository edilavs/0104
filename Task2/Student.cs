using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Student:Person
    {
        public Student(string name, string surname, byte age, double IQRank, double LanguageRank)
        {
            this.Name = name;
            this.Surname = surname;
            this._age = age;
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;
        }
        private byte _age;
        public byte Age
        {
            get => _age; set
            {
                if (value >=6 && value < 20)
                {
                    _age = value;
                }
                else 
                    return;
            }
        }
        public double IQRank { get; set; }
        public double LanguageRank { get; set; }
        public void ExamResult()
        {
            if(IQRank + LanguageRank<120)
                Console.WriteLine("Sagird sinifde qalib.");
        }
    }
}
