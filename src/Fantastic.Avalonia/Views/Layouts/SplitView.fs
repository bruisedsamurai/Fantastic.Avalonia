namespace Fantastic.Avalonia

open Avalonia.Controls
open Avalonia.Controls.Primitives
open Avalonia.Controls.Templates
open Avalonia.Media
open Fabulous
open System.Runtime.CompilerServices
open Fabulous.StackAllocatedCollections.StackList

type IFabSplitView =
    inherit IFabContentControl

module SplitView =
    let WidgetKey = Widgets.register<SplitView>()

    let CompactPaneLength =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.CompactPaneLengthProperty

    let DisplayMode =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.DisplayModeProperty

    let IsPaneOpen =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.IsPaneOpenProperty

    let OpenPaneLength =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.OpenPaneLengthProperty

    let PaneBackgroundWidget =
        Attributes.defineAvaloniaPropertyWidget SplitView.PaneBackgroundProperty

    let PaneBackground =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.PaneBackgroundProperty

    let PanePlacement =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.PanePlacementProperty

    let Pane = Attributes.defineAvaloniaPropertyWidget SplitView.PaneProperty

    let PaneString =
        Attributes.defineAvaloniaProperty<string, obj> SplitView.PaneProperty box ScalarAttributeComparers.equalityCompare

    let PaneObject =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.PaneProperty

    let PaneTemplate =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.PaneTemplateProperty

    let TemplateSettings =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.TemplateSettingsProperty

    let UseLightDismissOverlayMode =
        Attributes.defineAvaloniaPropertyWithEquality SplitView.UseLightDismissOverlayModeProperty

    let ClosedPaneWidth =
        Attributes.defineAvaloniaPropertyWithEquality SplitViewTemplateSettings.ClosedPaneWidthProperty

    let PaneColumnGridLength =
        Attributes.defineAvaloniaPropertyWithEquality SplitViewTemplateSettings.PaneColumnGridLengthProperty

[<AutoOpen>]
module SplitViewBuilders =
    type Fantastic.Avalonia.View with

        /// <summary>Creates a SplitView widget.</summary>
        /// <param name="pane">The content of the pane.</param>
        /// <param name="content">The content to display.</param>
        static member SplitView(pane: string, content: string) =
            WidgetBuilder<'msg, IFabSplitView>(
                SplitView.WidgetKey,
                SplitView.PaneString.WithValue(pane),
                ContentControl.ContentString.WithValue(content)
            )

        /// <summary>Creates a SplitView widget.</summary>
        /// <param name="pane">The content of the pane.</param>
        /// <param name="content">The content to display.</param>
        static member SplitView(pane: WidgetBuilder<'msg, #IFabControl>, content: string) =
            WidgetBuilder<'msg, IFabSplitView>(
                SplitView.WidgetKey,
                AttributesBundle(
                    StackList.one(ContentControl.ContentString.WithValue(content)),
                    [| SplitView.Pane.WithValue(pane.Compile()) |],
                    [||],
                    [||]
                )
            )

        /// <summary>Creates a SplitView widget.</summary>
        /// <param name="pane">The content of the pane.</param>
        /// <param name="content">The content to display.</param>
        static member SplitView(pane: string, content: WidgetBuilder<'msg, #IFabControl>) =
            WidgetBuilder<'msg, IFabSplitView>(
                SplitView.WidgetKey,
                AttributesBundle(
                    StackList.one(SplitView.PaneString.WithValue(pane)),
                    [| ContentControl.ContentWidget.WithValue(content.Compile()) |],
                    [||],
                    [||]
                )
            )

        /// <summary>Creates a SplitView widget.</summary>
        /// <param name="pane">The content of the pane.</param>
        /// <param name="content">The content to display.</param>
        static member SplitView(pane: WidgetBuilder<'msg, #IFabControl>, content: WidgetBuilder<'msg, #IFabControl>) =
            WidgetBuilder<'msg, IFabSplitView>(
                SplitView.WidgetKey,
                AttributesBundle(
                    StackList.empty(),
                    [| SplitView.Pane.WithValue(pane.Compile())
                       ContentControl.ContentWidget.WithValue(content.Compile()) |],
                    [||],
                    [||]
                )
            )

type SplitViewModifiers =
    /// <summary>Sets the CompactPaneLength property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The CompactPaneLength value.</param>
    [<Extension>]
    static member inline compactPaneLength(this: WidgetBuilder<'msg, #IFabSplitView>, value: float) =
        this.AddScalar(SplitView.CompactPaneLength.WithValue(value))

    /// <summary>Sets the DisplayMode property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DisplayMode value.</param>
    [<Extension>]
    static member inline displayMode(this: WidgetBuilder<'msg, #IFabSplitView>, value: SplitViewDisplayMode) =
        this.AddScalar(SplitView.DisplayMode.WithValue(value))

    /// <summary>Sets the IsPaneOpen property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsPaneOpen value.</param>
    [<Extension>]
    static member inline isPaneOpen(this: WidgetBuilder<'msg, #IFabSplitView>, value: bool) =
        this.AddScalar(SplitView.IsPaneOpen.WithValue(value))

    /// <summary>Sets the OpenPaneLength property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The OpenPaneLength value.</param>
    [<Extension>]
    static member inline openPaneLength(this: WidgetBuilder<'msg, #IFabSplitView>, value: float) =
        this.AddScalar(SplitView.OpenPaneLength.WithValue(value))

    /// <summary>Sets the PaneBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PaneBackground value.</param>
    [<Extension>]
    static member inline paneBackground(this: WidgetBuilder<'msg, #IFabSplitView>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(SplitView.PaneBackgroundWidget.WithValue(value.Compile()))

    /// <summary>Sets the PaneBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PaneBackground value.</param>
    [<Extension>]
    static member inline paneBackground(this: WidgetBuilder<'msg, #IFabSplitView>, value: IBrush) =
        this.AddScalar(SplitView.PaneBackground.WithValue(value))

    /// <summary>Sets the PaneBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PaneBackground value.</param>
    [<Extension>]
    static member inline paneBackground(this: WidgetBuilder<'msg, #IFabSplitView>, value: Color) =
        SplitViewModifiers.paneBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the PaneBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PaneBackground value.</param>
    [<Extension>]
    static member inline paneBackground(this: WidgetBuilder<'msg, #IFabSplitView>, value: string) =
        SplitViewModifiers.paneBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the Pane property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Pane value.</param>
    [<Extension>]
    static member inline pane(this: WidgetBuilder<'msg, #IFabSplitView>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(SplitView.Pane.WithValue(value.Compile()))

    /// <summary>Sets the Pane property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Pane value.</param>
    [<Extension>]
    static member inline pane(this: WidgetBuilder<'msg, #IFabSplitView>, value: string) =
        this.AddScalar(SplitView.PaneString.WithValue(value))

    /// <summary>Sets the Pane property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Pane value.</param>
    [<Extension>]
    static member inline pane(this: WidgetBuilder<'msg, #IFabSplitView>, value: obj) =
        this.AddScalar(SplitView.PaneObject.WithValue(value))

    /// <summary>Sets the PanePlacement property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PanePlacement value.</param>
    [<Extension>]
    static member inline panePlacement(this: WidgetBuilder<'msg, #IFabSplitView>, value: SplitViewPanePlacement) =
        this.AddScalar(SplitView.PanePlacement.WithValue(value))

    /// <summary>Sets the PaneTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PaneTemplate value.</param>
    [<Extension>]
    static member inline paneTemplate(this: WidgetBuilder<'msg, #IFabSplitView>, value: IDataTemplate) =
        this.AddScalar(SplitView.PaneTemplate.WithValue(value))

    /// <summary>Sets the TemplateSettings property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The TemplateSettings value.</param>
    [<Extension>]
    static member inline templateSettings(this: WidgetBuilder<'msg, #IFabSplitView>, value: SplitViewTemplateSettings) =
        this.AddScalar(SplitView.TemplateSettings.WithValue(value))

    /// <summary>Sets the UseLightDismissOverlayMode property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The UseLightDismissOverlayMode value.</param>
    [<Extension>]
    static member inline useLightDismissOverlayMode(this: WidgetBuilder<'msg, #IFabSplitView>, value: bool) =
        this.AddScalar(SplitView.UseLightDismissOverlayMode.WithValue(value))

    /// <summary>Sets the ClosedPaneWidth property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ClosedPaneWidth value.</param>
    [<Extension>]
    static member inline closedPaneWidth(this: WidgetBuilder<'msg, #IFabSplitView>, value: float) =
        this.AddScalar(SplitView.ClosedPaneWidth.WithValue(value))

    /// <summary>Sets the PaneColumnGridLength property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The PaneColumnGridLength value.</param>
    [<Extension>]
    static member inline paneColumnGridLength(this: WidgetBuilder<'msg, #IFabSplitView>, value: GridLength) =
        this.AddScalar(SplitView.PaneColumnGridLength.WithValue(value))

    /// <summary>Link a ViewRef to access the direct SplitView control instance.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ViewRef instance that will receive access to the underlying control.</param>
    [<Extension>]
    static member inline reference(this: WidgetBuilder<'msg, IFabSplitView>, value: ViewRef<SplitView>) =
        this.AddScalar(ViewRefAttributes.ViewRef.WithValue(value.Unbox))
