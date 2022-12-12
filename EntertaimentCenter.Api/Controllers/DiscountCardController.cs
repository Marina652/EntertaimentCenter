using AutoMapper;
using EntertaimentCenter.Api.Models.Discount;
using EntertaimentCenter.Api.Models.DiscountCard;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using EntertaimentCenter.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntertaimentCenter.Api.Controllers;

[ApiController]
public class DiscountCardController : ControllerBase
{
    private readonly IServices<DiscountCard> _service;
    private readonly IMapper _mapper;

    public DiscountCardController(IServices<DiscountCard> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(ApiRoutes.DiscountCardRoutes.GetDiscountCards)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        var res = await _service.SelectAll(token);

        var response = _mapper.Map<List<ResponceDiscountCardModel>>(res);

        return Ok(response);
    }

    [HttpGet(ApiRoutes.DiscountCardRoutes.GetDiscountCardById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id,
        CancellationToken token)
    {
        var foundObject = await _service.FindById(id, token);

        var response = _mapper.Map<ResponceDiscountCardModel>(foundObject);

        return Ok(response);
    }

    [HttpPost(ApiRoutes.DiscountCardRoutes.CreateDiscountCard)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create(RequestDiscountCardModel request,
        CancellationToken token)
    {
        var map = _mapper.Map<DiscountCard>(request);

        var createdId = await _service.Create(map, token);

        return Ok(createdId);
    }

    [HttpPatch(ApiRoutes.DiscountCardRoutes.UpdateDiscountCard)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] RequestDiscountCardModel request,
        CancellationToken token)
    {
        var newObject = _mapper.Map<DiscountCard>(request);

        newObject.Id = id;

        await _service.Update(newObject, token);

        return Ok();
    }

    [HttpDelete(ApiRoutes.DiscountCardRoutes.DeleteDiscountCard)]
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
