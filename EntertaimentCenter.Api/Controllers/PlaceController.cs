using AutoMapper;
using EntertaimentCenter.Api.Models.Client;
using EntertaimentCenter.Api.Models.Order;
using EntertaimentCenter.Api.Models.Place;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using EntertaimentCenter.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntertaimentCenter.Api.Controllers;

[ApiController]
public class PlaceController : ControllerBase
{
    private readonly IServices<Place> _service;
    private readonly IMapper _mapper;

    public PlaceController(IServices<Place> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(ApiRoutes.PlaceRoutes.GetPlaces)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        var res = await _service.SelectAll(token);

        var response = _mapper.Map<List<ResponcePlaceModel>>(res);

        return Ok(response);
    }

    [HttpGet(ApiRoutes.PlaceRoutes.GetPlaceById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id,
        CancellationToken token)
    {
        var foundObject = await _service.FindById(id, token);

        var response = _mapper.Map<ResponcePlaceModel>(foundObject);

        return Ok(response);
    }

    [HttpPost(ApiRoutes.PlaceRoutes.CreatePlace)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create(RequestPlaceModel request,
        CancellationToken token)
    {
        var map = _mapper.Map<Place>(request);

        var createdId = await _service.Create(map, token);

        return Ok(createdId);
    }

    [HttpPatch(ApiRoutes.PlaceRoutes.UpdatePlace)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] RequestPlaceModel request,
        CancellationToken token)
    {
        var newObject = _mapper.Map<Place>(request);

        newObject.Id = id;

        await _service.Update(newObject, token);

        return Ok();
    }

    [HttpDelete(ApiRoutes.PlaceRoutes.DeletePlace)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id,
        CancellationToken token)
    {
        await _service.Delete(id, token);

        return Ok();
    }
}
