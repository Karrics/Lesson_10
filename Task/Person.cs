using System;


namespace Task
{
    internal class Person
    {
        private string name;
        private string hobby;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name, string hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }

        public bool CheckInterest(string events)
        {
            return events.ToLower().Contains(hobby.ToLower());
        }
    }
}
