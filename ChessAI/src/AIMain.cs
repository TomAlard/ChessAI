using System.Threading;
using ChessAI.interfaces;

namespace ChessAI {
    public static class AIMain {
        
        // ReSharper disable once InconsistentNaming
        private static void Main() {
            var handler = new LichessAPIHandler();
            sleepUntilChallenged(handler);
            playGame(handler);
        }

        private static void sleepUntilChallenged(ILichessAPIHandler handler) {
            while (!handler.hasPendingChallenges()) {
                Thread.Sleep(5000);
            }
        }

        private static void playGame(ILichessAPIHandler handler) {
            var state = handler.acceptRandomPendingChallenge();
            var movePicker = new MovePicker();
            while (!state.gameOver) {
                if (state.playerToMove()) {
                    var board = state.board;
                    var bestMove = movePicker.pickBestMove(board, state.playerColor);
                    board.updateBoard(bestMove);
                    handler.executeMove(bestMove);
                }
                Thread.Sleep(500);
                state = handler.getCurrentState();
            }
            Main();
        }
        
    }
}