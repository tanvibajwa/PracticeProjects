using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadFile_ManipulateData_CreateFile
{
    public class DataManipulation
    {
        public static void SortEntriesByAscendingPrice(List<StockPriceEntry> collection)
        {

            for (int index_where_replacement_should_happen = 0; index_where_replacement_should_happen < collection.Count - 1; index_where_replacement_should_happen++)
            {
                var min_price = float.MaxValue;

                for (int j = index_where_replacement_should_happen; j < collection.Count; j++)
                {
                    if (collection[j].Price <= min_price)
                    {
                        min_price = collection[j].Price;
                        var min_value_entry = collection[j];
                        collection[j] = collection[index_where_replacement_should_happen];
                        collection[index_where_replacement_should_happen] = min_value_entry;
                    }
                }
            }
        }

        public static void CalculateAndAddPercentageDifferenceAttribute(List<StockPriceEntry> collection)
        {
            var max = collection.Max(entry => entry.Price);

            for (int i = 0; i < collection.Count; i++)
            {
                collection[i].PercentDifference = ((max - collection[i].Price) / collection[i].Price) * 100;
            }
        }

    }
}
