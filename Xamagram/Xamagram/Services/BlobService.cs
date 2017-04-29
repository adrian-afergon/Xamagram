using Microsoft.WindowsAzure.Storage;
using Plugin.Media.Abstractions;
using System;
using System.Threading.Tasks;

namespace Xamagram.Services
{
    class BlobService
    {
        private static BlobService _instance;

        public static BlobService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BlobService();
                }

                return _instance;
            }
        }

        public async Task<string> UploadPhotoAsync(MediaFile photo)
        {
            var storageAccount = CloudStorageAccount.Parse(GlobalSettings.BlobSharedKey);
            var blobClient = storageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference(GlobalSettings.BlobContainerName);
            await container.CreateIfNotExistsAsync();

            var blob = container.GetBlockBlobReference(Guid.NewGuid().ToString());
            blob.Properties.ContentType = "image/png";
            await blob.UploadFromStreamAsync(photo.GetStream());

            return blob.Uri.ToString();
        }
    }
}
