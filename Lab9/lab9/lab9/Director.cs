using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Director
    {
        
  

        public void Add(object obj, int v)
        {
            Student st = obj as Student;
            Tok tk = obj as Tok;
            if (st != null)
            {
                
                st.AddSalary(v);
                return;
            }
            if (tk != null)
            {
                tk.AddSalary(v);
                return;
            }

            throw new Exception("Not valid obj");
                
        }

        public void Remove(object obj, int v)
        {
            Student st = obj as Student;
            Tok tk = obj as Tok;
            if (st != null)
            {
                st.RemoveSalary(v);
                return;
            }
            if (tk != null)
            {
                tk.RemoveSalary(v);
                return;
            }

            throw new Exception("Not valid obj");

        }


    }

    class Student
    {
        private string name;
        private int salary;

        public delegate void Message(string msg);

        public event Message Up;
        public event Message Down;



        public Student(string n, int s)
        {
            name = n;
            salary = s;
        }

        public override string ToString()
        {
            return "Student. Name = " + name + " Salary = " + salary;
        }

        public void AddSalary(int v)
        {
            if (v <= 0)
                throw new Exception("Must be greater than zero");
            salary += v;
            if (Up != null)
                Up("Студент " + name + " Повышение на " + v);
        }

        public void RemoveSalary(int v)
        {
            if (v <= 0)
                throw new Exception("Must be greater than zero");
            salary -= v;
            if (Down != null)
                Down("Студент " + name + " Понижение на " + v);
        }

        
    }

    class Tok
    {
        private string name;
        private int salary;

        public delegate void Message(string msg);

        public event Message Up;
        public event Message Down;
        


        public Tok(string n, int s)
        {
            name = n;
            salary = s;
        }

        public override string ToString()
        {
            return "Tok. Name = " + name + " Salary = " + salary;
        }

        public void AddSalary(int v)
        {
            if (v <= 0)
                throw new Exception("Must be greater than zero");
            if (Up != null)
                Up("Токарь " + name + " Повышение на " + v);
            salary += v;
        }

        public void RemoveSalary(int v)
        {
            if (v <= 0)
                throw new Exception("Must be greater than zero");
            if (Down != null)
                Down("Токарь " + name + " Понижение на " + v);
            salary -= v;
        }
    }
}
