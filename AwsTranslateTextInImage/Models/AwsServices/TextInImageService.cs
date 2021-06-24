using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsTranslateTextInImage.Models.AwsServices
{
    public class TextInImageService : BaseAws
    {
        public TextInImageService() : base()
        {
        }

        public async Task<List<TextDetection>> DetectTextInImage(string fileName, string bucketName)
        {
            fileName = Path.GetFileName(fileName);

            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient(awsCredentials, region);

            DetectTextRequest request = new DetectTextRequest()
            {
                Image = new Image()
                {
                    S3Object = new S3Object()
                    {
                        Name = fileName,
                        Bucket = bucketName
                    }
                },
                Filters = new DetectTextFilters()
                {
                    WordFilter = new DetectionFilter()
                    {
                        MinConfidence = 80
                    }
                }
            };

            try
            {
                DetectTextResponse response = await rekognitionClient.DetectTextAsync(request);
                return response.TextDetections;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
