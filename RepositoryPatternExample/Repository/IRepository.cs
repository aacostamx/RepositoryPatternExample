//------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace RepositoryPatternExample
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        TEntity Read(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
