using System;

namespace Inheritance
{
    public class Animal
    {
        public int weight;
        public int length;
        public string name;

        public string GetProperties()
        {
            return String.Format("Name:{0} Length:{1} Weight:{2} ",name,length,weight);
        }
    }
}