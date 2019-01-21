using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLib.Library;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VideoLib.models;
using Rg.Plugins.Popup.Services;

namespace VideoLib
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProjectStartPage : ContentPage
	{
        ObservableCollection<VideoEntity> ListofVideos = new ObservableCollection<VideoEntity>();
        int counter = 0;
        public ProjectStartPage ()
		{
			InitializeComponent ();
            lstVideos.ItemsSource = ListofVideos;
		}
        async void BtnAddVideo_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            //string filename = await DependencyService.Get<IVideoPicker>().GetVideoFileAsync();
            string filename = await DependencyService.Get<IVideoPicker>().GetVideoFileAsync();

            if (!String.IsNullOrWhiteSpace(filename))
            {
                await PopupNavigation.Instance.PushAsync(new VideoNamePopup());
                MessagingCenter.Subscribe<MyMessage>(this, "PopUpData", (value) =>
                {
                    string receivedData = value.MyValue;
                    VideoEntity v = new VideoEntity
                    {
                        ID = counter,
                        Filename = filename,
                        Name = receivedData
                    };
                    ListofVideos.Add(v);
                    counter++;
                });
            }

            btn.IsEnabled = true;

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var video = (sender as MenuItem).CommandParameter as VideoEntity;
            ListofVideos.Remove(ListofVideos.Where(i => i.ID == video.ID).Single());
        }
    }
}