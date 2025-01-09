using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarFeaturesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarFeaturesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("GetCarFeatureListByCarId/{id:int}")]
    public async Task<IActionResult> GetCarFeatureListByCarId(int id)
    {
        var value = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
        return Ok(value);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCarFeature(int id)
    {
        var values = await _mediator.Send(new GetByIdQuery(id));
        return Ok(values);
    }


    [HttpPut]
    public async Task<IActionResult> UpdateCarFeature(UpdateCarFeatureAvailableChangeToFalseCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
    [HttpGet("CarFeatureChangeAvailableToFalse/{id:int}")]
    public async Task<IActionResult> CarFeatureChangeAvailableToFalse(int id)
    {
        await _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
        return Ok();
    }
    [HttpGet("CarFeatureChangeAvailableToTrue/{id:int}")]
    public async Task<IActionResult> CarFeatureChangeAvailableToTrue(int id)
    {
        await _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
        return Ok();
    }
    [HttpPost]
    public async Task<IActionResult> CreateCarFeatureByCarId(CreateCarFeatureByCarCommand command)
    {
        _mediator.Send(command);
        return Ok();
    }
}
