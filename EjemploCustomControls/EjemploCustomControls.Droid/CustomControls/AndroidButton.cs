using System;
using System.ComponentModel;
using Android.Graphics.Drawables;
using Android.Util;
using EjemploCustomControls.CustomControls;
using EjemploCustomControls.Droid.CustomControls;
using Java.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(AndroidButton))]
namespace EjemploCustomControls.Droid.CustomControls
{
    public class AndroidButton : ButtonRenderer
    {
        private GradientDrawable _normal, _pressed;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var button = (CustomButton)e.NewElement;

                button.SizeChanged += (s, args) =>
                {
                    // Estado normal
                    _normal = new GradientDrawable();
                    _normal.SetColor(Android.Graphics.Color.DarkBlue);
                    _normal.SetCornerRadius(100);

                    // Estado pulsado
                    _pressed = new GradientDrawable();
                    _pressed.SetColor(Android.Graphics.Color.DarkCyan);
                    _pressed.SetCornerRadius(100);

                    var sld = new StateListDrawable();
                    sld.AddState(new int[] { Android.Resource.Attribute.StatePressed }, _pressed);
                    sld.AddState(new int[] { }, _normal);
                    Control.SetBackgroundDrawable(sld);
                    Control.SetTextSize(ComplexUnitType.Px, 60);
                    Control.SetTextColor(Android.Graphics.Color.Silver);
                };
            }
        }
    }
}