namespace VerifyTests;

public static class VerifyNewtonsoftJson
{
    public static void Enable()
    {
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