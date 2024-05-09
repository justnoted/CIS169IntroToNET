using Microsoft.EntityFrameworkCore;
using CIS169IntroToNET.Data;

namespace CIS169IntroToNET.Model;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CIS169IntroToNETContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<CIS169IntroToNETContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null CIS169IntroToNETContext");
            }

            // Look for any movies.
            if (context.Course.Any())
            {
                return;   // DB has been seeded
            }

            context.Course.AddRange(
                new Course
                {
                    Id = 169,
                    CourseName = "C#",
                    CourseDescription = "Find yourself in the teaching of C#. The programming language, this is not a music class.",
                    RoomNumber = 200,
                    StartTime = new TimeOnly(9,00),
                    EndTime = new TimeOnly(9,50)
                },

                new Course
                {
                    Id = 175,
                    CourseName = "Java II",
                    CourseDescription = "Learn how to Java, specifically write.",
                    RoomNumber = 200,
                    StartTime = new TimeOnly(10,00),
                    EndTime = new TimeOnly(10,50)
                },

                new Course
                {
                    Id = 412,
                    CourseName = "COBOL II",
                    CourseDescription = "Continue learning about the language that most likely manages your money at the ATM",
                    RoomNumber = 116,
                    StartTime = new TimeOnly(11,00),
                    EndTime = new TimeOnly(11,50)
                },

                new Course
                {
                    Id = 501,
                    CourseName = "Intro to Business Analysis",
                    CourseDescription = "Teamwork completes the coursework",
                    RoomNumber = 200,
                    StartTime = new TimeOnly(8,00),
                    EndTime = new TimeOnly(8,50)
                },
                
                new Course
                {
                    Id = 281,
                    CourseName = "Mobile Development",
                    CourseDescription = "Learn how to cram elements neatly on a touchscreen",
                    RoomNumber = 200,
                    StartTime = new TimeOnly(13,00),
                    EndTime = new TimeOnly(13,50)
                },
                
                new Course
                {
                    Id = 170,
                    CourseName = "Jazz Band",
                    CourseDescription = "Play the note, swing it, and emphasize it. Don't worry, it's not Whiplash.",
                    RoomNumber = 171,
                    StartTime = new TimeOnly(17,00),
                    EndTime = new TimeOnly(18,20)
                }
            );
            context.SaveChanges();
        }
    }
}