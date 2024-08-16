using Assignment_CSharp_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_Demo.Interfaces
{
    public interface IStudent
    {
        void InputData();
        void Display();

        List<Student> Search(double n, double m);
        List<Student> Search(string name);
    }
}
