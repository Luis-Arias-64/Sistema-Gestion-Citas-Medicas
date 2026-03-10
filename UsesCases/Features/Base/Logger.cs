using SGCM.Entities.Base;
using SGCM.UsesCase.Interfaces.Logger;

namespace SGCM.UsesCase.Base
{
    public class Logger
    {
        public string Message {get;set;}

        public Logger(string Message)
        {
            this.Message = Message;
        }

        public async static LogErrorAsync(string Message)
        {
            
        }
    }
}