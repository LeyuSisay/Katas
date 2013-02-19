using System;

namespace Algorithm
{
    public class AgeDifferenceType
    {
        private readonly Func<PairAgeDifference, PairAgeDifference, PairAgeDifference> _strategy;
        public static readonly AgeDifferenceType Closer = new AgeDifferenceType((p1, p2) => p1.AgeDifference < p2.AgeDifference ? p1 : p2);
        public static readonly AgeDifferenceType Further = new AgeDifferenceType((p1, p2) => p1.AgeDifference > p2.AgeDifference ? p1 : p2);

        public Func<PairAgeDifference, PairAgeDifference, PairAgeDifference> Strategy
        {
            get { return _strategy; }
        }

        private AgeDifferenceType(Func<PairAgeDifference, PairAgeDifference, PairAgeDifference> strategy)
        {
            _strategy = strategy;
        }
    }
}