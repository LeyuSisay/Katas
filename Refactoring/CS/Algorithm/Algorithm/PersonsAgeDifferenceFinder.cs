using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class PersonsAgeDifferenceFinder
    {
        private readonly IEnumerable<Person> _persons;

        public PersonsAgeDifferenceFinder(IEnumerable<Person> persons)
        {
            _persons = persons;
        }

        public PairAgeDifference Find(AgeDifferenceType ageDifferenceType)
        {
            var pairAgeDifferences = ComputePairAgeDifferences();

            return pairAgeDifferences.Any() ? pairAgeDifferences.Aggregate(ageDifferenceType.Strategy) : new PairAgeDifference();
        }

        private IEnumerable<PairAgeDifference> ComputePairAgeDifferences()
        {
            return _persons.SelectMany((p1, firstIndex) => _persons.Skip(firstIndex + 1), (p1, p2) => p1.BirthDate < p2.BirthDate ? new PairAgeDifference(p1, p2) : new PairAgeDifference(p2, p1));
        }
    }
}