using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DynamicDataTest
{
    [ScaffoldTable(true)]
    [MetadataType(typeof(LaptopMetadata))]
    public partial class Laptop
    {
    }


    public class LaptopMetadata
    {
        [ScaffoldColumn(false)]
        public global::System.String Processor;

        [UIHint("Text2")]
        public global::System.String ScreenSize
        {
            get;
            set;
        }
    }
}