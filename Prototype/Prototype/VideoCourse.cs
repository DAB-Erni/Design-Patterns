namespace Prototype
{
    public class VideoCourse : Course
    {
        public VideoCourse(string name, string description) : base(name, description) { }

        public override ICoursePrototype Clone()
        {
            return new VideoCourse(CourseName, CourseDescription);
        }

        public override void Display()
        {
            Console.WriteLine($"Course Name: {CourseName}, Description: {CourseDescription}");
        }
    }
}

//Concrete Prototype
