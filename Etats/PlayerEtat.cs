namespace Tour_Par_Tour.Etats
{
    public class PlayerEtat : Etat
    {
        public Player Player { get; private set; }
        public int PointsActions { get; private set; }
        public Player Joueur { get; private set; }

        public PlayerEtat()
        {
            PointsActions = 5;
            SetNom("Joueur");
            Joueur = GameManager.Instance.Joueur;
        }

        public override void Attaque()
        {
            for (int i = 0; i < PointsActions; i++)
            {
                Console.WriteLine("Le joueur attaque et inflige +1 dégât");
                GameManager.Instance.EnnemiEtat.PertePV();
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
            this.TurnManager.SetJoueurAJoue();
            this.TurnManager.Transition(GameManager.Instance.EnnemiEtat);

        }

        public override void PertePV()
        {
            Joueur.PertePV(1);
        }
    }
}
