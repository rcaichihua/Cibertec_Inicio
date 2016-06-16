using System.Collections.Generic;

namespace WebDeveloper.DataAccess
{
    public interface IDataAccess<T>
    {
        //no se pone public a los metodos, solo en la implemnetacion se pondra privador o publico
        List<T> GetList();
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);

    }
}
