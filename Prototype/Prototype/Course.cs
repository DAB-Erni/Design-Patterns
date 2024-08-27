namespace Prototype;

public abstract class Course : ICoursePrototype
{
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }

    protected Course(string name, string description)
    {
        CourseName = name;
        CourseDescription = description;
    }

    public abstract ICoursePrototype Clone();
    public abstract void Display();
}

//Base Class
