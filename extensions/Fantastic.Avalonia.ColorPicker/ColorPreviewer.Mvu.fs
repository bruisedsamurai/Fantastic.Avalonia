namespace Fantastic.Avalonia

open Avalonia.Controls
open Avalonia.Controls.Primitives
open Fabulous
open Fantastic.Avalonia

module MvuColorPreviewer =
    let ColorChanged =
        Attributes.Mvu.defineEvent "ColorPreviewer_ColorChanged" (fun target -> (target :?> ColorPreviewer).ColorChanged)

[<AutoOpen>]
module MvuColorPreviewerBuilders =
    type Fantastic.Avalonia.View with
        /// <summary>Creates a ColorPreviewer widget.</summary>
        /// <param name="fn">Raised when the color changes.</param>
        static member ColorPreviewer(fn: ColorChangedEventArgs -> 'msg) =
            WidgetBuilder<'msg, IFabColorPreviewer>(ColorPreviewer.WidgetKey, MvuColorPreviewer.ColorChanged.WithValue(fn))
