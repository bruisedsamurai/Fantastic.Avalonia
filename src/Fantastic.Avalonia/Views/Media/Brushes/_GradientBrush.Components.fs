namespace Fantastic.Avalonia

open Avalonia.Media
open Fantastic.Avalonia

module ComponentGradientBrush =
    let GradientStops =
        Attributes.defineAvaloniaListWidgetCollection "GradientBrush_GradientStops" (fun target -> (target :?> GradientBrush).GradientStops)
