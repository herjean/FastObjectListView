using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewProject
{
    class testClass
    {
        string name;

        public testClass(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        static internal List<testClass>GET()
        {
            List<testClass> IDs = new List<testClass>();
            for(int i=1; i<10001; i++) { 
            testClass item = new ListViewProject.testClass("Hello " + i);
            IDs.Add(item);
            }
            return IDs;
        }
    }
}
