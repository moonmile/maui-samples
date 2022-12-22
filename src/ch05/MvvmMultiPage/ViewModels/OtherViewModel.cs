using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmMultiPage.ViewModels
{
    internal class OtherViewModel : Prism.Mvvm.BindableBase
    {
        public string Ttile { get; } = "Other Page";
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Content { get; set; } = "";
    }
}
