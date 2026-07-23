namespace Fantastic.Avalonia

open Avalonia.Controls
open Avalonia.Media
open Fabulous
open Fantastic.Avalonia


module ComponentColorView =
    let ColorChanged =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "ColorView_ColorChanged" ColorView.ColorProperty

[<AutoOpen>]
module ComponentColorViewBuilders =
    type Fantastic.Avalonia.View with
        /// <summary>Creates a ColorView widget.</summary>
        /// <param name="color">The Color value.</param>
        /// <param name="fn">Raised when the color changes.</param>
        static member ColorView(color: Color, fn: Color -> unit) =
            WidgetBuilder<'msg, IFabColorView>(ColorView.WidgetKey, ComponentColorView.ColorChanged.WithValue(ComponentValueEventData.create color fn))
