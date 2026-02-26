using System;

namespace RPGDiceProgram.Models {
    [Serializable]
    public class RPGDiceRollParams {
        public int DiceCount { get; set; }
        public RPGDiceType DiceType { get; set; }
        public int AbilityModifier { get; set; }

        /// <summary>
        /// A visual representation of the dice roll formula, such as <c>"3d12 + 2"</c> or <c>"d6 - 1"</c>.
        /// </summary>
        public string DisplayFormulaText {
            get {
                string info = "";
                if (DiceCount > 1)
                    info += DiceCount;
                info += DiceType.ToString().ToLower();
                if (AbilityModifier > 0)
                    info += " + " + AbilityModifier;
                else if (AbilityModifier < 0)
                    info += " - " + Math.Abs(AbilityModifier);
                return info;
            }
        }

        /// <summary>
        /// A visual representation of the min and max possible rolls, expressed as a range such as <c>"5 - 38"</c>.
        /// </summary>
        public string DisplayRangeText => GetMin() + " - " + GetMax();

        public int GetMin() => DiceCount + AbilityModifier;
        public int GetMax() {
            int max = AbilityModifier;
            for (int i = 0; i < DiceCount; i++)
                max += (int) DiceType;
            return max;
        }

        public RPGDiceRollResults Roll() {
            RPGDiceRollResults results = new();
            results.individualRolls = new int[Math.Max(0, DiceCount)];
            results.abilityModifier = AbilityModifier;

            Random r = new();
            for (int i = 0; i < results.individualRolls.Length; i++) {
                int roll = r.Next(1, (int) DiceType + 1);
                results.individualRolls[i] = roll;
                results.total += roll;
            }
            results.total += results.abilityModifier;
            return results;
        }
    }
}
