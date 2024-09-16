using AutoMapper;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrudControllerBase<TEntity, TDTO>: ControllerBase 
    where TEntity: EntityBase
    where TDTO: DTOBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CrudControllerBase(AppDbContext AppDbContext, IMapper mapper)
        {
            _appDbContext = AppDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IActionResult> List()
        {
            var entities = await _appDbContext.Set<TEntity>().ToListAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Detail(long id)
        {
            var entity = await _appDbContext.Set<TEntity>().FindAsync(id);
            if (entity == null) {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(TDTO dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            await _appDbContext.Set<TEntity>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return CreatedAtAction("Detail", new { id = entity.Id }, entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(long id, TDTO dto)
        {
            if (!await EntityExists(id)) {
                return NotFound();
            }
            TEntity entity = _mapper.Map<TEntity>(dto);
            _appDbContext.Entry(entity).State = EntityState.Modified;
            try {
                await _appDbContext.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                throw;
            }
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var entity = await _appDbContext.Set<TEntity>().FindAsync(id);

            if (entity == null) {
                return NotFound();                
            }

            _appDbContext.Set<TEntity>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        private Task<bool> EntityExists(long id)
        {
            return _appDbContext.Set<TEntity>().AnyAsync(e => e.Id == id);
        }
    }
}
