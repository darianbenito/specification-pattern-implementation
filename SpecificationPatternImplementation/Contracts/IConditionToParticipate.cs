namespace SpecificationPatternImplementation.Contracts
{
    public interface IConditionToParticipate
    {
        public bool CanParticipate(IPlayer player);
    }
}