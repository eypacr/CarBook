using CarBook.Application.Dtos.CommentDtos;
using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository _repository;

        public CommentsController(ICommentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> CommentList()=> Ok(await _repository.GetAllAsync());
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var values = await _repository.GetByIdAsync(id);
            if (values == null)
            {
                return BadRequest("Aradığınız id Bulunamadı");  
            }
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentDto createCommentDto)
        {
            // BlogId'yi kullanarak veritabanında ilgili blogu arıyoruz.
            var blog = await _repository.GetByIdAsync(createCommentDto.BlogId);

            // Blog bulunamadıysa, hata mesajı döndür.
            if (blog == null)
            {
                return NotFound("Geçerli bir Blog Id gereklidir.");
            }

            // Blog var ise, yeni yorum nesnesi oluşturuluyor.
            var comment = new Comment
            {
                Name = createCommentDto.Name,
                CreatedDate = createCommentDto.CreatedDate,
                Description = createCommentDto.Description,
                BlogId = createCommentDto.BlogId
            };

            // Yorum veritabanına kaydediliyor.
            await _repository.CreateAsync(comment);

            return Ok("Yorum bilgisi başarıyla eklendi.");
        }



        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto updateCommentDto)
        {
            var values = await _repository.GetByIdAsync(updateCommentDto.CommentId);
            if (values == null)
            {
                return NotFound("Aradığınız id bulunamadı");
            }

            var blog = await _repository.GetByIdAsync(updateCommentDto.BlogId);
            if (blog == null)
            {
                return NotFound("Geçerli bir Blog Id gereklidir.");
            }

            values.Name = updateCommentDto.Name;
            values.CreatedDate = updateCommentDto.CreatedDate;
            values.Description = updateCommentDto.Description;
            values.BlogId = updateCommentDto.BlogId;

            await _repository.UpdateAsync(values);
            return Ok("Yorum bilgisi başarıyla güncellendi.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveComment(int id)
        {
            var comment = await _repository.GetByIdAsync(id);
            if (comment == null)
            {
                return NotFound("Aradığınız id bulunamadı");
            }

            await _repository.RemoveAsync(comment);
            return NoContent();
        }

    }
}
