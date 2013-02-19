using System;

namespace Algorithm
{
    public class PairAgeDifference
    {
        public PairAgeDifference()
        {

        }
        public PairAgeDifference(Person youngerPerson, Person olderPerson)
        {
            YoungerPerson = youngerPerson;
            OlderPerson = olderPerson;
            AgeDifference = OlderPerson.BirthDate - YoungerPerson.BirthDate;
        }

        public Person YoungerPerson { get; private set; }
        public Person OlderPerson { get; private set; }
        public TimeSpan AgeDifference { get; set; }
    }
}