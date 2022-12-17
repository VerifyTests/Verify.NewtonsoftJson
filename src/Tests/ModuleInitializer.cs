using static Tests;

public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init()
    {

        VerifyNewtonsoftJson.Enable();

        #endregion

        VerifyDiffPlex.Initialize();

        #region adapter
        VerifierSettings.AddExtraSettings(
            _ =>
            {
                _.Converters.Add(
                    new ArgonJsonConverterAdapter(
                        new KeysJsonConverter(typeof(Employee))));
            });
        #endregion
    }
}