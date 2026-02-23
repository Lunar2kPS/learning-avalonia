using System.ComponentModel;
using RPGDiceProgram.Models;

namespace RPGDiceProgram.ViewModels {
    public class RPGDiceRollParamsVM : INotifyPropertyChanged {
        private RPGDiceRollParams target;

        public event PropertyChangedEventHandler PropertyChanged;

        public int DiceCount {
            get { return target.DiceCount; }
            set {
                target.DiceCount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DiceCount)));
            }
        }

        public RPGDiceType DiceType {
            get { return target.DiceType; }
            set {
                target.DiceType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DiceType)));
            }
        }

        public int AbilityModifier {
            get { return target.AbilityModifier; }
            set {
                target.AbilityModifier = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AbilityModifier)));
            }
        }

        public RPGDiceRollParamsVM(RPGDiceRollParams target) {
            this.target = target;
        }
    }
}
