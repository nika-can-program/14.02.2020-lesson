using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._2020_lesson
{
    public class Student
    {
        string name;
        int course;
        bool grant;
        private int age;

        public string Name
        {
            private get
            {return name;}

            set
            {name = value;}
        }
        public int Age
        {
            private get
            {return age;}

            set
            {
                if(value > 16)
                {age = value;}
                else
                {age = 0;}
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Курс: {course}, Стипендия: {grant}, Возраст:{age}");

            
        }
    }
    class Animal
    {
        string name;
        string color;
        int age;
        bool home;

        public Animal()
        {

        }
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal(string name, string color, int age, bool home)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.home = home;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Age { get { return age; } set { age = value < 0 ? 0 : value; } }
        public bool Home { get { return home; } set { home = value; } }

        public virtual void AnimalInfo()
        {
            Console.WriteLine($"Имя: {name}, Цвет: {color}, Возраст: {age}, Одомашненность: {home}");


        }
    }

    class Dog : Animal
    {
        float speed;

        public Dog() { }
        public Dog(string name,float speed):base(name)
        {
            this.speed = speed;
        }

        public float Speed { get { return speed; } set { speed = value; } }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Скорость: {speed}");
        }

    }

    class Emploee
    {
        string fio;
        int age;
        int zp;
        int pp=0.5;
        int nalog;

        public Emploee()
        {

        }
        public Emploee(string fio, int age, int zp,int pp,int nalog)
        {
            this.fio = fio;
            this.age = age;
            this.zp = zp;
            this.pp = pp;
            this.nalog = nalog;
        }

        public string Fio { get { return fio; } set { fio = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Zp { get { return zp; } set { zp = value; } }
        public int Pp { get { return pp; } set { pp = value; } }
        public int Nalog { get { return nalog; } set { nalog = value; } }

        public virtual void SalaryInfo()
        {
            zp = zp-(pp*nalog);
            Console.WriteLine($"Salary:{zp}");
        }

    }
    class Program 
    { 
    
        static void Main(string[] args)
        {


                /*Student tom = new Student();

            tom.Age = 20;
            tom.Name = "Misha";

            tom.DisplayInfo();

            Student alex = new Student();
            alex.Name = "Sasha";
            alex.Age = 14;

            alex.DisplayInfo();*/

            Animal tom = new Animal("Tom", "Black", 2, false);
        

            Dog man = new Dog("mudak" ,14.15f);
            man.Name = "Baran";

            man.AnimalInfo();
            Console.WriteLine(man.Speed);

            Console.ReadLine();

        }
    }
}


