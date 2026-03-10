namespace SGCM.UsesCase.Base
{
    public class OperationResult<T>
    {
        public T Value {get;}
        public bool IsSuccess {get;}
        public string Message {get;}

        public OperationResult(T Value, bool IsSuccess, string Message)
        {
            this.Value = Value;
            this.IsSuccess = IsSuccess;
            this.Message = Message;
        }
        public static OperationResult<T> Success(T value, string Message) => new OperationResult<T>(value,true, Message);
        public static OperationResult<T> Failure(string Message = "Operation failed") => new OperationResult<T>(default, false, Message);
        public static OperationResult<T> CustomError(string Message) => new OperationResult<T>(default,false,Message);
    }
}