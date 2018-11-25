﻿using HttpServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YFrameworkBase.DataAccessor;

namespace AreaIconCore.Views.Pages {
    /// <summary>
    /// MainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Page {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            XmlDataProvider pro = new XmlDataProvider();
            var cont = pro.GetNode<WebInfoContainer>("IPGW");
            Console.WriteLine(cont.ToString());
        }
    }
}
