using Tour_Par_Tour.Etats;

namespace Tour_Par_Tour
{
    public class TurnManager
    {
        public event Action OnNewTurn;
        public bool IsPlayerOneTurn { get; private set; }
        public bool IsPlayerTwoTurn { get; private set; }

        public Etat Etat { get; private set; }

        public TurnManager(Etat etat)
        {
            Transition(etat);
        }

        public void NewTurn(Etat etat)
        {
            Console.WriteLine($"Début du tour pour {etat.Nom}");
            etat.DebutTour();
            etat.FinDeTour();
        }

        public void Transition(Etat etat)
        {
            Console.WriteLine("On change de camp !!");
            Etat = etat;
            Etat.SetTurnManager(this);
            NewTurn(Etat);
        }
        

    }
}
