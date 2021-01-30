namespace ChessAI.interfaces {
    public interface IMovePicker {
        IMove pickBestMove(IBoard board, Color color);
    }
}