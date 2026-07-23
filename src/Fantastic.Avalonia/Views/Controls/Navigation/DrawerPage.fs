namespace Fantastic.Avalonia

open System.Runtime.CompilerServices
open Avalonia.Controls
open Avalonia.Controls.Templates
open Avalonia.Layout
open Avalonia.Media
open Fabulous
open Fabulous.StackAllocatedCollections.StackList

type IFabDrawerPage =
    inherit IFabPage

module DrawerPage =
    let WidgetKey = Widgets.register<DrawerPage>()

    let ContentWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.ContentProperty

    let ContentTemplate =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.ContentTemplateProperty

    let DrawerWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerProperty

    let DrawerTemplate =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerTemplateProperty

    let DrawerHeaderString =
        Attributes.defineAvaloniaProperty<string, obj> DrawerPage.DrawerHeaderProperty box ScalarAttributeComparers.equalityCompare

    let DrawerHeaderWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerHeaderProperty

    let DrawerHeaderTemplate =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerHeaderTemplateProperty

    let DrawerFooterString =
        Attributes.defineAvaloniaProperty<string, obj> DrawerPage.DrawerFooterProperty box ScalarAttributeComparers.equalityCompare

    let DrawerFooterWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerFooterProperty

    let DrawerFooterTemplate =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerFooterTemplateProperty

    let DrawerIconString =
        Attributes.defineAvaloniaProperty<string, obj> DrawerPage.DrawerIconProperty box ScalarAttributeComparers.equalityCompare

    let DrawerIconGeometry =
        Attributes.defineAvaloniaProperty<Geometry, obj> DrawerPage.DrawerIconProperty box ScalarAttributeComparers.equalityCompare

    let DrawerIconWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerIconProperty

    let DrawerIconTemplate =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerIconTemplateProperty

    let IsOpen =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.IsOpenProperty

    let DrawerLength =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerLengthProperty

    let CompactDrawerLength =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.CompactDrawerLengthProperty

    let DrawerBreakpointLength =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerBreakpointLengthProperty

    let IsGestureEnabled =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.IsGestureEnabledProperty

    let DrawerBehavior =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerBehaviorProperty

    let DrawerLayoutBehavior =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerLayoutBehaviorProperty

    let DrawerPlacement =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerPlacementProperty

    let DrawerBackgroundWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerBackgroundProperty

    let DrawerBackground =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerBackgroundProperty

    let DrawerHeaderBackgroundWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerHeaderBackgroundProperty

    let DrawerHeaderBackground =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerHeaderBackgroundProperty

    let DrawerHeaderForegroundWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerHeaderForegroundProperty

    let DrawerHeaderForeground =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerHeaderForegroundProperty

    let DrawerFooterBackgroundWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerFooterBackgroundProperty

    let DrawerFooterBackground =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerFooterBackgroundProperty

    let DrawerFooterForegroundWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.DrawerFooterForegroundProperty

    let DrawerFooterForeground =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.DrawerFooterForegroundProperty

    let BackdropBrushWidget =
        Attributes.defineAvaloniaPropertyWidget DrawerPage.BackdropBrushProperty

    let BackdropBrush =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.BackdropBrushProperty

    let HorizontalContentAlignment =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.HorizontalContentAlignmentProperty

    let VerticalContentAlignment =
        Attributes.defineAvaloniaPropertyWithEquality DrawerPage.VerticalContentAlignmentProperty

[<AutoOpen>]
module DrawerPageBuilders =
    type Fantastic.Avalonia.View with

        /// <summary>Creates a DrawerPage widget.</summary>
        /// <param name="drawer">The drawer pane content.</param>
        /// <param name="content">The main content area.</param>
        static member DrawerPage(drawer: WidgetBuilder<'msg, #IFabControl>, content: WidgetBuilder<'msg, #IFabControl>) =
            WidgetBuilder<'msg, IFabDrawerPage>(
                DrawerPage.WidgetKey,
                AttributesBundle(
                    StackList.empty(),
                    [| DrawerPage.DrawerWidget.WithValue(drawer.Compile())
                       DrawerPage.ContentWidget.WithValue(content.Compile()) |],
                    [||],
                    [||]
                )
            )

        /// <summary>Creates a DrawerPage widget without a drawer.</summary>
        /// <param name="content">The main content area.</param>
        static member DrawerPage(content: WidgetBuilder<'msg, #IFabControl>) =
            WidgetBuilder<'msg, IFabDrawerPage>(DrawerPage.WidgetKey, DrawerPage.ContentWidget.WithValue(content.Compile()))

type DrawerPageModifiers =
    /// <summary>Sets the Drawer property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Drawer value.</param>
    [<Extension>]
    static member inline drawer(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(DrawerPage.DrawerWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerTemplate value.</param>
    [<Extension>]
    static member inline drawerTemplate(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IDataTemplate) =
        this.AddScalar(DrawerPage.DrawerTemplate.WithValue(value))

    /// <summary>Sets the ContentTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ContentTemplate value.</param>
    [<Extension>]
    static member inline contentTemplate(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IDataTemplate) =
        this.AddScalar(DrawerPage.ContentTemplate.WithValue(value))

    /// <summary>Sets the DrawerHeader property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeader value.</param>
    [<Extension>]
    static member inline drawerHeader(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        this.AddScalar(DrawerPage.DrawerHeaderString.WithValue(value))

    /// <summary>Sets the DrawerHeader property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeader value.</param>
    [<Extension>]
    static member inline drawerHeader(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(DrawerPage.DrawerHeaderWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerHeaderTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderTemplate value.</param>
    [<Extension>]
    static member inline drawerHeaderTemplate(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IDataTemplate) =
        this.AddScalar(DrawerPage.DrawerHeaderTemplate.WithValue(value))

    /// <summary>Sets the DrawerFooter property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooter value.</param>
    [<Extension>]
    static member inline drawerFooter(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        this.AddScalar(DrawerPage.DrawerFooterString.WithValue(value))

    /// <summary>Sets the DrawerFooter property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooter value.</param>
    [<Extension>]
    static member inline drawerFooter(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(DrawerPage.DrawerFooterWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerFooterTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterTemplate value.</param>
    [<Extension>]
    static member inline drawerFooterTemplate(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IDataTemplate) =
        this.AddScalar(DrawerPage.DrawerFooterTemplate.WithValue(value))

    /// <summary>Sets the DrawerIcon property to an SVG path string.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerIcon value.</param>
    [<Extension>]
    static member inline drawerIcon(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        this.AddScalar(DrawerPage.DrawerIconString.WithValue(value))

    /// <summary>Sets the DrawerIcon property to a Geometry value.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerIcon value.</param>
    [<Extension>]
    static member inline drawerIcon(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Geometry) =
        this.AddScalar(DrawerPage.DrawerIconGeometry.WithValue(value))

    /// <summary>Sets the DrawerIcon property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerIcon value.</param>
    [<Extension>]
    static member inline drawerIcon(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(DrawerPage.DrawerIconWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerIconTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerIconTemplate value.</param>
    [<Extension>]
    static member inline drawerIconTemplate(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IDataTemplate) =
        this.AddScalar(DrawerPage.DrawerIconTemplate.WithValue(value))

    /// <summary>Sets the IsOpen property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsOpen value.</param>
    [<Extension>]
    static member inline isOpen(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: bool) =
        this.AddScalar(DrawerPage.IsOpen.WithValue(value))

    /// <summary>Sets the DrawerLength property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerLength value.</param>
    [<Extension>]
    static member inline drawerLength(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: float) =
        this.AddScalar(DrawerPage.DrawerLength.WithValue(value))

    /// <summary>Sets the CompactDrawerLength property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The CompactDrawerLength value.</param>
    [<Extension>]
    static member inline compactDrawerLength(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: float) =
        this.AddScalar(DrawerPage.CompactDrawerLength.WithValue(value))

    /// <summary>Sets the DrawerBreakpointLength property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerBreakpointLength value.</param>
    [<Extension>]
    static member inline drawerBreakpointLength(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: float) =
        this.AddScalar(DrawerPage.DrawerBreakpointLength.WithValue(value))

    /// <summary>Sets the IsGestureEnabled property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IsGestureEnabled value.</param>
    [<Extension>]
    static member inline isGestureEnabled(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: bool) =
        this.AddScalar(DrawerPage.IsGestureEnabled.WithValue(value))

    /// <summary>Sets the DrawerBehavior property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerBehavior value.</param>
    [<Extension>]
    static member inline drawerBehavior(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: DrawerBehavior) =
        this.AddScalar(DrawerPage.DrawerBehavior.WithValue(value))

    /// <summary>Sets the DrawerLayoutBehavior property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerLayoutBehavior value.</param>
    [<Extension>]
    static member inline drawerLayoutBehavior(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: DrawerLayoutBehavior) =
        this.AddScalar(DrawerPage.DrawerLayoutBehavior.WithValue(value))

    /// <summary>Sets the DrawerPlacement property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerPlacement value.</param>
    [<Extension>]
    static member inline drawerPlacement(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: DrawerPlacement) =
        this.AddScalar(DrawerPage.DrawerPlacement.WithValue(value))

    /// <summary>Sets the DrawerBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerBackground value.</param>
    [<Extension>]
    static member inline drawerBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(DrawerPage.DrawerBackgroundWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerBackground value.</param>
    [<Extension>]
    static member inline drawerBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IBrush) =
        this.AddScalar(DrawerPage.DrawerBackground.WithValue(value))

    /// <summary>Sets the DrawerBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerBackground value.</param>
    [<Extension>]
    static member inline drawerBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Color) =
        DrawerPageModifiers.drawerBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerBackground value.</param>
    [<Extension>]
    static member inline drawerBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        DrawerPageModifiers.drawerBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerHeaderBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderBackground value.</param>
    [<Extension>]
    static member inline drawerHeaderBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(DrawerPage.DrawerHeaderBackgroundWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerHeaderBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderBackground value.</param>
    [<Extension>]
    static member inline drawerHeaderBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IBrush) =
        this.AddScalar(DrawerPage.DrawerHeaderBackground.WithValue(value))

    /// <summary>Sets the DrawerHeaderBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderBackground value.</param>
    [<Extension>]
    static member inline drawerHeaderBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Color) =
        DrawerPageModifiers.drawerHeaderBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerHeaderBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderBackground value.</param>
    [<Extension>]
    static member inline drawerHeaderBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        DrawerPageModifiers.drawerHeaderBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerHeaderForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderForeground value.</param>
    [<Extension>]
    static member inline drawerHeaderForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(DrawerPage.DrawerHeaderForegroundWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerHeaderForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderForeground value.</param>
    [<Extension>]
    static member inline drawerHeaderForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IBrush) =
        this.AddScalar(DrawerPage.DrawerHeaderForeground.WithValue(value))

    /// <summary>Sets the DrawerHeaderForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderForeground value.</param>
    [<Extension>]
    static member inline drawerHeaderForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Color) =
        DrawerPageModifiers.drawerHeaderForeground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerHeaderForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerHeaderForeground value.</param>
    [<Extension>]
    static member inline drawerHeaderForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        DrawerPageModifiers.drawerHeaderForeground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerFooterBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterBackground value.</param>
    [<Extension>]
    static member inline drawerFooterBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(DrawerPage.DrawerFooterBackgroundWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerFooterBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterBackground value.</param>
    [<Extension>]
    static member inline drawerFooterBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IBrush) =
        this.AddScalar(DrawerPage.DrawerFooterBackground.WithValue(value))

    /// <summary>Sets the DrawerFooterBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterBackground value.</param>
    [<Extension>]
    static member inline drawerFooterBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Color) =
        DrawerPageModifiers.drawerFooterBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerFooterBackground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterBackground value.</param>
    [<Extension>]
    static member inline drawerFooterBackground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        DrawerPageModifiers.drawerFooterBackground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerFooterForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterForeground value.</param>
    [<Extension>]
    static member inline drawerFooterForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(DrawerPage.DrawerFooterForegroundWidget.WithValue(value.Compile()))

    /// <summary>Sets the DrawerFooterForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterForeground value.</param>
    [<Extension>]
    static member inline drawerFooterForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IBrush) =
        this.AddScalar(DrawerPage.DrawerFooterForeground.WithValue(value))

    /// <summary>Sets the DrawerFooterForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterForeground value.</param>
    [<Extension>]
    static member inline drawerFooterForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Color) =
        DrawerPageModifiers.drawerFooterForeground(this, View.SolidColorBrush(value))

    /// <summary>Sets the DrawerFooterForeground property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The DrawerFooterForeground value.</param>
    [<Extension>]
    static member inline drawerFooterForeground(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        DrawerPageModifiers.drawerFooterForeground(this, View.SolidColorBrush(value))

    /// <summary>Sets the BackdropBrush property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The BackdropBrush value.</param>
    [<Extension>]
    static member inline backdropBrush(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: WidgetBuilder<'msg, #IFabBrush>) =
        this.AddWidget(DrawerPage.BackdropBrushWidget.WithValue(value.Compile()))

    /// <summary>Sets the BackdropBrush property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The BackdropBrush value.</param>
    [<Extension>]
    static member inline backdropBrush(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: IBrush) =
        this.AddScalar(DrawerPage.BackdropBrush.WithValue(value))

    /// <summary>Sets the BackdropBrush property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The BackdropBrush value.</param>
    [<Extension>]
    static member inline backdropBrush(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: Color) =
        DrawerPageModifiers.backdropBrush(this, View.SolidColorBrush(value))

    /// <summary>Sets the BackdropBrush property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The BackdropBrush value.</param>
    [<Extension>]
    static member inline backdropBrush(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: string) =
        DrawerPageModifiers.backdropBrush(this, View.SolidColorBrush(value))

    /// <summary>Sets the HorizontalContentAlignment property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The HorizontalContentAlignment value.</param>
    [<Extension>]
    static member inline horizontalContentAlignment(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: HorizontalAlignment) =
        this.AddScalar(DrawerPage.HorizontalContentAlignment.WithValue(value))

    /// <summary>Sets the VerticalContentAlignment property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The VerticalContentAlignment value.</param>
    [<Extension>]
    static member inline verticalContentAlignment(this: WidgetBuilder<'msg, #IFabDrawerPage>, value: VerticalAlignment) =
        this.AddScalar(DrawerPage.VerticalContentAlignment.WithValue(value))

    /// <summary>Link a ViewRef to access the direct DrawerPage control instance.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ViewRef instance that will receive access to the underlying control.</param>
    [<Extension>]
    static member inline reference(this: WidgetBuilder<'msg, IFabDrawerPage>, value: ViewRef<DrawerPage>) =
        this.AddScalar(ViewRefAttributes.ViewRef.WithValue(value.Unbox))
