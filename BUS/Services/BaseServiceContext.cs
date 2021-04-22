using AutoMapper;
using DAL.Models.Context;

namespace BUS.Services
{
    public class BaseServiceContext
    {
        protected readonly AppDbContext _context;
        protected readonly IMapper _mapper;

        public BaseServiceContext(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
