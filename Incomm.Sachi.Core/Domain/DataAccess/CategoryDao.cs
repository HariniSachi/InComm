using System.Collections.Generic;
using Incomm.Sachi.Core.Domain.Model;
using NLog;

namespace Incomm.Sachi.Core.Domain.DataAccess
{
    public class CategoryDao : IBaseDao<Category>
    {
        private readonly ILogger _logger;

        public CategoryDao(ILogger logger)
        {
            _logger = logger;
        }
        public IList<Category> FindAll()
        {
            _logger.Trace("Invoking category data access object find all method.");

            //TODO: Implement call to data access layer
            //For now hard code the return values
            return new List<Category>()
            {
                new Category() {CategoryId = 1, Description = "Coffee"},
                new Category() {CategoryId = 2, Description = "Tea"}
            };
        }
    }
}
