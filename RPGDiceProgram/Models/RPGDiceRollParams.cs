using System;

namespace RPGDiceProgram.Models {
    [Serializable]
    public class RPGDiceRollParams {
        public int DiceCount { get; set; }
        public RPGDiceType DiceType { get; set; }
        public int AbilityModifier { get; set; }
    }
}
