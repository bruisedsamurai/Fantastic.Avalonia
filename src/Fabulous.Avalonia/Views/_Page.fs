namespace Fabulous.Avalonia

open System.Runtime.CompilerServices
open Avalonia
open Avalonia.Controls
open Avalonia.Controls.Templates
open Fabulous

type IFabPage =
    inherit IFabTemplatedControl

module Page =
    let HeaderString =
        Attributes.defineAvaloniaProperty<string, obj> Page.HeaderProperty box ScalarAttributeComparers.equalityCompare

    let HeaderWidget =
        Attributes.defineAvaloniaPropertyWidget Page.HeaderProperty

    let HeaderTemplate =
        Attributes.defineAvaloniaPropertyWithEquality Page.HeaderTemplateProperty

    let IconString =
        Attributes.defineAvaloniaProperty<string, obj> Page.IconProperty box ScalarAttributeComparers.equalityCompare

    let IconWidget =
        Attributes.defineAvaloniaPropertyWidget Page.IconProperty

    let IconTemplate =
        Attributes.defineAvaloniaPropertyWithEquality Page.IconTemplateProperty

    let SafeAreaPadding =
        Attributes.defineAvaloniaPropertyWithEquality Page.SafeAreaPaddingProperty

type PageModifiers =
    /// <summary>Sets the Header property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Header value.</param>
    [<Extension>]
    static member inline header(this: WidgetBuilder<'msg, #IFabPage>, value: string) =
        this.AddScalar(Page.HeaderString.WithValue(value))

    /// <summary>Sets the Header property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Header value.</param>
    [<Extension>]
    static member inline header(this: WidgetBuilder<'msg, #IFabPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(Page.HeaderWidget.WithValue(value.Compile()))

    /// <summary>Sets the HeaderTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The HeaderTemplate value.</param>
    [<Extension>]
    static member inline headerTemplate(this: WidgetBuilder<'msg, #IFabPage>, value: IDataTemplate) =
        this.AddScalar(Page.HeaderTemplate.WithValue(value))

    /// <summary>Sets the Icon property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Icon value.</param>
    [<Extension>]
    static member inline icon(this: WidgetBuilder<'msg, #IFabPage>, value: string) =
        this.AddScalar(Page.IconString.WithValue(value))

    /// <summary>Sets the Icon property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The Icon value.</param>
    [<Extension>]
    static member inline icon(this: WidgetBuilder<'msg, #IFabPage>, value: WidgetBuilder<'msg, #IFabControl>) =
        this.AddWidget(Page.IconWidget.WithValue(value.Compile()))

    /// <summary>Sets the IconTemplate property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The IconTemplate value.</param>
    [<Extension>]
    static member inline iconTemplate(this: WidgetBuilder<'msg, #IFabPage>, value: IDataTemplate) =
        this.AddScalar(Page.IconTemplate.WithValue(value))

    /// <summary>Sets the SafeAreaPadding property.</summary>
    /// <param name="this">Current widget.</param>
    /// <param name="value">The SafeAreaPadding value.</param>
    [<Extension>]
    static member inline safeAreaPadding(this: WidgetBuilder<'msg, #IFabPage>, value: Thickness) =
        this.AddScalar(Page.SafeAreaPadding.WithValue(value))
