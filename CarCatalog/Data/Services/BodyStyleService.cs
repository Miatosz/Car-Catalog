using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarCatalog.Data.Interfaces;
using CarCatalog.Data.Models;
using CarCatalog.Data.Models.DTOs;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Data.Services
{
    public class BodyStyleService : IBodyStyleService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public BodyStyleService(AppDBContext ctx, IMapper mp) 
        { 
            _context = ctx; 
            _mapper = mp;
        }

        public async Task<BodyStyleDto> GetBodyStyleById(int id) => _mapper.Map<BodyStyleDto>(await _context.BodyStyles.FindAsync(id));  

        public async Task<IEnumerable<BodyStyleDto>> GetAllBodyStyles() => _mapper.Map<IEnumerable<BodyStyleDto>>( await _context.BodyStyles.ToListAsync());
        public bool SaveChanges() => _context.SaveChanges() >= 0;
    }
}