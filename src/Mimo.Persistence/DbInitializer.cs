using System.Collections.Generic;
using System.Linq;
using Mimo.Domain.Models;

namespace Mimo.Persistence
{
    public static class DbInitializer
    {
        public static void Initialize(MimoDbContext context)
        {
            context.Database.EnsureCreated();

         
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            // create courses
            var swiftCourse = new Course { Name = "Swift" };
            var javascriptCourse = new Course { Name = "Javascript" };
            var cSharpCourse = new Course { Name = "C#" };
            context.Courses.AddRange(swiftCourse, javascriptCourse, cSharpCourse);
            context.SaveChanges();

            // create chapters
            var swiftChapters = new List<Chapter>
        {
            new() { Order = 1, Name = "Chapter 1", Course = swiftCourse },
            new() { Order = 2, Name = "Chapter 2", Course = swiftCourse }
        };
            var javascriptChapters = new List<Chapter>
        {
            new() { Order = 1, Name = "Chapter 1", Course = javascriptCourse },
            new() { Order = 2, Name = "Chapter 2", Course = javascriptCourse },
            new() { Order = 3, Name = "Chapter 3", Course = javascriptCourse }
        };
            var cSharpChapters = new List<Chapter>
        {
            new() { Order = 1, Name = "Chapter 1", Course = cSharpCourse },
            new() { Order = 2, Name = "Chapter 2", Course = cSharpCourse },
            new() { Order = 3, Name = "Chapter 3", Course = cSharpCourse },
            new() { Order = 4, Name = "Chapter 4", Course = cSharpCourse }
        };
            context.Chapters.AddRange(swiftChapters);
            context.Chapters.AddRange(javascriptChapters);
            context.Chapters.AddRange(cSharpChapters);
            context.SaveChanges();

            // create lessons
            var swiftLessons = new List<Lesson>
        {
            new() { Order = 1, Name = "Lesson 1", Chapter = swiftChapters[0] },
            new() { Order = 2, Name = "Lesson 2", Chapter = swiftChapters[0] },
            new() { Order = 3, Name = "Lesson 3", Chapter = swiftChapters[0] },
            new() { Order = 1, Name = "Lesson 1", Chapter = swiftChapters[1] },
            new() { Order = 2, Name = "Lesson 2", Chapter = swiftChapters[1] },
            new() { Order = 3, Name = "Lesson 3", Chapter = swiftChapters[1] }
        };
            var javascriptLessons = new List<Lesson>
        {
            new() { Order = 1, Name = "Lesson 1", Chapter = javascriptChapters[0] },
            new() { Order = 2, Name = "Lesson 2", Chapter = javascriptChapters[0] },
            new() { Order = 3, Name = "Lesson 3", Chapter = javascriptChapters[0] },
            new() { Order = 1, Name = "Lesson 1", Chapter = javascriptChapters[1] },
            new() { Order = 2, Name = "Lesson 2", Chapter = javascriptChapters[1] },
            new() { Order = 3, Name = "Lesson 3", Chapter = javascriptChapters[1] },
            new() { Order = 1, Name = "Lesson 1", Chapter = javascriptChapters[2] },
            new() { Order = 2, Name = "Lesson 2", Chapter = javascriptChapters[2] },
            new() { Order = 3, Name = "Lesson 3", Chapter = javascriptChapters[2] }
        };
            var cSharpLessons = new List<Lesson>
        {
            new() { Order = 1, Name = "Lesson 1", Chapter = cSharpChapters[0] },
            new() { Order = 2, Name = "Lesson 2", Chapter = cSharpChapters[0] },
            new() { Order = 3, Name = "Lesson 3", Chapter = cSharpChapters[0] },
            new() { Order = 1, Name = "Lesson 1", Chapter = cSharpChapters[1] },
            new() { Order = 2, Name = "Lesson 2", Chapter = cSharpChapters[1] },
            new() { Order = 3, Name = "Lesson 3", Chapter = cSharpChapters[1] },
            new() { Order = 1, Name = "Lesson 1", Chapter = cSharpChapters[2] },
            new() { Order = 2, Name = "Lesson 2", Chapter = cSharpChapters[2] },
            new() { Order = 3, Name = "Lesson 3", Chapter = cSharpChapters[2] },
            new() { Order = 1, Name = "Lesson 1", Chapter = cSharpChapters[3] },
            new() { Order = 2, Name = "Lesson 2", Chapter = cSharpChapters[3] },
            new() { Order = 3, Name = "Lesson 3", Chapter = cSharpChapters[3] }
        };
            context.Lessons.AddRange(swiftLessons);
            context.Lessons.AddRange(javascriptLessons);
            context.Lessons.AddRange(cSharpLessons);
            context.SaveChanges();

            // create user
            var user = new User { Name = "Mark Smith" };
            context.Users.Add(user);
            context.SaveChanges();

            // create achievements
            var achievements = new List<Achievement>
        {
            new() { Name = "Complete 5 lessons", },
            new() { Name = "Complete 25 lessons", },
            new() { Name = "Complete 50 lessons",  },
            new() { Name = "Complete 1 chapter", },
            new() { Name = "Complete 5 chapters",  },
            new() { Name = "Complete the Swift course",  },
            new() { Name = "Complete the Javascript course", },
            new() { Name = "Complete the C# course",  }
        };
            context.Achievements.AddRange(achievements);
            context.SaveChanges();


            var userAchievement = new List<UserAchievement> { new UserAchievement() { AchievementId = 1, UserId = 1 } };

            context.UserAchievements.AddRange(userAchievement);
            context.SaveChanges();
        }
    }


}
