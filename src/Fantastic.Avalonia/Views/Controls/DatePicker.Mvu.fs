namespace Fantastic.Avalonia

open System
open Avalonia.Controls
open Fabulous
open Fantastic.Avalonia

module MvuDatePicker =
    let SelectedDateChanged =
        Attributes.Mvu.defineAvaloniaPropertyWithChangedEvent "DatePicker_SelectedDateChanged" DatePicker.SelectedDateProperty Nullable Nullable.op_Explicit

[<AutoOpen>]
module MvuDatePickerBuilders =
    type Fantastic.Avalonia.View with

        /// <summary>Creates a DatePicker widget.</summary>
        /// <param name="date">The initial date.</param>
        /// <param name="fn">Raised when the selected date changes.</param>
        static member DatePicker(date: DateTimeOffset, fn: DateTimeOffset -> 'msg) =
            WidgetBuilder<'msg, IFabDatePicker>(DatePicker.WidgetKey, MvuDatePicker.SelectedDateChanged.WithValue(ValueEventData.create date fn))
