using AutoMapper;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.DTOS.CertificateDTOS
{
    public class CertificateUpdateDTO
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }

    public class CertificateUpdateMappingProfile : Profile
    {
        public CertificateUpdateMappingProfile()
        {
            CreateMap<Certificate, CertificateUpdateDTO>().ReverseMap();
        }
    }
}
