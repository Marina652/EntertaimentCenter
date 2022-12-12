using AutoMapper;
using EntertaimentCenter.Api.Models.Discount;
using EntertaimentCenter.Api.Models.Place;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using EntertaimentCenter.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntertaimentCenter.Api.Controllers;

[ApiController]
public class DiscountController : ControllerBase
{
    private readonly IServices<Discount> _service;
    private readonly IMapper _mapper;

    public DiscountController(IServices<Discount> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(ApiRoutes.DiscountRoutes.GetDiscounts)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        var res = await _service.SelectAll(token);

        var response = _mapper.Map<List<ResponceDiscountModel>>(res);

        return Ok(response);
    }

    [HttpGet(ApiRoutes.DiscountRoutes.GetDiscountById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id,
        CancellationToken token)
    {
        var foundObject = await _service.FindById(id, token);

        var response = _mapper.Map<ResponceDiscountModel>(foundObject);

        return Ok(response);
    }

    [HttpPost(ApiRoutes.DiscountRoutes.CreateDiscount)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create(RequestDiscountModel request,
        CancellationToken token)
    {
        var map = _mapper.Map<Discount>(request);

        var createdId = await _service.Create(map, token);

        return Ok(createdId);
    }

    [HttpPatch(ApiRoutes.DiscountRoutes.UpdateDiscount)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] RequestDiscountModel request,
        CancellationToken token)
    {
        var newObject = _mapper.Map<Discount>(request);

        newObject.Id = id;

        await _service.Update(newObject, token);

        return Ok();
    }

    [HttpDelete(ApiRoutes.DiscountRoutes.DeleteDiscount)]
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
