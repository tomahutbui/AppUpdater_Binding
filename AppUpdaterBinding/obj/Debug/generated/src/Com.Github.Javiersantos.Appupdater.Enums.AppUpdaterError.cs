using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/enums/AppUpdaterError", DoNotGenerateAcw=true)]
	public sealed partial class AppUpdaterError : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='GITHUB_USER_REPO_INVALID']"
		[Register ("GITHUB_USER_REPO_INVALID")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError GithubUserRepoInvalid {
			get {
				const string __id = "GITHUB_USER_REPO_INVALID.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='JSON_ERROR']"
		[Register ("JSON_ERROR")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError JsonError {
			get {
				const string __id = "JSON_ERROR.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='JSON_URL_MALFORMED']"
		[Register ("JSON_URL_MALFORMED")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError JsonUrlMalformed {
			get {
				const string __id = "JSON_URL_MALFORMED.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='NETWORK_NOT_AVAILABLE']"
		[Register ("NETWORK_NOT_AVAILABLE")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError NetworkNotAvailable {
			get {
				const string __id = "NETWORK_NOT_AVAILABLE.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='UPDATE_VARIES_BY_DEVICE']"
		[Register ("UPDATE_VARIES_BY_DEVICE")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError UpdateVariesByDevice {
			get {
				const string __id = "UPDATE_VARIES_BY_DEVICE.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='XML_ERROR']"
		[Register ("XML_ERROR")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError XmlError {
			get {
				const string __id = "XML_ERROR.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/field[@name='XML_URL_MALFORMED']"
		[Register ("XML_URL_MALFORMED")]
		public static global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError XmlUrlMalformed {
			get {
				const string __id = "XML_URL_MALFORMED.Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/enums/AppUpdaterError", typeof (AppUpdaterError));

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

		internal AppUpdaterError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater.enums']/class[@name='AppUpdaterError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;", "")]
		public static unsafe global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError[] Values ()
		{
			const string __id = "values.()[Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Github.Javiersantos.Appupdater.Enums.AppUpdaterError));
			} finally {
			}
		}

	}
}
