namespace ChessAI {
    public interface ILichessAPIHandler {
        IBoard getCurrentBoard();
        void executeMove(IMove playedMove);
    }
}