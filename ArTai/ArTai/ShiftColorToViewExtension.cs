using System;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ArTai
{

    public static class ViewExtensions
    {
        public static void ShiftColorTo(this VisualElement view, Color sourceColor, Color targetColor, Action<Color> setter, uint length = 250, Easing easing = null)
        {
            view.Animate("ShiftColorTo",
                x =>
                {
                    var red     = sourceColor.R + (x * (targetColor.R - sourceColor.R));
                    var green   = sourceColor.G + (x * (targetColor.G - sourceColor.G));
                    var blue    = sourceColor.B + (x * (targetColor.B - sourceColor.B));
                    var alpha   = sourceColor.A + (x * (targetColor.A - sourceColor.A));

                    setter(Color.FromRgba(red, green, blue, alpha));
                },
                length: length,
                easing: easing);
        }
    }
}