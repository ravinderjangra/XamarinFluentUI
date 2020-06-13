using System.ComponentModel;
using FluentUISamples.ControlExamples;
using Xamarin.Forms;

namespace FluentUISamples
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ShowButtonExamples.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new ButtonExamples());
            };

            ShowLabelExamples.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new LabelExamples());
            };

            ShowActivityIndicatorExamples.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new ActivityIndicatorExamples());
            };

            ShowDatePickerExamples.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new DatePickerExamples());
            };
        }
    }
}
