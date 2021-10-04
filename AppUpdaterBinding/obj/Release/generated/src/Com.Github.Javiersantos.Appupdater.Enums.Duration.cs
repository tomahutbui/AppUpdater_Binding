using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Duration']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/enums/Duration", DoNotGenerateAcw=true)]
	public sealed partial class Duration : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Duration']/field[@name='INDEFINITE']"
		[Register ("INDEFINITE")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.Duration Indefinite {
			get {
				const string __id = "INDEFINITE.Lcom/github/javiersantos/appupdater/enums/Duration;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Duration> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Duration']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.Duration Normal {
			get {
				const string __id = "NORMAL.Lcom/github/javiersantos/appupdater/enums/Duration;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Duration> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/enums/Duration", typeof (Duration));

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

		internal Duration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Duration']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/Duration;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.Duration ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/Duration;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.Duration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='Duration']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/github/javiersantos/appupdater/enums/Duration;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.Duration[] Values ()
		{
			const string __id = "values.()[Lcom/github/javiersantos/appupdater/enums/Duration;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Github.Javiersantos.Appupdater.Enums.Duration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Github.Javiersantos.Appupdater.Enums.Duration));
			} finally {
			}
		}

	}
}
