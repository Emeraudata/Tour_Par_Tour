using Tour_Par_Tour.Etats;

namespace Tour_Par_Tour
{
    public class TurnManager
    {

        public Etat Etat { get; private set; }
        public bool JoueurAJoue { get; private set; }
        public bool EnnemiAJoue { get; private set; }

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

        public void SetJoueurAJoue()
        {
            JoueurAJoue = !JoueurAJoue;
        }

        public void SetAnnemiAJoue()
        {
            EnnemiAJoue = !EnnemiAJoue;
        }

        public void Transition(Etat etat)
        {
            Console.WriteLine("On change de camp !!");
            Etat = etat;
            Etat.SetTurnManager(this);
            if (!JoueurAJoue && !EnnemiAJoue)
            {
                NewTurn(Etat);
            } else
            {
                FinDeTour();
            }
        }

        public void FinDeTour()
        {
            if (GameManager.Instance.Ennemi.NombrePV > 0)
            {
                NewTurn(Etat);
            } else
            {
                Console.WriteLine("Fin de la partie");
            }
        }

    }
}
