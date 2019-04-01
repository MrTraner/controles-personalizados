﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms.Platform.Android; //Para usar la clase ViewRenderer
using com.refractored.monodroidtoolkit; //Para usar la clase HoloCircularProgressBar
using System.ComponentModel; //Para usar la clase PropertyChangedEventArgs del método OnElementPropertyChanged
using Xamarin.Forms; //Para usar la clase ExportRenderer
using ControlesPersonalizados; //Para usar la clase CircularProgress
using ControlesPersonalizados.Droid.Renderers; //Para usar la clase CircularProgressRenderer

[assembly: ExportRenderer(typeof(CircularProgress), typeof(CircularProgressRenderer))]
namespace ControlesPersonalizados.Droid.Renderers
{
    public class CircularProgressRenderer : ViewRenderer<CircularProgress, HoloCircularProgressBar>
    {
        public CircularProgressRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgress> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement != null || this.Element == null)
            {
                return;
            }

            var progress = new HoloCircularProgressBar(Context)
            {
                Max = Element.Max,
                Progress = Element.Progress,
                Indeterminate = Element.Indeterminate,
                ProgressColor = Element.ProgressColor.ToAndroid(),
                ProgressBackgroundColor = Element.ProgressBackground.ToAndroid(),
                IndeterminateInterval = Element.IndeterminateSpeed
            };

            SetNativeControl(progress);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(Control == null || Element == null)
            {
                return;
            }

            if(e.PropertyName == CircularProgress.MaxProperty.PropertyName)
            {
                Control.Max = Element.Max;
            }
            else if (e.PropertyName == CircularProgress.ProgressProperty.PropertyName)
            {
                Control.Progress = Element.Progress;
            }
            else if (e.PropertyName == CircularProgress.IndeterminateProperty.PropertyName)
            {
                Control.Indeterminate = Element.Indeterminate;
            }
            else if (e.PropertyName == CircularProgress.ProgressColorProperty.PropertyName)
            {
                Control.ProgressColor = Element.ProgressColor.ToAndroid();
            }
            else if (e.PropertyName == CircularProgress.ProgressBackgroundProperty.PropertyName)
            {
                Control.ProgressBackgroundColor = Element.ProgressBackground.ToAndroid();
            }
            else if (e.PropertyName == CircularProgress.IndeterminateSpeedProperty.PropertyName)
            {
                Control.IndeterminateInterval = Element.IndeterminateSpeed;
            }
        }
    }
}