using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Classes
{
    public class ClassService : IClassService

    {
        private readonly DataContext _context;
        private readonly ILogger<ClassService> _logger;

        public ClassService(DataContext context, ILogger<ClassService> logger)
        {
            _context = context;
            _logger = logger;
        }
        /// <summary>
        /// Create a new Class 
        /// </summary>
        /// <param name="sclass"></param>
        /// <returns></returns>
        public GenericResponse<Class> Create(Class sclass)
        {
            try
            {
                sclass.CreatedAt = DateTime.Now;
                sclass.Id =  Guid.NewGuid().ToString();
                _context.Classes.Add(sclass);
                _context.SaveChanges();
                return new GenericResponse<Class>(System.Net.HttpStatusCode.OK, sclass);
            }
            catch (System.Exception ex)
            {
                return new GenericResponse<Class>(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Get Class By id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<GenericResponse<Class>> GetClassById(string id)
        {
            var sclass = await _context.Classes.FindAsync(id);
            return new GenericResponse<Class>(System.Net.HttpStatusCode.OK, sclass);
        }

        /// <summary>
        /// Get List of Classes by filter
        /// </summary>
        /// <returns></returns>
        public async Task<GenericResponse<List<Class>>> GetClasses()
        {
            var classes = await _context.Classes.ToListAsync();
            return new GenericResponse<List<Class>>(System.Net.HttpStatusCode.OK, classes);

        }

        /// <summary>
        /// Update Class
        /// </summary>
        /// <param name="sclass"></param>
        /// <returns></returns>
        public GenericResponse<Class> Update(Class sclass)
        {
            try
            {
                var data = _context.Classes.Find(sclass.Id);
                if (data != null)
                {
                    data.FinishedAt = sclass.FinishedAt;
                    data.IsCompleted = sclass.IsCompleted;
                    data.StaffId = sclass.StaffId;
                    data.StartedAt = sclass.StartedAt;
                    data.SubjectId = sclass.SubjectId;
                    _context.SaveChangesAsync();
                    return new GenericResponse<Class>(System.Net.HttpStatusCode.OK, data);
                }
                else
                {
                    return new GenericResponse<Class>(System.Net.HttpStatusCode.NotFound);
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<Class>(System.Net.HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
