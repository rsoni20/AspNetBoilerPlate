using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ME.Companies.Dto;
using Abp.Application.Services;
using ME.Entities;
using Abp.Domain.Repositories;

namespace ME.Companies
{
    public class CompanyAppService : AsyncCrudAppService<Company, CompanyDto, long, PagedResultRequestDto, CreateCompanyDto, CompanyDto>, ICompanyAppService
    {
        private IRepository<Company, long> _repository;

        protected CompanyAppService(IRepository<Company, long> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<CompanyDto> Create(CreateCompanyDto input)
        {
            throw new NotImplementedException();
        }

        public override Task Delete(EntityDto<long> input)
        {
            throw new NotImplementedException();
        }

        public override Task<CompanyDto> Get(EntityDto<long> input)
        {
            throw new NotImplementedException();
        }

        public override Task<PagedResultDto<CompanyDto>> GetAll(PagedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<CompanyDto> Update(CompanyDto input)
        {
            throw new NotImplementedException();
        }
    }
}
