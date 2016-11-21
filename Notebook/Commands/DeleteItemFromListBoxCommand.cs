using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Notebook
{
    public class DeleteItemFromListBoxCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            var item = parameter as ListBoxItem;
            if (item == null) return;
            var listBox = item.FindAncestor<ListBox>();
            if (listBox == null) return;
            var items = listBox.Items as IEditableCollectionView;
            if (items == null) return;
            items.Remove(item.DataContext);
        }
    }
}
