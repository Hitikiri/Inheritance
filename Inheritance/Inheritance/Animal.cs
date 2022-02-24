using System;

namespace Inheritance
{
    public abstract class Animal
    {
        public int weight;
        public int length;
        public string name;
        public int energy;

        public string GetProperties()
        {
            return String.Format("Name:{0} Length:{1} Weight:{2} ",name,length,weight);
        }

        public abstract void Move();

        public virtual void Sleep()
        {
            energy += 5;
        }
    }
}