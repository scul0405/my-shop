
using Entity;
using GUI;
using GUI.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using ThreeLayerContract;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace client
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }


        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = System.IO.Path.GetDirectoryName(exePath);
            FileInfo[] fis = new DirectoryInfo(folder).GetFiles("*.dll");

            var guis = new List<IGUI>();
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

            var daoFactory = daos.Where(dao => dao.GetVersion() == mockDaoVersion)
                                 .ToDictionary(dao => dao.OnData(), dao => dao);

            var busFactory = buses.Where(bus => bus.GetVersion() == mockBusVersion)
                                  .ToDictionary(bus => bus.OnData(), bus => bus.CreateNew(daoFactory[bus.OnData()]));

            var guiFactory = guis.Single(gui => gui.GetVersion() == mockGuiVersion).CreateNew(busFactory);

            // guiFactory.GetMainWindow();
            var jsonData = new
            {
                book_categories = new List<string> { "sach giao khoa", "sach giao khoa", "sachh dep trai", "sach the thao" },
                books = new List<Book>
                {
                    new() { author = "NXB Giáo dục", desc = "Sách cho trẻ tiểu học", name = "Tiếng Việt 1", price = 12000, quantity=1000, total_sold=12 },
                    new() { author = "NXB Giáo dục", desc = "Sách cho trẻ tiểu học", name = "Toán 1", price = 12000, quantity=1000, total_sold=12 },
                    new() { author = "Nguyễn Hưng", name = "Ếch ộp", price = 78000, quantity=100, total_sold=120},
                    new() { author = "SportBook2VN", desc = "Sách cho người già", name = "Real Madrid", price = 22000, quantity=100, total_sold=12}, 
                },
                categories = new List<string> {  "sach giao khoa", "sach the thao", "sach dep trai" }
            };

            var debug = new
            {
                thanhCong = busFactory["Migrate"].Post(jsonData, null)
            };
            

            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window m_window;
    }
}
