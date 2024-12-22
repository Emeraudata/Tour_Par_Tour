namespace Tour_Par_Tour
{
    public class Player
    {
        public bool IsTurn { get; private set; }
        public int ActionPoints { get; private set; }
        public int PV { get; private set; }

        private int m_baseNumberOfactionPoints;

        public Player()
        {
            m_baseNumberOfactionPoints = 5;
            ActionPoints = 5;
            PV = 100;
        }

        public void SetIsTurn(bool isPlayerTurn)
        {
            IsTurn = isPlayerTurn;
        }

        public void RestartPointActions()
        {
            ActionPoints = m_baseNumberOfactionPoints;
        }

        public void MinusActionPoints()
        {
            if(ActionPoints > 0)
                ActionPoints -= 1;
        }


        public void MakeAction(string numeroJoueur)
        {
            Console.WriteLine($"Je réalise une action en tant que {numeroJoueur}");
        }

        public void PertePV(int pvPerdus)
        {
            if(PV >= 0)
                PV -= pvPerdus;
        }
    }
}
