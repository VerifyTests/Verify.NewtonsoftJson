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

    public class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public IList<string>? Roles { get; set; }
    }

    [Fact]
    public Task TestAdapter()
    {
        var newtonsoftJsonConverter = new KeysJsonConverter(typeof(Employee));
        var verifyJsonConverter = new ArgonJsonConverterAdapter(newtonsoftJsonConverter);
        Employee employee = new Employee
        {
            FirstName = "James",
            LastName = "Newton-King",
            Roles = new List<string>
            {
                "Admin"
            }
        };
        string json = Argon.JsonConvert.SerializeObject(employee, Argon.Formatting.Indented, verifyJsonConverter);
        return VerifyJson(json);
    }

    [Fact]
    public Task TestAdapterWithScrubber()
    {
        var newtonsoftJsonConverter = new KeysJsonConverter(typeof(Employee));
        var verifyJsonConverter = new ArgonJsonConverterAdapter(newtonsoftJsonConverter, new Newtonsoft.Json.JsonSerializer());
        Employee employee = new Employee
        {
            FirstName = "James",
            LastName = "Newton-King",
            Roles = new List<string>
            {
                "Admin",
                "Scrub"
            }
        };
        string json = Argon.JsonConvert.SerializeObject(employee, Argon.Formatting.Indented, verifyJsonConverter);
        var settings = new VerifySettings();
        settings.ScrubLinesContaining("Scrub");
        return VerifyJson(json, settings);
    }

    [Fact]
    public Task TestAdapterWithIgnoredMembers()
    {
        var newtonsoftJsonConverter = new KeysJsonConverter(typeof(Employee));
        var verifyJsonConverter = new ArgonJsonConverterAdapter(newtonsoftJsonConverter, new Newtonsoft.Json.JsonSerializer());
        Employee employee = new Employee
        {
            FirstName = "James",
            LastName = "Newton-King",
            Roles = new List<string>
            {
                "Admin",
                "Scrub"
            }
        };
        string json = Argon.JsonConvert.SerializeObject(employee, Argon.Formatting.Indented, verifyJsonConverter);
        var settings = new VerifySettings();
        settings.IgnoreMember("Roles");
        return VerifyJson(json, settings);
    }

    [Fact]
    public Task TestVerifierConfiguration()
    {
        Employee employee = new Employee
        {
            FirstName = "James",
            LastName = "Newton-King",
            Roles = new List<string>
            {
                "Admin"
            }
        };
        return Verify(employee);
    }
}