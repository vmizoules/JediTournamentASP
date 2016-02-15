using EntitiesLayer.Tools;
using System.ComponentModel;

namespace EntitiesLayer
{
    /// <summary>
    /// Énumération des différentes phases possible lors d'un tournoi.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EPhaseTournoi
    {
        [Description("Quart de Finale")]
        QuartFinale,
        [Description("Demi Finale")]
        DemiFinale,
        [Description("Finale")]
        Finale
    }
    
    /// <summary>
    /// Classe Match.
    /// </summary>
    public class Match : EntityObject
    {
        /// <summary>
        /// Id du Jedi vainqueur. Si égale à -1 alors le match n'a pas été joué.
        /// </summary>
        public int IdJediVainqueur { get; set; }
        /// <summary>
        /// Premier combattant Jedi.
        /// </summary>
        public Jedi Jedi1 { get; set; }
        /// <summary>
        /// Second combattant Jedi.
        /// </summary>
        public Jedi Jedi2 { get; set; }
        /// <summary>
        /// Phase du tournoi associé au match.
        /// </summary>
        public EPhaseTournoi PhaseTournoi { get; set; }
        /// <summary>
        /// Stade dans lequel à lieu le tournoi.
        /// </summary>
        public Stade Stade { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Match()
            : this(-1, null, null, EPhaseTournoi.QuartFinale, null)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id du match.</param>
        /// <param name="jedi1">Premier jedi concurrent.</param>
        /// <param name="jedi2">Second jedi concurrent.</param>
        /// <param name="phase">Phase lors de laquelle se déroule le match.</param>
        /// <param name="stade">Stade dans lequel se déroule le match.</param>
        public Match(int id, Jedi jedi1, Jedi jedi2, EPhaseTournoi phase, Stade stade) 
            : base(id)
        {
            Jedi1 = jedi1;
            Jedi2 = jedi2;
            PhaseTournoi = phase;
            Stade = stade;
            IdJediVainqueur = -1;   // Initialisation de l'ID à -1 => vainqueur non déterminé
        }
    }
}
