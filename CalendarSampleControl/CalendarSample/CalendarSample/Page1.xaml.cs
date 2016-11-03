using Syncfusion.SfCalendar.XForms;
using System;
using Xamarin.Forms;

namespace CalendarSample
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            SfCalendar sfcalendar = new SfCalendar();
            sfcalendar.ViewMode = ViewMode.MonthView;
            MonthViewSettings settings = new MonthViewSettings();
            settings.CurrentMonthTextColor = Color.Maroon;
            settings.DisabledTextColor = Color.Black;
            sfcalendar.MonthViewSettings = settings;
            //sfcalendar.OnDrawMonthCell += sfcalendar_OnDrawMonthCell;
            sfcalendar.OnMonthCellLoaded += sfcalendar_OnDrawMonthCell;
            this.Content = sfcalendar;
        }
        void sfcalendar_OnDrawMonthCell(object sender, MonthCell args)
        {
            //Change the specific date's background and text color
            args.TextColor = Color.FromRgb(210, 120, 170);
            args.BackgroundColor = Color.FromRgb(61, 61, 61);
            if (args.Date.Date.Equals(new DateTime(2016, 6, 3)))
            {
                args.BackgroundColor = Color.Aqua;
                args.TextColor = Color.Green;
            }
        }
    }
}
