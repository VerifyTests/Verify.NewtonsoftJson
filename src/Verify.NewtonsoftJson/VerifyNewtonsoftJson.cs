namespace VerifyTests;

public static class VerifyNewtonsoftJson
{
    public static bool Initialized { get; private set; }

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();
        VerifierSettings
            .AddExtraSettings(_ =>
            {
                var converters = _.Converters;
                converters.Add(new JArrayConverter());
                converters.Add(new JObjectConverter());
            });
    }
}