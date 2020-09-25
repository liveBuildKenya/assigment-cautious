using Microsoft.EntityFrameworkCore;
using Seed;
using Seed.Infrastructure;
using System.Reflection;

namespace AssignmentManagement.Core.Data
{
    public class AssignmentDbContext: DbContext, IDbContext
    {
        #region Ctor

        public AssignmentDbContext()
        {

        }

        public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options) : base(options)
        {

        }

        #endregion

        #region Utilities

        /// <summary>
        /// Further configuration of the model
        /// </summary>
        /// <param name="modelBuilder">Builder being use to construct the context model</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //For development
            optionsBuilder.UseSqlServer("Server=WORKSPACE_01;Database=AssignmentManagement;Trusted_Connection=True");

        }

        #endregion

        #region Methods

        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        #endregion
    }
}
