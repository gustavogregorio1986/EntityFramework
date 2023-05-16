﻿using EntityFramework.Data.Contexto;
using EntityFramework.Data.Repositorio.Interfce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data.Repositorio
{
    public class GenericRepositorio<T> : IGenericRepository<T>, IDisposable where T : class
    {
        private readonly EntityFrameworkComtexto _db;

        public GenericRepositorio()
        {

        }

        public GenericRepositorio(EntityFrameworkComtexto db)
        {
            this._db = db;
        }

        public void Adicionar(T entidade)
        {
            _db.Set<T>().Add(entidade);
            Commit();
        }

        public void Atualizar(T entidade)
        {
            _db.Entry(entidade).State = EntityState.Modified;
            Commit();
        }

        public T Buscar(params object[] Key)
        {
            return _db.Set<T>().Find(Key);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Deletar(int i)
        {
            var obj = Buscar(i);
            _db.Set<T>().Remove(obj);
            Commit();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public List<T> Obter(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public List<T> ObterTodos()
        {
            return _db.Set<T>().ToList();
        }

        public T Primeiro(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).FirstOrDefault();
        }
    }
}
