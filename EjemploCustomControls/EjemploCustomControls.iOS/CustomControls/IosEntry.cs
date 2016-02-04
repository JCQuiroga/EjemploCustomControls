using EjemploCustomControls.CustomControls;
using EjemploCustomControls.iOS.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(IosEntry))]
namespace EjemploCustomControls.iOS.CustomControls
{
    public class IosEntry:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.BorderStyle = UITextBorderStyle.Bezel;
            Control.TextColor = UIColor.Blue;
        }
    }
}