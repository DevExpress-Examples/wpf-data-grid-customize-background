<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/303781796/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T939764)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Data Grid - Customize Background Color

This example demonstrates how to use the [WPF ColorEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ColorEdit?v=20.2&p=netframework) control to customize the background color of grid UI elements.

![WPF Data Grid - Customize Background Color, DevExpress](https://raw.githubusercontent.com/DevExpress-Examples/how-to-specify-wpf-data-grid-background/22.2.2%2B/i/wpf-data-grid-background-customization-devexpress.png)

The [GridControl.Background](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.Background) property specifies the background color of UI elements such as column headers, the group panel, and the row indicator.

The [GridControl.DataAreaBackground](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.DataAreaBackground) property specifies the background color of data cells and group rows.

```xaml
<dxg:GridControl Grid.Column="0"
                    Background="{Binding SelectedColor, Converter={dxmvvm:ColorToBrushConverter}}"
                    DataAreaBackground="{Binding DataAreaSelectedColor, Converter={dxmvvm:ColorToBrushConverter}}"
                    ItemsSource="{Binding Items}"
                    AutoGenerateColumns="AddNew" Grid.ColumnSpan="3">
    <dxg:GridControl.View>
        <dxg:TableView EnableSelectedRowAppearance="False"/>
    </dxg:GridControl.View>
</dxg:GridControl>
```

```csharp
public class MainViewModel : ViewModelBase {
    public Color SelectedColor {
        get { return GetProperty(() => SelectedColor); }
        set { SetProperty(() => SelectedColor, value); }
    }

    public Color DataAreaSelectedColor {
        get { return GetProperty(() => DataAreaSelectedColor); }
        set { SetProperty(() => DataAreaSelectedColor, value); }
    }

    public virtual ObservableCollection<Employee> Items {
        get { return GetProperty(() => Items); }
        set { SetProperty(() => Items, value); }
    }
    public MainViewModel() {
        Items = Stuff.GetStuff();
    }
}
```

## Documentation

* [Data Grid - Appearance Customization](https://docs.devexpress.com/WPF/6152/controls-and-libraries/data-grid/appearance-customization)
* [MVVM Support](https://docs.devexpress.com/WPF/10122/controls-and-libraries/data-grid/mvvm-support)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-customize-background&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-customize-background&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
