using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUtility
{
    public partial class ClientConfiguration
    {
        public static ClientConfiguration Default { get { return ClientConfiguration.OneBox; } }

        public static ClientConfiguration OneBox = new ClientConfiguration()
        {
            // You only need to populate this section if you are logging on via a native app. For Service to Service scenarios in which you e.g. use a service principal you don't need that.
            UriString = "https://usnconeboxax1aos.cloud.onebox.dynamics.com/",
            UserName = "tusr1@TAEOfficial.ccsctp.net",            
            // Insert the correct password here for the actual test.
            Password = "24?uW5*rDEXnL~-H",

            // You need this only if you logon via service principal using a client secret. See: https://docs.microsoft.com/en-us/dynamics365/unified-operations/dev-itpro/data-entities/services-home-page to get more data on how to populate those fields.
            // You can find that under AAD in the azure portal
            ActiveDirectoryResource = "https://usnconeboxax1aos.cloud.onebox.dynamics.com", // Don't have a trailing "/". Note: Some of the sample code handles that issue.
            ActiveDirectoryTenant = "https://login.windows-ppe.net/TAEOfficial.ccsctp.net", // Some samples: https://login.windows.net/yourtenant.onmicrosoft.com, https://login.windows.net/microsoft.com
            //ActiveDirectoryClientAppId = "d8a9a121-b463-41f6-a86c-041272bdb340",
            ActiveDirectoryClientAppId = "ae634736-b8bd-49b2-af19-0fa8cc403fe8",

            // Insert here the application secret when authenticate with AAD by the application
            //ActiveDirectoryClientAppSecret = "ae634736-b8bd-49b2-af19-0fa8cc403fe8",
            //SecretID="1036a397-696e-4515-a91f-1683eb105020"
            //SecretName="console-app-2"
            ActiveDirectoryClientAppSecret = "6R58Q~NF_QYFfYRBqkvcucCBo_boANZ7O_SlpbXV",

            // Change TLS version of HTTP request from the client here
            // Ex: TLSVersion = "1.2"
            // Leave it empty if want to use the default version
            TLSVersion = "",
        };

        public string TLSVersion { get; set; }
        public string UriString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
        public string ActiveDirectoryClientAppSecret { get; set; }
    }
}
