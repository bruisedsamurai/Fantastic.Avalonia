namespace Fantastic.Avalonia.Tests

open Fabulous
open Fantastic.Avalonia
open NUnit.Framework

[<SetUpFixture>]
type Setup() =
    static member RegisteredWidgets = ResizeArray<WidgetKey>()

    [<OneTimeSetUp>]
    member this.Setup() =
        // Force the widgets to register before the tests start
        Setup.RegisteredWidgets.Add(TextBlock.WidgetKey)
