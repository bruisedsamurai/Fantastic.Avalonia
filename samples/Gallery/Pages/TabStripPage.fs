namespace Gallery


open Fantastic.Avalonia
open type Fantastic.Avalonia.View

module TabStripPage =
    let view () =
        TabStrip([ "Tab 1"; "Tab 2"; "Tab 3" ], (fun x -> TextBlock(x)))
