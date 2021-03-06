﻿using Gopas.XamIntro.BaseMasterDetailPage.Pages;
using Gopas.XamIntro.Course._1GUIComponents;
using Gopas.XamIntro.Course._2Navigation;
using Gopas.XamIntro.Course._2Navigation.SimpleMasterDetailPageFolder;
using Gopas.XamIntro.Course._3Plugins;
using Gopas.XamIntro.Course._4REST;
using Gopas.XamIntro.Course._5DependencyService;
using Gopas.XamIntro.Course._6Push;
using Gopas.XamIntro.Course._7Database;
using Gopas.XamIntro.Course._7Database.SQLite;
using Gopas.XamIntro.Course._8MVVM.View;
using Gopas.XamIntro.Course._9Scanning;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Gopas.XamIntro.BaseMasterDetailPage.VM
{
    class MasterMasterVM : INotifyPropertyChanged
    {
        public ObservableCollection<GroupedVM> MenuItems { get; set; } = new ObservableCollection<GroupedVM>();
        public MasterMasterVM()
        {
            var section = new GroupedVM()
            {
                ShortName = "Basic GUI components",
                LongName = "Basic GUI components",
            };
            section.Add(new MasterMenuItemVM { Title = "Components", TargetType = typeof(FormsGUIComponentsPage) });
            section.Add(new MasterMenuItemVM { Title = "StackLayout and Grid", TargetType = typeof(StackAndGridPage) });
            section.Add(new MasterMenuItemVM { Title = "Absolute and Relative Layouts", TargetType = typeof(AbsoluteAndRelativeLayout) });
            section.Add(new MasterMenuItemVM { Title = "Flex Layout", TargetType = typeof(FlexLayoutPage) });

            MenuItems.Add(section);

            section = new GroupedVM()
            {
                ShortName = "Navigation",
                LongName = "Navigation"
            };
            section.Add(new MasterMenuItemVM { Title = "NavigationPage", TargetType = typeof(SimpleNavigationPage) });
            section.Add(new MasterMenuItemVM { Title = "TabbedPage", TargetType = typeof(SimpleTabbedPage) });
            section.Add(new MasterMenuItemVM { Title = "MasterDetailPage", TargetType = typeof(SimpleMasterDetailPage) });
            section.Add(new MasterMenuItemVM { Title = "CarouselPage", TargetType = typeof(SimpleCarouselPage) });
            section.Add(new MasterMenuItemVM { Title = "Alert", TargetType = typeof(SimpleAlertPage) });
            MenuItems.Add(section);

            section = new GroupedVM()
            {
                ShortName = "Plugins",
                LongName = "Plugins"
            };
            section.Add(new MasterMenuItemVM { Title = "Connectivity", TargetType = typeof(ConnectivityPage) });
            section.Add(new MasterMenuItemVM { Title = "Secure storage", TargetType = typeof(SecureStoragePage) });
            MenuItems.Add(section);

            section = new GroupedVM()
            {
                ShortName = "Web API",
                LongName = "Web API"
            };
            section.Add(new MasterMenuItemVM { Title = "REST", TargetType = typeof(RestPage) });
            section.Add(new MasterMenuItemVM { Title = "REST ASP.NET Core", TargetType = typeof(RestASP) });
            MenuItems.Add(section);


            if (Device.RuntimePlatform == Device.Android)
            {
                section = new GroupedVM()
                {
                    ShortName = "Dependency Service",
                    LongName = "Dependency Service"
                };
                section.Add(new MasterMenuItemVM { Title = "Toast", TargetType = typeof(ToastPage) });
                section.Add(new MasterMenuItemVM { Title = "Local notification", TargetType = typeof(LocalNotificationPage) });
                MenuItems.Add(section);
            }
            section = new GroupedVM()
            {
                ShortName = "Push notifications",
                LongName = "Push notifications"
            };
            section.Add(new MasterMenuItemVM { Title = "AppCenter", TargetType = typeof(AppCenterPage) });
            MenuItems.Add(section);

            section = new GroupedVM()
            {
                ShortName = "Database",
                LongName = "Database"
            };
            section.Add(new MasterMenuItemVM { Title = "JsonDatabase", TargetType = typeof(JsonDatabasePage) });
            section.Add(new MasterMenuItemVM { Title = "SQLiteDatabase", TargetType = typeof(SQLitePage) });
            MenuItems.Add(section);

            section = new GroupedVM()
            {
                ShortName = "MVVM",
                LongName = "MVVM"
            };
            section.Add(new MasterMenuItemVM { Title = "Binding", TargetType = typeof(PageView) });

            section = new GroupedVM()
            {
                ShortName = "Skenování",
                LongName = "Skenování"
            };
            section.Add(new MasterMenuItemVM { Title = "Scanning", TargetType = typeof(ScanningPage) });
            MenuItems.Add(section);
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
