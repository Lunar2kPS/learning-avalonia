using System;
using System.Collections.Generic;
using System.Linq;
using RPGDiceProgram.Models;

namespace RPGDiceProgram.ViewModels {
    public class RPGDiceTypesVM : ViewModelBase {
        public IReadOnlyList<RPGDiceType> AllValues { get; set; } = Enum.GetValues<RPGDiceType>();
    }
}
