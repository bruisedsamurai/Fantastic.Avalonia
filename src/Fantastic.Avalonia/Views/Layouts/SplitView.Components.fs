namespace Fantastic.Avalonia

open Avalonia.Controls
open Avalonia.Interactivity
open Fabulous
open Fantastic.Avalonia
open System.Runtime.CompilerServices

module ComponentSplitView =
    let PaneClosed =
        Attributes.Component.defineEvent "SplitView_PaneClosed" (fun target -> (target :?> SplitView).PaneClosed)

    let PaneClosing =
        Attributes.Component.defineEvent "SplitView_PaneClosing" (fun target -> (target :?> SplitView).PaneClosing)

    let PaneOpened =
        Attributes.Component.defineEvent "SplitView_PaneOpened" (fun target -> (target :?> SplitView).PaneOpened)

    let PaneOpening =
        Attributes.Component.defineEvent "SplitView_PaneOpening" (fun target -> (target :?> SplitView).PaneOpening)

    let IsPaneOpenChanged =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "SplitView_IsPaneOpenChanged" SplitView.IsPaneOpenProperty

    let PanClosed = PaneClosed

    let PanClosing = PaneClosing

    let PanOpened = PaneOpened

    let PanOpening = PaneOpening

    let IsPresented = IsPaneOpenChanged

type ComponentSplitViewModifiers =
    /// <summary>Listens to the SplitView PaneClosed event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneClosed event fires.</param>
    [<Extension>]
    static member inline onPaneClosed(this: WidgetBuilder<'msg, #IFabSplitView>, fn: RoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PaneClosed.WithValue(fn))

    /// <summary>Listens to the SplitView PaneClosing event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneClosing event fires.</param>
    [<Extension>]
    static member inline onPaneClosing(this: WidgetBuilder<'msg, #IFabSplitView>, fn: CancelRoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PaneClosing.WithValue(fn))

    /// <summary>Listens to the SplitView PaneOpened event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneOpened event fires.</param>
    [<Extension>]
    static member inline onPaneOpened(this: WidgetBuilder<'msg, #IFabSplitView>, fn: RoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PaneOpened.WithValue(fn))

    /// <summary>Listens to the SplitView PaneOpening event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneOpening event fires.</param>
    [<Extension>]
    static member inline onPaneOpening(this: WidgetBuilder<'msg, #IFabSplitView>, fn: CancelRoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PaneOpening.WithValue(fn))

    /// <summary>Listens to the SplitView IsPaneOpen property changes.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="isPaneOpen">The IsPaneOpen value.</param>
    /// <param name="fn">Raised when the IsPaneOpen property changes.</param>
    [<Extension>]
    static member inline onIsPaneOpenChanged(this: WidgetBuilder<'msg, #IFabSplitView>, isPaneOpen: bool, fn: bool -> unit) =
        this.AddScalar(ComponentSplitView.IsPaneOpenChanged.WithValue(ComponentValueEventData.create isPaneOpen fn))

    /// <summary>Listens to the SplitView PaneClosed event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneClosed event fires.</param>
    [<Extension>]
    static member inline onPanClosed(this: WidgetBuilder<'msg, #IFabSplitView>, fn: RoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PanClosed.WithValue(fn))

    /// <summary>Listens to the SplitView PaneClosing event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneClosing event fires.</param>
    [<Extension>]
    static member inline onPanClosing(this: WidgetBuilder<'msg, #IFabSplitView>, fn: CancelRoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PanClosing.WithValue(fn))

    /// <summary>Listens to the SplitView PaneOpened event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneOpened event fires.</param>
    [<Extension>]
    static member inline onPanOpened(this: WidgetBuilder<'msg, #IFabSplitView>, fn: RoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PanOpened.WithValue(fn))

    /// <summary>Listens to the SplitView PaneOpening event.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="fn">Raised when the PaneOpening event fires.</param>
    [<Extension>]
    static member inline onPanOpening(this: WidgetBuilder<'msg, #IFabSplitView>, fn: CancelRoutedEventArgs -> unit) =
        this.AddScalar(ComponentSplitView.PanOpening.WithValue(fn))

    /// <summary>Listens to the SplitView IsPaneOpen property changes.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsPaneOpen value.</param>
    /// <param name="fn">Raised when the IsPaneOpen property changes.</param>
    [<Extension>]
    static member inline isPresented(this: WidgetBuilder<'msg, #IFabSplitView>, value: bool, fn: bool -> unit) =
        this.AddScalar(ComponentSplitView.IsPresented.WithValue(ComponentValueEventData.create value fn))
