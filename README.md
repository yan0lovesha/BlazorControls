# BlazorControls

I used to build some tools for my self for simplify some boring manual works. This is a library that contains the UI controls which are useful in my own toolkit.

I also used to use latest or intreseting technology to build it up. This time it is based on [Blazor](https://blazor.net). Below is the controls currently implemented as a Blazor Libaray.

It is using Bootstrap which comes with Blazor by default.

## Controls

* ### ActionButton
  It is a button that triggers an async function to do some backend jobs. It will update the text when the job started and ended. It will be shown as different status when the job succeeded or failed. 

* ### TreeView
  This tree view control supports following features:
  * Dynamically load child items
  * Expand all nodes by default
  * Events
    * OnNodeSelected
    * OnNodeExpanded
    * OnNodeCollapsed

* ### JsonViewer
  This is a control implemented based on the TreeView control. You can feed a JToken object into it. It will display the object structure as an expanded tree.
