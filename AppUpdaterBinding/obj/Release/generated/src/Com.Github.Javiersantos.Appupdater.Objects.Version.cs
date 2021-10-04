using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/objects/Version", DoNotGenerateAcw=true)]
	public partial class Version : global::Java.Lang.Object, global::Java.Lang.IComparable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/objects/Version", typeof (Version));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Version']/constructor[@name='Version' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Version (string version) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_version = JNIEnv.NewString (version);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_version);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_version);
			}
		}

		static Delegate cb_compareTo_Lcom_github_javiersantos_appupdater_objects_Version_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_github_javiersantos_appupdater_objects_Version_Handler ()
		{
			if (cb_compareTo_Lcom_github_javiersantos_appupdater_objects_Version_ == null)
				cb_compareTo_Lcom_github_javiersantos_appupdater_objects_Version_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lcom_github_javiersantos_appupdater_objects_Version_);
			return cb_compareTo_Lcom_github_javiersantos_appupdater_objects_Version_;
		}

		static int n_CompareTo_Lcom_github_javiersantos_appupdater_objects_Version_ (IntPtr jnienv, IntPtr native__this, IntPtr native_that)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Version> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var that = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Version> (native_that, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (that);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Version']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.objects.Version']]"
		[Register ("compareTo", "(Lcom/github/javiersantos/appupdater/objects/Version;)I", "GetCompareTo_Lcom_github_javiersantos_appupdater_objects_Version_Handler")]
		public virtual unsafe int CompareTo (global::Com.Github.Javiersantos.Appupdater.Objects.Version that)
		{
			const string __id = "compareTo.(Lcom/github/javiersantos/appupdater/objects/Version;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((that == null) ? IntPtr.Zero : ((global::Java.Lang.Object) that).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (that);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Version']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/String;", "")]
		public unsafe string Get ()
		{
			const string __id = "get.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

        public int CompareTo(Java.Lang.Object o)
        {
            throw new NotImplementedException();
        }
    }
}
