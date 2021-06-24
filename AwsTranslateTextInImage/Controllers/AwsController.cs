using Amazon.Rekognition.Model;
using AwsTranslateTextInImage.Models.AwsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsTranslateTextInImage.Controllers
{
    public class AwsController
    {
        public async Task<string> GetTextInImage(string fileName, string bucketName)
        {
            try
            {
                await new S3Service().UploadS3(fileName, bucketName);
            }
            catch (Exception)
            {
                throw new Exception("Erro durante o upload pro S3");
            }

            try
            {
                List<TextDetection> listText = await new TextInImageService().DetectTextInImage(fileName, bucketName);
                string text = "";
                foreach (var i in listText)
                {
                    if (i.Type == "WORD")
                        text += i.DetectedText + " ";
                }
                return text;
            }
            catch (Exception)
            {
                throw new Exception("Erro durante o detecção de texto na imagem");
            }
        }

        public async Task<string> GetTranslatedText(string text, string sourceLanguageCode, string targetLanguageCode)
        {
            try
            {
                return await new TranslateService().TranslateText(text, sourceLanguageCode, targetLanguageCode);
            }
            catch (Exception)
            {
                throw new Exception("Erro durante a tradução do texto");
            }
        }
    }
}
