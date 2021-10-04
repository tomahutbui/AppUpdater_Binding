package mono.com.github.javiersantos.appupdater;


public class AppUpdaterUtils_UpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.github.javiersantos.appupdater.AppUpdaterUtils.UpdateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailed:(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V:GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IUpdateListenerInvoker, AppUpdaterBinding\n" +
			"n_onSuccess:(Lcom/github/javiersantos/appupdater/objects/Update;Ljava/lang/Boolean;)V:GetOnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Ljava_lang_Boolean_Handler:Com.Github.Javiersantos.Appupdater.AppUpdaterUtils/IUpdateListenerInvoker, AppUpdaterBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Github.Javiersantos.Appupdater.AppUpdaterUtils+IUpdateListenerImplementor, AppUpdaterBinding", AppUpdaterUtils_UpdateListenerImplementor.class, __md_methods);
	}


	public AppUpdaterUtils_UpdateListenerImplementor ()
	{
		super ();
		if (getClass () == AppUpdaterUtils_UpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Github.Javiersantos.Appupdater.AppUpdaterUtils+IUpdateListenerImplementor, AppUpdaterBinding", "", this, new java.lang.Object[] {  });
	}


	public void onFailed (com.github.javiersantos.appupdater.enums.AppUpdaterError p0)
	{
		n_onFailed (p0);
	}

	private native void n_onFailed (com.github.javiersantos.appupdater.enums.AppUpdaterError p0);


	public void onSuccess (com.github.javiersantos.appupdater.objects.Update p0, java.lang.Boolean p1)
	{
		n_onSuccess (p0, p1);
	}

	private native void n_onSuccess (com.github.javiersantos.appupdater.objects.Update p0, java.lang.Boolean p1);

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
