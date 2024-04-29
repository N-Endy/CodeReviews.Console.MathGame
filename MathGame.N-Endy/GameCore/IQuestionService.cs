using MathGame.N_Endy.GameEntities;

namespace MathGame.N_Endy.GameCore
{
    public interface IQuestionService
    {
        Question GenerateQuestion(string operation);
        int CheckAnswer();
    }
}