namespace Fantastic.Avalonia

open System.Runtime.CompilerServices
open Avalonia.Controls
open Avalonia.Controls.Templates
open Avalonia.Layout
open Fabulous

type IFabContentPage =
    inherit IFabPage

module ContentPage =
    let WidgetKey = Widgets.register<ContentPage>()

    let ContentWidget =
        Attributes.defineAvaloniaPropertyWidget ContentPage.ContentProperty

    let ContentString =
        Attributes.defineAvaloniaProperty<string, obj> ContentPage.ContentProperty box ScalarAttributeComparers.equalityCompare

    let ContentTemplate =
        Attributes.defineAvaloniaPropertyWithEquality ContentPage.ContentTemplateProperty

    let AutomaticallyApplySafeAreaPadding =
        Attributes.defineAvaloniaPropertyWithEquality ContentPage.AutomaticallyApplySafeAreaPaddingProperty

    let TopCommandBarWidget =
        Attributes.defineAvaloniaPropertyWidget ContentPage.TopCommandBarProperty

    let BottomCommandBarWidget =
        Attributes.defineAvaloniaPropertyWidget ContentPage.BottomCommandBarProperty

    let HorizontalContentAlignment =
        Attributes.defineAvaloniaPropertyWithEquality ContentPage.HorizontalContentAlignmentProperty

    let VerticalContentAlignment =
        Attributes.defineAvaloniaPropertyWithEquality ContentPage.VerticalContentAlignmentProperty

[<AutoOpen>]
module ContentPageBuilders =
    type Fantastic.Avalonia.View with

        /// <summary>Creates a ContentPage widget.</summary>
        /// <param name="content">The single root view displayed on the page.</param>
        static member ContentPage(content: WidgetBuilder<'msg, #IFabControl>) =
            WidgetBuilder<'msg, IFabContentPage>(ContentPage.WidgetKey, ContentPage.ContentWidget.WithValue(content.Compile()))

        /// <summary>Creates a ContentPage widget with a string content.</summary>
        /// <param name="content">The string content displayed on the page.</param>
        static member ContentPage(content: string) =
            WidgetBuilder<'msg, IFabContentPage>(ContentPage.WidgetKey, ContentPage.ContentString.WithValue(content))

type ContentPageModifiers =
    /// <summary>Sets the ContentTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ContentTemplate value.</param>
    [<Extension>]
    static member inline contentTemplate(this: WidgetBuilder<'msg, #IFabContentPage>, value: IDataTemplate) =
        this.AddScalar(ContentPage.ContentTemplate.WithValue(value))

    /// <summary>Sets the AutomaticallyApplySafeAreaPadding property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">When <c>true</c>, platform safe-area insets are automatically applied as padding to the content presenter.</param>
    [<Extension>]
    static member inline automaticallyApplySafeAreaPadding(this: WidgetBuilder<'msg, #IFabContentPage>, value: bool) =
        this.AddScalar(ContentPage.AutomaticallyApplySafeAreaPadding.WithValue(value))

    /// <summary>Sets the TopCommandBar property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">Content rendered in a command bar slot above the page content. Typically a CommandBar.</param>
    [<Extension>]
    static member inline topCommandBar(this: WidgetBuilder<'msg, #IFabContentPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(ContentPage.TopCommandBarWidget.WithValue(value.Compile()))

    /// <summary>Sets the BottomCommandBar property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">Content rendered in a command bar slot below the page content. Typically a CommandBar.</param>
    [<Extension>]
    static member inline bottomCommandBar(this: WidgetBuilder<'msg, #IFabContentPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(ContentPage.BottomCommandBarWidget.WithValue(value.Compile()))

    /// <summary>Sets the HorizontalContentAlignment property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The HorizontalContentAlignment value.</param>
    [<Extension>]
    static member inline horizontalContentAlignment(this: WidgetBuilder<'msg, #IFabContentPage>, value: HorizontalAlignment) =
        this.AddScalar(ContentPage.HorizontalContentAlignment.WithValue(value))

    /// <summary>Sets the VerticalContentAlignment property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The VerticalContentAlignment value.</param>
    [<Extension>]
    static member inline verticalContentAlignment(this: WidgetBuilder<'msg, #IFabContentPage>, value: VerticalAlignment) =
        this.AddScalar(ContentPage.VerticalContentAlignment.WithValue(value))

    /// <summary>Link a ViewRef to access the direct ContentPage control instance.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The ViewRef instance that will receive access to the underlying control.</param>
    [<Extension>]
    static member inline reference(this: WidgetBuilder<'msg, IFabContentPage>, value: ViewRef<ContentPage>) =
        this.AddScalar(ViewRefAttributes.ViewRef.WithValue(value.Unbox))
