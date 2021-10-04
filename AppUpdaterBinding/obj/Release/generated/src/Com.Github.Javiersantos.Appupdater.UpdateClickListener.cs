using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Javiersantos.Appupdater {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='UpdateClickListener']"
	[global::Android.Runtime.Register ("com/github/javiersantos/appupdater/UpdateClickListener", DoNotGenerateAcw=true)]
	public partial class UpdateClickListener : global::Java.Lang.Object, global::Android.Content.IDialogInterfaceOnClickListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/javiersantos/appupdater/UpdateClickListener", typeof (UpdateClickListener));

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

		protected UpdateClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='UpdateClickListener']/constructor[@name='UpdateClickListener' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.github.javiersantos.appupdater.enums.UpdateFrom'] and parameter[3][@type='java.net.URL']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/github/javiersantos/appupdater/enums/UpdateFrom;Ljava/net/URL;)V", "")]
		public unsafe UpdateClickListener (global::Android.Content.Context context, global::Com.Github.Javiersantos.Appupdater.Enums.UpdateFrom updateFrom, global::Java.Net.URL apk) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/github/javiersantos/appupdater/enums/UpdateFrom;Ljava/net/URL;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((updateFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) updateFrom).Handle);
				__args [2] = new JniArgumentValue ((apk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apk).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (updateFrom);
				global::System.GC.KeepAlive (apk);
			}
		}

		static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
		{
			if (cb_onClick_Landroid_content_DialogInterface_I == null)
				cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnClick_Landroid_content_DialogInterface_I);
			return cb_onClick_Landroid_content_DialogInterface_I;
		}

		static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Github.Javiersantos.Appupdater.UpdateClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialog = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_dialog, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (dialog, which);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.javiersantos.appupdater']/class[@name='UpdateClickListener']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
		[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
		public virtual unsafe void OnClick (global::Android.Content.IDialogInterface dialog, int which)
		{
			const string __id = "onClick.(Landroid/content/DialogInterface;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue (which);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dialog);
			}
		}

	}
}
