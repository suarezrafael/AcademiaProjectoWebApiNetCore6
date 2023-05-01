using AcademiaProjeto.Data.Context;
using AcademiaProjeto.Domain.Entities;
using AcademiaProjeto.Repositories.Base;
using AcademiaProjeto.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProjeto.Repositories.Repository
{
    public class CursoRepository : BaseRepository<Curso>, ICursoRepository
    {
        public CursoRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
