using System;


namespace Application.Interfaces
{
    public interface  IGetRepositoryById<T> where T : class
    {
     public  T GetByIdi(int id);

   

    }
}
