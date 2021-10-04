using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/objects/GitHub", DoNotGenerateAcw=true)]
	public partial class GitHub : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/objects/GitHub", typeof (GitHub));

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

		protected GitHub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']/constructor[@name='GitHub' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GitHub (string gitHubUser, string gitHubRepo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_gitHubUser = JNIEnv.NewString (gitHubUser);
			IntPtr native_gitHubRepo = JNIEnv.NewString (gitHubRepo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_gitHubUser);
				__args [1] = new JniArgumentValue (native_gitHubRepo);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_gitHubUser);
				JNIEnv.DeleteLocalRef (native_gitHubRepo);
			}
		}

		static Delegate cb_getGitHubRepo;
#pragma warning disable 0169
		static Delegate GetGetGitHubRepoHandler ()
		{
			if (cb_getGitHubRepo == null)
				cb_getGitHubRepo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGitHubRepo);
			return cb_getGitHubRepo;
		}

		static IntPtr n_GetGitHubRepo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.GitHub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GitHubRepo);
		}
#pragma warning restore 0169

		static Delegate cb_setGitHubRepo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGitHubRepo_Ljava_lang_String_Handler ()
		{
			if (cb_setGitHubRepo_Ljava_lang_String_ == null)
				cb_setGitHubRepo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGitHubRepo_Ljava_lang_String_);
			return cb_setGitHubRepo_Ljava_lang_String_;
		}

		static void n_SetGitHubRepo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_repo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.GitHub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var repo = JNIEnv.GetString (native_repo, JniHandleOwnership.DoNotTransfer);
			__this.GitHubRepo = repo;
		}
#pragma warning restore 0169

		public virtual unsafe string GitHubRepo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']/method[@name='getGitHubRepo' and count(parameter)=0]"
			[Register ("getGitHubRepo", "()Ljava/lang/String;", "GetGetGitHubRepoHandler")]
			get {
				const string __id = "getGitHubRepo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']/method[@name='setGitHubRepo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGitHubRepo", "(Ljava/lang/String;)V", "GetSetGitHubRepo_Ljava_lang_String_Handler")]
			set {
				const string __id = "setGitHubRepo.(Ljava/lang/String;)V";
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

		static Delegate cb_getGitHubUser;
#pragma warning disable 0169
		static Delegate GetGetGitHubUserHandler ()
		{
			if (cb_getGitHubUser == null)
				cb_getGitHubUser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGitHubUser);
			return cb_getGitHubUser;
		}

		static IntPtr n_GetGitHubUser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.GitHub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GitHubUser);
		}
#pragma warning restore 0169

		static Delegate cb_setGitHubUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGitHubUser_Ljava_lang_String_Handler ()
		{
			if (cb_setGitHubUser_Ljava_lang_String_ == null)
				cb_setGitHubUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGitHubUser_Ljava_lang_String_);
			return cb_setGitHubUser_Ljava_lang_String_;
		}

		static void n_SetGitHubUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_user)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.GitHub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			__this.GitHubUser = user;
		}
#pragma warning restore 0169

		public virtual unsafe string GitHubUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']/method[@name='getGitHubUser' and count(parameter)=0]"
			[Register ("getGitHubUser", "()Ljava/lang/String;", "GetGetGitHubUserHandler")]
			get {
				const string __id = "getGitHubUser.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']/method[@name='setGitHubUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGitHubUser", "(Ljava/lang/String;)V", "GetSetGitHubUser_Ljava_lang_String_Handler")]
			set {
				const string __id = "setGitHubUser.(Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.objects']/class[@name='GitHub']/method[@name='isGitHubValid' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.objects.GitHub']]"
		[Register ("isGitHubValid", "(Lcom/github/javiersantos/appupdater/objects/GitHub;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean IsGitHubValid (global::Com.Github.Javiersantos.Appupdater.Objects.GitHub gitHub)
		{
			const string __id = "isGitHubValid.(Lcom/github/javiersantos/appupdater/objects/GitHub;)Ljava/lang/Boolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((gitHub == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gitHub).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gitHub);
			}
		}

	}
}
