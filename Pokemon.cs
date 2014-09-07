using System;
using System.Collections.Generic;

namespace TypeCalculator
{
    /// <summary>
    /// This class will determine a given type or type combination's resistance (or weakness) to a given move type. 
    /// Source: http://bulbapedia.bulbagarden.net/wiki/Type_chart#Generation_VI, and the individual type pages (too many to list here)
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
    public class Pokemon
    {
        /* Dictionary of defences. Each row starts with a type, then lists how effective different types are against it. For example, 
         * the Bug entry says that Fire-, Flying-, and Rock-type moves are super effective, while Fighting-, Grass-, and Ground-type moves 
         * are not very effective. A 0 means that type is immune to that move (eg Dark is immune to Psychic). */
        private static Dictionary<string, Dictionary<string, double>> defences = new Dictionary<string, Dictionary<string, double>> { 
            { "Bug", new Dictionary<string, double> { 
                { "Fire", 2 }, { "Flying", 2 }, { "Rock", 2 }, { "Fighting", 0.5 }, { "Grass", 0.5 }, { "Ground", 0.5 } } 
            },
            { "Dark", new Dictionary<string, double> { 
                { "Bug", 2 }, { "Fairy", 2 }, { "Fighting", 2 }, { "Dark", 0.5 }, { "Ghost", 0.5 }, { "Psychic", 0 } } 
            },
            { "Dragon", new Dictionary<string, double> { 
                { "Dragon", 2 }, { "Fairy", 2 }, { "Ice", 2 }, { "Electric", 0.5 }, { "Fire", 0.5 }, { "Grass", 0.5 }, { "Water", 0.5} } 
            },
            { "Electric", new Dictionary<string, double> { 
                { "Ground", 2 }, { "Electric", 0.5 }, { "Flying", 0.5 }, { "Steel", 0.5 } } 
            },
            { "Fairy", new Dictionary<string, double> { 
                { "Poison", 2 }, { "Steel", 2 }, { "Bug", 0.5 }, { "Dark", 0.5 }, { "Fighting", 0.5 }, { "Dragon", 0 } } 
            },
            { "Fighting", new Dictionary<string, double> { 
                { "Fairy", 2 }, { "Flying", 2 }, { "Psychic", 2 }, { "Bug", 0.5 }, { "Dark", 0.5 }, { "Rock", 0.5 } } 
            },
            { "Fire", new Dictionary<string, double> { 
                { "Ground", 2 }, { "Rock", 2 }, { "Water", 2 }, { "Bug", 0.5 }, { "Fairy", 0.5 }, { "Fire", 0.5 }, { "Grass", 0.5 }, { "Ice", 0.5 }, { "Steel", 0.5 } } 
            },
            { "Flying", new Dictionary<string, double> { 
                { "Electric", 2 }, { "Ice", 2 }, { "Rock", 2 }, { "Bug", 0.5 }, { "Fighting", 0.5 }, { "Grass", 0.5 }, { "Ground", 0 } } 
            },
            { "Ghost", new Dictionary<string, double> { 
                { "Dark", 2 }, { "Ghost", 2 }, { "Bug", 0.5 }, { "Poison", 0.5 }, { "Fighting", 0 }, { "Normal", 0 } } 
            },
            { "Grass", new Dictionary<string, double> { 
                { "Bug", 2 }, { "Fire", 2 }, { "Flying", 2 }, { "Ice", 2 }, { "Poison", 2 }, { "Electric", 0.5 }, { "Grass", 0.5 }, { "Ground", 0.5 }, { "Water", 0.5 } } 
            },
            { "Ground", new Dictionary<string, double> { 
                { "Grass", 2 }, { "Ice", 2 }, { "Water", 2 }, { "Poison", 0.5 }, { "Rock", 0.5 }, { "Electric", 0 } } 
            },
            { "Ice", new Dictionary<string, double> { 
                { "Fighting", 2 }, { "Fire", 2 }, { "Rock", 2 }, { "Steel", 2 }, { "Ice", 0.5 } } 
            },
            { "Normal", new Dictionary<string, double> { 
                { "Fighting", 2 }, { "Ghost", 0 } } 
            },
            { "Poison", new Dictionary<string, double> { 
                { "Ground", 2 }, { "Psychic", 2 }, { "Bug", 0.5 }, { "Fairy", 0.5 }, { "Fighting", 0.5 }, { "Grass", 0.5 }, { "Poison", 0.5 } } 
            },
            { "Psychic", new Dictionary<string, double> { 
                { "Bug", 2 }, { "Dark", 2 }, { "Ghost", 2 }, { "Fighting", 0.5 }, { "Psychic", 0.5 } } 
            },
            { "Rock", new Dictionary<string, double> { 
                { "Fighting", 2 }, { "Grass", 2 }, { "Ground", 2 }, { "Steel", 2 }, { "Water", 2 }, { "Fire", 0.5 }, { "Flying", 0.5 }, { "Normal", 0.5 }, { "Poison", 0.5 } } 
            },
            { "Steel", new Dictionary<string, double> { 
                { "Fighting", 2 }, { "Fire", 2 }, { "Ground", 2 }, { "Bug", 0.5 }, { "Dragon", 0.5 }, { "Fairy", 0.5 }, { "Flying", 0.5 }, { "Grass", 0.5 }, { "Ice", 0.5 }, { "Normal", 0.5 }, { "Psychic", 0.5 }, { "Rock", 0.5 }, { "Steel", 0.5 }, { "Poison", 0 } } 
            },
            { "Water", new Dictionary<string, double> { 
                { "Electric", 2 }, { "Grass", 2 }, { "Fire", 0.5 }, { "Ice", 0.5 }, { "Steel", 0.5 }, { "Water", 0.5 } } 
            } 
        };

        /// <summary>
        /// Determines whether a Pokémon of the given type (or types) is weak or resistant to a move of a given type, and
        /// calculates what the damage bonus would be.
        /// </summary>
        /// <param name="attack">The Attack instance containing the move's type, and the defender's type(s)</param>
        /// <returns>0 if the target is immune, 0.25 if the target doubly resists, 0.5 if the target resists, 1 if the attack does 
        /// normal damage, 2 if it's super effective, and 4 if it's doubly effective</returns>
        public static double CalculateBonus(Attack attack)
        {
            double returnValue = 1;
            var row = defences[attack.DefenderType1];
            if (row.ContainsKey(attack.AttackType))
            {
                returnValue = row[attack.AttackType];
                if (returnValue == 0)
                    return 0;
            }

            if (!String.IsNullOrEmpty(attack.DefenderType2))
            {
                row = defences[attack.DefenderType2];
                if (row.ContainsKey(attack.AttackType))
                {
                    var val = row[attack.AttackType];
                    if (val == 0)
                        return 0;
                    else
                    {
                        returnValue *= val;
                    }
                }
            }

            return returnValue;
        }
    }
}