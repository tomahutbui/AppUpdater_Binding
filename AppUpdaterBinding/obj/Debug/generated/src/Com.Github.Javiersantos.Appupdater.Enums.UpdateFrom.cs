using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/enums/UpdateFrom", DoNotGenerateAcw=true)]
	public sealed partial class UpdateFrom : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/field[@name='AMAZON']"
		[Register ("AMAZON")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom Amazon {
			get {
				const string __id = "AMAZON.Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/field[@name='FDROID']"
		[Register ("FDROID")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom Fdroid {
			get {
				const string __id = "FDROID.Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/field[@name='GITHUB']"
		[Register ("GITHUB")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom Github {
			get {
				const string __id = "GITHUB.Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/field[@name='GOOGLE_PLAY']"
		[Register ("GOOGLE_PLAY")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom GooglePlay {
			get {
				const string __id = "GOOGLE_PLAY.Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/field[@name='JSON']"
		[Register ("JSON")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom Json {
			get {
				const string __id = "JSON.Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/field[@name='XML']"
		[Register ("XML")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom Xml {
			get {
				const string __id = "XML.Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/enums/UpdateFrom", typeof (UpdateFrom));

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

		internal UpdateFrom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/UpdateFrom;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='UpdateFrom']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/github/javiersantos/appupdater/enums/UpdateFrom;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom[] Values ()
		{
			const string __id = "values.()[Lcom/github/javiersantos/appupdater/enums/UpdateFrom;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom));
			} finally {
			}
		}

	}
}
