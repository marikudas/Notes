using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Notebook
{
    public class AddNewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            (parameter as IEditableCollectionView)?.AddNew();
            (parameter as IEditableCollectionView)?.CommitNew();
        }
    }
}
