using System;
using System.ComponentModel;

namespace EnumUtilitiesSample
{
    /// <summary>
    /// Sample Enum with some Description attributes
    /// </summary>
    public enum SampleEnum : byte
    {
        [Description("First Value")]
        Value1 = 1,
        [Description("Second Value")]
        Value2,
        [Description("Third Value")]
        Value3,
        [Description("Fourth Value")]
        Value4,
        [Description("Fifth Value")]
        Value5,
        NoDescription
    }
}
