// <copyright file="AuditInfoRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FormsWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Класс для работы с таблицей AuditInfo.
    /// </summary>
    public class AuditInfoRepository : IGenericRepository<AuditInfo>
    {
        private DataContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditInfoRepository"/> class.
        /// </summary>
        public AuditInfoRepository()
        {
            this.db = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditInfoRepository"/> class.
        /// </summary>
        /// <param name="dataContext">DB context.</param>
        public AuditInfoRepository(DataContext dataContext)
        {
            this.db = dataContext;
        }

        /// <inheritdoc/>
        public void Create(AuditInfo item)
        {
            this.db.GetTable<AuditInfo>().InsertOnSubmit(item);
            this.db.SubmitChanges();
        }

        /// <inheritdoc/>
        public AuditInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Remove(AuditInfo item)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Update(AuditInfo item)
        {
            throw new NotImplementedException();
        }
    }
}
