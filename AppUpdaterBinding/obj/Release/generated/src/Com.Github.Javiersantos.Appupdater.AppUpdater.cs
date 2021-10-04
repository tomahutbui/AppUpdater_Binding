using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/AppUpdater", DoNotGenerateAcw=true)]
	public partial class AppUpdater : global::Java.Lang.Object, global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/AppUpdater", typeof (AppUpdater));

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

		protected AppUpdater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/constructor[@name='AppUpdater' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppUpdater (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_dismiss;
#pragma warning disable 0169
		static Delegate GetDismissHandler ()
		{
			if (cb_dismiss == null)
				cb_dismiss = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dismiss);
			return cb_dismiss;
		}

		static void n_Dismiss (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "GetDismissHandler")]
		public virtual unsafe void Dismiss ()
		{
			const string __id = "dismiss.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Init);
			return cb_init;
		}

		static IntPtr n_Init (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Init ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()Lcom/github/javiersantos/appupdater/AppUpdater;", "GetInitHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater Init ()
		{
			const string __id = "init.()Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setButtonDismiss_I;
#pragma warning disable 0169
		static Delegate GetSetButtonDismiss_IHandler ()
		{
			if (cb_setButtonDismiss_I == null)
				cb_setButtonDismiss_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetButtonDismiss_I);
			return cb_setButtonDismiss_I;
		}

		static IntPtr n_SetButtonDismiss_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetButtonDismiss (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonDismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonDismiss", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDismiss_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismiss (int textResource)
		{
			const string __id = "setButtonDismiss.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setButtonDismiss_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetButtonDismiss_Ljava_lang_String_Handler ()
		{
			if (cb_setButtonDismiss_Ljava_lang_String_ == null)
				cb_setButtonDismiss_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDismiss_Ljava_lang_String_);
			return cb_setButtonDismiss_Ljava_lang_String_;
		}

		static IntPtr n_SetButtonDismiss_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDismiss (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonDismiss' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setButtonDismiss", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDismiss_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismiss (string text)
		{
			const string __id = "setButtonDismiss.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clickListener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_clickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDismissClickListener (clickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonDismissClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButtonDismissClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismissClickListener (global::Android.Content.IDialogInterfaceOnClickListener clickListener)
		{
			const string __id = "setButtonDismissClickListener.(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clickListener);
			}
		}

		static Delegate cb_setButtonDoNotShowAgain_I;
#pragma warning disable 0169
		static Delegate GetSetButtonDoNotShowAgain_IHandler ()
		{
			if (cb_setButtonDoNotShowAgain_I == null)
				cb_setButtonDoNotShowAgain_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetButtonDoNotShowAgain_I);
			return cb_setButtonDoNotShowAgain_I;
		}

		static IntPtr n_SetButtonDoNotShowAgain_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetButtonDoNotShowAgain (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonDoNotShowAgain", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDoNotShowAgain_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgain (int textResource)
		{
			const string __id = "setButtonDoNotShowAgain.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setButtonDoNotShowAgain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetButtonDoNotShowAgain_Ljava_lang_String_Handler ()
		{
			if (cb_setButtonDoNotShowAgain_Ljava_lang_String_ == null)
				cb_setButtonDoNotShowAgain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDoNotShowAgain_Ljava_lang_String_);
			return cb_setButtonDoNotShowAgain_Ljava_lang_String_;
		}

		static IntPtr n_SetButtonDoNotShowAgain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDoNotShowAgain (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setButtonDoNotShowAgain", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDoNotShowAgain_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgain (string text)
		{
			const string __id = "setButtonDoNotShowAgain.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clickListener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_clickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDoNotShowAgainClickListener (clickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonDoNotShowAgainClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButtonDoNotShowAgainClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgainClickListener (global::Android.Content.IDialogInterfaceOnClickListener clickListener)
		{
			const string __id = "setButtonDoNotShowAgainClickListener.(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clickListener);
			}
		}

		static Delegate cb_setButtonUpdate_I;
#pragma warning disable 0169
		static Delegate GetSetButtonUpdate_IHandler ()
		{
			if (cb_setButtonUpdate_I == null)
				cb_setButtonUpdate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetButtonUpdate_I);
			return cb_setButtonUpdate_I;
		}

		static IntPtr n_SetButtonUpdate_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetButtonUpdate (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonUpdate", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonUpdate_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdate (int textResource)
		{
			const string __id = "setButtonUpdate.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setButtonUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetButtonUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_setButtonUpdate_Ljava_lang_String_ == null)
				cb_setButtonUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonUpdate_Ljava_lang_String_);
			return cb_setButtonUpdate_Ljava_lang_String_;
		}

		static IntPtr n_SetButtonUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonUpdate (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setButtonUpdate", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonUpdate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdate (string text)
		{
			const string __id = "setButtonUpdate.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clickListener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_clickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonUpdateClickListener (clickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setButtonUpdateClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButtonUpdateClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdateClickListener (global::Android.Content.IDialogInterfaceOnClickListener clickListener)
		{
			const string __id = "setButtonUpdateClickListener.(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clickListener);
			}
		}

		static Delegate cb_setCancelable_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetCancelable_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setCancelable_Ljava_lang_Boolean_ == null)
				cb_setCancelable_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCancelable_Ljava_lang_Boolean_);
			return cb_setCancelable_Ljava_lang_Boolean_;
		}

		static IntPtr n_SetCancelable_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_isDialogCancelable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var isDialogCancelable = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_isDialogCancelable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCancelable (isDialogCancelable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setCancelable' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setCancelable", "(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetCancelable_Ljava_lang_Boolean_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetCancelable (global::Java.Lang.Boolean isDialogCancelable)
		{
			const string __id = "setCancelable.(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((isDialogCancelable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isDialogCancelable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (isDialogCancelable);
			}
		}

		static Delegate cb_setContentOnUpdateAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateAvailable_IHandler ()
		{
			if (cb_setContentOnUpdateAvailable_I == null)
				cb_setContentOnUpdateAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContentOnUpdateAvailable_I);
			return cb_setContentOnUpdateAvailable_I;
		}

		static IntPtr n_SetContentOnUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setContentOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentOnUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateAvailable (int textResource)
		{
			const string __id = "setContentOnUpdateAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContentOnUpdateAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setContentOnUpdateAvailable_Ljava_lang_String_ == null)
				cb_setContentOnUpdateAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContentOnUpdateAvailable_Ljava_lang_String_);
			return cb_setContentOnUpdateAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetContentOnUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateAvailable (description));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setContentOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentOnUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateAvailable (string description)
		{
			const string __id = "setContentOnUpdateAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_description = JNIEnv.NewString (description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_description);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
			}
		}

		static Delegate cb_setContentOnUpdateNotAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateNotAvailable_IHandler ()
		{
			if (cb_setContentOnUpdateNotAvailable_I == null)
				cb_setContentOnUpdateNotAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContentOnUpdateNotAvailable_I);
			return cb_setContentOnUpdateNotAvailable_I;
		}

		static IntPtr n_SetContentOnUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateNotAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setContentOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentOnUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateNotAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateNotAvailable (int textResource)
		{
			const string __id = "setContentOnUpdateNotAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContentOnUpdateNotAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateNotAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setContentOnUpdateNotAvailable_Ljava_lang_String_ == null)
				cb_setContentOnUpdateNotAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContentOnUpdateNotAvailable_Ljava_lang_String_);
			return cb_setContentOnUpdateNotAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetContentOnUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateNotAvailable (description));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setContentOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentOnUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateNotAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateNotAvailable (string description)
		{
			const string __id = "setContentOnUpdateNotAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_description = JNIEnv.NewString (description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_description);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
			}
		}

		static Delegate cb_setDialogButtonDismiss_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogButtonDismiss_IHandler ()
		{
			if (cb_setDialogButtonDismiss_I == null)
				cb_setDialogButtonDismiss_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogButtonDismiss_I);
			return cb_setDialogButtonDismiss_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogButtonDismiss_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDismiss (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogButtonDismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDismiss", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDismiss_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDismiss (int textResource)
		{
			const string __id = "setDialogButtonDismiss.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogButtonDismiss_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogButtonDismiss_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogButtonDismiss_Ljava_lang_String_ == null)
				cb_setDialogButtonDismiss_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogButtonDismiss_Ljava_lang_String_);
			return cb_setDialogButtonDismiss_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogButtonDismiss_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDismiss (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogButtonDismiss' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDismiss", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDismiss_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDismiss (string text)
		{
			const string __id = "setDialogButtonDismiss.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setDialogButtonDoNotShowAgain_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogButtonDoNotShowAgain_IHandler ()
		{
			if (cb_setDialogButtonDoNotShowAgain_I == null)
				cb_setDialogButtonDoNotShowAgain_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogButtonDoNotShowAgain_I);
			return cb_setDialogButtonDoNotShowAgain_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogButtonDoNotShowAgain_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDoNotShowAgain (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDoNotShowAgain", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDoNotShowAgain_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDoNotShowAgain (int textResource)
		{
			const string __id = "setDialogButtonDoNotShowAgain.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogButtonDoNotShowAgain_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogButtonDoNotShowAgain_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogButtonDoNotShowAgain_Ljava_lang_String_ == null)
				cb_setDialogButtonDoNotShowAgain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogButtonDoNotShowAgain_Ljava_lang_String_);
			return cb_setDialogButtonDoNotShowAgain_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogButtonDoNotShowAgain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDoNotShowAgain (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDoNotShowAgain", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDoNotShowAgain_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDoNotShowAgain (string text)
		{
			const string __id = "setDialogButtonDoNotShowAgain.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setDialogButtonUpdate_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogButtonUpdate_IHandler ()
		{
			if (cb_setDialogButtonUpdate_I == null)
				cb_setDialogButtonUpdate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogButtonUpdate_I);
			return cb_setDialogButtonUpdate_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogButtonUpdate_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonUpdate (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogButtonUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonUpdate", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonUpdate_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonUpdate (int textResource)
		{
			const string __id = "setDialogButtonUpdate.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogButtonUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogButtonUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogButtonUpdate_Ljava_lang_String_ == null)
				cb_setDialogButtonUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogButtonUpdate_Ljava_lang_String_);
			return cb_setDialogButtonUpdate_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogButtonUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogButtonUpdate (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogButtonUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonUpdate", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonUpdate_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonUpdate (string text)
		{
			const string __id = "setDialogButtonUpdate.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setDialogDescriptionWhenUpdateAvailable_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogDescriptionWhenUpdateAvailable_IHandler ()
		{
			if (cb_setDialogDescriptionWhenUpdateAvailable_I == null)
				cb_setDialogDescriptionWhenUpdateAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogDescriptionWhenUpdateAvailable_I);
			return cb_setDialogDescriptionWhenUpdateAvailable_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogDescriptionWhenUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogDescriptionWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateAvailable (int textResource)
		{
			const string __id = "setDialogDescriptionWhenUpdateAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_ == null)
				cb_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_);
			return cb_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateAvailable (description));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogDescriptionWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateAvailable (string description)
		{
			const string __id = "setDialogDescriptionWhenUpdateAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_description = JNIEnv.NewString (description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_description);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
			}
		}

		static Delegate cb_setDialogDescriptionWhenUpdateNotAvailable_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogDescriptionWhenUpdateNotAvailable_IHandler ()
		{
			if (cb_setDialogDescriptionWhenUpdateNotAvailable_I == null)
				cb_setDialogDescriptionWhenUpdateNotAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogDescriptionWhenUpdateNotAvailable_I);
			return cb_setDialogDescriptionWhenUpdateNotAvailable_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogDescriptionWhenUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateNotAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogDescriptionWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateNotAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateNotAvailable (int textResource)
		{
			const string __id = "setDialogDescriptionWhenUpdateNotAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_ == null)
				cb_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_);
			return cb_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateNotAvailable (description));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogDescriptionWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateNotAvailable (string description)
		{
			const string __id = "setDialogDescriptionWhenUpdateNotAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_description = JNIEnv.NewString (description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_description);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
			}
		}

		static Delegate cb_setDialogTitleWhenUpdateAvailable_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogTitleWhenUpdateAvailable_IHandler ()
		{
			if (cb_setDialogTitleWhenUpdateAvailable_I == null)
				cb_setDialogTitleWhenUpdateAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogTitleWhenUpdateAvailable_I);
			return cb_setDialogTitleWhenUpdateAvailable_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogTitleWhenUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogTitleWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateAvailable (int textResource)
		{
			const string __id = "setDialogTitleWhenUpdateAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogTitleWhenUpdateAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_ == null)
				cb_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogTitleWhenUpdateAvailable_Ljava_lang_String_);
			return cb_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogTitleWhenUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateAvailable (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogTitleWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateAvailable (string title)
		{
			const string __id = "setDialogTitleWhenUpdateAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_setDialogTitleWhenUpdateNotAvailable_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogTitleWhenUpdateNotAvailable_IHandler ()
		{
			if (cb_setDialogTitleWhenUpdateNotAvailable_I == null)
				cb_setDialogTitleWhenUpdateNotAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetDialogTitleWhenUpdateNotAvailable_I);
			return cb_setDialogTitleWhenUpdateNotAvailable_I;
		}

		[Obsolete]
		static IntPtr n_SetDialogTitleWhenUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateNotAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogTitleWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateNotAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateNotAvailable (int textResource)
		{
			const string __id = "setDialogTitleWhenUpdateNotAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_ == null)
				cb_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_);
			return cb_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_SetDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateNotAvailable (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDialogTitleWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateNotAvailable (string title)
		{
			const string __id = "setDialogTitleWhenUpdateNotAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_;
#pragma warning disable 0169
		static Delegate GetSetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_Handler ()
		{
			if (cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ == null)
				cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_);
			return cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_;
		}

		static IntPtr n_SetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ (IntPtr jnienv, IntPtr native__this, IntPtr native_display)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var display = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Display> (native_display, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDisplay (display));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.Display']]"
		[Register ("setDisplay", "(Lcom/github/javiersantos/appupdater/enums/Display;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDisplay (global::Com.Github.Javiersantos.Appupdater.Enums.Display display)
		{
			const string __id = "setDisplay.(Lcom/github/javiersantos/appupdater/enums/Display;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((display == null) ? IntPtr.Zero : ((global::Java.Lang.Object) display).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (display);
			}
		}

		static Delegate cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_;
#pragma warning disable 0169
		static Delegate GetSetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_Handler ()
		{
			if (cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ == null)
				cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_);
			return cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_;
		}

		static IntPtr n_SetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_duration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var duration = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Duration> (native_duration, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDuration (duration));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.Duration']]"
		[Register ("setDuration", "(Lcom/github/javiersantos/appupdater/enums/Duration;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDuration (global::Com.Github.Javiersantos.Appupdater.Enums.Duration duration)
		{
			const string __id = "setDuration.(Lcom/github/javiersantos/appupdater/enums/Duration;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((duration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) duration).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (duration);
			}
		}

		static Delegate cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_);
			return cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_user, IntPtr native_repo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			var repo = JNIEnv.GetString (native_repo, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitHubUserAndRepo (user, repo));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setGitHubUserAndRepo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGitHubUserAndRepo", "(Ljava/lang/String;Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetGitHubUserAndRepo (string user, string repo)
		{
			const string __id = "setGitHubUserAndRepo.(Ljava/lang/String;Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_repo = JNIEnv.NewString (repo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_user);
				__args [1] = new JniArgumentValue (native_repo);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_repo);
			}
		}

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static IntPtr n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIcon (iconRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetIcon_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetIcon (int iconRes)
		{
			const string __id = "setIcon.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (iconRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitleOnUpdateAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateAvailable_IHandler ()
		{
			if (cb_setTitleOnUpdateAvailable_I == null)
				cb_setTitleOnUpdateAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTitleOnUpdateAvailable_I);
			return cb_setTitleOnUpdateAvailable_I;
		}

		static IntPtr n_SetTitleOnUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setTitleOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleOnUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateAvailable (int textResource)
		{
			const string __id = "setTitleOnUpdateAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitleOnUpdateAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleOnUpdateAvailable_Ljava_lang_String_ == null)
				cb_setTitleOnUpdateAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitleOnUpdateAvailable_Ljava_lang_String_);
			return cb_setTitleOnUpdateAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetTitleOnUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateAvailable (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setTitleOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleOnUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateAvailable (string title)
		{
			const string __id = "setTitleOnUpdateAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_setTitleOnUpdateNotAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateNotAvailable_IHandler ()
		{
			if (cb_setTitleOnUpdateNotAvailable_I == null)
				cb_setTitleOnUpdateNotAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTitleOnUpdateNotAvailable_I);
			return cb_setTitleOnUpdateNotAvailable_I;
		}

		static IntPtr n_SetTitleOnUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int textResource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateNotAvailable (textResource));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setTitleOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleOnUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateNotAvailable_IHandler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateNotAvailable (int textResource)
		{
			const string __id = "setTitleOnUpdateNotAvailable.(I)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textResource);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateNotAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_ == null)
				cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitleOnUpdateNotAvailable_Ljava_lang_String_);
			return cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetTitleOnUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateNotAvailable (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setTitleOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleOnUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateNotAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateNotAvailable (string title)
		{
			const string __id = "setTitleOnUpdateNotAvailable.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_;
#pragma warning disable 0169
		static Delegate GetSetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_Handler ()
		{
			if (cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ == null)
				cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_);
			return cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_;
		}

		static IntPtr n_SetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_updateFrom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var updateFrom = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (native_updateFrom, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateFrom (updateFrom));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setUpdateFrom' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.UpdateFrom']]"
		[Register ("setUpdateFrom", "(Lcom/github/javiersantos/appupdater/enums/UpdateFrom;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateFrom (global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom updateFrom)
		{
			const string __id = "setUpdateFrom.(Lcom/github/javiersantos/appupdater/enums/UpdateFrom;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((updateFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) updateFrom).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (updateFrom);
			}
		}

		static Delegate cb_setUpdateJSON_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateJSON_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateJSON_Ljava_lang_String_ == null)
				cb_setUpdateJSON_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpdateJSON_Ljava_lang_String_);
			return cb_setUpdateJSON_Ljava_lang_String_;
		}

		static IntPtr n_SetUpdateJSON_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var jsonUrl = JNIEnv.GetString (native_jsonUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateJSON (jsonUrl));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setUpdateJSON' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpdateJSON", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetUpdateJSON_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateJSON (string jsonUrl)
		{
			const string __id = "setUpdateJSON.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_jsonUrl = JNIEnv.NewString (jsonUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonUrl);
			}
		}

		static Delegate cb_setUpdateXML_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateXML_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateXML_Ljava_lang_String_ == null)
				cb_setUpdateXML_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpdateXML_Ljava_lang_String_);
			return cb_setUpdateXML_Ljava_lang_String_;
		}

		static IntPtr n_SetUpdateXML_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_xmlUrl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var xmlUrl = JNIEnv.GetString (native_xmlUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateXML (xmlUrl));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='setUpdateXML' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpdateXML", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetUpdateXML_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateXML (string xmlUrl)
		{
			const string __id = "setUpdateXML.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			IntPtr native_xmlUrl = JNIEnv.NewString (xmlUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_xmlUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_xmlUrl);
			}
		}

		static Delegate cb_showAppUpdated_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetShowAppUpdated_Ljava_lang_Boolean_Handler ()
		{
			if (cb_showAppUpdated_Ljava_lang_Boolean_ == null)
				cb_showAppUpdated_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ShowAppUpdated_Ljava_lang_Boolean_);
			return cb_showAppUpdated_Ljava_lang_Boolean_;
		}

		static IntPtr n_ShowAppUpdated_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_res)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var res = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_res, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowAppUpdated (res));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='showAppUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("showAppUpdated", "(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetShowAppUpdated_Ljava_lang_Boolean_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater ShowAppUpdated (global::Java.Lang.Boolean res)
		{
			const string __id = "showAppUpdated.(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (res);
			}
		}

		static Delegate cb_showEvery_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetShowEvery_Ljava_lang_Integer_Handler ()
		{
			if (cb_showEvery_Ljava_lang_Integer_ == null)
				cb_showEvery_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ShowEvery_Ljava_lang_Integer_);
			return cb_showEvery_Ljava_lang_Integer_;
		}

		static IntPtr n_ShowEvery_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_times)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var times = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_times, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowEvery (times));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='showEvery' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("showEvery", "(Ljava/lang/Integer;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetShowEvery_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater ShowEvery (global::Java.Lang.Integer times)
		{
			const string __id = "showEvery.(Ljava/lang/Integer;)Lcom/github/javiersantos/appupdater/AppUpdater;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((times == null) ? IntPtr.Zero : ((global::Java.Lang.Object) times).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (times);
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdater']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
