// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Image;
using System.Drawing;

namespace PamaxieML.Model
{
    public class ModelInput
    {
        [ColumnName("Label")] [LoadColumn(0)] public string Label { get; set; }

        [ColumnName("ImageSource")]
        [LoadColumn(1)]
        public string ImageSource { get; set; }
    }

    public class ImageInputData
    {
        [ImageType(227, 227)] public Bitmap Image { get; set; }
    }
}