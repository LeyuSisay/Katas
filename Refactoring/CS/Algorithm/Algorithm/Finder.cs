using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Finder
    {
        private readonly List<Person> _persons;

        public Finder(List<Person> persons)
        {
            _persons = persons;
        }

        public PairAgeDifference Find(AgeDifferenceType ageDifferenceType)
        {
            var pairAgeDifferences = ComputePairAgeDifferences();

            if (!pairAgeDifferences.Any())
            {
                return new PairAgeDifference();
            }

            return pairAgeDifferences.Aggregate(ageDifferenceType.Strategy);
        }

        private List<PairAgeDifference> ComputePairAgeDifferences()
        {
            var pairAgeDifferences = new List<PairAgeDifference>();

            for (var first = 0; first < _persons.Count - 1; first++)
            {
                for (var second = first + 1; second < _persons.Count; second++)
                {
                    var pairAgeDifference = new PairAgeDifference();

                    var firstPersonYoungerThanSecond = _persons[first].BirthDate < _persons[second].BirthDate;

                    if (firstPersonYoungerThanSecond)
                    {
                        pairAgeDifference.YongerPerson = _persons[first];
                        pairAgeDifference.OlderPerson = _persons[second];
                    }
                    else
                    {
                        pairAgeDifference.YongerPerson = _persons[second];
                        pairAgeDifference.OlderPerson = _persons[first];
                    }

                    pairAgeDifference.AgeDifference = pairAgeDifference.OlderPerson.BirthDate -
                                                      pairAgeDifference.YongerPerson.BirthDate;

                    pairAgeDifferences.Add(pairAgeDifference);
                }
            }
            return pairAgeDifferences;
        }
    }
}