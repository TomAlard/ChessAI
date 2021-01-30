namespace ChessAI.interfaces {
    public interface ILichessAPIHandler {
        bool hasPendingChallenges();
        State acceptRandomPendingChallenge();
        State getCurrentState();
        void executeMove(IMove playedMove);
    }
}