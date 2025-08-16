# TizenXamlCommonProfileApp

[View in English](README.md)

이 프로젝트는 모바일 애플리케이션 내에서 다양한 화면 간의 페이지 탐색 및 전환을 시연하기 위해 설계된 Xamarin.Forms 샘플 애플리케이션입니다. Xamarin.Forms, C# 및 XAML을 사용하여 다중 페이지 애플리케이션을 구현하려는 개발자를 위한 기초적인 예제 역할을 합니다.

## 프로젝트 개요

`TizenXamlCommonProfileApp` 솔루션은 모바일 애플리케이션 개발, 특히 UI 탐색에 중점을 둔 일반적인 패턴을 보여주도록 구성되어 있습니다.

### 사용된 주요 기술:
*   **Xamarin.Forms**: C# 및 XAML로 네이티브 UI를 구축하기 위한 크로스 플랫폼 UI 툴킷입니다.
*   **C#**: 애플리케이션 로직을 위한 주요 프로그래밍 언어입니다.
*   **XAML**: 사용자 인터페이스를 정의하기 위한 확장 가능한 애플리케이션 마크업 언어입니다.
*   **.NET Standard**: 다양한 .NET 플랫폼에서 코드 재사용성을 보장합니다.

### 프로젝트 구조:
*   **`TizenXamlCommonProfileApp/TizenXamlCommonProfileApp`**: 이 프로젝트는 핵심 Xamarin.Forms PCL(Portable Class Library) 프로젝트입니다. 모든 공유 UI 정의(XAML 파일) 및 애플리케이션 로직(C# 코드 비하인드 및 ViewModel)을 포함합니다.
*   **`TizenXamlCommonProfileApp/TizenXamlCommonProfileApp.Tizen`**: 이 프로젝트는 Tizen 특정 프로젝트로, Tizen 장치에서 Xamarin.Forms 애플리케이션을 부트스트랩하는 역할을 합니다.

## 페이지 탐색

이 애플리케이션은 Xamarin.Forms의 `NavigationPage`를 사용하여 표준 탐색 패턴을 시연합니다.

*   **애플리케이션 진입점**: `App.xaml.cs` 파일은 애플리케이션의 메인 페이지를 초기화합니다. `MainPage`를 `FirstPage()`를 래핑하는 `NavigationPage`로 설정합니다. 이는 푸시 및 팝 작업을 허용하는 탐색 스택을 설정합니다.
    ```csharp
    // App.xaml.cs에서
    MainPage = new NavigationPage(new FirstPage());
    ```
*   **페이지 전환**: 페이지 간 탐색은 주로 `Navigation.PushAsync()`를 사용하여 처리됩니다. 예를 들어, `FirstPage`에서 "다음" 버튼을 클릭하면 `SecondPage`가 탐색 스택에 푸시됩니다.
    ```csharp
    // FirstPage.xaml.cs 예시
    private async void btn_Clicked(object sender, EventArgs e)
    {
        // ... 기타 로직
        if (Id == btnNext.Id)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
    ```
*   **샘플 페이지**: 이 프로젝트에는 여러 샘플 페이지(`FirstPage.xaml`, `SecondPage.xaml`, `ThirdPage.xaml`, `FourthPage.xaml`, `FifthPage.xaml`, `Sixthpage.xaml`, `SeventhPage.xaml`, `LastPage.xaml`)가 포함되어 있습니다. 각 페이지에는 일반적으로 순서대로 다음 페이지로 탐색을 트리거하거나 뒤로 이동하는 옵션을 제공하는 UI 요소(예: 버튼)가 포함되어 있습니다.

## MVVM 패턴 예제

이 프로젝트에는 MVVM(Model-View-ViewModel) 아키텍처 패턴의 기본 예제도 포함되어 있습니다.

*   **`CurrentTimeViewModel.cs`**: 이 클래스는 ViewModel 역할을 합니다. Xamarin.Forms에서 데이터 바인딩에 중요한 `INotifyPropertyChanged` 인터페이스를 구현합니다. ViewModel은 매초 업데이트되는 `DateTime` 속성을 노출하여 바인딩된 UI 요소에 변경 사항을 알립니다.
    ```csharp
    // CurrentTimeViewModel.cs에서
    public class CurrentTimeViewModel : INotifyPropertyChanged
    {
        // ... 속성 및 INotifyPropertyChanged 구현
    }
    ```
    이 ViewModel은 페이지의 `Label` 또는 다른 표시 컨트롤에 바인딩되어 현재 시간을 표시할 수 있으며, 코드 비하인드 조작 없이 UI가 ViewModel의 데이터 변경에 반응하는 방법을 보여줍니다.

## 실행 방법

1.  **솔루션 열기**: Visual Studio (또는 Visual Studio for Mac)에서 `TizenXamlCommonProfileApp.sln`을 엽니다.
2.  **Tizen 플랫폼 선택**: `TizenXamlCommonProfileApp.Tizen` 프로젝트가 시작 프로젝트로 설정되어 있는지 확인합니다.
3.  **빌드 및 배포**: 솔루션을 빌드하고 Tizen 에뮬레이터 또는 연결된 Tizen 장치에 배포합니다.

이 프로젝트는 특히 탐색 및 기본 MVVM 구현에 중점을 둔 Xamarin.Forms의 기본 개념에 대한 명확하고 간결한 예제를 제공합니다.
