using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Adventures_in_CRUD_
{
    public static class db
    {
		public static string getConnection()
		{
			string connstring = ConfigurationManager.AppSettings["connString"].ToString();
			return connstring;
		}

		public static void ToggleEncrypt()
		{

			// ConfigurationUserLevel defines how the access to the file is managed:
			//   None - Gets the Configuration that applies to all users
			//   PerUserRoaming - Gets the roaming Configuration that applies to current user only
			//   PerUserRoamingAndLocal - Gets the local Configuration applying to the current user
			Configuration myConfig =
				ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			ConfigurationSection section = myConfig.GetSection("AppConfig");
			section.SectionInformation.UnprotectSection();

			// Choose your encryption:
			//    DpapiProtectedConfigurationProvider - Windows Data Protection API (DPAPI) to encrypt/decrypt
			//    RsaProtectedConfigurationProvider - RSA encryption algorithm to encrypt/decrypt
			section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");

			// This would toggle on and off encryption
			if (section.SectionInformation.IsProtected)
			{ }
			else
			{ }


		}
	}
}
