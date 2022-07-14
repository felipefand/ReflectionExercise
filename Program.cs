using System.Reflection;

namespace ReflectionExercise
{
    internal class Program
    {
        static void DisplayPublicProperties()
        {
            var operations = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var operation in operations)
            {
                if (operation.GetTypeInfo () == typeof(Student))
                {
                    var properties = operation.GetProperties();

                    foreach(var property in properties)
                    {
                        Console.WriteLine(property.Name);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void CreateInstance(string name, string university, int rollNumber)
        {
            var operations = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var operation in operations)
            {
                if (operation.GetTypeInfo() == typeof(Student))
                {
                    var student = (Student)Activator.CreateInstance(operation);
                    student.Name = name;
                    student.University = university;
                    student.RollNumber = rollNumber;

                    student.DisplayInfo();
                }
            }
        }

        static void Main(string[] args)
        {
            DisplayPublicProperties();
            CreateInstance("Felipe", "Let's Code", 123456);
            CreateInstance("Fulano", "Lets's Code", 654321);
        }
    }
}