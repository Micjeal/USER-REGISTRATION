using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace USER_REGISTRATION
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }



        private async void click_to_Register(object sender, RoutedEventArgs e)
        {
            // registration is when all fields are filled.
            string name = TxtBox.Text;
            string email = TxtEmail.Text;
            string password = Txtpass.Text;
            string confirm = TxtPassword.Text;

            if (TxtBox.Text == "" || TxtEmail.Text == "" || Txtpass.Text == "" )
            {
                var MessageDialog = new  MessageDialog("fill all areas");
                await MessageDialog.ShowAsync();
                return;
            }
            else if (password != confirm)
            {
                var MessageDialog = new MessageDialog("does not match");
                await MessageDialog.ShowAsync();
                return;
            }else
            {
                var MessageDialog = new MessageDialog($"{name} has been successfully registered");
                await MessageDialog.ShowAsync();
                
            }



        }

        private void click_to_clear(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        // method to clear all text fields
        private void ClearFields()
        {
            TxtBox.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            Txtpass.Text = string.Empty;

            // Reset button content
            RegisterBtn.Content = " Register ";
        }
    }
}
