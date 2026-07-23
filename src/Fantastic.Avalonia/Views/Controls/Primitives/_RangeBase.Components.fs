namespace Fantastic.Avalonia

open Avalonia.Controls.Primitives
open Fantastic.Avalonia

module ComponentRangeBase =
    let ValueChanged =
        Attributes.Component.defineAvaloniaPropertyWithChangedEvent' "RangeBase_ValueChanged" RangeBase.ValueProperty
