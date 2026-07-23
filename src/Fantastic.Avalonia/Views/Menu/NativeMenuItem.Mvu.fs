namespace Fantastic.Avalonia

open Avalonia.Controls
open Fabulous
open Fantastic.Avalonia

module MvuNativeMenuItem =

    let Click =
        Attributes.Mvu.defineEventNoArg "NativeMenuItem_Click" (fun target -> (target :?> NativeMenuItem).Click)

[<AutoOpen>]
module MvuNativeMenuItemBuilders =
    type Fantastic.Avalonia.View with
        /// <summary>Creates a NativeMenuItem widget.</summary>
        /// <param name="header">The header of the Flyout.</param>
        /// <param name="onClicked">Raised when the menu item is clicked.</param>
        static member NativeMenuItem(header: string, onClicked: 'msg) =
            WidgetBuilder<'msg, IFabNativeMenuItem>(
                NativeMenuItem.WidgetKey,
                NativeMenuItem.Header.WithValue(header),
                MvuNativeMenuItem.Click.WithValue(MsgValue onClicked)
            )
