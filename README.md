# How-to-create-a-contact-list-with-initials-using-.NET-MAUI-Avatar-View
This repository contains sample which demonstrates how to create a contact list with initials using .NET MAUI Avatar View

The .NET Multi-platform App UI (MAUI) Avatar View (Initials View) provides a graphical representation of the user image that allows you to customize the view by adding image, background color, icon, text, and more.
The .NET MAUI Initials View can be achieved by using the `ContentType` property which should be set to `Initials`. 

## Type of .NET MAUI Initials View
There are two types of .NET MAUI Initials View available in the SfAvatarView: 
*	Single character initial view. 
*	Double character initial view. 
### .NET MAUI Single Character Initial View
The .NET MAUI single character initial view can be achieved using the `SingleCharacter` option of the `InitialsType` property of the SfAvatarView.
The following code sample is an example for .NET MAUI Initials View with single character.

**XAML**

<sfAvatar:SfAvatarView ContentType="Initials"
     InitialsType="SingleCharacter" >
</sfAvatar:SfAvatarView>
 
### .NET MAUI Double Character Initials View
The .NET MAUI double character initial view can be achieved using the `DoubleCharacter` option of the `InitialsType` property of the SfAvatarView.
The following code sample is an example for .NET MAUI Initials View with double characters.

**XAML**

<sfAvatar:SfAvatarView ContentType="Initials"
     InitialsType="DoubleCharacter" >
</sfAvatar:SfAvatarView>

## Steps to add .NET MAUI Initials View
This section explains how to create a contact list with initials view with a double character in a .NET MAUI application.
**Step 1**: Create a .NET MAUI application project in Visual Studio 2022.
**Step 2**: Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) Nuget to the project from [nuget.org](https://www.nuget.org/).
**Step 3**: In the MauiProgram.cs file, register the Syncfusion.Maui.Core handler as follows.

**C#**

using Syncfusion.Maui.Core.Hosting;
namespace AvatarView_ContactList;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}


**Step 4**: Add the .NET MAUI Avatar View control namespace to the MainPage.xaml.

**XAML**

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="AvatarView_ContactList.MainPage"
             xmlns:sfAvatar="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
             xmlns:local="clr-namespace:AvatarView_ContactList">


**Step 5**: Create a list of contact details in the view model. Have a property Name that holds the value to be shown as in the .NET MAUI Initials View.

**C#**

public class Contact
{
    public string Name { get; set; }
}

public class ContactsViewModel
{
    public List<Contact> ListOfContacts { get; set; }

    public ContactsViewModel()
    {
        ListOfContacts = new List<Contact>();

        ListOfContacts.Add(new Contact() { Name = "Tucker Davis" });
        ListOfContacts.Add(new Contact() { Name = "Elizabeth Ann" });
        ListOfContacts.Add(new Contact() { Name = "Lily Sue" });
        ListOfContacts.Add(new Contact() { Name = "Mary Margaret" });
        ListOfContacts.Add(new Contact() { Name = "Sophia Grace" });
        ListOfContacts.Add(new Contact() { Name = "Andrew James" });
        ListOfContacts.Add(new Contact() { Name = "George Frances" });
        ListOfContacts.Add(new Contact() { Name = "James Richard" });
        ListOfContacts.Add(new Contact() { Name = "John Peter" });
        ListOfContacts.Add(new Contact() { Name = "Logan James" });
    }
}


**Step 6**: Define the Avatar View (SfAvatarView) in the XAML and set the `ContentType` as `Initials` and set the `InitialType` property as `DoubleCharacter`. To create initials for the contact in the .NET MAUI Avatar View, populate the contact list in the collection view and bind the contact’s name to the `AvatarName` property.
This will display the Avatar View as Initials View in a circle shape.

**XAML**

<ContentPage.BindingContext>
    <local:ContactsViewModel/>
</ContentPage.BindingContext>

<Grid>
    <CollectionView ItemsSource="{Binding ListOfContacts}">
        <CollectionView.ItemTemplate>
            <DataTemplate>
                <HorizontalStackLayout Spacing="10" Margin="10">
                    <sfAvatar:SfAvatarView ContentType="Initials"
                                            InitialsType="DoubleCharacter"
                                            AvatarName="{Binding Name}"                   
                                            WidthRequest="50"
                                            AvatarColorMode="LightBackground"
                                            HeightRequest="50"
                                            CornerRadius="25">
                    </sfAvatar:SfAvatarView>
                    <Label Text="{Binding Name}"
                            HorizontalOptions="Center" VerticalOptions="Center"
                            HorizontalTextAlignment="Center"   						     VerticalTextAlignment="Center"/>
                </HorizontalStackLayout>
            </DataTemplate>
        </CollectionView.ItemTemplate>
    </CollectionView>
</Grid>


You can explore the runnable demo of achieving the .NET MAUI Initials View in this repository

 


