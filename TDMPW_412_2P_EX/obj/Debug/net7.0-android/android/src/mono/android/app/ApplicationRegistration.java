package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("TDMPW_412_2P_EX.MainApplication, TDMPW_412_2P_EX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6422b93dd0d6f7b1ae.MainApplication.class, crc6422b93dd0d6f7b1ae.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
