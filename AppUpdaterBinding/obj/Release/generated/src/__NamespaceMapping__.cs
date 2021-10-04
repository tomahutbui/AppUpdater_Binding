using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.github.javiersantos.appupdater", Managed="Com.Github.Javiersantos.Appupdater")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.github.javiersantos.appupdater.enums", Managed="Com.Github.Javiersantos.Appupdater.Enums")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.github.javiersantos.appupdater.interfaces", Managed="Com.Github.Javiersantos.Appupdater.Interfaces")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.github.javiersantos.appupdater.objects", Managed="Com.Github.Javiersantos.Appupdater.Objects")]

delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

