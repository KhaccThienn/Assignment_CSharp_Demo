using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_Demo.Entities
{
    public class Student
    {
        // Private fields
        private int id;
        private string name;
        private double mathScore;
        private double phyScore;
        private double cheScore;

        // No args constructor
        public Student() { }

        // Full args constructor
        public Student(int id, string name, double mathScore, double phyScore, double cheScore)
        {
            this.id = id;
            this.name = name;
            this.mathScore = mathScore;
            this.phyScore = phyScore;
            this.cheScore = cheScore;
        }

        // Getters and Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double MathScore
        {
            get { return mathScore; }
            set { mathScore = value; }
        }

        public double PhyScore
        {
            get { return phyScore; }
            set { phyScore = value; }
        }

        public double CheScore
        {
            get { return cheScore; }
            set { cheScore = value; }
        }
    }
}
