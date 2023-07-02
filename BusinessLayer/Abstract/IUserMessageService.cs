using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IUserMessageService : IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessageWithUserService();
    }
}
