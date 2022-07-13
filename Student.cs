namespace ReflectionExercise
{
    public class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {University} - {RollNumber}");
        }
    }
}
