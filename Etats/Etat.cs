namespace Tour_Par_Tour.Etats
{
    public abstract class Etat
    {
        public TurnManager TurnManager { get; private set; }
        public string Nom { get; private set; }

        public void SetTurnManager(TurnManager turnManager)
        {
           TurnManager = turnManager;
        }

        public void SetNom(string nom)
        {
            Nom = nom;
        }

        public abstract void DebutTour();
        public abstract void FinDeTour();
        public abstract void PertePV();
        public abstract void Attaque();
    }
}
