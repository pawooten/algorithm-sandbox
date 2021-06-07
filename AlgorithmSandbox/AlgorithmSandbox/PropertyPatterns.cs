using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSandbox
{
    public enum PostalState
    {
        Ohio,
        Michigan,
        Wisconsin
    }

    public class Address
    {
        public PostalState State { get; set; }
    }

    public class PropertyPatterns
    {

        /// <summary>
        /// Lookup sales tax value based on Address.State value
        /// </summary>
        /// <param name="location"></param>
        /// <param name="salePrice"></param>
        /// <returns></returns>
        public static decimal ComputeSalesTax( Address location, decimal salePrice ) =>
            location switch
            {
                { State: PostalState.Ohio } => salePrice * 0.08M,
                { State: PostalState.Wisconsin } => salePrice * 0.075M,
                { State: PostalState.Michigan } => salePrice * 0.05M,
        // other cases removed for brevity...
        _ => 0M
            };
    }
}
