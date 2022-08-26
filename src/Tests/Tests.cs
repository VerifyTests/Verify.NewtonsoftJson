using Newtonsoft.Json.Linq;

[UsesVerify]
public class Tests
{
    string json = @"{
  'short': {
    'original': 'http://www.foo.com/',
    'short': 'foo',
    'error': {
      'code': 0,
      'msg': 'No action taken'
    }
  }
}";

    [Fact]
    public Task TestJToken() =>
        Verify(JToken.Parse(json));

    string jsonArray = @"[
  'Small',
  'Medium',
  'Large'
]";

    [Fact]
    public Task TestJArray() =>
        Verify(JArray.Parse(jsonArray));
}