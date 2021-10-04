using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/AppUpdaterUtils", DoNotGenerateAcw=true)]
	public partial class AppUpdaterUtils : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.javiersantos.appupdater']/interface[@name='AppUpdaterUtils.AppUpdaterListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/github/javiersantos/appupdater/AppUpdaterUtils$AppUpdaterListener", "", "Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IAppUpdaterListenerInvoker")]
		public partial interface IAppUpdaterListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/interface[@name='AppUpdaterUtils.AppUpdaterListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.AppUpdaterError']]"
			[Register ("onFailed", "(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V", "GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IAppUpdaterListenerInvoker, AppUpdaterBinding")]
			void OnFailed (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/interface[@name='AppUpdaterUtils.AppUpdaterListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
			[Register ("onSuccess", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "GetOnSuccess_Ljava_lang_String_Ljava_lang_Boolean_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IAppUpdaterListenerInvoker, AppUpdaterBinding")]
			void OnSuccess (string p0, global::Java.Lang.Boolean p1);

		}

		[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/AppUpdaterUtils$AppUpdaterListener", DoNotGenerateAcw=true)]
		internal partial class IAppUpdaterListenerInvoker : global::Java.Lang.Object, IAppUpdaterListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/AppUpdaterUtils$AppUpdaterListener", typeof (IAppUpdaterListenerInvoker));

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

			public static IAppUpdaterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAppUpdaterListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.javiersantos.appupdater.AppUpdaterUtils.AppUpdaterListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAppUpdaterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IAppUpdaterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_ == null)
					cb_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSuccess_Ljava_lang_String_Ljava_lang_Boolean_);
				return cb_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_;
			}

			static void n_OnSuccess_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IAppUpdaterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_;
			public unsafe void OnSuccess (string p0, global::Java.Lang.Boolean p1)
			{
				if (id_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_Ljava_lang_Boolean_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.github.javiersantos.appupdater.AppUpdaterUtils.AppUpdaterListener.onFailed
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

		// event args for com.github.javiersantos.appupdater.AppUpdaterUtils.AppUpdaterListener.onSuccess
		public partial class SuccessEventArgs : global::System.EventArgs {
			public SuccessEventArgs (string p0, global::Java.Lang.Boolean p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;

			public string P0 {
				get { return p0; }
			}

			global::Java.Lang.Boolean p1;

			public global::Java.Lang.Boolean P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/github/javiersantos/appupdater/AppUpdaterUtils_AppUpdaterListenerImplementor")]
		internal sealed partial class IAppUpdaterListenerImplementor : global::Java.Lang.Object, IAppUpdaterListener {

			object sender;

			public IAppUpdaterListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/github/javiersantos/appupdater/AppUpdaterUtils_AppUpdaterListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
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

			public void OnSuccess (string p0, global::Java.Lang.Boolean p1)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IAppUpdaterListenerImplementor value)
			{
				return value.OnFailedHandler == null && value.OnSuccessHandler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.javiersantos.appupdater']/interface[@name='AppUpdaterUtils.UpdateListener']"
		[Register ("com/github/javiersantos/appupdater/AppUpdaterUtils$UpdateListener", "", "Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IUpdateListenerInvoker")]
		public partial interface IUpdateListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/interface[@name='AppUpdaterUtils.UpdateListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.AppUpdaterError']]"
			[Register ("onFailed", "(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V", "GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IUpdateListenerInvoker, AppUpdaterBinding")]
			void OnFailed (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/interface[@name='AppUpdaterUtils.UpdateListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='com.github.javiersantos.appupdater.objects.Update'] and parameter[2][@type='java.lang.Boolean']]"
			[Register ("onSuccess", "(Lcom/github/javiersantos/appupdater/objects/Update;Ljava/lang/Boolean;)V", "GetOnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IUpdateListenerInvoker, AppUpdaterBinding")]
			void OnSuccess (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0, global::Java.Lang.Boolean p1);

		}

		[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/AppUpdaterUtils$UpdateListener", DoNotGenerateAcw=true)]
		internal partial class IUpdateListenerInvoker : global::Java.Lang.Object, IUpdateListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/AppUpdaterUtils$UpdateListener", typeof (IUpdateListenerInvoker));

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

			public static IUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.javiersantos.appupdater.AppUpdaterUtils.UpdateListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_ == null)
					cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_);
				return cb_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_;
			}

			static void n_OnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Objects.Update> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_;
			public unsafe void OnSuccess (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0, global::Java.Lang.Boolean p1)
			{
				if (id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/github/javiersantos/appupdater/objects/Update;Ljava/lang/Boolean;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_, __args);
			}

		}

		

		[global::Android.Runtime.Register ("mono/com/github/javiersantos/appupdater/AppUpdaterUtils_UpdateListenerImplementor")]
		internal sealed partial class IUpdateListenerImplementor : global::Java.Lang.Object, IUpdateListener {

			object sender;

			public IUpdateListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/github/javiersantos/appupdater/AppUpdaterUtils_UpdateListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
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

			public void OnSuccess (global::Com.Github.Javiersantos.Appupdater.Objects.Update p0, global::Java.Lang.Boolean p1)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0.ToString(), p1));
			}

			internal static bool __IsEmpty (IUpdateListenerImplementor value)
			{
				return value.OnFailedHandler == null && value.OnSuccessHandler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/AppUpdaterUtils", typeof (AppUpdaterUtils));

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

		protected AppUpdaterUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/constructor[@name='AppUpdaterUtils' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppUpdaterUtils (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var user = JNIEnv.GetString (native_user, JniHandleOwnership.DoNotTransfer);
			var repo = JNIEnv.GetString (native_repo, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGitHubUserAndRepo (user, repo));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='setGitHubUserAndRepo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGitHubUserAndRepo", "(Ljava/lang/String;Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;", "GetSetGitHubUserAndRepo_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils SetGitHubUserAndRepo (string user, string repo)
		{
			const string __id = "setGitHubUserAndRepo.(Ljava/lang/String;Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;";
			IntPtr native_user = JNIEnv.NewString (user);
			IntPtr native_repo = JNIEnv.NewString (repo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_user);
				__args [1] = new JniArgumentValue (native_repo);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_user);
				JNIEnv.DeleteLocalRef (native_repo);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var updateFrom = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (native_updateFrom, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateFrom (updateFrom));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='setUpdateFrom' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.enums.UpdateFrom']]"
		[Register ("setUpdateFrom", "(Lcom/github/javiersantos/appupdater/enums/UpdateFrom;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;", "GetSetUpdateFrom_Lcom_github_javiersantos_appupdater_enums_UpdateFrom_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils SetUpdateFrom (global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom updateFrom)
		{
			const string __id = "setUpdateFrom.(Lcom/github/javiersantos/appupdater/enums/UpdateFrom;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((updateFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) updateFrom).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var jsonUrl = JNIEnv.GetString (native_jsonUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateJSON (jsonUrl));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='setUpdateJSON' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpdateJSON", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;", "GetSetUpdateJSON_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils SetUpdateJSON (string jsonUrl)
		{
			const string __id = "setUpdateJSON.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;";
			IntPtr native_jsonUrl = JNIEnv.NewString (jsonUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var xmlUrl = JNIEnv.GetString (native_xmlUrl, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUpdateXML (xmlUrl));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='setUpdateXML' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUpdateXML", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;", "GetSetUpdateXML_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils SetUpdateXML (string xmlUrl)
		{
			const string __id = "setUpdateXML.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;";
			IntPtr native_xmlUrl = JNIEnv.NewString (xmlUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_xmlUrl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_xmlUrl);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='start' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetWithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_Handler ()
		{
			if (cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_ == null)
				cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_);
			return cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_;
		}

		[Obsolete]
		static IntPtr n_WithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appUpdaterListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appUpdaterListener = (global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IAppUpdaterListener)global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IAppUpdaterListener> (native_appUpdaterListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithListener (appUpdaterListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='withListener' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.AppUpdaterUtils.AppUpdaterListener']]"
		[Obsolete (@"deprecated")]
		[Register ("withListener", "(Lcom/github/javiersantos/appupdater/AppUpdaterUtils$AppUpdaterListener;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;", "GetWithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_AppUpdaterListener_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils WithListener (global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IAppUpdaterListener appUpdaterListener)
		{
			const string __id = "withListener.(Lcom/github/javiersantos/appupdater/AppUpdaterUtils$AppUpdaterListener;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((appUpdaterListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) appUpdaterListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (appUpdaterListener);
			}
		}

		static Delegate cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_;
#pragma warning disable 0169
		static Delegate GetWithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_Handler ()
		{
			if (cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_ == null)
				cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_);
			return cb_withListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_;
		}

		static IntPtr n_WithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_updateListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var updateListener = (global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IUpdateListener> (native_updateListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithListener (updateListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='AppUpdaterUtils']/method[@name='withListener' and count(parameter)=1 and parameter[1][@type='com.github.javiersantos.appupdater.AppUpdaterUtils.UpdateListener']]"
		[Register ("withListener", "(Lcom/github/javiersantos/appupdater/AppUpdaterUtils$UpdateListener;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;", "GetWithListener_Lcom_github_javiersantos_appupdater_AppUpdaterUtils_UpdateListener_Handler")]
		public virtual unsafe global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils WithListener (global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils.IUpdateListener updateListener)
		{
			const string __id = "withListener.(Lcom/github/javiersantos/appupdater/AppUpdaterUtils$UpdateListener;)Lcom/github/javiersantos/appupdater/AppUpdaterUtils;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((updateListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) updateListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.AppUpdaterUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (updateListener);
			}
		}

	}
}
