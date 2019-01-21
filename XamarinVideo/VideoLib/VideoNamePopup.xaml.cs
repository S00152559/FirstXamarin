using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VideoLib.models;
using Rg.Plugins.Popup.Services;

namespace VideoLib
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoNamePopup
    {
        public VideoNamePopup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            MessagingCenter.Send(new MyMessage() { MyValue = textinput.Text.ToString() }, "PopUpData");
        }
    }
}