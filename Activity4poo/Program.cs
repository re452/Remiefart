using System;
namespace Activity4poo
{
    abstract class Students
    {
        public string name;
        public double grade;
        public void setData(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }
        public abstract void DisplayInfo();

        public abstract string Status();
    }

    class College : Students
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"College Student Name: {name}, Grade: {grade}");
        }
        public override string Status()
        {
            return grade <= 3 ? "Passed!" : "Failed..";
        }
    }
    class SeniorHigh : Students
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Senior High Student Name: {name}, Grade: {grade}");
        }
        public override string Status() 
        {
            return grade >= 75 ? "Passed!" : "Failed..";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Students College_student1 = new College();
            College_student1.setData("Remie", 2.5);
            College_student1.DisplayInfo();
            Console.WriteLine(College_student1.Status());

            Students College_student2 = new College();
            College_student2.setData("Reeaa", 4);
            College_student2.DisplayInfo();
            Console.WriteLine(College_student2.Status()); 

            Students SeniorHigh_student1 = new SeniorHigh();
            SeniorHigh_student1.setData("Remuy", 87);
            SeniorHigh_student1.DisplayInfo();
            Console.WriteLine(SeniorHigh_student1.Status());

            Students SeniorHigh_student2 = new SeniorHigh();
            SeniorHigh_student2.setData("Remay", 70);
            SeniorHigh_student2.DisplayInfo();
            Console.WriteLine(SeniorHigh_student2.Status());
        }
    }
}