# <img src="/src/icon.png" height="30px"> Verify.NewtonsoftJson

[![Build status](https://ci.appveyor.com/api/projects/status/ej794va900x9257f?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-NewtonsoftJson)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.NewtonsoftJson.svg)](https://www.nuget.org/packages/Verify.NewtonsoftJson/)

Adds [Verify](https://github.com/VerifyTests/Verify) support for converting Newtonsoft.Json types (JObject and JArray).

Adds support for converting existing implementation of `Newtonsoft.Json.JsonConverter` to `Argon.JsonConverter` instances.
This allows to customize Verify serialization behaviour of types using JsonConverter implementations for Newtonsoft.Json with DRY.


## NuGet package

https://nuget.org/packages/Verify.NewtonsoftJson/


## Usage

### Converting Newtonsoft.Json types

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init()
{

    VerifyNewtonsoftJson.Enable();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L5-L13' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

### Adapting Newtonsoft.Json JsonConverter

<!-- snippet: adapter -->
<a id='snippet-adapter'></a>
```cs
VerifierSettings.AddExtraSettings(
    _ =>
    {
        _.Converters.Add(
            new ArgonJsonConverterAdapter(
                new KeysJsonConverter(typeof(Employee))));
    });
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L17-L25' title='Snippet source file'>snippet source</a> | <a href='#snippet-adapter' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Icon

[Pattern](https://thenounproject.com/term/pattern/1440985/) designed by [Shadows of love](https://thenounproject.com/vinoth7089/) from [The Noun Project](https://thenounproject.com/).
