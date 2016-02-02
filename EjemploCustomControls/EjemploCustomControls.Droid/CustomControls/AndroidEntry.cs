using Android.Views;
using EjemploCustomControls.CustomControls;
using EjemploCustomControls.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(AndroidEntry))]
namespace EjemploCustomControls.Droid.CustomControls
{
    public class AndroidEntry : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetTextColor(global::Android.Graphics.Color.CornflowerBlue);
            Control.SetBackgroundColor(global::Android.Graphics.Color.Firebrick);
            Control.SetLines(7);
            //Control.SetHorizontallyScrolling(false);
        }
    }
}