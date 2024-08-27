using Prototype;
using System;
class Program
{
    static void Main(string[] args)
    {
        VideoCourse videoCourse = new VideoCourse("C# Basics", "An introductory course on C#.");
        TextCourse textCourse = new TextCourse("JavaScript Fundamentals", "A comprehensive guide to JavaScript programming.");
        InteractiveCourse interactiveCourse = new InteractiveCourse("Python for Data Science", "Interactive tutorials for data science.");

        VideoCourse clonedVideoCourse = (VideoCourse)videoCourse.Clone();
        TextCourse clonedTextCourse = (TextCourse)textCourse.Clone();
        InteractiveCourse clonedInteractiveCourse = (InteractiveCourse)interactiveCourse.Clone();

        Console.WriteLine("Available courses:");
        videoCourse.Display();
        textCourse.Display();
        interactiveCourse.Display();

        Console.WriteLine("\nCloned version of available courses:");
        clonedVideoCourse.Display();
        clonedTextCourse.Display();
        clonedInteractiveCourse.Display();

    }
}