using ChessAI.interfaces;

namespace ChessAI {
    public class State {

        private readonly Color colorToMove;
        
        public readonly IBoard board;

        public readonly Color playerColor;

        public readonly bool gameOver;

        public State(IBoard board, Color playerColor, bool gameOver, Color colorToMove) {
            this.board = board;
            this.playerColor = playerColor;
            this.gameOver = gameOver;
            this.colorToMove = colorToMove;
        }
        
        public bool playerToMove() {
            return colorToMove == playerColor;
        }
    }
}