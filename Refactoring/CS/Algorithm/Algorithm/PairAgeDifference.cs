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
        }

        public Person YoungerPerson { get; private set; }
        public Person OlderPerson { get; private set; }

        public TimeSpan AgeDifference
        {
            get
            {
                return OlderPerson.BirthDate - YoungerPerson.BirthDate;
            }
        }
    }
}