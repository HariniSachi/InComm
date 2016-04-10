namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public interface IDao<T> : IBaseDao<T>
    {
        T FindBy(int id);
        int Add(T item);
        void Update(T item);
    }
}
