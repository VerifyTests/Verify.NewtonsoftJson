public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init() =>
        VerifyNewtonsoftJson.Enable();

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifyDiffPlex.Initialize();
}