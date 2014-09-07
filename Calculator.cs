using System;

namespace TypeCalculator
{
    /// <summary>
    /// This class will calculate how much damage a given attack might do. Sources: http://bulbapedia.bulbagarden.net/wiki/Damage
    /// and http://bulbapedia.bulbagarden.net/wiki/Critical_hit
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
    public class Calculator
    {
        private const double lowerBound = 0.85, upperBound = 1.0;
        private const double critChance = 0.0625, critMultiplier = 1.5, noCrit = 1;
        private const double yesSTAB = 1.5, noSTAB = 1.0;

        /// <summary>
        /// Determines if a critical hit has occurred (6.25% chance), calculates the damage range for an attack, then gets a possible damage value for the attack
        /// </summary>
        /// <param name="typeBonus">The type bonus granted by the move's type interacting with the defender's type(s); possible values are 0, 0.25, 0.5, 1, 2, or 4</param>
        /// <param name="attack">The Attack that contains the attacker's level, the attacker's Attack (or Sp. Attack), the defender's Defence (or Sp. Defence), the 
        /// move's base damage, the attacker's type(s), and whether the move has STAB (Same-Type Attack Bonus)</param>
        /// <returns>A four-element array, containing, in order, the crit occurrence (1 if a crit, 0 otherwise), the lower bound for damage, a random number 
        /// lying between the lower and upper bound, and the upper bound for damage</returns>
        public static int[] calculateDamageRange(double typeBonus, Attack attack)
        {
            int[] damageRange = new int[4];
            damageRange[0] = 0;
            double critDamage = noCrit;
            
            var isCrit = new Random().Next(100);
            if (isCrit <= critChance * 100)
            {
                critDamage = critMultiplier;
                damageRange[0] = 1;
            }

            /* The attack modifier calculation: STAB * Type * Critical * Other * x, where
             *      STAB: stands for Same-Type Attack Bonus - if the attack shares a type with the attacker, this is 1.5; otherwise, this is 1, 
             *      Type: the bonus based on the interation between the attack and the defender's type(s) - could be 0, 0.25, 0.5, 1, 2, or 4, 
             *      Critical: if the attack was a crit, this is the crit bonus; otherwise, this is 1, 
             *      Other: miscellaneous modifiers, such as ability, weather, etc - not used, so this is always 1,
             *      x: a random number in the array [0.85, 1] */
            var modifier = 0.0;
            if (attack.STAB)
                modifier = yesSTAB;
            else
                modifier = noSTAB;

            modifier *= typeBonus * critDamage * 1; // apparently, this is how this is calculated

            var lower = lowerBound * modifier;
            var upper = upperBound * modifier;

            /* The damage calculation: ((2 * Level + 10) / 250 * (Attack / Defence) * Base + 2) * Modifier, where
             *      Level: the attacker's level,
             *      Attack: the attacker's attack value,
             *      Defence: the attacker's defence value,
             *      Base: the attack's base damage, 
             *      Modifier: the attack modifier, which is explained above. */
            double damage = ((2.0 * Convert.ToDouble(attack.AttackerLevel) + 10.0) / 250.0) 
                * (Convert.ToDouble(attack.AttackValue) / Convert.ToDouble(attack.DefenceValue)) 
                * Convert.ToDouble(attack.BaseDamage) 
                + 2;

            damageRange[1] = (int)(lower * damage);
            damageRange[3] = (int)(upper * damage);

            damageRange[2] = new Random().Next(damageRange[1], damageRange[3]);

            return damageRange;
        }
    }
}