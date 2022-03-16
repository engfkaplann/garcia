﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GarciaCore.Application.Contracts.Persistence;
using GarciaCore.Domain;

namespace GarciaCore.Application.Services
{
    public class BaseService<TRepository, TEntity, TDto, TKey> : IBaseService<TEntity, TDto, TKey>
        where TRepository : IAsyncRepository<TEntity, TKey>
        where TKey : IEquatable<TKey>
        where TEntity : IEntity<TKey>
    {
        private readonly TRepository _repository;
        private readonly IMapper _mapper;

        public BaseService(TRepository repository)
        {
            _repository = repository;
            _mapper = InitializeMapper()
                .CreateMapper();
        }

        public virtual async Task<BaseResponse<IEnumerable<TDto>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            var result = _mapper.Map<IEnumerable<TDto>>(entities);
            return new BaseResponse<IEnumerable<TDto>>(result);
        }

        public virtual async Task<BaseResponse<TDto>> GetByIdAsync(TKey id)
        {
            var entity = await _repository.GetByIdAsync(id);
            var result = _mapper.Map<TDto>(entity);
            return new BaseResponse<TDto>(result);

        }

        public virtual async Task<BaseResponse<long>> AddAsync(TEntity entity)
        {
            var result = await _repository.AddAsync(entity);
            return new BaseResponse<long>(result, System.Net.HttpStatusCode.Created);
        }

        public virtual async Task<BaseResponse<long>> UpdateAsync(TKey id, object updateRequest)
        {
            var entity = await _repository.GetByIdAsync(id);
            
            if(entity == null)
            {
                return new BaseResponse<long>(0, 
                    System.Net.HttpStatusCode.NotFound, 
                    new ApiError("Entity Not Found", 
                    "The id entered does not match any entity"));
            }

            var result = await _repository.UpdateAsync(Helpers.BasicMap(entity, updateRequest));
            return new BaseResponse<long>(result, System.Net.HttpStatusCode.OK);
        }

        public virtual async Task<BaseResponse<long>> DeleteAsync(TKey id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity == null)
            {
                return new BaseResponse<long>(0,
                    System.Net.HttpStatusCode.NotFound,
                    new ApiError("Entity Not Found",
                    "The id entered does not match any entity"));
            }

            var result = await _repository.DeleteAsync(entity);
            return new BaseResponse<long>(result, System.Net.HttpStatusCode.OK);
        }

        private MapperConfiguration InitializeMapper() =>
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TEntity, TDto>();
            });

    }
}
