namespace Prototype
{
    public class InteractiveCourse : Course
    {
        public InteractiveCourse(string name, string description) : base(name, description) { }

        public override ICoursePrototype Clone()
        {
            return new InteractiveCourse(CourseName, CourseDescription);
        }

        public override void Display()
        {
            Console.WriteLine($"Course Name: {CourseName}, Description: {CourseDescription}");
        }
    }
}

//Concrete Prototype