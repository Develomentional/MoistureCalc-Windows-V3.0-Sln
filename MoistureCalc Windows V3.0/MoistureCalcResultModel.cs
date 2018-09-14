using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoistureCalc_Windows_V3._0
{
    class MoistureCalcResultModel
    {
        MoistureCalcResultModel()
        {
                         
        }
       
        private String greenSample;
        private String drySample;
        private String moistureContent;

        public string GreenSample { get => greenSample; set => greenSample = value; }
        public string DrySample { get => drySample; set => drySample = value; }
        public string MoistureContent { get => moistureContent; set => moistureContent = value; }

       
    }
    public class MoistureCalcModelKeys
    {
        public static String kGreenSampleKey = "greenSampleKey";
        public static String kDrySampleKey = "DrySampleKey";
        public static String kMoisturContentKey = "MoisturContentKey";

        public MoistureCalcModelKeys()
        {
        }

        public void CalculateMCResultWithDictionary(DictionaryBase program)
        {
            MoistureCalcResultModel moistureCalcResultModel;
            
           // moistureCalcResultModel.DrySample = "7";
            Console.Write("calulating");
        }
         }
}
