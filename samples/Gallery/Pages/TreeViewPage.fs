namespace Gallery


open Fantastic.Avalonia
open type Fantastic.Avalonia.View

module TreeViewPage =
    let view () =
        TabControl() {
            TabItem("Simple", SimpleTreeView.view())
            TabItem("With TreeViewItem", SimpleTreeViewItem.view())
            TabItem("With node interaction", TreeViewWithNodeInteraction.view())
            TabItem("Editable", EditableTreeView.view())
        }
