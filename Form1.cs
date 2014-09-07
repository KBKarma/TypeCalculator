using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace TypeCalculator
{
    /// <summary>
    /// Performs Pokémon type and damage analysis. 
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
    public partial class Form1 : Form
    {
        /* Used to reset each secondary type box so they don't get smaller and smaller every time a type is selected from the primary one */
        private List<string> types = new List<string> { 
            "(none)", "Bug", "Dark", "Dragon", "Electric", "Fairy", "Fighting", "Fire", "Flying", 
            "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water" };

        public Form1()
        {
            InitializeComponent();

            /* Set indexes and prepare secondary type dropdowns */
            mvType.SelectedIndex = 0;
            defType1.SelectedIndex = 0;
            defType2.SelectedIndex = 0;
            defType2.Items.Remove("Bug");

            atkType1.SelectedIndex = 0;
            atkType2.SelectedIndex = 0;
            atkType2.Items.Remove("Bug");           
        }

        /// <summary>
        /// When a type is selected in the defender's primary type dropdown, this removes that type from the secondary (no Bug/Bug types!).
        /// </summary>
        private void defType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in types)
                if (!defType2.Items.Contains(item))
                    defType2.Items.Add(item);

            defType2.Items.Remove(defType1.SelectedItem);
        }

        /// <summary>
        /// When a type is selected in the attacker's primary type dropdown, this removes that type from the secondary (no Bug/Bug types!).
        /// </summary>
        private void atkType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in types)
                if (!atkType2.Items.Contains(item))
                    atkType2.Items.Add(item);

            atkType2.Items.Remove(defType1.SelectedItem);
        }

        /// <summary>
        /// Activates or deactivates the advanced options.
        /// </summary>
        private void advancedCheck_CheckedChanged(object sender, EventArgs e)
        {
            atkValBox.Enabled = !atkValBox.Enabled;
            atkValBox.ReadOnly = !atkValBox.ReadOnly;

            defValBox.Enabled = !defValBox.Enabled;
            defValBox.ReadOnly = !defValBox.ReadOnly;

            atkLvlBox.Enabled = !atkLvlBox.Enabled;
            atkLvlBox.ReadOnly = !atkLvlBox.ReadOnly;

            mvPowBox.Enabled = !mvPowBox.Enabled;
            mvPowBox.ReadOnly = !mvPowBox.ReadOnly;

            atkType1.Enabled = !atkType1.Enabled;
            atkType2.Enabled = !atkType2.Enabled;

            damageText.Enabled = !damageText.Enabled;
        }

        /// <summary>
        /// Calculates the resistance or weakness of a given type combination to a move of a given type. With the advanced options set, 
        /// this will calculate the minimum and maximum possible damage values, then get a possible damage value.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            var bonus = 1.0;

            var attack = new Attack() {
                AttackType = mvType.SelectedItem.ToString(),
                DefenderType1 = defType1.SelectedItem.ToString(),
                DefenderType2 = defType2.SelectedItem.ToString() == "(none)" ? null : defType2.SelectedItem.ToString()
            };

            if (advancedCheck.Checked)
            {
                attack.AttackValue = Convert.ToInt32(atkValBox.Value);
                attack.DefenceValue = Convert.ToInt32(defValBox.Value);
                attack.AttackerLevel = Convert.ToInt32(atkLvlBox.Value);
                attack.BaseDamage = Convert.ToInt32(mvPowBox.Value);        
                attack.AttackerType1 = atkType1.SelectedItem.ToString();
                attack.AttackerType2 = atkType2.SelectedItem.ToString() == "(none)" ? null : atkType2.SelectedItem.ToString();
                attack.GetSTAB();
            }

            // Basic mode
            bonus = Pokemon.CalculateBonus(attack);

            if (bonus == 0)
                resultText.Text = "It doesn't affect the enemy Pokémon.";
            else if (bonus == 0.5 || bonus == 0.25)
                resultText.Text = "It's not very effective (x" + bonus + ")...";
            else if (bonus == 2 || bonus == 4)
                resultText.Text = "It's super effective (x" + bonus + ")!";
            else
                resultText.Text = "It hit.";

            // Advanced mode
            var range = new int[4];
            if (advancedCheck.Checked)
            {
                if (bonus == 0)
                {
                    damageText.Text = "No damage dealt - immune.";
                }
                else
                {
                    range = Calculator.calculateDamageRange(bonus, attack);

                    string damage = String.Empty;
                    if (range[0] == 1)
                        damage = "A critical hit! ";

                    damage += "Damage done between " + range[1] + " and " + range[3] + " (dealt: " + range[2] + ")";
                    damageText.Text = damage;
                }
            }
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void resetMenuItem_Click(object sender, EventArgs e)
        {
            mvType.SelectedIndex = 0;
            defType1.SelectedIndex = 0;
            if (defType2.Items.Count == defType1.Items.Count)
            {
                foreach (var item in types)
                    if (!defType2.Items.Contains(item))
                        defType2.Items.Add(item);
            }
            defType2.SelectedIndex = 0;
            resultText.Text = String.Empty;

            atkValBox.Value = 5;
            defValBox.Value = 5;
            atkLvlBox.Value = 1;
            mvPowBox.Value = 10;
            atkType1.SelectedIndex = 0;
            if (atkType2.Items.Count == atkType1.Items.Count)
            {
                foreach (var item in types)
                    if (!atkType2.Items.Contains(item))
                        atkType2.Items.Add(item);
            }
            atkType2.SelectedIndex = 0;
            damageText.Text = String.Empty;

            advancedCheck.Checked = false;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Displays a message box detailing what the application does and what everthing means.
        /// </summary>
        private void explanationMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.Append("This program determines the efficacy of a move used on a Pokémon, and optionally calculates the damage done by the attacking Pokémon to the defending Pokémon.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("A move in Pokémon has an elemental type and a base damage. Each Pokémon may have one or two elemental types themselves. If a Pokémon shares a type with the move, then the move does bonus damage. This is called Same-Type Attack Bonus, or STAB.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("Each elemental type is weak to some types, resistant to other, possibly immune to one or two, and takes damage normally from the rest. For example, the Normal type is weak to (ie takes extra damage from) Fighting-type moves, but is immune to (ie takes no damage from) Ghost-type moves. For multiple-typed Pokémon, each elemental weakness is cumulative. Thus, a Water/Flying Pokémon is doubly weak to Electric attacks, while a Grass/Water type would take damage normally. If any of the defender's types are immune, the Pokémon is immune.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("Each Pokémon has a number of stats, including its Level. A move can be either a Physical or a Special move. If it is a Physical one, it uses the attacker's Attack stat, and hits the defender's Defence. If it's Special, it uses Special Attack and Special Defence in the same way.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("There is a small chance (6.25%) that a move will be a critical hit. If it is, it does extra damage. The probability of this is not modifiable.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("Each move does damage within a certain range. This range is modified by whether the move has STAB. The calculation for this range is long and complex. The end result of using the Advanced Mode of this application is to determine the range and get a possible damage.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("There are additional modifications to combat, such as Pokémon abilities, special conditions of the moves used, the weather, hazards laid down by other moves, and held items, but I am not simulating those.");
            MessageBox.Show(message.ToString(), "What This Application Does");
        }

        /// <summary>
        /// Displays a pop-up listing types and resistances and weaknesses
        /// </summary>
        private void matchupsMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.Append("If a type is weak to another, it takes double damage from attacks of that type. If it resists, it takes half. If it's immune, it takes no damage.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("If a Pokémon has two types, then the weaknesses and resistances are cumulative. If both types resist the move type, the Pokémon takes a quarter of the damage. If they're both weak, it takes quadruple. If one is weak and one reists, it takes normal damage. If one type is immune, however, it takes no damage.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("Bug: Bug types are weak to Fire, Flying, and Rock, and resist Fighting, Grass, and Ground.");
            message.Append(Environment.NewLine);
            message.Append("Dark: Dark types are weak to Bug, Fairy, and Fighting, resist Dark and Ghost, and are immune to Psychic.");
            message.Append(Environment.NewLine);
            message.Append("Dragon: Dragon types are weak to Dragon, Fairy, and Ice, and resist Electric, Fire, Grass, and Water.");
            message.Append(Environment.NewLine);
            message.Append("Electric: Electric types are weak to Ground, and resist Electric, Flying, and Steel.");
            message.Append(Environment.NewLine);
            message.Append("Fairy: Fairy types are weak to Poison and Steel, resist Bug, Dark, and Flying, and are immune to Dragon.");
            message.Append(Environment.NewLine);
            message.Append("Fighting: Fighting types are weak to Fairy, Flying, and Psychic, and resist Bug, Dark, and Rock.");
            message.Append(Environment.NewLine);
            message.Append("Fire: Fire types are weak to Ground, Rock, and Water, and resist Bug, Fairy, Fire, Grass, Ice, and Steel.");
            message.Append(Environment.NewLine);
            message.Append("Flying: Flying types are weak to Electric, Ice, and Rock, resist Bug, Fighting, and Grass, and are immune to Ground.");
            message.Append(Environment.NewLine);
            message.Append("Ghost: Ghost types are weak to Dark and Ghost, resist Bug and Poison, and are immune to Fighting and Normal.");
            message.Append(Environment.NewLine);
            message.Append("Grass: Grass types are weak to Bug, Fire, Flying, Ice, and Poison, and resist Electric, Grass, Ground, and Water.");
            message.Append(Environment.NewLine);
            message.Append("Ground: Ground types are weak to Grass, Ice, and Water, resist Poison and Rock, and are immune to Electric.");
            message.Append(Environment.NewLine);
            message.Append("Ice: Ice types are weak to Fighting, Fire, Rock, and Steel, and resist Ice.");
            message.Append(Environment.NewLine);
            message.Append("Normal: Normal types are weak to Fighting, and are immune to Ghost.");
            message.Append(Environment.NewLine);
            message.Append("Poison: Poison types are weak to Ground and Psychic, and resist Bug, Fairy, Fighting, Grass, and Poison.");
            message.Append(Environment.NewLine);
            message.Append("Psychic: Psychic types are weak to Bug, Dark, and Ghost, and resist Fighting and Psychic.");
            message.Append(Environment.NewLine);
            message.Append("Rock: Rock types are weak to Fighting, Grass, Ground, Steel, and Water, and resist Fire, Flying, Normal, and Poison.");
            message.Append(Environment.NewLine);
            message.Append("Steel: Steel types are weak to Fighting, Fire, and Ground, resist Bug, Dragon, Fairy, Flying, Grass, Ice, Normal, Psychic, Rock, Steel, and are immune to Poison.");
            message.Append(Environment.NewLine);
            message.Append("Water: Water types are weak to Electric and Grass, and resist Fire, Ice, Steel, and Water.");
            MessageBox.Show(message.ToString(), "Resistance and Weaknesses of Each Type");
        }

        /// <summary>
        /// Displays the copyright information.
        /// </summary>
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.Append("This program was created by Alex Altman on 6-7 June 2014, and is licenced under a CC BY-NC-SA 2.5 licence, defined at http://creativecommons.org/licenses/by-nc-sa/2.5/.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("All information used was retrieved from Bulbapedia, which is also licenced under a CC BY-NC-SA 2.5 licence.");
            message.Append(Environment.NewLine);
            message.Append(Environment.NewLine);
            message.Append("Pokémon and all related properties are © 1995-2014 Nintendo.");
            MessageBox.Show(message.ToString(), "About This Application");
        }
    }
}