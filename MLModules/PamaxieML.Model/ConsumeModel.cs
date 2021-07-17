// This file was auto-generated by ML.NET Model Builder. 

using System;
using Microsoft.ML;

namespace PamaxieML.Model
{
    /// <summary>
    /// BUG: Rewrite all of this, this is auto generated currently and doesn't nessecarily fit our needs.
    /// </summary>
    public class ConsumeModel
    {
        private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);
        public static readonly String ModelPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Pamaxie/MLModel.zip";

        // For more info on consuming ML.NET models, visit https://aka.ms/mlnet-consume
        // Method for consuming model in your app
        public static ModelOutput Predict(ModelInput input, out OutputProperties properties)
        {
            var result = PredictionEngine.Value.Predict(input);
            var label = OutputProperties.ImagePredictionResult.None;
            switch (result.Prediction)
            {
                case "Gore":
                    label = OutputProperties.ImagePredictionResult.Gore;
                    break;
                case "None":
                    label = OutputProperties.ImagePredictionResult.None;
                    break;
                case "Pornographic":
                    label = OutputProperties.ImagePredictionResult.Pornographic;
                    break;
                case "Racy":
                    label = OutputProperties.ImagePredictionResult.Racy;
                    break;
            }

            properties = new OutputProperties
            {
                GoreLikelihood = result.Score[0],
                NoneLikelihood = result.Score[1],
                PornographicLikelihood = result.Score[2],
                RacyLikelihood = result.Score[3],
                PredictedLabel = label
            };

            Console.WriteLine();
            return result;
        }

        public static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
        {
            // Create new MLContext
            MLContext mlContext = new MLContext();
            // Load model & create prediction engine
            ITransformer mlModel = mlContext.Model.Load(ModelPath, out var _);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
            return predEngine;
        }
    }
}
