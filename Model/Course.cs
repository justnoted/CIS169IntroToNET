using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace CIS169IntroToNET.Model;

public class Course
{
    public int Id { get; set; }
    [Display(Name="Course Name")] public string? CourseName { get; set; }
    [Display(Name="Course Description")] public string? CourseDescription { get; set; }
    [Display(Name="Room Number")] public int RoomNumber { get; set; }
    [DataType(DataType.Time)] [Display(Name="Start Time")] public TimeOnly StartTime { get; set; }
    [DataType(DataType.Time)] [Display(Name="End Time")] public TimeOnly EndTime { get; set; }
}