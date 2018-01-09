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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
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
        private void MyCalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            //Checking selected date is null  
            if (args.NewDate != null)
            {
                /* Getting selected new date value*/
                DisplayDate(args.NewDate.Value.ToString());
            }
        }
        private async void DisplayDate(string SelectedDate)
        {
            ContentDialog noWifiDialog = new ContentDialog()
            {
                Title = "Windows 10 Calendar Control",
                Content = "Selected date is: " + SelectedDate,
                PrimaryButtonText = "Ok"
            };
            noWifiDialog.Margin = new Thickness(0, 100, 0, 0);
            await noWifiDialog.ShowAsync();
        }
    }
}
