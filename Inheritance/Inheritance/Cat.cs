using System;

namespace Inheritance
{
    public class Cat : Animal
    {
        public int runSpeed;
        public string sound;

        public string GetProperties()
        {
            string animalProperties = base.GetProperties();
            string catProperties= String.Format(" Run Speed:{0} Sound:{1}",runSpeed,sound);
            return animalProperties+catProperties;
        }
    }
}