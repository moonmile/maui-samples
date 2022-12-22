using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmMultiPage.ViewModels
{
    internal class SecondViewModel : Prism.Mvvm.BindableBase
    {
        public string Ttile { get; } = "Second Page";
        public int _count = 0;
        public string CountText { get => $"クリック回数は{_count}"; } 
        public ICommand OnButtonClicked { get; private set; }
        public SecondViewModel()
        {
            OnButtonClicked = new DelegateCommand(() => {
                // カウントアップ
                _count++;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CountText)));
            });
        }
    }
}
