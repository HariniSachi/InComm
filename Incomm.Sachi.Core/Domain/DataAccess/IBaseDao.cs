using System.Collections.Generic;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public interface IBaseDao<T>
    {
        IList<T> FindAll();
    }
}
