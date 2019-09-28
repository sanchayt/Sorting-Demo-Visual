using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using SortingDemoVisual.Models;

namespace SortingDemoVisual.Controllers
{
    public class SortingController : ApiController
    {

        [HttpPost]
        [Route("api/sorting/sortArray")]
        public List<String> sortArray([FromBody]JObject data)
        {
            // Convert user input in desirable types
            int sortType = data["sortType"].ToObject<Int32>();
            int type = data["type"].ToObject<Int32>();
            Object[] arr = data["arr"].ToArray<Object>();

            List<String> result;
            // Checking for Digits
            if (type==0)
            {
                int[] intArray = Array.ConvertAll(arr, x => Convert.ToInt32(x));
                // Switch between multiple sorting algorithms for digits
                switch (sortType)
                {
                    case 0:
                        result = SortingAlgorithms.bubbleSort(intArray);
                        break;
                    case 1:
                        result = SortingAlgorithms.insertionSort(intArray);
                        break;
                    case 2:
                        SortingAlgorithms sorting = new SortingAlgorithms();
                        result = sorting.heapSort(intArray);
                        break;
                    default:
                        result = new List<String>();
                        break;
                }

            }
            // Checking for Words
            else if(type == 1)
            {
                String[] stringArray = Array.ConvertAll(arr, x => Convert.ToString(x));
                // Switch between multiple sorting algorithms for words
                switch (sortType)
                {
                    case 0:
                        result = SortingAlgorithms.bubbleSortString(stringArray);
                        break;
                    case 1:
                        result = SortingAlgorithms.insertionSortString(stringArray);
                        break;
                    case 2:
                        SortingAlgorithms sorting = new SortingAlgorithms();
                        result = sorting.heapSortString(stringArray);
                        break;
                    default:
                        result = new List<String>();
                        break;
                }
            }
            else
            {
                return new List<string>();
            }
            return result;
        }

    }
}
