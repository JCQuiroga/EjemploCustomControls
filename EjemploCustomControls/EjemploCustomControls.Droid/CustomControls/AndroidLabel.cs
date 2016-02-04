using EjemploCustomControls.CustomControls;
using EjemploCustomControls.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(AndroidLabel))]
namespace EjemploCustomControls.Droid.CustomControls
{
    public class AndroidLabel:LabelRenderer
    {
        protected override void OnElementChanged(
         ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.SetTextColor(global::Android.Graphics.Color.DarkBlue);
        }
    }
}