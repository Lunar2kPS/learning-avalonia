using RPGDiceProgram.Models;

namespace RPGDiceProgram.ViewModels {
    public partial class MainWindowVM : ViewModelBase {
        public string Greeting { get; } = "Welcome to Carlos' RPG Dice Program!";
        public RPGDiceRollParamsVM DiceRoll { get; }
        public RPGDiceTypesVM DiceTypes { get; } = new();

        public MainWindowVM() {
            DiceRoll = new RPGDiceRollParamsVM(
                new RPGDiceRollParams() {
                    DiceCount = 3,
                    DiceType = RPGDiceType.D12,
                    AbilityModifier = 2
                }
            );
        }
    }
}
