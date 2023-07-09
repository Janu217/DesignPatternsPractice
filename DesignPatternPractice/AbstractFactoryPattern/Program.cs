using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Start");
            Example obj1 = new Example();
            Example obj2 = new Example();
            Console.WriteLine("Main Method Execution End");
            Console.ReadLine();
        }
        //static void Main(string[] args)
        //{
        //    //The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes
        //    //Online Source FrondEnd Course
        //    OnlineSourceFrondEndCourseFactory onlineSourceFrondEndCourseFactory = new OnlineSourceFrondEndCourseFactory();
        //    Console.WriteLine("Source" + onlineSourceFrondEndCourseFactory.GetIsource().getSourceName());
        //    Console.WriteLine("Course Duration" + onlineSourceFrondEndCourseFactory.GetCourse().GetCourseDuration());
        //    Console.WriteLine("Course Name" + onlineSourceFrondEndCourseFactory.GetCourse().getCourseName());
        //    Console.WriteLine("Course Fee" + onlineSourceFrondEndCourseFactory.GetCourse().getCourseFee());

        //    //Offline Source BackEnd Course
        //    OfflineSourceBackEndCourse offlineSourceBackEndCourse = new OfflineSourceBackEndCourse();
        //    Console.WriteLine("Source" + offlineSourceBackEndCourse.GetIsource().getSourceName());
        //    Console.WriteLine("Course Duration" + offlineSourceBackEndCourse.GetCourse().GetCourseDuration());
        //    Console.WriteLine("Course Name" + offlineSourceBackEndCourse.GetCourse().getCourseName());
        //    Console.WriteLine("Course Fee" + offlineSourceBackEndCourse.GetCourse().getCourseFee());

        //    Console.WriteLine("Hello World!");          
        //}
    }
}
