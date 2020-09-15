using SpecificationPatternImplementation.Contracts;

namespace SpecificationPatternImplementation.ConditionsToParticipate
{
    public class OrConditionToParticipate : IConditionToParticipate
    {
        private readonly IConditionToParticipate _conditionToParticipateLeft;

        private readonly IConditionToParticipate _conditionToParticipateRight;

        public OrConditionToParticipate(IConditionToParticipate conditionToParticipateLeft, IConditionToParticipate conditionToParticipateRight)
        {
            _conditionToParticipateLeft = conditionToParticipateLeft;
            _conditionToParticipateRight = conditionToParticipateRight;
        }


        public bool CanParticipate(IPlayer player)
        {
            return _conditionToParticipateLeft.CanParticipate(player) || _conditionToParticipateRight.CanParticipate(player);
        }
    }
}
