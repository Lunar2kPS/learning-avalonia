using RPGDiceProgram.Models;

namespace RPGDiceProgram.ViewModels {
    public class RPGDiceRollParamsVM : ViewModelBase {
        private RPGDiceRollParams target;

        public int DiceCount {
            get { return target.DiceCount; }
            set {
                SetProperty(target.DiceCount, value, v => target.DiceCount = v, nameof(DiceCount));
                OnPropertyChanged(nameof(DisplayResult));
            }
        }

        public RPGDiceType DiceType {
            get { return target.DiceType; }
            set {
                SetProperty(target.DiceType, value, v => target.DiceType = v, nameof(DiceType));
                OnPropertyChanged(nameof(DisplayResult));
            }
        }

        public int AbilityModifier {
            get { return target.AbilityModifier; }
            set {
                SetProperty(target.AbilityModifier, value, v => target.AbilityModifier = v, nameof(AbilityModifier));
                OnPropertyChanged(nameof(DisplayResult));
            }
        }

        public string DisplayResult {
            get {
                return DiceCount + DiceType.ToString().ToLower() + " + " + AbilityModifier + "\n"
                    + GetMin() + " - " + GetMax();
            }
        }

        public RPGDiceRollParamsVM(RPGDiceRollParams target) {
            this.target = target;
        }

        public int GetMin() => target.GetMin();
        public int GetMax() => target.GetMax();
        public RPGDiceRollResults Roll() => target.Roll();
    }
}
