using Brainworks.Model.Student;
using System;


namespace Brainworks
{
    public class program
    {
        static void Main()
        {
            Studentmodel studentFirst = new Studentmodel(1, "John");
            studentFirst.Introduce();

            Subjectmodel subject1 = new Subjectmodel();
            subject1.Id = 1;
            subject1.Name = "Computer Science";
            studentFirst.subjects.Add(subject1);

            Subjectmodel subject2 = new Subjectmodel();
            subject2.Id = 2;
            subject2.Name = " Science";
            studentFirst.subjects.Add(subject2);

            Subjectmodel subject3 = new Subjectmodel();
            subject3.Id = 3;
            subject3.Name = "Computer";
            studentFirst.subjects.Add(subject3);
            
            foreach(Subjectmodel subject in studentFirst.subjects)
            {
                Console.WriteLine(subject.Name);
            }
             
            Console.ReadKey();

        }
       
    }
    
}