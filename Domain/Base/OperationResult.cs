namespace SGCM.Domain.Base
{
    public class OperationResult
    {
        public string? Message {get;set;}
        public bool Success {get;set;}
        public string data {get;set;}
        
        public OperationResult()
        {
            this.Success =true;
        }
    }
}