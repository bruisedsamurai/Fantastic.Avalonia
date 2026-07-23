namespace Fantastic.Avalonia

open Avalonia.Media
open Fantastic.Avalonia

module MvuGradientBrush =
    let GradientStops =
        Attributes.defineAvaloniaListWidgetCollection "GradientBrush_GradientStops" (fun target -> (target :?> GradientBrush).GradientStops)
