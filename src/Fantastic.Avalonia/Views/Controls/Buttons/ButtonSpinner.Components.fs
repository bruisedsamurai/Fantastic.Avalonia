namespace Fantastic.Avalonia

open Avalonia.Controls
open Fabulous
open Fantastic.Avalonia

[<AutoOpen>]
module ComponentsButtonSpinnerBuilders =
    type Fantastic.Avalonia.View with

        /// <summary>Creates a ButtonSpinner widget.</summary>
        /// <param name="text">The text to display.</param>
        /// <param name="fn">Raised when the ButtonSpinner is clicked.</param>
        static member ButtonSpinner(text: string, fn: SpinEventArgs -> unit) =
            WidgetBuilder<'msg, IFabButtonSpinner>(ButtonSpinner.WidgetKey, ContentControl.ContentString.WithValue(text), ComponentSpinner.Spin.WithValue(fn))
