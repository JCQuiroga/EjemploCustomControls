using EjemploCustomControls.CustomControls;
using EjemploCustomControls.iOS.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(IosLabel))]
namespace EjemploCustomControls.iOS.CustomControls
{
    public class IosLabel:LabelRenderer
    {
        protected override void OnElementChanged(
         ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.TextColor= UIColor.Blue;
        }
    }
}