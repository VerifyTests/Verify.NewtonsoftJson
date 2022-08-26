# <img src="/src/icon.png" height="30px"> Verify.NewtonsoftJson

[![Build status](https://ci.appveyor.com/api/projects/status/ej794va900x9257f?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-NewtonsoftJson)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.NewtonsoftJson.svg)](https://www.nuget.org/packages/Verify.NewtonsoftJson/)

Adds [Verify](https://github.com/VerifyTests/Verify) support for converting Newtonsoft.Json types (JObject and JArray).


## NuGet package

https://nuget.org/packages/Verify.NewtonsoftJson/


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

[Pattern](https://thenounproject.com/term/pattern/1440985/) designed by [Shadows of love](https://thenounproject.com/vinoth7089/) from [The Noun Project](https://thenounproject.com/).
