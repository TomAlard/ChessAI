namespace ChessAI {
    public interface IMovePicker {
        IMove pickBestMove(IBoard board, bool color);
    }
}