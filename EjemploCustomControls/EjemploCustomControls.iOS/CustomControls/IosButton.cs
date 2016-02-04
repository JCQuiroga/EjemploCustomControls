using EjemploCustomControls.CustomControls;
using EjemploCustomControls.iOS.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButton), typeof(IosButton))]
namespace EjemploCustomControls.iOS.CustomControls
{
    public class IosButton:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.BackgroundColor= UIColor.Blue;
            Control.Layer.BorderColor = Color.Blue.ToCGColor();
            Control.Layer.BorderWidth = 2;
        }
    }
}