namespace SGCM.Entities.Exceptions{
    public abstract class BaseExeption : Exception
    {
        public BaseExeption() { }
        public BaseExeption(string message) : base(message) { }
        public BaseExeption(string message, Exception inner) : base(message, inner) { }
        protected BaseExeption(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}