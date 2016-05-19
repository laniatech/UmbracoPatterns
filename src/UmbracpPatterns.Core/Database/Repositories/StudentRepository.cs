using System;
using System.Collections.Generic;
using UmbracoPatterns.Core.Database.Dto;
using UmbracoPatterns.Core.Interfaces;
using UmbracoPatterns.Core.Interfaces.Repositories;

namespace UmbracoPatterns.Core.Database.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IUnitOfWorkProvider _uowProvider;

        public StudentRepository(IUnitOfWorkProvider uowProvider)
        {
            _uowProvider = uowProvider;
        }

        public StudentDto Add(StudentDto entity)
        {
            using(var uow = _uowProvider.GetUnitOfWork())
            {
                var id = uow.Db.Insert(entity);
                uow.Commit();
                entity.Id = Convert.ToInt32(id);
            }
            return entity;
        }

        public void DeleteById(int id)
        {
            using (var uow = _uowProvider.GetUnitOfWork())
            {
                uow.Db.Delete<StudentDto>(id);
                uow.Commit();
            }
        }

        public StudentDto GetByID(int id)
        {
            using (var uow = _uowProvider.GetUnitOfWork())
            {
                return uow.Db.Query<StudentDto>().Include(s => s.Address).SingleOrDefault(s => s.Id == id);
            }
        }

        public List<StudentDto> List()
        {
            using (var uow = _uowProvider.GetUnitOfWork())
            {
                return uow.Db.Query<StudentDto>().Include(s => s.Address).ToList();
            }
        }

        public void Update(StudentDto entity)
        {
            using (var uow = _uowProvider.GetUnitOfWork())
            {
                uow.Db.Update(entity);
                uow.Commit();
            }
        }
    }
}