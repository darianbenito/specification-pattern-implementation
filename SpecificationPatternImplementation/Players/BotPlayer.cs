using SpecificationPatternImplementation.Contracts;

namespace SpecificationPatternImplementation.Players
{
    public class BotPlayer : IPlayer
    {
        public BotPlayer(int level, int participationQty)
        {
            Level = level;
            ParticipationQty = participationQty;
        }

        #region BotPlayer extra props

        #endregion

        public int Level { get; }

        public int ParticipationQty { get; }
    }
}
