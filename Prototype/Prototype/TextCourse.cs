namespace Prototype
{
    public class TextCourse : Course
    {
        public TextCourse(string name, string description) : base(name, description) { }

        public override ICoursePrototype Clone()
        {
            return new TextCourse(CourseName, CourseDescription);
        }

        public override void Display()
        {
            Console.WriteLine($"Course Name: {CourseName}, Description: {CourseDescription}");
        }
    }
}

//Concrete Prototype