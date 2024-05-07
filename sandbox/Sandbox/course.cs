using System.ComponentModel.DataAnnotations;

class Course
{
    public string _courseCode;
    public string _courseName;
    public int _creditHours;
    public string _color;
    public void Display() {
        Console.WriteLine($"{_courseCode} {_courseName} {_creditHours} {_color}");
    }
}