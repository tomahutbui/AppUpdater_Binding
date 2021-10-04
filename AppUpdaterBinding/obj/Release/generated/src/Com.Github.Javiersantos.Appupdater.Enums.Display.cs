using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Display']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/enums/Display", DoNotGenerateAcw=true)]
	public sealed partial class Display : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Display']/field[@name='DIALOG']"
		[Register ("DIALOG")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.Display Dialog {
			get {
				const string __id = "DIALOG.Lcom/github/javiersantos/appupdater/enums/Display;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Display> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Display']/field[@name='NOTIFICATION']"
		[Register ("NOTIFICATION")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.Display Notification {
			get {
				const string __id = "NOTIFICATION.Lcom/github/javiersantos/appupdater/enums/Display;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Display> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Display']/field[@name='SNACKBAR']"
		[Register ("SNACKBAR")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.Display Snackbar {
			get {
				const string __id = "SNACKBAR.Lcom/github/javiersantos/appupdater/enums/Display;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Display> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/enums/Display", typeof (Display));

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

		internal Display (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Display']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/Display;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.Display ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/Display;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Display> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Display']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/github/javiersantos/appupdater/enums/Display;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.Display[] Values ()
		{
			const string __id = "values.()[Lcom/github/javiersantos/appupdater/enums/Display;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Github.Javiersantos.Appupdater.Enums.Display[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Github.Javiersantos.Appupdater.Enums.Display));
			} finally {
			}
		}

	}
}
