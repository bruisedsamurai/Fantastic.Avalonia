namespace Fantastic.Avalonia

open Avalonia.Controls.Primitives
open Fantastic.Avalonia

module MvuRangeBase =
    let ValueChanged =
        Attributes.Mvu.defineAvaloniaPropertyWithChangedEvent' "RangeBase_ValueChanged" RangeBase.ValueProperty
