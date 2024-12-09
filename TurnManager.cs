namespace Tour_Par_Tour
{
    public class TurnManager
    {
        public event Action OnNewTurn;
        public bool IsPlayerOneTurn { get; private set; }
        public bool IsPlayerTwoTurn { get; private set; }

        public TurnManager()
        {
            
        }

        public void NewTurn()
        {

        }

    }
}
