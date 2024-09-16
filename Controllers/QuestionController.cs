﻿using AutoMapper;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public QuestionsController(AppDbContext AppDbContext, IMapper mapper)
        {
            _appDbContext = AppDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
        {
            return await _appDbContext.Questions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(int id)
        {
            var question = await _appDbContext.Questions.FindAsync(id);
            if (question is null)
            {
                return NotFound();
            }
            return question;
        }

        [HttpPost]
        public async Task<ActionResult<Question>> PostQuestion(QuestionDTO questionDTO)
        {
            Question question = _mapper.Map<Question>(questionDTO);
            _appDbContext.Questions.Add(question);
            await _appDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetQuestion), new { id = question.Id }, question);
        }

        [HttpPut]
        public async Task<ActionResult<Question>> PutQuestion(int id, Question question)
        {
            if (id != question.Id)
            {
                return BadRequest();
            }
            _appDbContext.Entry(question).State = EntityState.Modified;
            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool QuestionExists(long id)
        {
            return (_appDbContext.Questions?.Any(question => question.Id == id)).GetValueOrDefault();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Question>> DeleteQuestion(int id)
        {
            var question = await _appDbContext.Questions.FindAsync(id);
            if (question is null)
            {
                return NotFound();
            }
            _appDbContext.Questions.Remove(question);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
