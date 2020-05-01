using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        public  bool isLastFileNameValid { get; set; }
        
        public bool isValidLogFileName(string fileName)
        {
            isLastFileNameValid = false;
            
            if(String.IsNullOrEmpty(fileName))
                throw new ArgumentException("filename has to be provided");
            
            if(!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
                return false;

            isLastFileNameValid = true;
            return true;
        }

    }
}