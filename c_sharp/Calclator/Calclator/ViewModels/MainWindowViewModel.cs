using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calclator.Model;
using Calclator.ViewModels;
using Prism.Mvvm;
using Prism.Commands;

namespace Calclator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Autofac Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private Models model;
        public MainWindowViewModel()
        {
            model = new Models();        
        }

        private double _x;
        public double X
        {
            get { return _x; }
            set { SetProperty(ref _x, value); }
        }

        private double _y;
        public double Y
        {
            get { return _y; }
            set { SetProperty(ref _y, value); }
        }

        private double _ans;
        public double Ans
        {
            get { return _ans; }
            set { SetProperty(ref _ans, value); }
        }

        private DelegateCommand calcComamnd;
        public DelegateCommand calcCommand
        {
            get { return calcComamnd = calcComamnd ?? new DelegateCommand(calc); }
        }

        private void calc()
        {
            Ans = model.calc(X, Y);
        }
    }
}
