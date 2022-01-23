﻿using GarciaCore.Domain;
using System.Linq.Expressions;

namespace GarciaCore.Persistence;

public interface IAsyncRepository<T> where T : Entity
{
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IReadOnlyList<T>> GetAllAsync(int page, int size);
    Task<IReadOnlyList<T>> GetByKeyAsync(string key, object value);
    Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> filter);
    Task<IReadOnlyList<T>> GetAsync(Dictionary<string, object> filter);
}