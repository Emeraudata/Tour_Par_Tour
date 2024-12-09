namespace Tour_Par_Tour
{
    public class GameManager
    {
        public GameManager Instance { get; private set; }
        public TurnManager TurnManager { get; private set; }

        public GameManager()
        {
            Instance = new GameManager();
        }

        public void StartANewGame()
        {
            Player playerOne = new();
            Player playerTwo = new();
            TurnManager = new();
            TurnManager.NewTurn();
        }
    }
}
