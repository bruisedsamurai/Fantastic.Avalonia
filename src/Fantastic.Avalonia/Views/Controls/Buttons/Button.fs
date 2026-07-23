namespace Fantastic.Avalonia

open System.Runtime.CompilerServices
open System.Windows.Input
open Avalonia.Controls
open Avalonia.Input
open Fabulous

type IFabButton =
    inherit IFabContentControl

module Button =
    let WidgetKey = Widgets.register<Button>()

    let ClickMode =
        Attributes.defineAvaloniaPropertyWithEquality Button.ClickModeProperty

    let Command = Attributes.defineAvaloniaPropertyWithEquality Button.CommandProperty

    let CommandParameter =
        Attributes.defineAvaloniaPropertyWithEquality Button.CommandParameterProperty

    let Flyout = Attributes.defineAvaloniaPropertyWidget Button.FlyoutProperty

    let HotKey = Attributes.defineAvaloniaPropertyWithEquality Button.HotKeyProperty

    let IsCancel = Attributes.defineAvaloniaPropertyWithEquality Button.IsCancelProperty

    let IsDefault =
        Attributes.defineAvaloniaPropertyWithEquality Button.IsDefaultProperty

    let IsPressed = Attributes.defineAvaloniaPropertyWithEquality Button.IsPressedProperty

type ButtonModifiers =
    /// <summary>Sets the ClickMode property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ClickMode value.</param>
    [<Extension>]
    static member inline clickMode(this: WidgetBuilder<'msg, #IFabButton>, value: ClickMode) =
        this.AddScalar(Button.ClickMode.WithValue(value))

    /// <summary>Sets the Command property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Command value.</param>
    [<Extension>]
    static member inline command(this: WidgetBuilder<'msg, #IFabButton>, value: ICommand) =
        this.AddScalar(Button.Command.WithValue(value))

    /// <summary>Sets the CommandParameter property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The CommandParameter value.</param>
    [<Extension>]
    static member inline commandParameter(this: WidgetBuilder<'msg, #IFabButton>, value: obj) =
        this.AddScalar(Button.CommandParameter.WithValue(value))

    /// <summary>Sets the Flyout property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Flyout value.</param>
    [<Extension>]
    static member inline flyout(this: WidgetBuilder<'msg, #IFabButton>, value: WidgetBuilder<'msg, #IFabFlyoutBase>) =
        this.AddWidget(Button.Flyout.WithValue(value.Compile()))

    /// <summary>Sets the HotKey property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The HotKey value.</param>
    [<Extension>]
    static member inline hotKey(this: WidgetBuilder<'msg, #IFabButton>, value: KeyGesture) =
        this.AddScalar(Button.HotKey.WithValue(value))

    /// <summary>Sets the IsCancel property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsCancel value.</param>
    [<Extension>]
    static member inline isCancel(this: WidgetBuilder<'msg, #IFabButton>, value: bool) =
        this.AddScalar(Button.IsCancel.WithValue(value))

    /// <summary>Sets the IsDefault property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsDefault value.</param>
    [<Extension>]
    static member inline isDefault(this: WidgetBuilder<'msg, #IFabButton>, value: bool) =
        this.AddScalar(Button.IsDefault.WithValue(value))

    /// <summary>Sets the IsPressed property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsPressed value.</param>
    [<Extension>]
    static member inline isPressed(this: WidgetBuilder<'msg, #IFabButton>, value: bool) =
        this.AddScalar(Button.IsPressed.WithValue(value))

    /// <summary>Link a ViewRef to access the direct Button control instance.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ViewRef instance that will receive access to the underlying control.</param>
    [<Extension>]
    static member inline reference(this: WidgetBuilder<'msg, IFabButton>, value: ViewRef<Button>) =
        this.AddScalar(ViewRefAttributes.ViewRef.WithValue(value.Unbox))
