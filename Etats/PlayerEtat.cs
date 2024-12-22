namespace Tour_Par_Tour.Etats
{
    public class PlayerEtat : Etat
    {
        public Player Player { get; private set; }
        public int PointsActions { get; private set; }

        public PlayerEtat()
        {
            PointsActions = 5;
            SetNom("Joueur");
        }

        public override void Attaque()
        {
            for (int i = 0; i < PointsActions; i++)
            {
                Console.WriteLine("Le joueur attaque");
            }
        }

        public override void DebutTour()
        {
            Console.WriteLine("Début du tour du joueur");
            Attaque();
            Console.WriteLine("Fin des attaques du joueur");
        }

        public override void FinDeTour()
        {
            Console.WriteLine("Fin du tour du joueur");
            this.TurnManager.Transition(new EnnemiEtat());

        }

        public override void PertePV()
        {
            throw new NotImplementedException();
        }
    }
}
