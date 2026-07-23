namespace Fantastic.Avalonia

open Avalonia.Controls
open Avalonia.Media
open Fabulous
open Fantastic.Avalonia


module MvuColorView =
    let ColorChanged =
        Attributes.Mvu.defineAvaloniaPropertyWithChangedEvent' "ColorView_ColorChanged" ColorView.ColorProperty

[<AutoOpen>]
module MvuColorViewBuilders =
    type Fantastic.Avalonia.View with
        /// <summary>Creates a ColorView widget.</summary>
        /// <param name="color">The Color value.</param>
        /// <param name="fn">Raised when the color changes.</param>
        static member ColorView(color: Color, fn: Color -> 'msg) =
            WidgetBuilder<'msg, IFabColorView>(ColorView.WidgetKey, MvuColorView.ColorChanged.WithValue(ValueEventData.create color fn))
