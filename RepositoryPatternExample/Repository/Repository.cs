//------------------------------------------------------------------------
// <copyright file="Repository.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace RepositoryPatternExample
{
    using System;

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Create(TEntity entity)
        {
            //Write your logic here to persist the entity
        }

        public TEntity Read(int id)
        {
            //Write your logic here to retrieve an entity by Id
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            //Write your logic here to update an entity
        }

        public void Delete(TEntity entity)
        {
            //Write your logic here to delete an entity
        }
    }
}
