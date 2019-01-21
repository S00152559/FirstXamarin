using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VideoLib;
using Android.Media;
using VideoLib.Library;

namespace XamarinVideo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditingPage : ContentPage
	{
		public EditingPage ()
		{

            //listVideo.ItemsSource = new List<VideoImage>
            //{
            //   new VideoImage{Name = "Screen 1",ImageUrl = "https://www.hublot.com/images/News_2018/match_for_solidarity_gallery_13.jpg"},
            //   new VideoImage{Name = "Screen 2",ImageUrl="https://englandexplore.com/wp-content/uploads/tips-americans-know-before-football-4.jpg"},
            //   new VideoImage{Name = "Screen 3",ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKhit_qTO-Gl0EdpB8qewoEcHgcInnBev-amDwGJfHqL0O7VvA"}
            //};
		}
	}
}