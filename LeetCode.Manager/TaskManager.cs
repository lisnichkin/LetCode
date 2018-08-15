using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using LeetCode.Models;

namespace LeetCode.Manager
{
    public class TaskManager
    {
        private readonly List<NameSpace> _nameSpaces = new List<NameSpace>
        {
            new NameSpace
            {
                Level = "Easy",
                Name = "LetCode.Algorithms.Easy.Implementation"
            },
            new NameSpace
            {
                Level = "Medium",
                Name = "LetCode.Algorithms.Medium.Implementation"
            },
            new NameSpace
            {
                Level = "Hard",
                Name = "LetCode.Algorithms.Hard.Implementation"
            }
        };

        public List<Task> GetTaskList()
        {
            List<Task> tasks = new List<Task>();

            foreach (var nameSpace in _nameSpaces)
            {
                var types = GetClasses(nameSpace.Name);

                foreach (var type in types)
                {
                    var task = Activator.CreateInstance(type);

                    MethodInfo method = type.GetMethod("GetDescription");

                    var taskDescription = method.Invoke(task, new object[0]).ToString();

                    tasks.Add(new Task
                    {
                        Name = type.Name,
                        Level = nameSpace.Level,
                        Description = taskDescription
                    });
                }
            } 

            return tasks;
        }

        private List<Type> GetClasses(string nameSpace)
        {
            var asm = Assembly.Load("LetCode");

            var classes = asm.GetTypes().Where(p =>
                p.Namespace == nameSpace
            ).ToList();

            return classes;
        }
    }
}
