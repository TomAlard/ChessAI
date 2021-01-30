namespace ChessAI.interfaces {
    public interface IMove {
        ISquare getOriginSquare();
        ISquare getDestinationSquare();
        IPiece getPiece();
        string toUCI();
    }
}