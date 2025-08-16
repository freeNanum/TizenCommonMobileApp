# TizenXamlCommonProfileApp

[한국어 버전 보기](README.ko.md)

This project is a sample Xamarin.Forms application designed to demonstrate page navigation and switching between various screens within a mobile application. It serves as a foundational example for developers looking to implement multi-page applications using Xamarin.Forms, C#, and XAML.

## Project Overview

The `TizenXamlCommonProfileApp` solution is structured to showcase a common pattern for mobile application development, particularly focusing on UI navigation.

### Key Technologies Used:
*   **Xamarin.Forms**: A cross-platform UI toolkit for building native UIs with C# and XAML.
*   **C#**: The primary programming language for application logic.
*   **XAML**: Extensible Application Markup Language for defining user interfaces.
*   **.NET Standard**: Ensures code reusability across different .NET platforms.

### Project Structure:
*   **`TizenXamlCommonProfileApp/TizenXamlCommonProfileApp`**: This is the core Xamarin.Forms Portable Class Library (PCL) project. It contains all the shared UI definitions (XAML files) and application logic (C# code-behind and ViewModels).
*   **`TizenXamlCommonProfileApp/TizenXamlCommonProfileApp.Tizen`**: This is the Tizen-specific project, responsible for bootstrapping the Xamarin.Forms application on Tizen devices.

## Page Navigation

The application demonstrates a standard navigation pattern using Xamarin.Forms' `NavigationPage`.

*   **Application Entry Point**: The `App.xaml.cs` file initializes the application's main page. It sets `MainPage` to a `NavigationPage` wrapping `FirstPage()`. This establishes a navigation stack, allowing for push and pop operations.
    ```csharp
    // In App.xaml.cs
    MainPage = new NavigationPage(new FirstPage());
    ```
*   **Page Switching**: Navigation between pages is primarily handled using `Navigation.PushAsync()`. For example, from `FirstPage`, clicking a "Next" button pushes `SecondPage` onto the navigation stack.
    ```csharp
    // Example from FirstPage.xaml.cs
    private async void btn_Clicked(object sender, EventArgs e)
    {
        // ... other logic
        if (Id == btnNext.Id)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
    ```
*   **Sample Pages**: The project includes multiple sample pages (`FirstPage.xaml`, `SecondPage.xaml`, `ThirdPage.xaml`, `FourthPage.xaml`, `FifthPage.xaml`, `Sixthpage.xaml`, `SeventhPage.xaml`, and `LastPage.xaml`). Each page typically contains UI elements (like buttons) that trigger navigation to the next page in the sequence or provide options to go back.

## MVVM Pattern Example

The project also includes a basic example of the Model-View-ViewModel (MVVM) architectural pattern.

*   **`CurrentTimeViewModel.cs`**: This class serves as a ViewModel. It implements the `INotifyPropertyChanged` interface, which is crucial for data binding in Xamarin.Forms. The ViewModel exposes a `DateTime` property that updates every second, notifying any bound UI elements of the change.
    ```csharp
    // In CurrentTimeViewModel.cs
    public class CurrentTimeViewModel : INotifyPropertyChanged
    {
        // ... property and INotifyPropertyChanged implementation
    }
    ```
    This ViewModel can be bound to a `Label` or other display control on a page to show the current time, demonstrating how UI can react to data changes in the ViewModel without direct code-behind manipulation.

## How to Run

1.  **Open the Solution**: Open `TizenXamlCommonProfileApp.sln` in Visual Studio (or Visual Studio for Mac).
2.  **Select Tizen Platform**: Ensure the `TizenXamlCommonProfileApp.Tizen` project is set as the startup project.
3.  **Build and Deploy**: Build the solution and deploy it to a Tizen emulator or a connected Tizen device.

This project provides a clear and concise example of fundamental Xamarin.Forms concepts, particularly focusing on navigation and a basic MVVM implementation.