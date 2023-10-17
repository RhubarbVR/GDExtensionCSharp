namespace GDExtension.Native;

public unsafe partial struct GDExtensionGodotVersion
{
    [NativeTypeName("uint32_t")]
    public uint major;

    [NativeTypeName("uint32_t")]
    public uint minor;

    [NativeTypeName("uint32_t")]
    public uint patch;

    [NativeTypeName("const char *")]
    public sbyte* @string;
}
