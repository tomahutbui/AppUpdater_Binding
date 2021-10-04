using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater.LibraryListener']"
	[Register ("com/github/javiersantos/appupdater/interfaces/IAppUpdater$LibraryListener", "", "Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerInvoker")]
	public partial interface IAppUpdaterLibraryListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater.LibraryListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.AppUpdaterError']]"
		[Register ("onFailed", "(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V", "GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerInvoker, AppUpdaterBinding")]
		void OnFailed (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater.LibraryListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.objects.Update']]"
		[Register ("onSuccess", "(Lcom/github/javiersantos/appupdater/objects/Update;)V", "GetOnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerInvoker, AppUpdaterBinding")]
		void OnSuccess (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0);

	}

	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/interfaces/IAppUpdater$LibraryListener", DoNotGenerateAcw=true)]
	internal partial class IAppUpdaterLibraryListenerInvoker : global::Java.Lang.Object, IAppUpdaterLibraryListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/interfaces/IAppUpdater$LibraryListener", typeof (IAppUpdaterLibraryListenerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAppUpdaterLibraryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppUpdaterLibraryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.javiersantos.appupdater.interfaces.IAppUpdater.LibraryListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppUpdaterLibraryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler ()
		{
			if (cb_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_ == null)
				cb_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_);
			return cb_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_;
		}

		static void n_OnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_;
		public unsafe void OnFailed (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0)
		{
			if (id_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_ == IntPtr.Zero)
				id_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_, __args);
		}

		static Delegate cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Handler ()
		{
			if (cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_ == null)
				cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_);
			return cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_;
		}

		static void n_OnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_;
		public unsafe void OnSuccess (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0)
		{
			if (id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_ == IntPtr.Zero)
				id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/github/javiersantos/appupdater/objects/Update;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_, __args);
		}

	}

	// event args for com.github.javiersantos.appupdater.interfaces.IAppUpdater.LibraryListener.onFailed
	public partial class FailedEventArgs : global::System.EventArgs {
		public FailedEventArgs (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0)
		{
			this.p0 = p0;
		}

		global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0;

		public global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError P0 {
			get { return p0; }
		}

	}

	// event args for com.github.javiersantos.appupdater.interfaces.IAppUpdater.LibraryListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {
		public SuccessEventArgs (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0)
		{
			this.p0 = p0;
		}

		global::Com.Github.Javiersantos.Appupdater.Objects.Update p0;

		public global::Com.Github.Javiersantos.Appupdater.Objects.Update P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/github/javiersantos/appupdater/interfaces/IAppUpdater_LibraryListenerImplementor")]
	internal sealed partial class IAppUpdaterLibraryListenerImplementor : global::Java.Lang.Object, IAppUpdaterLibraryListener {

		object sender;

		public IAppUpdaterLibraryListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/github/javiersantos/appupdater/interfaces/IAppUpdater_LibraryListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<FailedEventArgs> OnFailedHandler;
		#pragma warning restore 0649

		public void OnFailed (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0)
		{
			var __h = OnFailedHandler;
			if (__h != null)
				__h (sender, new FailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
		#pragma warning restore 0649

		public void OnSuccess (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IAppUpdaterLibraryListenerImplementor value)
		{
			return value.OnFailedHandler == null && value.OnSuccessHandler == null;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']"
	[Register ("com/github/javiersantos/appupdater/interfaces/IAppUpdater", "", "Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker")]
	public partial interface IAppUpdater : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "GetDismissHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		void Dismiss ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='init' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("init", "()Lcom/github/javiersantos/appupdater/AppUpdater;", "GetInitHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater Init ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonDismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonDismiss", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDismiss_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismiss (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonDismiss' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setButtonDismiss", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDismiss_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismiss (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonDismissClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButtonDismissClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismissClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonDoNotShowAgain", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDoNotShowAgain_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgain (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setButtonDoNotShowAgain", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDoNotShowAgain_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgain (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonDoNotShowAgainClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButtonDoNotShowAgainClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgainClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setButtonUpdate", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonUpdate_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdate (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setButtonUpdate", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonUpdate_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdate (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setButtonUpdateClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButtonUpdateClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdateClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setCancelable' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setCancelable", "(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetCancelable_Ljava_lang_Boolean_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetCancelable (global::Java.Lang.Boolean p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setContentOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentOnUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setContentOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentOnUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setContentOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentOnUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateNotAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateNotAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setContentOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentOnUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetContentOnUpdateNotAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateNotAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogButtonDismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDismiss", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDismiss_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDismiss (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogButtonDismiss' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDismiss", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDismiss_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDismiss (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDoNotShowAgain", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDoNotShowAgain_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDoNotShowAgain (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogButtonDoNotShowAgain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonDoNotShowAgain", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonDoNotShowAgain_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDoNotShowAgain (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogButtonUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonUpdate", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonUpdate_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonUpdate (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogButtonUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogButtonUpdate", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogButtonUpdate_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonUpdate (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogDescriptionWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogDescriptionWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogDescriptionWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateNotAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateNotAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogDescriptionWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogDescriptionWhenUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateNotAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogTitleWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogTitleWhenUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogTitleWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateNotAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateNotAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDialogTitleWhenUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setDialogTitleWhenUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateNotAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.Display']]"
		[Register ("setDisplay", "(Lcom/github/javiersantos/appupdater/enums/Display;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDisplay (global::Com.Github.Javiersantos.Appupdater.Enums.Display p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.Duration']]"
		[Register ("setDuration", "(Lcom/github/javiersantos/appupdater/enums/Duration;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDuration (global::Com.Github.Javiersantos.Appupdater.Enums.Duration p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setGitHubUserAndRepo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGitHubUserAndRepo", "(Ljava/lang/String;Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetGitHubUserAndRepo (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetIcon_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetIcon (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setTitleOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleOnUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setTitleOnUpdateAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleOnUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setTitleOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleOnUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateNotAvailable_IHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateNotAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setTitleOnUpdateNotAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleOnUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetTitleOnUpdateNotAvailable_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateNotAvailable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setUpdateFrom' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.UpdateFrom']]"
		[Register ("setUpdateFrom", "(Lcom/github/javiersantos/appupdater/enums/UpdateFrom;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateFrom (global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setUpdateJSON' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpdateJSON", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetUpdateJSON_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateJSON (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='setUpdateXML' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpdateXML", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetSetUpdateXML_Ljava_lang_String_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateXML (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='showAppUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("showAppUpdated", "(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetShowAppUpdated_Ljava_lang_Boolean_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater ShowAppUpdated (global::Java.Lang.Boolean p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='showEvery' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("showEvery", "(Ljava/lang/Integer;)Lcom/github/javiersantos/appupdater/AppUpdater;", "GetShowEvery_Ljava_lang_Integer_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		global::Com.Github.Javiersantos.Appupdater.AppUpdater ShowEvery (global::Java.Lang.Integer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.interfaces']/interface[@name='IAppUpdater']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterInvoker, AppUpdaterBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/interfaces/IAppUpdater", DoNotGenerateAcw=true)]
	internal partial class IAppUpdaterInvoker : global::Java.Lang.Object, IAppUpdater {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/interfaces/IAppUpdater", typeof (IAppUpdaterInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAppUpdater GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppUpdater> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.javiersantos.appupdater.interfaces.IAppUpdater'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppUpdaterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss ();
		}
#pragma warning restore 0169

		IntPtr id_dismiss;
		public unsafe void Dismiss ()
		{
			if (id_dismiss == IntPtr.Zero)
				id_dismiss = JNIEnv.GetMethodID (class_ref, "dismiss", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dismiss);
		}

		static Delegate cb_init;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Init);
			return cb_init;
		}

		[Obsolete]
		static IntPtr n_Init (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Init ());
		}
#pragma warning restore 0169

		IntPtr id_init;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()Lcom/github/javiersantos/appupdater/AppUpdater;");
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_init), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setButtonDismiss_I;
#pragma warning disable 0169
		static Delegate GetSetButtonDismiss_IHandler ()
		{
			if (cb_setButtonDismiss_I == null)
				cb_setButtonDismiss_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetButtonDismiss_I);
			return cb_setButtonDismiss_I;
		}

		static IntPtr n_SetButtonDismiss_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetButtonDismiss (p0));
		}
#pragma warning restore 0169

		IntPtr id_setButtonDismiss_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismiss (int p0)
		{
			if (id_setButtonDismiss_I == IntPtr.Zero)
				id_setButtonDismiss_I = JNIEnv.GetMethodID (class_ref, "setButtonDismiss", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonDismiss_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setButtonDismiss_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetButtonDismiss_Ljava_lang_String_Handler ()
		{
			if (cb_setButtonDismiss_Ljava_lang_String_ == null)
				cb_setButtonDismiss_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDismiss_Ljava_lang_String_);
			return cb_setButtonDismiss_Ljava_lang_String_;
		}

		static IntPtr n_SetButtonDismiss_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDismiss (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setButtonDismiss_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismiss (string p0)
		{
			if (id_setButtonDismiss_Ljava_lang_String_ == IntPtr.Zero)
				id_setButtonDismiss_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setButtonDismiss", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonDismiss_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDismissClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDismissClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0)
		{
			if (id_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setButtonDismissClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonDismissClickListener_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setButtonDoNotShowAgain_I;
#pragma warning disable 0169
		static Delegate GetSetButtonDoNotShowAgain_IHandler ()
		{
			if (cb_setButtonDoNotShowAgain_I == null)
				cb_setButtonDoNotShowAgain_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetButtonDoNotShowAgain_I);
			return cb_setButtonDoNotShowAgain_I;
		}

		static IntPtr n_SetButtonDoNotShowAgain_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetButtonDoNotShowAgain (p0));
		}
#pragma warning restore 0169

		IntPtr id_setButtonDoNotShowAgain_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgain (int p0)
		{
			if (id_setButtonDoNotShowAgain_I == IntPtr.Zero)
				id_setButtonDoNotShowAgain_I = JNIEnv.GetMethodID (class_ref, "setButtonDoNotShowAgain", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonDoNotShowAgain_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setButtonDoNotShowAgain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetButtonDoNotShowAgain_Ljava_lang_String_Handler ()
		{
			if (cb_setButtonDoNotShowAgain_Ljava_lang_String_ == null)
				cb_setButtonDoNotShowAgain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDoNotShowAgain_Ljava_lang_String_);
			return cb_setButtonDoNotShowAgain_Ljava_lang_String_;
		}

		static IntPtr n_SetButtonDoNotShowAgain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDoNotShowAgain (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setButtonDoNotShowAgain_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgain (string p0)
		{
			if (id_setButtonDoNotShowAgain_Ljava_lang_String_ == IntPtr.Zero)
				id_setButtonDoNotShowAgain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setButtonDoNotShowAgain", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonDoNotShowAgain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonDoNotShowAgainClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonDoNotShowAgainClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0)
		{
			if (id_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setButtonDoNotShowAgainClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonDoNotShowAgainClickListener_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setButtonUpdate_I;
#pragma warning disable 0169
		static Delegate GetSetButtonUpdate_IHandler ()
		{
			if (cb_setButtonUpdate_I == null)
				cb_setButtonUpdate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetButtonUpdate_I);
			return cb_setButtonUpdate_I;
		}

		static IntPtr n_SetButtonUpdate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetButtonUpdate (p0));
		}
#pragma warning restore 0169

		IntPtr id_setButtonUpdate_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdate (int p0)
		{
			if (id_setButtonUpdate_I == IntPtr.Zero)
				id_setButtonUpdate_I = JNIEnv.GetMethodID (class_ref, "setButtonUpdate", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonUpdate_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setButtonUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetButtonUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_setButtonUpdate_Ljava_lang_String_ == null)
				cb_setButtonUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonUpdate_Ljava_lang_String_);
			return cb_setButtonUpdate_Ljava_lang_String_;
		}

		static IntPtr n_SetButtonUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonUpdate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setButtonUpdate_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdate (string p0)
		{
			if (id_setButtonUpdate_Ljava_lang_String_ == IntPtr.Zero)
				id_setButtonUpdate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setButtonUpdate", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonUpdate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetButtonUpdateClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetButtonUpdateClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0)
		{
			if (id_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setButtonUpdateClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setButtonUpdateClickListener_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setCancelable_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetCancelable_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setCancelable_Ljava_lang_Boolean_ == null)
				cb_setCancelable_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCancelable_Ljava_lang_Boolean_);
			return cb_setCancelable_Ljava_lang_Boolean_;
		}

		static IntPtr n_SetCancelable_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCancelable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setCancelable_Ljava_lang_Boolean_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetCancelable (global::Java.Lang.Boolean p0)
		{
			if (id_setCancelable_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setCancelable_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setCancelable", "(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCancelable_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setContentOnUpdateAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateAvailable_IHandler ()
		{
			if (cb_setContentOnUpdateAvailable_I == null)
				cb_setContentOnUpdateAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContentOnUpdateAvailable_I);
			return cb_setContentOnUpdateAvailable_I;
		}

		static IntPtr n_SetContentOnUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setContentOnUpdateAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateAvailable (int p0)
		{
			if (id_setContentOnUpdateAvailable_I == IntPtr.Zero)
				id_setContentOnUpdateAvailable_I = JNIEnv.GetMethodID (class_ref, "setContentOnUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentOnUpdateAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setContentOnUpdateAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setContentOnUpdateAvailable_Ljava_lang_String_ == null)
				cb_setContentOnUpdateAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContentOnUpdateAvailable_Ljava_lang_String_);
			return cb_setContentOnUpdateAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetContentOnUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setContentOnUpdateAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateAvailable (string p0)
		{
			if (id_setContentOnUpdateAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentOnUpdateAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentOnUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentOnUpdateAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setContentOnUpdateNotAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateNotAvailable_IHandler ()
		{
			if (cb_setContentOnUpdateNotAvailable_I == null)
				cb_setContentOnUpdateNotAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContentOnUpdateNotAvailable_I);
			return cb_setContentOnUpdateNotAvailable_I;
		}

		static IntPtr n_SetContentOnUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateNotAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setContentOnUpdateNotAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateNotAvailable (int p0)
		{
			if (id_setContentOnUpdateNotAvailable_I == IntPtr.Zero)
				id_setContentOnUpdateNotAvailable_I = JNIEnv.GetMethodID (class_ref, "setContentOnUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentOnUpdateNotAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setContentOnUpdateNotAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentOnUpdateNotAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setContentOnUpdateNotAvailable_Ljava_lang_String_ == null)
				cb_setContentOnUpdateNotAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContentOnUpdateNotAvailable_Ljava_lang_String_);
			return cb_setContentOnUpdateNotAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetContentOnUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentOnUpdateNotAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setContentOnUpdateNotAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetContentOnUpdateNotAvailable (string p0)
		{
			if (id_setContentOnUpdateNotAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentOnUpdateNotAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentOnUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentOnUpdateNotAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogButtonDismiss_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDismiss (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogButtonDismiss_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDismiss (int p0)
		{
			if (id_setDialogButtonDismiss_I == IntPtr.Zero)
				id_setDialogButtonDismiss_I = JNIEnv.GetMethodID (class_ref, "setDialogButtonDismiss", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonDismiss_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogButtonDismiss_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDismiss (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogButtonDismiss_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDismiss (string p0)
		{
			if (id_setDialogButtonDismiss_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogButtonDismiss_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogButtonDismiss", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonDismiss_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogButtonDoNotShowAgain_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDoNotShowAgain (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogButtonDoNotShowAgain_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDoNotShowAgain (int p0)
		{
			if (id_setDialogButtonDoNotShowAgain_I == IntPtr.Zero)
				id_setDialogButtonDoNotShowAgain_I = JNIEnv.GetMethodID (class_ref, "setDialogButtonDoNotShowAgain", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonDoNotShowAgain_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogButtonDoNotShowAgain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogButtonDoNotShowAgain (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogButtonDoNotShowAgain_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonDoNotShowAgain (string p0)
		{
			if (id_setDialogButtonDoNotShowAgain_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogButtonDoNotShowAgain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogButtonDoNotShowAgain", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonDoNotShowAgain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogButtonUpdate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonUpdate (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogButtonUpdate_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonUpdate (int p0)
		{
			if (id_setDialogButtonUpdate_I == IntPtr.Zero)
				id_setDialogButtonUpdate_I = JNIEnv.GetMethodID (class_ref, "setDialogButtonUpdate", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonUpdate_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogButtonUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogButtonUpdate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogButtonUpdate_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogButtonUpdate (string p0)
		{
			if (id_setDialogButtonUpdate_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogButtonUpdate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogButtonUpdate", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonUpdate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogDescriptionWhenUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogDescriptionWhenUpdateAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateAvailable (int p0)
		{
			if (id_setDialogDescriptionWhenUpdateAvailable_I == IntPtr.Zero)
				id_setDialogDescriptionWhenUpdateAvailable_I = JNIEnv.GetMethodID (class_ref, "setDialogDescriptionWhenUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogDescriptionWhenUpdateAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateAvailable (string p0)
		{
			if (id_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogDescriptionWhenUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogDescriptionWhenUpdateAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogDescriptionWhenUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateNotAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogDescriptionWhenUpdateNotAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateNotAvailable (int p0)
		{
			if (id_setDialogDescriptionWhenUpdateNotAvailable_I == IntPtr.Zero)
				id_setDialogDescriptionWhenUpdateNotAvailable_I = JNIEnv.GetMethodID (class_ref, "setDialogDescriptionWhenUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogDescriptionWhenUpdateNotAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogDescriptionWhenUpdateNotAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogDescriptionWhenUpdateNotAvailable (string p0)
		{
			if (id_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogDescriptionWhenUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogDescriptionWhenUpdateNotAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogTitleWhenUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogTitleWhenUpdateAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateAvailable (int p0)
		{
			if (id_setDialogTitleWhenUpdateAvailable_I == IntPtr.Zero)
				id_setDialogTitleWhenUpdateAvailable_I = JNIEnv.GetMethodID (class_ref, "setDialogTitleWhenUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogTitleWhenUpdateAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogTitleWhenUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateAvailable (string p0)
		{
			if (id_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogTitleWhenUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogTitleWhenUpdateAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
		static IntPtr n_SetDialogTitleWhenUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateNotAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDialogTitleWhenUpdateNotAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateNotAvailable (int p0)
		{
			if (id_setDialogTitleWhenUpdateNotAvailable_I == IntPtr.Zero)
				id_setDialogTitleWhenUpdateNotAvailable_I = JNIEnv.GetMethodID (class_ref, "setDialogTitleWhenUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogTitleWhenUpdateNotAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
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
		static IntPtr n_SetDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDialogTitleWhenUpdateNotAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDialogTitleWhenUpdateNotAvailable (string p0)
		{
			if (id_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDialogTitleWhenUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDialogTitleWhenUpdateNotAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_;
#pragma warning disable 0169
		static Delegate GetSetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_Handler ()
		{
			if (cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ == null)
				cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_);
			return cb_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_;
		}

		static IntPtr n_SetDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Display> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDisplay (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDisplay (global::Com.Github.Javiersantos.Appupdater.Enums.Display p0)
		{
			if (id_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ == IntPtr.Zero)
				id_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Lcom/github/javiersantos/appupdater/enums/Display;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Lcom_github_javiersantos_appupdater_enums_Display_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_;
#pragma warning disable 0169
		static Delegate GetSetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_Handler ()
		{
			if (cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ == null)
				cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_);
			return cb_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_;
		}

		static IntPtr n_SetDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Duration> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetDuration (global::Com.Github.Javiersantos.Appupdater.Enums.Duration p0)
		{
			if (id_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ == IntPtr.Zero)
				id_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_ = JNIEnv.GetMethodID (class_ref, "setDuration", "(Lcom/github/javiersantos/appupdater/enums/Duration;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_Lcom_github_javiersantos_appupdater_enums_Duration_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_);
			return cb_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitHubUserAndRepo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetGitHubUserAndRepo (string p0, string p1)
		{
			if (id_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGitHubUserAndRepo", "(Ljava/lang/String;Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static IntPtr n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
		}
#pragma warning restore 0169

		IntPtr id_setIcon_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIcon_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setTitleOnUpdateAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateAvailable_IHandler ()
		{
			if (cb_setTitleOnUpdateAvailable_I == null)
				cb_setTitleOnUpdateAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTitleOnUpdateAvailable_I);
			return cb_setTitleOnUpdateAvailable_I;
		}

		static IntPtr n_SetTitleOnUpdateAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setTitleOnUpdateAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateAvailable (int p0)
		{
			if (id_setTitleOnUpdateAvailable_I == IntPtr.Zero)
				id_setTitleOnUpdateAvailable_I = JNIEnv.GetMethodID (class_ref, "setTitleOnUpdateAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleOnUpdateAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setTitleOnUpdateAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleOnUpdateAvailable_Ljava_lang_String_ == null)
				cb_setTitleOnUpdateAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitleOnUpdateAvailable_Ljava_lang_String_);
			return cb_setTitleOnUpdateAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetTitleOnUpdateAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTitleOnUpdateAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateAvailable (string p0)
		{
			if (id_setTitleOnUpdateAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitleOnUpdateAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitleOnUpdateAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleOnUpdateAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setTitleOnUpdateNotAvailable_I;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateNotAvailable_IHandler ()
		{
			if (cb_setTitleOnUpdateNotAvailable_I == null)
				cb_setTitleOnUpdateNotAvailable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTitleOnUpdateNotAvailable_I);
			return cb_setTitleOnUpdateNotAvailable_I;
		}

		static IntPtr n_SetTitleOnUpdateNotAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateNotAvailable (p0));
		}
#pragma warning restore 0169

		IntPtr id_setTitleOnUpdateNotAvailable_I;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateNotAvailable (int p0)
		{
			if (id_setTitleOnUpdateNotAvailable_I == IntPtr.Zero)
				id_setTitleOnUpdateNotAvailable_I = JNIEnv.GetMethodID (class_ref, "setTitleOnUpdateNotAvailable", "(I)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleOnUpdateNotAvailable_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleOnUpdateNotAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_ == null)
				cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitleOnUpdateNotAvailable_Ljava_lang_String_);
			return cb_setTitleOnUpdateNotAvailable_Ljava_lang_String_;
		}

		static IntPtr n_SetTitleOnUpdateNotAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitleOnUpdateNotAvailable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setTitleOnUpdateNotAvailable_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetTitleOnUpdateNotAvailable (string p0)
		{
			if (id_setTitleOnUpdateNotAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitleOnUpdateNotAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitleOnUpdateNotAvailable", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleOnUpdateNotAvailable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_;
#pragma warning disable 0169
		static Delegate GetSetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_Handler ()
		{
			if (cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ == null)
				cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_);
			return cb_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_;
		}

		static IntPtr n_SetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateFrom (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateFrom (global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom p0)
		{
			if (id_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ == IntPtr.Zero)
				id_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_ = JNIEnv.GetMethodID (class_ref, "setUpdateFrom", "(Lcom/github/javiersantos/appupdater/enums/UpdateFrom;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setUpdateJSON_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateJSON_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateJSON_Ljava_lang_String_ == null)
				cb_setUpdateJSON_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpdateJSON_Ljava_lang_String_);
			return cb_setUpdateJSON_Ljava_lang_String_;
		}

		static IntPtr n_SetUpdateJSON_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateJSON (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setUpdateJSON_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateJSON (string p0)
		{
			if (id_setUpdateJSON_Ljava_lang_String_ == IntPtr.Zero)
				id_setUpdateJSON_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateJSON", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateJSON_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setUpdateXML_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUpdateXML_Ljava_lang_String_Handler ()
		{
			if (cb_setUpdateXML_Ljava_lang_String_ == null)
				cb_setUpdateXML_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetUpdateXML_Ljava_lang_String_);
			return cb_setUpdateXML_Ljava_lang_String_;
		}

		static IntPtr n_SetUpdateXML_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateXML (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setUpdateXML_Ljava_lang_String_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater SetUpdateXML (string p0)
		{
			if (id_setUpdateXML_Ljava_lang_String_ == IntPtr.Zero)
				id_setUpdateXML_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUpdateXML", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateXML_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_showAppUpdated_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetShowAppUpdated_Ljava_lang_Boolean_Handler ()
		{
			if (cb_showAppUpdated_Ljava_lang_Boolean_ == null)
				cb_showAppUpdated_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ShowAppUpdated_Ljava_lang_Boolean_);
			return cb_showAppUpdated_Ljava_lang_Boolean_;
		}

		static IntPtr n_ShowAppUpdated_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowAppUpdated (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showAppUpdated_Ljava_lang_Boolean_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater ShowAppUpdated (global::Java.Lang.Boolean p0)
		{
			if (id_showAppUpdated_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_showAppUpdated_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "showAppUpdated", "(Ljava/lang/Boolean;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showAppUpdated_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_showEvery_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetShowEvery_Ljava_lang_Integer_Handler ()
		{
			if (cb_showEvery_Ljava_lang_Integer_ == null)
				cb_showEvery_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ShowEvery_Ljava_lang_Integer_);
			return cb_showEvery_Ljava_lang_Integer_;
		}

		static IntPtr n_ShowEvery_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ShowEvery (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showEvery_Ljava_lang_Integer_;
		public unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdater ShowEvery (global::Java.Lang.Integer p0)
		{
			if (id_showEvery_Ljava_lang_Integer_ == IntPtr.Zero)
				id_showEvery_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "showEvery", "(Ljava/lang/Integer;)Lcom/github/javiersantos/appupdater/AppUpdater;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdater> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showEvery_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}
}
