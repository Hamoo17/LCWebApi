using LCWebApi.Server.Specifications.Base;
using LCWebApi.Shared;
using LCWebApi.Shared.Wrapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCWebApi.Server.Extentions
{
    public static class QueryableExtensions
    {
        public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize) where T : class
        {
            if (source == null) throw new ApiException();
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            pageSize = pageSize == 0 ? 10 : pageSize;
            int count = await source.CountAsync();
            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            List<T> items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return PaginatedResult<T>.Success(items, count, pageNumber, pageSize);
        }
        public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(this IEnumerable<T> source, int pageNumber, int pageSize) where T : class
        {
            if (source == null) throw new ApiException();
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            pageSize = pageSize == 0 ? 10 : pageSize;
            int count =  source.Count();
            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            List<T> items =  source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return  PaginatedResult<T>.Success(items, count, pageNumber, pageSize);
        }
        //public static async Task<CustomPagingResult<T>> ToCustomPaginatedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize) where T : GetAllRPTPagedResponse
        //{
        //    if (source == null) throw new ApiException();
        //    pageNumber = pageNumber == 0 ? 1 : pageNumber;
        //    pageSize = pageSize == 0 ? 10 : pageSize;
        //    int count = await source.CountAsync();
        //    pageNumber = pageNumber <= 0 ? 1 : pageNumber;
        //    List<T> items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        //    int TotalRecords = source.Count();
        //    int TotalDelevired = source.Where(x => x.DeliveryStatus == 1).Count();
        //    int TotalPending = source.Where(x => x.DeliveryStatus == 0).Count();
        //    int TotalNotDeleverd = source.Where(x => x.DeliveryStatus == 2).Count();
        //    return CustomPagingResult<T>.Success(items, count, pageNumber, pageSize, TotalRecords, TotalDelevired, TotalPending, TotalNotDeleverd);
        //}

        public static IQueryable<T> Specify<T>(this IQueryable<T> query, ISpecification<T> spec) where T : class
        {
            var queryableResultWithIncludes = spec.Includes
                .Aggregate(query,
                    (current, include) => current.Include(include));
            var secondaryResult = spec.IncludeStrings
                .Aggregate(queryableResultWithIncludes,
                    (current, include) => current.Include(include));
            return secondaryResult.Where(spec.Criteria);
        }
    }
}
