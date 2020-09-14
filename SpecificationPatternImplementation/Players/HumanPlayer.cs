using SpecificationPatternImplementation.Contracts;

namespace SpecificationPatternImplementation.Players
{
    public class HumanPlayer : IPlayer
    {
        public HumanPlayer(int level, int participationQty)
        {
            Level = level;
            ParticipationQty = participationQty;
        }

        #region HumanPlayer extra props

        #endregion

        public int Level { get; }

        public int ParticipationQty { get; }
    }
}
