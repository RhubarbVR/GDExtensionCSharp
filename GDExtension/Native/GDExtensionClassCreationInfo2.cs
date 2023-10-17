namespace GDExtension.Native;

public unsafe partial struct GDExtensionClassCreationInfo2
{
    [NativeTypeName("GDExtensionBool")]
    public byte is_virtual;

    [NativeTypeName("GDExtensionBool")]
    public byte is_abstract;

    [NativeTypeName("GDExtensionBool")]
    public byte is_exposed;

    [NativeTypeName("GDExtensionClassSet")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, byte> set_func;

    [NativeTypeName("GDExtensionClassGet")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, byte> get_func;

    [NativeTypeName("GDExtensionClassGetPropertyList")]
    public delegate* unmanaged[Cdecl]<void*, uint*, GDExtensionPropertyInfo*> get_property_list_func;

    [NativeTypeName("GDExtensionClassFreePropertyList")]
    public delegate* unmanaged[Cdecl]<void*, GDExtensionPropertyInfo*, void> free_property_list_func;

    [NativeTypeName("GDExtensionClassPropertyCanRevert")]
    public delegate* unmanaged[Cdecl]<void*, void*, byte> property_can_revert_func;

    [NativeTypeName("GDExtensionClassPropertyGetRevert")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, byte> property_get_revert_func;

    [NativeTypeName("GDExtensionClassValidateProperty")]
    public delegate* unmanaged[Cdecl]<void*, GDExtensionPropertyInfo*, byte> validate_property_func;

    [NativeTypeName("GDExtensionClassNotification2")]
    public delegate* unmanaged[Cdecl]<void*, int, byte, void> notification_func;

    [NativeTypeName("GDExtensionClassToString")]
    public delegate* unmanaged[Cdecl]<void*, byte*, void*, void> to_string_func;

    [NativeTypeName("GDExtensionClassReference")]
    public delegate* unmanaged[Cdecl]<void*, void> reference_func;

    [NativeTypeName("GDExtensionClassUnreference")]
    public delegate* unmanaged[Cdecl]<void*, void> unreference_func;

    [NativeTypeName("GDExtensionClassCreateInstance")]
    public delegate* unmanaged[Cdecl]<void*, void*> create_instance_func;

    [NativeTypeName("GDExtensionClassFreeInstance")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> free_instance_func;

    [NativeTypeName("GDExtensionClassRecreateInstance")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*> recreate_instance_func;

    [NativeTypeName("GDExtensionClassGetVirtual")]
    public delegate* unmanaged[Cdecl]<void*, void*, delegate* unmanaged[Cdecl]<void*, void**, void*, void>> get_virtual_func;

    [NativeTypeName("GDExtensionClassGetVirtualCallData")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*> get_virtual_call_data_func;

    [NativeTypeName("GDExtensionClassCallVirtualWithData")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, void**, void*, void> call_virtual_with_data_func;

    [NativeTypeName("GDExtensionClassGetRID")]
    public delegate* unmanaged[Cdecl]<void*, ulong> get_rid_func;

    public void* class_userdata;
}
