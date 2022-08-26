# <img src="/src/icon.png" height="30px"> Verify.Newtonsoft.Json

[![Build status](https://ci.appveyor.com/api/projects/status/ej794va900x9257f?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Newtonsoft-Json)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Newtonsoft.Json.svg)](https://www.nuget.org/packages/Verify.Newtonsoft.Json/)

Adds [Verify](https://github.com/VerifyTests/Verify) support for converting Newtonsoft types.


## NuGet package

https://nuget.org/packages/Verify.Newtonsoft.Json/


## Usage

<!-- snippet: ModuleInitializer.cs -->
<a id='snippet-ModuleInitializer.cs'></a>
```cs
public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init() =>
        VerifyNewtonsoftJson.Enable();
}
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L1-L6' title='Snippet source file'>snippet source</a> | <a href='#snippet-ModuleInitializer.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Icon

[Clock](https://thenounproject.com/term/clock/731041/) designed by [Mooyai Khomsun Chaiwong](https://thenounproject.com/mooyai/) from [The Noun Project](https://thenounproject.com/).
