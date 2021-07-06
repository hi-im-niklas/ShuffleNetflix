using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShuffleWatchList
{
    class ShufflerViewModel
    {

        public ICommand CloseCommand { get; set; }

        public ShufflerViewModel()
        {
            this.CloseCommand = new CloseCommand();
        }


    }
}
