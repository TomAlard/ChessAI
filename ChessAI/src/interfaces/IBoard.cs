using System.Collections.Generic;

namespace ChessAI.interfaces {
    public interface IBoard {
        IEnumerable<IMove> getAllLegalMoves();
        void updateBoard(IMove playedMove);
        void undoLastMove();
    }
}