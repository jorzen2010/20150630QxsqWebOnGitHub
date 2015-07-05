using System;
using System.Web.Mvc;

namespace admin.jiaolianxueyuan.com.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class HeadPhotoAttribute : Attribute, IMetadataAware
    {
        public string Folder { get; private set; }

        public HeadPhotoAttribute(string folder)
        {
            this.Folder = folder;
        }

        public virtual void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues.Add("Folder", this.Folder);

            metadata.TemplateHint = "HeadPhoto";



        }
    }
}