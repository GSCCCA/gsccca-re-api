using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Described the different types of images accepted by the GSCCCA eFiling system
    /// </summary>
    public enum IMAGE_FILE_TYPE : int
    {
        /// <summary>
        /// TIFF Image
        /// </summary>
        TIFF, 
        
        
        /// <summary>
        /// PDF Document
        /// </summary>
        PDF
    }

    /// <summary>
    /// Provides the binary data of a document image and a type attribute for determining the type of image represented
    /// </summary>
    public class DocumentImage
    {
        private IMAGE_FILE_TYPE type = IMAGE_FILE_TYPE.TIFF;
        private byte[] data = null;
        private bool recordable = true;

        /// <summary>
        /// Creates a DocumentImage object using the IMAGE_FILE_TYPE and binary data provided
        /// </summary>
        /// <param name="type">The type of Image provided</param>
        /// <param name="data">The binary data of the Image</param>
        public DocumentImage(IMAGE_FILE_TYPE type, byte[] data)
        {
            this.type = type;
            this.data = data;
        }

        /// <summary>
        /// Gets/sets a value that indicates whether or not the images are to be recorded
        /// </summary>
        public bool Recordable
        {
            get { return this.recordable; }
            set { this.recordable = value; }
        }


        /// <summary>
        /// Creates a DocumentImage object using the path of the image provided.
        /// </summary>
        /// <exception cref="System.Exception">Thrown when the image does not exist or is not one of the allowed types</exception>
        /// <param name="filePath">The path of the image for which the DocumentImage will be created</param>
        public DocumentImage(string filePath)
        {
            if (File.Exists(filePath))
            {
                //try to get the extention
                string ext = Path.GetExtension(filePath).TrimStart('.').ToUpper();
                switch (ext)
                {
                    case "TIFF":
                    case "TIF":
                        type = IMAGE_FILE_TYPE.TIFF;
                        break;
                    case "PDF":
                        type = IMAGE_FILE_TYPE.PDF;
                        break;
                    default:
                        throw new Exception("Image Type Not Allowed");
                }
                this.data = File.ReadAllBytes(filePath);
            }
            else
            {
                throw new Exception("File does not exist");
            }
        }

        /// <summary>
        /// Gets the binary data of the DocumentImage
        /// </summary>
        public byte[] Data
        {
            get { return this.data; }
        }

        /// <summary>
        /// Gets the Image type of the DocumentImage
        /// </summary>
        public IMAGE_FILE_TYPE FileType
        {
            get { return this.type; }
        }
    }
}
