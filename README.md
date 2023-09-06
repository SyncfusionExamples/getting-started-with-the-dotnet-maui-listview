# Getting Started with the .NET MAUI ListView 
A quick-start project that helps you to integrate a ListView control in the .NET MAUI application by adding Syncfusion MAUI ListView package from NuGet. This project also explains on how to select items in the list, change its layout, and add a header and footer.

Refer to the following documentation for the Syncfusion .NET MAUI ListView Control: 
https://help.syncfusion.com/maui/listview/getting-started

Check out this GitHub example for the Syncfusion .NET MAUI ListView Control: 
https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView

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