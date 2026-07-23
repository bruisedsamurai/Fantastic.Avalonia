namespace Fantastic.Avalonia

open Avalonia.Media
open Fabulous
open Fantastic.Avalonia

[<AutoOpen>]
module ComponentColorPickerBuilders =
    type Fantastic.Avalonia.View with
        /// <summary>Creates a ColorPicker widget.</summary>
        /// <param name="color">The Color value.</param>
        /// <param name="fn">Raised when the color changes.</param>
        static member ColorPicker(color: Color, fn: Color -> unit) =
            WidgetBuilder<'msg, IFabColorPicker>(ColorPicker.WidgetKey, ComponentColorView.ColorChanged.WithValue(ComponentValueEventData.create color fn))
