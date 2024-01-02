using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using ThreeLayerContract;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace client
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.ExtendsContentIntoTitleBar = true;
            this.SetTitleBar(AppTitleBar);
            this.InitializeComponent();
            Load_Plugin();
        }

        Dictionary<string, IDAO> daoFactory;
        Dictionary<string, IBus> busFactory;
        private void Load_Plugin()
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = System.IO.Path.GetDirectoryName(exePath);
            FileInfo[] fis = new DirectoryInfo(folder).GetFiles("*.dll");

            var guis = new ObservableCollection<IGUI>();
            var buses = new List<IBus>();
            var daos = new List<IDAO>();

            // the real version will get from the user
            var mockGuiVersion = AppVersion.Default;
            var mockBusVersion = AppVersion.Default;
            var mockDaoVersion = AppVersion.Default;

            // Load all assemblies from current working directory
            foreach (FileInfo fileInfo in fis)
            {
                var domain = AppDomain.CurrentDomain;
                Assembly assembly = domain.Load(AssemblyName.GetAssemblyName(fileInfo.FullName));

                // Get all of the types in the dll
                Type[] types = assembly.GetTypes();

                // Only create instance of concrete class that inherits from IGUI, IBus or IDao
                foreach (var type in types)
                {
                    if (type.IsClass && !type.IsAbstract)
                    {
                        if (typeof(IGUI).IsAssignableFrom(type))
                            guis.Add(Activator.CreateInstance(type) as IGUI);
                        else if (typeof(IBus).IsAssignableFrom(type))
                            buses.Add(Activator.CreateInstance(type) as IBus);
                        else if (typeof(IDAO).IsAssignableFrom(type))
                            daos.Add(Activator.CreateInstance(type) as IDAO);
                    }
                }
            }

            daoFactory = daos.Where(dao => dao.GetVersion() == mockDaoVersion)
                                 .ToDictionary(dao => dao.OnData(), dao => dao);

            busFactory = buses.Where(bus => bus.GetVersion() == mockBusVersion)
                                  .ToDictionary(bus => bus.OnData(), bus => bus.CreateNew(daoFactory[bus.OnData()]));

            


            cmbGUIList.ItemsSource = guis;
            cmbBusList.ItemsSource = buses;
            cmbDaoList.ItemsSource = daos;
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            //IGUI gui = cmbGUIList.SelectedItem as IGUI;

            //var guiFactory = gui.CreateNew(busFactory);

            //var screen = new MyShop(guiFactory);
            //this.Close();
            //screen.Activate();

            IGUI gui = cmbGUIList.SelectedItem as IGUI;
            var guiFactory = gui.CreateNew(busFactory);

            var myShopPageType = typeof(MyShopPage);

            myFrame.Navigate(myShopPageType, guiFactory);
            myControlsContainer.Visibility = Visibility.Collapsed;
        }
    }
}
