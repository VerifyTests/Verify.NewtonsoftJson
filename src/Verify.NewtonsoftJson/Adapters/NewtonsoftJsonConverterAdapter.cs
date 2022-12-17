using ArgonJsonConverter = Argon.JsonConverter;
using ArgonJsonWriter = Argon.JsonWriter;
using NewtonsoftJsonConverter = Newtonsoft.Json.JsonConverter;
using NewtonsoftJsonSerializer = Newtonsoft.Json.JsonSerializer;
using NewtonsoftJsonWriter = Newtonsoft.Json.JsonWriter;


/// <summary>
/// This class implements the <a href="https://en.wikipedia.org/wiki/Adapter_pattern">adapter pattern</a>
/// for using existing implementation of <see cref="Newtonsoft.Json.JsonConverter"/> in place of a <see cref="Argon.JsonConverter"/>.
/// </summary>
public class ArgonJsonConverterAdapter : ArgonJsonConverter
{
    private readonly NewtonsoftJsonConverter _implementation;
    private readonly NewtonsoftJsonSerializer _newtonsoftJsonSerializer;

    /// <summary>
    /// <inheritdoc cref="ArgonJsonConverterAdapter"/>
    /// </summary>
    /// <param name="implementation">The wrapped instance used under the hood</param>
    /// <param name="newtonsoftJsonSerializer">You can pass a serializer to customize the behavior</param>
    public ArgonJsonConverterAdapter(NewtonsoftJsonConverter implementation, NewtonsoftJsonSerializer? newtonsoftJsonSerializer = null)
    {
        _implementation = implementation;
        _newtonsoftJsonSerializer = newtonsoftJsonSerializer ?? new NewtonsoftJsonSerializer();
    }

    public override bool CanRead => false;

    public override bool CanConvert(Type type) => _implementation.CanConvert(type);

    public override object? ReadJson(Argon.JsonReader reader, Type type, object? existingValue, Argon.JsonSerializer serializer) =>
        throw new NotImplementedException();

    public override void WriteJson(Argon.JsonWriter writer, object value, Argon.JsonSerializer serializer) =>
        _implementation.WriteJson(new ArgonJsonWriterAdapter(writer), value, _newtonsoftJsonSerializer);
}

internal class ArgonJsonWriterAdapter : NewtonsoftJsonWriter
{
    private readonly ArgonJsonWriter _implementation;

    public ArgonJsonWriterAdapter(ArgonJsonWriter implementation)
    {
        _implementation = implementation;
    }

    public override void Close() => _implementation.Close();

    public override Task CloseAsync(CancellationToken cancellationToken = default) => _implementation.CloseAsync(cancellationToken);

    public override bool Equals(object? obj) => _implementation.Equals(obj);

    public override void Flush() => throw new NotImplementedException();

    public override Task FlushAsync(CancellationToken cancellationToken = default) => _implementation.FlushAsync(cancellationToken);

    public override int GetHashCode() => _implementation.GetHashCode();

    public override string? ToString() => _implementation.ToString();

    public override void WriteComment(string? text) => _implementation.WriteComment(text);

    public override Task WriteCommentAsync(string? text, CancellationToken cancellationToken = default) => _implementation.WriteCommentAsync(text, cancellationToken);

    public override void WriteEnd() => _implementation.WriteEnd();

    public override void WriteEndArray() => _implementation.WriteEndArray();

    public override Task WriteEndArrayAsync(CancellationToken cancellationToken = default) => _implementation.WriteEndArrayAsync(cancellationToken);

    public override Task WriteEndAsync(CancellationToken cancellationToken = default) => _implementation.WriteEndAsync(cancellationToken);

    public override void WriteEndConstructor() => throw new NotImplementedException();

    public override Task WriteEndConstructorAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();

    public override void WriteEndObject() => _implementation.WriteEndObject();

    public override Task WriteEndObjectAsync(CancellationToken cancellationToken = default) => _implementation.WriteEndObjectAsync(cancellationToken);

    public override void WriteNull() => _implementation.WriteNull();

    public override Task WriteNullAsync(CancellationToken cancellationToken = default) => _implementation.WriteNullAsync(cancellationToken);

    public override void WritePropertyName(string name) => _implementation.WritePropertyName(name);

    public override void WritePropertyName(string name, bool escape) => _implementation.WritePropertyName(name, escape);

    public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = default) => _implementation.WritePropertyNameAsync(name, cancellationToken);

    public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = default) => _implementation.WritePropertyNameAsync(name, escape, cancellationToken);

    public override void WriteRaw(string? json) => _implementation.WriteRaw(json);

    public override Task WriteRawAsync(string? json, CancellationToken cancellationToken = default) => _implementation.WriteRawAsync(json, cancellationToken);

    public override void WriteRawValue(string? json) => _implementation.WriteRawValue(json);

    public override Task WriteRawValueAsync(string? json, CancellationToken cancellationToken = default) => _implementation.WriteRawValueAsync(json, cancellationToken);

    public override void WriteStartArray() => _implementation.WriteStartArray();

    public override Task WriteStartArrayAsync(CancellationToken cancellationToken = default) => _implementation.WriteStartArrayAsync(cancellationToken);

    public override void WriteStartConstructor(string name) => throw new NotImplementedException();

    public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = default) => throw new NotImplementedException();

    public override void WriteStartObject() => _implementation.WriteStartObject();

    public override Task WriteStartObjectAsync(CancellationToken cancellationToken = default) => _implementation.WriteStartObjectAsync(cancellationToken);

    public override void WriteUndefined() => _implementation.WriteUndefined();

    public override Task WriteUndefinedAsync(CancellationToken cancellationToken = default) => _implementation.WriteUndefinedAsync(cancellationToken);

    public override void WriteValue(string? value) => _implementation.WriteValue(value);

    public override void WriteValue(int value) => _implementation.WriteValue(value);

    public override void WriteValue(uint value) => _implementation.WriteValue(value);

    public override void WriteValue(long value) => _implementation.WriteValue(value);

    public override void WriteValue(ulong value) => _implementation.WriteValue(value);

    public override void WriteValue(float value) => _implementation.WriteValue(value);

    public override void WriteValue(double value) => _implementation.WriteValue(value);

    public override void WriteValue(bool value) => _implementation.WriteValue(value);

    public override void WriteValue(short value) => _implementation.WriteValue(value);

    public override void WriteValue(ushort value) => _implementation.WriteValue(value);

    public override void WriteValue(char value) => _implementation.WriteValue(value);

    public override void WriteValue(byte value) => _implementation.WriteValue(value);

    public override void WriteValue(sbyte value) => _implementation.WriteValue(value);

    public override void WriteValue(decimal value) => _implementation.WriteValue(value);

    public override void WriteValue(DateTime value) => _implementation.WriteValue(value);

    public override void WriteValue(DateTimeOffset value) => _implementation.WriteValue(value);

    public override void WriteValue(Guid value) => _implementation.WriteValue(value);

    public override void WriteValue(TimeSpan value) => _implementation.WriteValue(value);

    public override void WriteValue(int? value) => _implementation.WriteValue(value);

    public override void WriteValue(uint? value) => _implementation.WriteValue(value);

    public override void WriteValue(long? value) => _implementation.WriteValue(value);

    public override void WriteValue(ulong? value) => _implementation.WriteValue(value);

    public override void WriteValue(float? value) => _implementation.WriteValue(value);

    public override void WriteValue(double? value) => _implementation.WriteValue(value);

    public override void WriteValue(bool? value) => _implementation.WriteValue(value);

    public override void WriteValue(short? value) => _implementation.WriteValue(value);

    public override void WriteValue(ushort? value) => _implementation.WriteValue(value);

    public override void WriteValue(char? value) => _implementation.WriteValue(value);

    public override void WriteValue(byte? value) => _implementation.WriteValue(value);

    public override void WriteValue(sbyte? value) => _implementation.WriteValue(value);

    public override void WriteValue(decimal? value) => _implementation.WriteValue(value);

    public override void WriteValue(DateTime? value) => _implementation.WriteValue(value);

    public override void WriteValue(DateTimeOffset? value) => _implementation.WriteValue(value);

    public override void WriteValue(Guid? value) => _implementation.WriteValue(value);

    public override void WriteValue(TimeSpan? value) => _implementation.WriteValue(value);

    public override void WriteValue(byte[]? value) => _implementation.WriteValue(value);

    public override void WriteValue(Uri? value) => _implementation.WriteValue(value);

    public override void WriteValue(object? value) => _implementation.WriteValue(value);

    public override Task WriteValueAsync(bool value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(bool? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(byte value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(byte? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(byte[]? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(char value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(char? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(DateTime? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(DateTimeOffset? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(decimal value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(decimal? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(double value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(double? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(float value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(float? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(Guid? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(int value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(int? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(long value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(long? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(object? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(sbyte? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(short value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(short? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(string? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(TimeSpan? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(uint value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(uint? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(ulong? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(Uri? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override Task WriteValueAsync(ushort? value, CancellationToken cancellationToken = default) => _implementation.WriteValueAsync(value, cancellationToken);

    public override void WriteWhitespace(string ws) => _implementation.WriteWhitespace(ws);

    public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = default) => _implementation.WriteWhitespaceAsync(ws, cancellationToken);

    protected override void Dispose(bool disposing) => throw new NotImplementedException();

}
