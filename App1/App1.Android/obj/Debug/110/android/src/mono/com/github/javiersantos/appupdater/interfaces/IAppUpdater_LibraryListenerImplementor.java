package mono.com.github.javiersantos.appupdater.interfaces;


public class IAppUpdater_LibraryListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.github.javiersantos.appupdater.interfaces.IAppUpdater.LibraryListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailed:(Lcom/github/javiersantos/appupdater/enums/AppUpdaterError;)V:GetOnFailed_Lcom_github_javiersantos_appupdater_enums_AppUpdaterError_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerInvoker, AppUpdaterBinding\n" +
			"n_onSuccess:(Lcom/github/javiersantos/appupdater/objects/Update;)V:GetOnSuccess_Lcom_github_javiersantos_appupdater_objects_Update_Handler:Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerInvoker, AppUpdaterBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerImplementor, AppUpdaterBinding", IAppUpdater_LibraryListenerImplementor.class, __md_methods);
	}


	public IAppUpdater_LibraryListenerImplementor ()
	{
		super ();
		if (getClass () == IAppUpdater_LibraryListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Github.Javiersantos.Appupdater.Interfaces.IAppUpdaterLibraryListenerImplementor, AppUpdaterBinding", "", this, new java.lang.Object[] {  });
	}


	public void onFailed (com.github.javiersantos.appupdater.enums.AppUpdaterError p0)
	{
		n_onFailed (p0);
	}

	private native void n_onFailed (com.github.javiersantos.appupdater.enums.AppUpdaterError p0);


	public void onSuccess (com.github.javiersantos.appupdater.objects.Update p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (com.github.javiersantos.appupdater.objects.Update p0);

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
