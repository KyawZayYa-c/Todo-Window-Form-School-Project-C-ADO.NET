using System.Collections.Generic;
using System.Linq;

namespace Todo_School_Project
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
    }

    public static class DataStore
    {
        public static List<User> Users = new List<User>();
        public static List<TaskItem> Tasks = new List<TaskItem>();

        public static void InitializeData()
        {
            if (!Users.Any(u => u.Role == "Admin"))
            {
                Users.Add(new User { UserId = 1, Username = "admin", Password = "123", Role = "Admin", IsActive = true });
            }

            if (!Users.Any(u => u.Role == "User"))
            {
                Users.Add(new User { UserId = 2, Username = "mgmg", Password = "123", Role = "User", IsActive = true });
                Users.Add(new User { UserId = 3, Username = "aung aung", Password = "123", Role = "User", IsActive = false });

                Tasks.Add(new TaskItem { Id = 1, UserId = 2, TaskName = "C# Homework", Status = "Pending" });
                Tasks.Add(new TaskItem { Id = 2, UserId = 2, TaskName = "Read Book", Status = "Completed" });
                Tasks.Add(new TaskItem { Id = 3, UserId = 3, TaskName = "Buy Groceries", Status = "Pending" });
            }
        }
    }
}