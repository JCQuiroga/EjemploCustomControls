package md5f6b73be76062975a376a5387eccbc854;


public class AndroidButton
	extends md5d4dd78677dce656d5db26c85a3743ef3.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EjemploCustomControls.Droid.CustomControls.AndroidButton, EjemploCustomControls.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AndroidButton.class, __md_methods);
	}


	public AndroidButton (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == AndroidButton.class)
			mono.android.TypeManager.Activate ("EjemploCustomControls.Droid.CustomControls.AndroidButton, EjemploCustomControls.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public AndroidButton (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == AndroidButton.class)
			mono.android.TypeManager.Activate ("EjemploCustomControls.Droid.CustomControls.AndroidButton, EjemploCustomControls.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public AndroidButton (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == AndroidButton.class)
			mono.android.TypeManager.Activate ("EjemploCustomControls.Droid.CustomControls.AndroidButton, EjemploCustomControls.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	java.util.ArrayList refList;
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
