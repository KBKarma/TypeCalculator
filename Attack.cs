namespace TypeCalculator
{
    /// <summary>
    /// A class representing one attack
    /// 
    /// The creator of this application is Alex Altman (github: KBKarma)
    /// 
    /// All information used in this application was obtained from Bulbapedia (http://bulbapedia.bulbagarden.net), with specific pages 
    /// referred to listed where they are referenced.
    /// 
    /// Bulbapedia, and this source code, comes under a CC BY-NC-SA 2.5 licence, defined at http://creativecommons.org/licenses/by-nc-sa/2.5/
    /// 
    /// Pokémon and all related properties are © 1995-2014 Nintendo.
    /// </summary>
    public class Attack
    {
        // Basic
        public string AttackType { get; set; }
        public string DefenderType1 { get; set; }
        public string DefenderType2 { get; set; }

        // Advanced
        public int? AttackValue { get; set; }
        public int? DefenceValue { get; set; }
        public int? AttackerLevel { get; set; }
        public int? BaseDamage { get; set; }
        public string AttackerType1 { get; set; }
        public string AttackerType2 { get; set; }
        public bool STAB { get; set; }

        /// <summary>
        /// Checks if the move has STAB (Same-Type Attack Bonus)
        /// </summary>
        public void GetSTAB()
        {
            if (AttackerType1 == AttackType || AttackerType2 == AttackType)
                STAB = true;
            else
                STAB = false;
        }
    }
}