using SpecificationPatternImplementation.Contracts;

// ReSharper disable ArgumentsStyleNamedExpression

namespace SpecificationPatternImplementation.ConditionsToParticipate
{
    public class MaxParticipationsConditionToParticipate : IConditionToParticipate
    {
        private readonly int _maxParticipationsPermitted;

        public MaxParticipationsConditionToParticipate(int maxParticipationsPermitted)
        {
            _maxParticipationsPermitted = maxParticipationsPermitted;
        }

        public bool CanParticipate(IPlayer player)
        {
            return player.ParticipationQty < _maxParticipationsPermitted;
        }
    }
}