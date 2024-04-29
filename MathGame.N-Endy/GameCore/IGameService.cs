using MathGame.N_Endy.GameEntities;

namespace MathGame.N_Endy.GameCore
{
    public interface IGameService
    {
        void StartGame();
        Question GetQuestion(string userChoice);
        bool PlayAgain();
        void EndGame();
    }
}