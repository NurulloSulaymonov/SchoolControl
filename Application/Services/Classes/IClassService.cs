using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Classes
{
    public interface IClassService
    {
        public Task<GenericResponse<List<Class>>> GetClasses();
        public Task<GenericResponse<Class>> GetClassById(string id);
        public GenericResponse<Class> Create(Class sclass);
        public GenericResponse<Class> Update(Class sclass);
    }
}
