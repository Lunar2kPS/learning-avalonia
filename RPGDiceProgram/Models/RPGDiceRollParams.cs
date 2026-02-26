using System;

namespace RPGDiceProgram.Models {
    [Serializable]
    public class RPGDiceRollParams {
        public int DiceCount { get; set; }
        public RPGDiceType DiceType { get; set; }
        public int AbilityModifier { get; set; }
        public string DisplayText {
            get {
                return (DiceCount > 1 ? DiceCount.ToString() : "")
                    + DiceType.ToString().ToLower() +
                    (AbilityModifier > 0 ? " + " + AbilityModifier : "") + "\n"
                    + GetMin() + " - " + GetMax();
            }
        }

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
