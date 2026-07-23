namespace Gallery


open Fantastic.Avalonia
open type Fantastic.Avalonia.View

module TreeDataGridPage =
    let view () =
        TabControl() {
            TabItem("Countries", CountriesPage.view())
            TabItem("Files", FilesPage.view())
        }
