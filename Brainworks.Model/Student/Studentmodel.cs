using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainworks.Model.Student
{
    public class Studentmodel
    {
        public Studentmodel()
        {

        }
        public Studentmodel(int id) : this()
        {
            Id = id + 1;
        }
        public Studentmodel(int id, string name) : this(id)
        {
            Name = name;
        }
        public int Id;
        public string Name;
        public List<Subjectmodel> subjects = new List<Subjectmodel>();
        public void Introduce()
        {
            Console.WriteLine("Hello ! My name is " + Name + " and id is " + Id);
        }

    }
}
