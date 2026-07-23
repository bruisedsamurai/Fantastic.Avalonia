namespace Fantastic.Avalonia


open Fabulous
open Fantastic.Avalonia


[<AutoOpen>]
module MvuProgressBarBuilders =
    type Fantastic.Avalonia.View with

        /// <summary>Creates a ProgressBar widget.</summary>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <param name="value">Current value.</param>
        /// <param name="fn">Raised when the value changes.</param>
        static member ProgressBar(min: float, max: float, value: float, fn: float -> 'msg) =
            WidgetBuilder<'msg, IFabProgressBar>(
                ProgressBar.WidgetKey,
                RangeBase.MinimumMaximum.WithValue(struct (min, max)),
                MvuRangeBase.ValueChanged.WithValue(ValueEventData.create value fn)
            )
