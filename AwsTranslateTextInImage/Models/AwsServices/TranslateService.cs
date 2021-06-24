using Amazon.Translate;
using Amazon.Translate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsTranslateTextInImage.Models.AwsServices
{
    public class TranslateService : BaseAws
    {
        public TranslateService() : base()
        {
        }

        public async Task<string> TranslateText(string text, string sourceLanguageCode, string targetLanguageCode)
        {
            AmazonTranslateClient translateClient = new AmazonTranslateClient(awsCredentials, region);

            TranslateTextRequest request = new TranslateTextRequest()
            {
                Text = text,
                SourceLanguageCode = sourceLanguageCode,
                TargetLanguageCode = targetLanguageCode
            };

            try
            {
                TranslateTextResponse response = await translateClient.TranslateTextAsync(request);
                return response.TranslatedText;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
