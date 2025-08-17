using System;
using System.Collections.Generic;

public class Course
{
    public string title;
    internal int units;

    public Course(string t, int u)
    {
        title = t;
        units = u;
    }
}

public class Student
{
    public string name;
    public Course enrolledCourse;

    public Student(string n, Course c)
    {
        name = n;
        enrolledCourse = c;
    }
}

public class Teacher
{
    public string name;
    protected string subject;

    public Teacher(string n, string s)
    {
        name = n;
        subject = s;
    }

    public void Teach()
    {
        Console.WriteLine(name + " teaches " + subject);
    }
}

public class Department
{
    public string name;
    public List<Teacher> teachers = new List<Teacher>();

    public Department(string n)
    {
        name = n;
    }
}

public class Room
{
    public string name;
    public Room(string n) { name = n; }
}

public class House
{
    public string address;
    public List<Room> rooms = new List<Room>();

    public House(string addr)
    {
        address = addr;
        rooms.Add(new Room("Living Room"));
        rooms.Add(new Room("Bedroom"));
    }

    public void ShowRooms()
    {
        foreach (var r in rooms)
            Console.WriteLine(" - " + r.name);
    }
}

class Program
{
    static void Main()
    {
        Course math = new Course("Mathematics", 3); 
        Student alice = new Student("Alice", math);
        Console.WriteLine(alice.name + " enrolled in " + alice.enrolledCourse.title);
        Teacher t1 = new Teacher("Mr. Smith", "Physics");
        Teacher t2 = new Teacher("Ms. Lee", "Chemistry");
        Department science = new Department("Science Department");
        science.teachers.Add(t1);
        science.teachers.Add(t2);
        Console.WriteLine(science.name + "Teachers: ");
        foreach (var t in science.teachers) t.Teach();

        House myHouse = new House("123 Main St");
        Console.WriteLine(myHouse.address + " has rooms: ");
        myHouse.ShowRooms();
    }
}