using System.Text;
namespace cSharpYoloLibrary
{
    public class FunctionAFunctionB
    {
        private List<int> processedDataList;
        private StringBuilder processedDataLog;
        private int totalData = 1000;
        public FunctionAFunctionB()
        {

            processedDataList = new List<int>();
            processedDataLog = new StringBuilder();
        }
        public async Task execute()
        {
            await functionA();
        }


        public async Task functionA()
        {
            await Task.Delay(1000);

            processedDataList.Clear();
            processedDataLog.Clear();

            for (int data = 1; data <= totalData; data++)
            {

                processedDataLog.Append($" processing data  {data}... {Environment.NewLine}");

                //start monitoring time to process current data on functionB
                var watch = System.Diagnostics.Stopwatch.StartNew();

                bool processDataWithFunctioB = await functionB(data);

                //stop timer
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                if (processDataWithFunctioB == true)
                {   //get and display time [in Millisecond] taken to process current data
                    processedDataLog.Append($"data {data} processed time {elapsedMs} Millisecond {Environment.NewLine}");
                }
                else
                {
                    //get and display time [in Millisecond] taken to process current data
                    processedDataLog.Append($"data {data} NOT process after execution of {elapsedMs} Millisecond {Environment.NewLine}");
                }


            }
        }
        public async Task<bool> functionB(int data)
        {
            await Task.Delay(0);

            // validate data be
            if (data <= 0) return false; //only processing from >0 

            //process data emitted from functionA loop here
            //add processed data to list
            processedDataList.Add(data);

            //return true on processing data complete
            return true;
        }
        public List<int> getAllProcessedData() => processedDataList;
        public string getAllProcessedDataLog() => processedDataLog.ToString();
    }


}