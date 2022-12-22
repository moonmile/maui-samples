using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmMultiPage.ViewModels
{
    internal class FirstViewModel : Prism.Mvvm.BindableBase
    {
        public string Ttile { get; } = "First Page";
        public int _count = 0;
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value, nameof(Count));
        }
        public ICommand OnButtonClicked { get; private set; }
        public FirstViewModel ()
        {
            OnButtonClicked = new DelegateCommand(() => {
                // カウントアップ
                Count++;
            });
        }
    }
}
