using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Entity
{
    public class BookCategory: INotifyPropertyChanged
    {
       public BookCategory() { }
       public int Id { get; set; }
       public string Name { get; set; }

       public event PropertyChangedEventHandler? PropertyChanged;
    }
}
