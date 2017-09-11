using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ME.Companies.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Companies
{
    public interface ICompanyAppService: IAsyncCrudAppService<CompanyDto, long, PagedResultRequestDto, CreateCompanyDto, CompanyDto>
    {
    }
}
