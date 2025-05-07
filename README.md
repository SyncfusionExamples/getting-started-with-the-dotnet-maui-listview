# Getting Started with the .NET MAUI ListView 
The [.NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples) is used to present lists of data in a vertical or horizontal orientation with different layouts virtually. A quick-start project that helps you to integrate a ListView control in the .NET MAUI application by adding Syncfusion MAUI ListView package from NuGet. This project also explains on how to select items in the list, change its layout, and add a header and footer.

# XAML

    <sf:SfListView ItemsSource="{Binding BookDetails}" ItemSize="140"
                   SelectionMode="None">
        <sf:SfListView.ItemsLayout>
            <sf:GridLayout SpanCount="2"></sf:GridLayout>
        </sf:SfListView.ItemsLayout>
        <sf:SfListView.HeaderTemplate>
            <DataTemplate>
                <Grid Background="#4CA1FE" HeightRequest="45">
                    <Label Text="Book List"
                           FontAttributes="Bold"
                           TextColor="White"
                           HorizontalTextAlignment="Center"
                           VerticalTextAlignment="Center"></Label>
                </Grid>
            </DataTemplate>
        </sf:SfListView.HeaderTemplate>
        <sf:SfListView.FooterTemplate>
            <DataTemplate>
                <Grid Background="#4CA1FE" HeightRequest="45">
                    <Label Text="Syncfusion | All rights reserved"
                           FontAttributes="Bold"
                           TextColor="White"
                           HorizontalTextAlignment="Center"
                           VerticalTextAlignment="Center"></Label>
                </Grid>
            </DataTemplate>
        </sf:SfListView.FooterTemplate>
        <sf:SfListView.ItemTemplate>
            <DataTemplate>
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="0.4*"></RowDefinition>
                        <RowDefinition Height="0.6*"></RowDefinition>
                    </Grid.RowDefinitions>
                    <Label Text="{Binding BookName}"
                           FontAttributes="Bold"
                           TextColor="CadetBlue"
                           FontSize="21"></Label>
                    <Label Text="{Binding BookDescription}"
                           Grid.Row="1"
                           FontSize="15"></Label>
                </Grid>
            </DataTemplate>
        </sf:SfListView.ItemTemplate>
    </sf:SfListView>

## Project prerequisites
Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## How to run this application
To run this application, you need to first clone the `getting-started-with-the-dotnet-maui-listview` repository and then open it in Visual Studio 2019. Now, simply build and run your project to view the output.

## Features and Benefits

### Data binding
The ListView has data binding support to work out-of-the box with popular data sources such as List, ObservableCollection, and many more.

### Different layouts
Data can be displayed in different layouts such as linear and grid. Both layouts are supported in the horizontal list view as well.

### Linear layout
The linear layout arranges items linearly in a single column vertically or a single row horizontally.

### Grid layout
The grid layout arranges items in a predefined number of columns and the number of columns can be changed.

### Grouping
A group is a collection of items that belong to a specific category. When grouping is applied, the data is organized into different groups based on key values.

## Related Links
[Learn More about .NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[Download Free Trial](https://www.syncfusion.com/downloads/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[Pricing](https://www.syncfusion.com/sales/teamlicense?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[Documentation](https://help.syncfusion.com/maui/listview/getting-started?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[View Demos](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[Community Forums](https://www.syncfusion.com/forums/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[Knowledge base](https://support.syncfusion.com/kb/cross-platforms/category/76?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

[Suggest a feature or report a bug](https://www.syncfusion.com/feedback/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)

## About Syncfusion .NET MAUI Controls
Syncfusion's [.NET MAUI Controls](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples) library is the only suite that you will ever need to build an application since it contains over 40 high-performance, lightweight, modular, and responsive UI controls in a single package. In addition to ListView, we provide popular .NET MAUI Controls such as [DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Scheduler](https://www.syncfusion.com/maui-controls/maui-scheduler?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), and [Excel](https://www.syncfusion.com/document-processing/excel-framework/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples).

## About Syncfusion

Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 29,000 companies and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.

Today, we provide 1800+ controls and frameworks for web ([ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Angular](https://www.syncfusion.com/angular-components?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [React](https://www.syncfusion.com/react-components?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Blazor](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Vue](https://www.syncfusion.com/vue-components?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)), and desktop development ([Windows Forms](https://www.syncfusion.com/winforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

<hr style="height:0.3px;border:none;color:lightgrey;background-color:lightgrey;" />

<p align="center">
<a href="mailto:sales@syncfusion.com?Subject=Syncfusion .NET MAUI ListView - GitHub" target="_top">sales@syncfusion.com</a> | <a href="https://www.syncfusion.com?utm_source=github&utm_medium=listing&utm_campaign=maui-listview-github-samples">www.syncfusion.com</a> | Toll Free: 1-888-9 DOTNET <br>
</p>