namespace Fabulous.Avalonia

open System.Runtime.CompilerServices
open Avalonia.Controls
open Fabulous
open Fabulous.Avalonia

module ComponentComboBox =
    let Text =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "ComboBox_TextChanged" ComboBox.TextProperty

    let IsDropDownOpenChanged =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "ComboBox_IsDropDownOpenChanged" ComboBox.IsDropDownOpenProperty

    let DropDownOpened =
        Attributes.Component.defineEventNoArg "ComboBox_DropDownOpened" (fun target -> (target :?> ComboBox).DropDownOpened)

    let DropDownClosed =
        Attributes.Component.defineEventNoArg "ComboBox_DropDownClosed" (fun target -> (target :?> ComboBox).DropDownClosed)

type ComponentComboBoxModifiers =
    /// <summary>Binds the ComboBox.Text property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Text value.</param>
    /// <param name="fn">Raised when the Text value changes.</param>
    [<Extension>]
    static member inline onTextChanged(this: WidgetBuilder<'msg, #IFabComboBox>, value: string, fn: string -> unit) =
        this.AddScalar(ComponentComboBox.Text.WithValue(ComponentValueEventData.create value fn))

    /// <summary>Binds the ComboBox.IsDropDownOpen property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="isOpen">Whether the drop down is open or not.</param>
    /// <param name="fn">Raised when the IsDropDownOpen value changes.</param>
    [<Extension>]
    static member inline onIsDropDownOpenChanged(this: WidgetBuilder<'msg, #IFabComboBox>, isOpen: bool, fn: bool -> unit) =
        this.AddScalar(ComponentComboBox.IsDropDownOpenChanged.WithValue(ComponentValueEventData.create isOpen fn))

    /// <summary>Binds the ComboBox.IsDropDownOpen property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="isOpen">Whether the drop down is open or not.</param>
    /// <param name="fn">Raised when the IsDropDownOpen value changes.</param>
    [<Extension>]
    static member inline onDropDownOpened(this: WidgetBuilder<'msg, #IFabComboBox>, isOpen: bool, fn: bool -> unit) =
        this.AddScalar(ComponentComboBox.IsDropDownOpenChanged.WithValue(ComponentValueEventData.create isOpen fn))

    /// <summary>Listens to the ComboBox DropDownOpened event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the DropDownOpened event fires.</param>
    [<Extension>]
    static member inline onDropDownOpened(this: WidgetBuilder<'msg, #IFabComboBox>, fn: unit -> unit) =
        this.AddScalar(ComponentComboBox.DropDownOpened.WithValue(fn))

    /// <summary>Listens to the ComboBox DropDownClosed event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the DropDownClosed event fires.</param>
    [<Extension>]
    static member inline onDropDownClosed(this: WidgetBuilder<'msg, #IFabComboBox>, fn: unit -> unit) =
        this.AddScalar(ComponentComboBox.DropDownClosed.WithValue(fn))
