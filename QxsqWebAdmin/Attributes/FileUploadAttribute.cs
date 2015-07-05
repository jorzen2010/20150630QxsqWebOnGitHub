using System;
using System.Web.Mvc;


namespace QxsqWebAdmin.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FileUploadAttribute : Attribute, IMetadataAware
    {
        public string Folder { get; private set; }
        public bool IsFlash { get; private set; }

        public FileUploadAttribute(string folder, bool isFlash = false)
        {
            this.Folder = folder;
            this.IsFlash = isFlash;
        }

        public virtual void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues.Add("Folder", this.Folder);
            if (this.IsFlash)
            {
                metadata.TemplateHint = "FlashUpload";
            }
            else
            {
                metadata.TemplateHint = "ImageUpload";
            }

        }
    }
}