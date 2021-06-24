using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsTranslateTextInImage.Models.AwsServices
{
    public class S3Service : BaseAws
    {
        private AmazonS3Client s3Client;

        public S3Service() : base()
        {
            s3Client = new AmazonS3Client(awsCredentials, region);
        }

        public async Task<bool> UploadS3(string fileName, string bucketName)
        {
            try
            {
                TransferUtility transfer = new TransferUtility(s3Client);
                await transfer.UploadAsync(fileName, bucketName);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Credenciais expiraram");
            }
        }

        public async Task<List<S3Bucket>> GetBuckets()
        {
            try
            {
                ListBucketsResponse listBuckets = await s3Client.ListBucketsAsync();
                return listBuckets.Buckets;
            }
            catch (Exception)
            {
                throw new Exception("Credenciais expiraram");
            }
        }
    }
}
