namespace GDExtension.Native;

public unsafe partial struct GDExtensionCallableCustomInfo
{
    public void* callable_userdata;

    public void* token;

    [NativeTypeName("GDExtensionObjectPtr")]
    public void* @object;

    [NativeTypeName("GDExtensionCallableCustomCall")]
    public delegate* unmanaged[Cdecl]<void*, void**, long, void*, GDExtensionCallError*, void> call_func;

    [NativeTypeName("GDExtensionCallableCustomIsValid")]
    public delegate* unmanaged[Cdecl]<void*, byte> is_valid_func;

    [NativeTypeName("GDExtensionCallableCustomFree")]
    public delegate* unmanaged[Cdecl]<void*, void> free_func;

    [NativeTypeName("GDExtensionCallableCustomHash")]
    public delegate* unmanaged[Cdecl]<void*, uint> hash_func;

    [NativeTypeName("GDExtensionCallableCustomEqual")]
    public delegate* unmanaged[Cdecl]<void*, void*, byte> equal_func;

    [NativeTypeName("GDExtensionCallableCustomLessThan")]
    public delegate* unmanaged[Cdecl]<void*, void*, byte> less_than_func;

    [NativeTypeName("GDExtensionCallableCustomToString")]
    public delegate* unmanaged[Cdecl]<void*, byte*, void*, void> to_string_func;
}
