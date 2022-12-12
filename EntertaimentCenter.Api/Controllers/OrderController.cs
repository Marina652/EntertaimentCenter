using AutoMapper;
using EntertaimentCenter.Api.Models.Client;
using EntertaimentCenter.Api.Models.Event;
using EntertaimentCenter.Api.Models.Order;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using EntertaimentCenter.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntertaimentCenter.Api.Controllers;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly IServices<Order> _service;
    private readonly IMapper _mapper;

    public OrderController(IServices<Order> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(ApiRoutes.OrderRoutes.GetOrders)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        var res = await _service.SelectAll(token);

        var response = _mapper.Map<List<ResponceOrderModel>>(res);

        return Ok(response);
    }

    [HttpGet(ApiRoutes.OrderRoutes.GetOrderById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id,
        CancellationToken token)
    {
        var foundObject = await _service.FindById(id, token);

        var response = _mapper.Map<ResponceOrderModel>(foundObject);

        return Ok(response);
    }

    [HttpPost(ApiRoutes.OrderRoutes.CreateOrder)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create(RequestOrderModel request,
        CancellationToken token)
    {
        var map = _mapper.Map<Order>(request);

        var createdId = await _service.Create(map, token);

        return Ok(createdId);
    }

    [HttpPatch(ApiRoutes.OrderRoutes.UpdateOrder)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] RequestOrderModel request,
        CancellationToken token)
    {
        var newObject = _mapper.Map<Order>(request);

        newObject.Id = id;

        await _service.Update(newObject, token);

        return Ok();
    }

    [HttpDelete(ApiRoutes.OrderRoutes.DeleteOrder)]
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
