ClangSharpPInvokeGenerator `
--file `
gdextension_interface.h `
--methodClassName `
GDExtension `
--namespace `
GDExtension.Native `
--output `
../../GDExtension/Native `
--prefixStrip `
GDExtension `
--with-callconv `
=Cdecl `
--define-macro `
char32_t=uint32_t `
--config `
generate-helper-types `
multi-file `
generate-file-scoped-namespaces `

Pause