using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatisticsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StatisticsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetCarCount()
    {
        var values = await _mediator.Send(new GetAllStatisticQuery()); //Send Metodu handlerlara istekte bulunmayı sağlıyor.
        return Ok(values);
    }
}
