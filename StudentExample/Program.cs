


List<Student> INFO350ClassA = new List<Student>();
List<String> listOfStrings = new List<String>();

String aDisplayString = new string("fubar");
String anotherString = "FUBAR  ";

Console.WriteLine(aDisplayString);
Console.WriteLine(anotherString);
Console.WriteLine(anotherString.Trim());

Student studentA = new Student("Phil", 1999, "other", "Information Systems", 4.0, true);
Student studentB = new Student("Jane", 2005, "female", "Information Systems", 4.0, false);
Student studentC = new Student("Vicky");

INFO350ClassA.Add(studentA);
INFO350ClassA.Add(studentB);

Console.WriteLine("There are " + INFO350ClassA.Count + " students in INFO 350 Class A");

INFO350ClassA.Add(studentC);

Console.WriteLine("There are now " + INFO350ClassA.Count + " students in INFO 350 Class A");


//for ( int i = 0;  i < INFO350ClassA.Count; i++ )
//{
//    Student student = INFO350ClassA[i];
//}

foreach (Student student in INFO350ClassA)
{
    student.displayLivesOnCampus();
}

foreach (Student student in INFO350ClassA)
{
    //student.SetLivesOnCampus(!student.livesOnCampus());
    // if the student lives on campus, set them to not live on campus
    if (student.livesOnCampus() == true)
    {
        student.SetLivesOnCampus(false);
    }

    if (student.Major.Equals("undecided"))
    {
        student.Major = "Information Systems";
    }
}

foreach (Student student in INFO350ClassA)
{
    student.displayLivesOnCampus();
}
