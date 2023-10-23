using Microsoft.AspNetCore.Mvc;
using BubbleSortServices;
namespace BubbleSort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BubbleSortController : ControllerBase
    {
        private static readonly int[] _UnsortedArray = new[]  {  64, 34, 25, 12, 22, 11, 90  };

        private readonly IBubbleSortArray _IBubbleSortArray;

        private readonly ILogger<BubbleSortController> _logger;

        public BubbleSortController(
            ILogger<BubbleSortController> logger
            , IBubbleSortArray _Ibubblesortarray
        )
        {
            _logger = logger;
            _IBubbleSortArray = _Ibubblesortarray;
        }

        [HttpGet("PrintUnsortedArray")]
        public async Task<ActionResult> PrintUnsortedArray()
        {
            return Ok(_UnsortedArray);
        }

        // pecify the type of the result.  ActionResult<int[]>
        // he response will contain the sorted array directly without any additional nesting.
        [HttpGet("PrintSortedArray")]
        public async Task<ActionResult<int[]>> PrintSortedArray()
        {
            var _SortedArray = _IBubbleSortArray.SortArray(_UnsortedArray);

            //This code returns the sorted array as the response without any unnecessary nesting. 
            return Ok(_SortedArray.Result);
        }
    }
}