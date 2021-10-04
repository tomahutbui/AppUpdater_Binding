using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/objects/Update", DoNotGenerateAcw=true)]
	public partial class Update : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/objects/Update", typeof (Update));

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

		protected Update (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/constructor[@name='Update' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Update () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/constructor[@name='Update' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe Update (string latestVersion, global::Java.Lang.Integer latestVersionCode) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Integer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_latestVersion = JNIEnv.NewString (latestVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_latestVersion);
				__args [1] = new JniArgumentValue ((latestVersionCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latestVersionCode).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_latestVersion);
				global::System.GC.KeepAlive (latestVersionCode);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/constructor[@name='Update' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/net/URL;)V", "")]
		public unsafe Update (string latestVersion, global::Java.Lang.Integer latestVersionCode, string releaseNotes, global::Java.Net.URL apk) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_latestVersion = JNIEnv.NewString (latestVersion);
			IntPtr native_releaseNotes = JNIEnv.NewString (releaseNotes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_latestVersion);
				__args [1] = new JniArgumentValue ((latestVersionCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latestVersionCode).Handle);
				__args [2] = new JniArgumentValue (native_releaseNotes);
				__args [3] = new JniArgumentValue ((apk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apk).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_latestVersion);
				JNIEnv.DeleteLocalRef (native_releaseNotes);
				global::System.GC.KeepAlive (latestVersionCode);
				global::System.GC.KeepAlive (apk);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/constructor[@name='Update' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)V", "")]
		public unsafe Update (string latestVersion, string releaseNotes, global::Java.Net.URL apk) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_latestVersion = JNIEnv.NewString (latestVersion);
			IntPtr native_releaseNotes = JNIEnv.NewString (releaseNotes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_latestVersion);
				__args [1] = new JniArgumentValue (native_releaseNotes);
				__args [2] = new JniArgumentValue ((apk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apk).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_latestVersion);
				JNIEnv.DeleteLocalRef (native_releaseNotes);
				global::System.GC.KeepAlive (apk);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/constructor[@name='Update' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/net/URL;)V", "")]
		public unsafe Update (string latestVersion, global::Java.Net.URL apk) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_latestVersion = JNIEnv.NewString (latestVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_latestVersion);
				__args [1] = new JniArgumentValue ((apk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apk).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_latestVersion);
				global::System.GC.KeepAlive (apk);
			}
		}

		static Delegate cb_getLatestVersion;
#pragma warning disable 0169
		static Delegate GetGetLatestVersionHandler ()
		{
			if (cb_getLatestVersion == null)
				cb_getLatestVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLatestVersion);
			return cb_getLatestVersion;
		}

		static IntPtr n_GetLatestVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LatestVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setLatestVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLatestVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setLatestVersion_Ljava_lang_String_ == null)
				cb_setLatestVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLatestVersion_Ljava_lang_String_);
			return cb_setLatestVersion_Ljava_lang_String_;
		}

		static void n_SetLatestVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_latestVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var latestVersion = JNIEnv.GetString (native_latestVersion, JniHandleOwnership.DoNotTransfer);
			__this.LatestVersion = latestVersion;
		}
#pragma warning restore 0169

		public virtual unsafe string LatestVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='getLatestVersion' and count(parameter)=0]"
			[Register ("getLatestVersion", "()Ljava/lang/String;", "GetGetLatestVersionHandler")]
			get {
				const string __id = "getLatestVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='setLatestVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLatestVersion", "(Ljava/lang/String;)V", "GetSetLatestVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLatestVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLatestVersionCode;
#pragma warning disable 0169
		static Delegate GetGetLatestVersionCodeHandler ()
		{
			if (cb_getLatestVersionCode == null)
				cb_getLatestVersionCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLatestVersionCode);
			return cb_getLatestVersionCode;
		}

		static IntPtr n_GetLatestVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LatestVersionCode);
		}
#pragma warning restore 0169

		static Delegate cb_setLatestVersionCode_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetLatestVersionCode_Ljava_lang_Integer_Handler ()
		{
			if (cb_setLatestVersionCode_Ljava_lang_Integer_ == null)
				cb_setLatestVersionCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLatestVersionCode_Ljava_lang_Integer_);
			return cb_setLatestVersionCode_Ljava_lang_Integer_;
		}

		static void n_SetLatestVersionCode_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_versionCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var versionCode = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_versionCode, JniHandleOwnership.DoNotTransfer);
			__this.LatestVersionCode = versionCode;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer LatestVersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='getLatestVersionCode' and count(parameter)=0]"
			[Register ("getLatestVersionCode", "()Ljava/lang/Integer;", "GetGetLatestVersionCodeHandler")]
			get {
				const string __id = "getLatestVersionCode.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='setLatestVersionCode' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setLatestVersionCode", "(Ljava/lang/Integer;)V", "GetSetLatestVersionCode_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setLatestVersionCode.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getReleaseNotes;
#pragma warning disable 0169
		static Delegate GetGetReleaseNotesHandler ()
		{
			if (cb_getReleaseNotes == null)
				cb_getReleaseNotes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReleaseNotes);
			return cb_getReleaseNotes;
		}

		static IntPtr n_GetReleaseNotes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReleaseNotes);
		}
#pragma warning restore 0169

		static Delegate cb_setReleaseNotes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReleaseNotes_Ljava_lang_String_Handler ()
		{
			if (cb_setReleaseNotes_Ljava_lang_String_ == null)
				cb_setReleaseNotes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReleaseNotes_Ljava_lang_String_);
			return cb_setReleaseNotes_Ljava_lang_String_;
		}

		static void n_SetReleaseNotes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_releaseNotes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var releaseNotes = JNIEnv.GetString (native_releaseNotes, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseNotes = releaseNotes;
		}
#pragma warning restore 0169

		public virtual unsafe string ReleaseNotes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='getReleaseNotes' and count(parameter)=0]"
			[Register ("getReleaseNotes", "()Ljava/lang/String;", "GetGetReleaseNotesHandler")]
			get {
				const string __id = "getReleaseNotes.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='setReleaseNotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReleaseNotes", "(Ljava/lang/String;)V", "GetSetReleaseNotes_Ljava_lang_String_Handler")]
			set {
				const string __id = "setReleaseNotes.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrlToDownload;
#pragma warning disable 0169
		static Delegate GetGetUrlToDownloadHandler ()
		{
			if (cb_getUrlToDownload == null)
				cb_getUrlToDownload = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUrlToDownload);
			return cb_getUrlToDownload;
		}

		static IntPtr n_GetUrlToDownload (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UrlToDownload);
		}
#pragma warning restore 0169

		static Delegate cb_setUrlToDownload_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetSetUrlToDownload_Ljava_net_URL_Handler ()
		{
			if (cb_setUrlToDownload_Ljava_net_URL_ == null)
				cb_setUrlToDownload_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUrlToDownload_Ljava_net_URL_);
			return cb_setUrlToDownload_Ljava_net_URL_;
		}

		static void n_SetUrlToDownload_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var apk = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_apk, JniHandleOwnership.DoNotTransfer);
			__this.UrlToDownload = apk;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.URL UrlToDownload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='getUrlToDownload' and count(parameter)=0]"
			[Register ("getUrlToDownload", "()Ljava/net/URL;", "GetGetUrlToDownloadHandler")]
			get {
				const string __id = "getUrlToDownload.()Ljava/net/URL;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='Update']/method[@name='setUrlToDownload' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
			[Register ("setUrlToDownload", "(Ljava/net/URL;)V", "GetSetUrlToDownload_Ljava_net_URL_Handler")]
			set {
				const string __id = "setUrlToDownload.(Ljava/net/URL;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
