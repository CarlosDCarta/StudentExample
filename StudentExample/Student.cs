using System;

public class Student
{
    // Properties
    public string Name { get; set; }
    public int BirthYear { get; set; }
    public string Gender { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    private bool _livesOnCampus;
    private bool _isHonors = false;

    // Constructor
    public Student(string name, int birthYear, string gender, string major, double gpa, bool livesOnCampus)
    {
        Name = name;
        BirthYear = birthYear;
        Gender = gender;
        Major = major;
        GPA = gpa;
        _livesOnCampus = livesOnCampus;
    }

    public Student(string name)
    {
        Name = name;
        Major = "undecided";
        GPA = 0.0;
    }

    // Method to display student information
    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {BirthYear}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"GPA: {GPA}");
    }


    public void SetLivesOnCampus( bool aLivesOnCampusValue )
    {
        _livesOnCampus = aLivesOnCampusValue;
        _isHonors = true;
    }

    public bool livesOnCampus()
    {
        return _livesOnCampus;
    }

    public int age()
    {
        int studentAge;

        // age is current year minus birthyear
        DateTime currentTime = DateTime.Now;

        studentAge = currentTime.Year - BirthYear;

        return studentAge;

        //return (DateTime.Now).Year - BirthYear;
    }

    public void displayLivesOnCampus()
    {
        if( _livesOnCampus == true)
        {
            Console.WriteLine($"{Name} lives on campus");
        } else
        {
            Console.WriteLine($"{Name} does not live on campus");
        }
    }

    // Method to calculate and return student's status based on GPA
    public string GetAcademicStatus()
    {
        if (GPA >= 3.5)
        {
            return "Excellent Standing";
        }
        else if (GPA >= 3.0)
        {
            return "Good Standing";
        }
        else if (GPA >= 2.0)
        {
            return "Fair Standing";
        }
        else
        {
            return "Probation";
        }
    }
}