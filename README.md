# Blazicons.GoogleMaterialDesign
Provides the Google Material Design icon library packaged as [Blazicons](https://github.com/kyleherzog/Blazicons), SVG icon components for Blazor.

Check out the [Demo Site](http://blazicons.com).

[![Build Status](https://dev.azure.com/kyleherzog/Blazicons/_apis/build/status/Blazicons.GoogleMaterialDesign?branchName=main)](https://dev.azure.com/kyleherzog/Blazicons/_build/latest?definitionId=20&branchName=main)

## Getting Started
To get started using the Google Material Design Blazicons, just install the Blazicons.GoogleMaterialDesign NuGet package.

Next add the Blazicons reference to the `_Imports.razor` file in the Blazor project.

```csharp
@using Blazicons
```

Finally, add the Blazicon components to your Blazor pages/components.
```html
<Blazicon Svg="GoogleMaterialOutlinedIcon.AddAlert"></Blazicon>
<Blazicon Svg="GoogleMaterialFilledIcon.AddAlert"></Blazicon>
<Blazicon Svg="GoogleMaterialRoundIcon.AddAlert"></Blazicon>
<Blazicon Svg="GoogleMaterialSharpIcon.AddAlert"></Blazicon>
<Blazicon Svg="GoogleMaterialTwoToneIcon.AddAlert"></Blazicon>
```

## Parameters & Styling
See the [Blazicons](https://github.com/kyleherzog/Blazicons) documentation for details on parameters and styling.