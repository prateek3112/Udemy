using Microsoft.EntityFrameworkCore;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.models
{
    public class userrepository : UserCourse
    {

        private readonly AppDbContext _appDbContext;
        public userrepository(AppDbContext appdbcontext)
        {
            _appDbContext = appdbcontext;
        }
        public IEnumerable<courses> courses
        {
            get
            {
                return _appDbContext.Course.Include(c => c.Category);
            }
        }
        public IEnumerable<Category> Categories
        {
            get
            {
                return _appDbContext.Categories;
            }
        }
        public IEnumerable<courses> Courses
        {
            get
            {
                return _appDbContext.Courses;
            }
        }

    }
}
