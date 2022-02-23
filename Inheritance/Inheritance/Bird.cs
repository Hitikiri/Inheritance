using System;

namespace Inheritance
{
    public class Bird: Animal
    {
        public int flySpeed;
        public int flyDistance;

        public string GetProperties()
        {
            string animalProperties = base.GetProperties();
            string birdProperties = String.Format(" Fly Speed:{0} Fly Distance:{1} ",flySpeed,flyDistance);
            return animalProperties + birdProperties;

        }
    }
}