using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsTranslateTextInImage.Models.AwsServices
{
    public class BaseAws
    {
        private readonly string AWS_PROFILE = "Aws Aula";

        public BaseAws()
        {
            try
            {
                SetCredentials();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected AWSCredentials awsCredentials;
        protected RegionEndpoint region = RegionEndpoint.USEast1;

        private void SetCredentials()
        {
            CredentialProfileStoreChain chain = new CredentialProfileStoreChain();
            if (!chain.TryGetAWSCredentials(AWS_PROFILE, out awsCredentials))
            {
                throw new Exception("Erro na autenticação");
            }
        }
    }
}
