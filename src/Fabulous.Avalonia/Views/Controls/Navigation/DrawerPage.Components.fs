namespace Fabulous.Avalonia

open System.Runtime.CompilerServices
open Avalonia.Controls
open Avalonia.Interactivity
open Fabulous
open Fabulous.Avalonia

module ComponentDrawerPage =
    let Opened =
        Attributes.Component.defineRoutedEvent "DrawerPage_Opened" DrawerPage.OpenedEvent

    let Closing =
        Attributes.Component.defineRoutedEvent<DrawerClosingEventArgs> "DrawerPage_Closing" DrawerPage.ClosingEvent

    let Closed =
        Attributes.Component.defineRoutedEvent "DrawerPage_Closed" DrawerPage.ClosedEvent

    let IsOpen =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "DrawerPage_IsOpen" DrawerPage.IsOpenProperty

type ComponentDrawerPageModifiers =
    /// <summary>Listens to the DrawerPage Opened event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the drawer transitions to open.</param>
    [<Extension>]
    static member inline onOpened(this: WidgetBuilder<'msg, #IFabDrawerPage>, fn: RoutedEventArgs -> unit) =
        this.AddScalar(ComponentDrawerPage.Opened.WithValue(fn))

    /// <summary>Listens to the DrawerPage Closing event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised just before the drawer closes. Set <c>args.Cancel = true</c> to prevent closing.</param>
    [<Extension>]
    static member inline onClosing(this: WidgetBuilder<'msg, #IFabDrawerPage>, fn: DrawerClosingEventArgs -> unit) =
        this.AddScalar(ComponentDrawerPage.Closing.WithValue(fn))

    /// <summary>Listens to the DrawerPage Closed event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised after the drawer has closed.</param>
    [<Extension>]
    static member inline onClosed(this: WidgetBuilder<'msg, #IFabDrawerPage>, fn: RoutedEventArgs -> unit) =
        this.AddScalar(ComponentDrawerPage.Closed.WithValue(fn))

    /// <summary>Two-way binding for the IsOpen property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsOpen value.</param>
    /// <param name="fn">Raised when the IsOpen value changes.</param>
    [<Extension>]
    static member inline isOpen(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: bool, fn: bool -> unit) =
        this.AddScalar(ComponentDrawerPage.IsOpen.WithValue(ComponentValueEventData.create value fn))
