namespace Fantastic.Avalonia

open Avalonia.Controls.Primitives
open Avalonia.Media
open Fabulous
open Fantastic.Avalonia

module ComponentColorSlider =
    let ColorChanged =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "ColorSlider_ColorChanged" ColorSlider.ColorProperty

[<AutoOpen>]
module ComponentColorSliderBuilders =
    type Fantastic.Avalonia.View with
        /// <summary>Creates a ColorSlider widget.</summary>
        /// <param name="color">The Color value.</param>
        /// <param name="fn">Raised when the color changes.</param>
        static member ColorSlider(color: Color, fn: Color -> unit) =
            WidgetBuilder<'msg, IFabColorSlider>(ColorSlider.WidgetKey, ComponentColorSlider.ColorChanged.WithValue(ComponentValueEventData.create color fn))
