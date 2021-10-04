package mono.com.github.javiersantos.appupdater;


public class AppUpdaterUtils_AppUpdaterListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.github.javiersantos.appupdater.AppUpdaterUtils.AppUpdaterListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailed:(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V:GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IAppUpdaterListenerInvoker, AppUpdaterBinding\n" +
			"n_onSuccess:(Ljava/lang/String;Ljava/lang/Boolean;)V:GetOnSuccess_Ljava_lang_String_Ljava_lang_Boolean_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IAppUpdaterListenerInvoker, AppUpdaterBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Github.Javiersantos.Appupdater.AppUpdaterUtils+IAppUpdaterListenerImplementor, AppUpdaterBinding", AppUpdaterUtils_AppUpdaterListenerImplementor.class, __md_methods);
	}


	public AppUpdaterUtils_AppUpdaterListenerImplementor ()
	{
		super ();
		if (getClass () == AppUpdaterUtils_AppUpdaterListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Github.Javiersantos.Appupdater.AppUpdaterUtils+IAppUpdaterListenerImplementor, AppUpdaterBinding", "", this, new java.lang.Object[] {  });
	}


	public void onFailed (com.github.javiersantos.appupdater.enums.AppUpdaterError p0)
	{
		n_onFailed (p0);
	}

	private native void n_onFailed (com.github.javiersantos.appupdater.enums.AppUpdaterError p0);


	public void onSuccess (java.lang.String p0, java.lang.Boolean p1)
	{
		n_onSuccess (p0, p1);
	}

	private native void n_onSuccess (java.lang.String p0, java.lang.Boolean p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
