using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Windows.Forms;

namespace CRM365PublishCustomizations
{
    public partial class FrmPublish : Form
    {
        public FrmPublish()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Get Organization Connection Data
        /// </summary>
        /// <returns>Organization to Use for Later Publish Action</returns>
        public OrganizationServiceProxy GetOrgService()
        {
            try
            {
                Uri url = new Uri("http://IPAddress/OrganizationName/XRMServices/2011/Organization.svc");
                System.ServiceModel.Description.ClientCredentials clientCredentials = new System.ServiceModel.Description.ClientCredentials();
                clientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential("UserName", "Password", "DomainName");

                OrganizationServiceProxy orgService = new OrganizationServiceProxy(url, null, clientCredentials, null);
                return orgService;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Btn Publish Click Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPublish_Click(object sender, EventArgs e)
        {
          var organizationObj=  GetOrgService();
            PublishEntity(organizationObj);
        }
        /// <summary>
        /// Publish An Entity
        /// </summary>
        /// <param name="orgProxy">Connection Information</param>
        /// <returns>Success Of Operation</returns>
        public bool PublishEntity(OrganizationServiceProxy orgProxy)
        {
        try 
	        {
                 //===========================Begin Publish All=============================
                PublishAllXmlRequest publishallxmlrequest = new PublishAllXmlRequest();
                orgProxy.Execute(publishallxmlrequest);
                //===========================End Publish All=============================


                return true;
            }
            catch (Exception ex)
        	{
                MessageBox.Show(ex.Message);
                return false;
		
	        }

        }
    }
}
