using Tour_Par_Tour.Etats;

namespace Tour_Par_Tour
{
    public class GameManager
    {
        public static GameManager Instance { get; private set; }
        public static TurnManager TurnManager { get; private set; }
        public Player Joueur { get; private set; }
        public PlayerEtat JoueurEtat { get; private set; }
        public Ennemi Ennemi { get; private set; }
        public EnnemiEtat EnnemiEtat { get; private set; }

        private GameManager() { }

        public static GameManager GetInstance()
        {
            if(Instance == null)
            {
                Instance = new GameManager();
            }
            return Instance;
        }

        public void StartANewGame()
        {
            Joueur = new();
            JoueurEtat = new();
            Ennemi = new();
            EnnemiEtat = new();
            TurnManager = new TurnManager(JoueurEtat);
            TurnManager.NewTurn(JoueurEtat);
        }
    }
}
