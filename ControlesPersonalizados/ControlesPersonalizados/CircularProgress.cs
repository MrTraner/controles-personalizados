using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms; //Para usar la clase View

namespace ControlesPersonalizados
{
    public class CircularProgress : View
    {
        public static readonly BindableProperty ProgressProperty = BindableProperty.Create("Progress", typeof(float), typeof(CircularProgress), (float)0);

        public float Progress
        {
            set
            {
                SetValue(ProgressProperty, value);
            }
            get
            {
                return (float)GetValue(ProgressProperty);
            }
        }

        public static readonly BindableProperty MaxProperty = BindableProperty.Create("Max", typeof(float), typeof(CircularProgress), (float)0);

        public float Max
        {
            set
            {
                SetValue(MaxProperty, value);
            }
            get
            {
                return (float)GetValue(MaxProperty);
            }
        }

        public static readonly BindableProperty IndeterminateProperty = BindableProperty.Create("Indeterminate", typeof(bool), typeof(CircularProgress), false);

        public bool Indeterminate
        {
            set
            {
                SetValue(IndeterminateProperty, value);
            }
            get
            {
                return (bool)GetValue(IndeterminateProperty);
            }
        }

        public static readonly BindableProperty IndeterminateSpeedProperty = BindableProperty.Create("IndeterminateSpeed", typeof(int), typeof(CircularProgress), 0);

        public int IndeterminateSpeed
        {
            set
            {
                SetValue(IndeterminateSpeedProperty, value);
            }
            get
            {
                return (int)GetValue(IndeterminateSpeedProperty);
            }
        }

        public static readonly BindableProperty ProgressBackgroundProperty = BindableProperty.Create("ProgressBackground", typeof(Color), typeof(CircularProgress), Color.White);

        public Color ProgressBackground
        {
            set
            {
                SetValue(ProgressBackgroundProperty, value);
            }
            get
            {
                return (Color)GetValue(ProgressBackgroundProperty);
            }
        }

        public static readonly BindableProperty ProgressColorProperty = BindableProperty.Create("ProgressColor", typeof(Color), typeof(CircularProgress), Color.Red);

        public Color ProgressColor
        {
            set
            {
                SetValue(ProgressColorProperty, value);
            }
            get
            {
                return (Color)GetValue(ProgressColorProperty);
            }
        }
    }
}
