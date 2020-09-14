using SpecificationPatternImplementation.Contracts;

namespace SpecificationPatternImplementation.ConditionsToParticipate
{
    public class LevelConditionToParticipate : IConditionToParticipate
    {
        private readonly int _validLevelToParticipate;

        public LevelConditionToParticipate(int validLevelToParticipate)
        {
            _validLevelToParticipate = validLevelToParticipate;
        }

        public bool CanParticipate(IPlayer player)
        {
            return player.Level == _validLevelToParticipate;
        }
    }
}