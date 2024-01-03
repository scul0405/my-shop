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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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

       
        ObservableCollection<IGUI> guis = new();
        List<IBus> buses = new();
        List<IDAO> daos = new();
        
        private void Load_Plugin()
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = System.IO.Path.GetDirectoryName(exePath);
            FileInfo[] fis = new DirectoryInfo(folder).GetFiles("*.dll");


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

            var guiVersion = guis.Select(gui => gui.GetVersion()).ToList();
            var busVersion = buses.Select(bus => bus.GetVersion()).ToList().Distinct();
            var daoVersion = daos.Select(dao => dao.GetVersion()).ToList().Distinct();

            cmbGUIList.ItemsSource = guiVersion;
            cmbBusList.ItemsSource = busVersion;
            cmbDaoList.ItemsSource = daoVersion;
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            var daoSelectedVersion = cmbDaoList.SelectedItem as string;
            var busSelectedVersion = cmbBusList.SelectedItem as string;
            var guiSelectedVersion = cmbGUIList.SelectedItem as string;

            var DaoFactory = new Dictionary<string, IDAO>();
            var BusFactory = new Dictionary<string, IBus>();

            // Lấy đơn vị dữ liệu của DAO
            var daoDataUnit = daos.GroupBy(dao => dao.OnData()).ToList();
            foreach (var daos in daoDataUnit)
            {
                var versionQuery = daos.Count() > 1 ? daoSelectedVersion : "Default";
                var targetDAO = daos.Single(dao => dao.GetVersion() == versionQuery);
                DaoFactory.Add(daos.Key, targetDAO);
            }

            // Lấy đơn vị dữu liệu của BUS
            var busDataUnit = buses.GroupBy(bus => bus.OnData()).ToList();
            foreach (var _buses in busDataUnit)
            {
                // Nếu có nhiều hơn một version thì chọn theo version của người dùng
                // còn không thì là mặc định
                var versionQuery = _buses.Count() > 1 ? busSelectedVersion : "Default";
                var targetBus = _buses.Single(bus => bus.GetVersion() == versionQuery);

                BusFactory.Add(_buses.Key, targetBus.CreateNew(DaoFactory[_buses.Key]));
            }

            // Khởi tạo app instance
            var GuiFactory = guis.Single(gui => gui.GetVersion() == guiSelectedVersion).CreateNew(BusFactory);

            var myShopPageType = typeof(MyShopPage);

            myFrame.Navigate(myShopPageType, GuiFactory);
            myControlsContainer.Visibility = Visibility.Collapsed;
        }
    }
}
