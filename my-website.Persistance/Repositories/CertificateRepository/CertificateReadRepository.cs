using my_website.Application.Repositories.CertificateRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.CertificateRepository
{
    public class CertificateReadRepository : ReadRepository<Certificate>, ICertificateReadRepository
    {
        public CertificateReadRepository(ApplicationDbContext context) : base(context) { }
    }
}
