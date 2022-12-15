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
    private readonly IServices<Order> _orderService;
    private readonly IServices<Client> _clientService;
    private readonly IServices<DiscountCard> _discountCardService;
    private readonly IServices<Discount> _discountService;
    private readonly IServices<Place> _placeService;
    private readonly IServices<CustomEvent> _eventService;
    private readonly IMapper _mapper;

    public OrderController(IServices<Order> orderService, 
        IServices<Client> clientService,
        IServices<DiscountCard> discountCardService,
        IServices<Discount> discountService,
        IServices<Place> placeService,
        IServices<CustomEvent> eventService,
        IMapper mapper)
    {
        _orderService = orderService;
        _clientService = clientService;
        _discountCardService = discountCardService;
        _discountService = discountService;
        _placeService = placeService;
        _eventService = eventService;
        _mapper = mapper;
    }

    [HttpGet(ApiRoutes.OrderRoutes.GetFullOrdersInformation)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetFullInformation(CancellationToken token)
    {
        var orders = await _orderService.SelectAll(token);

        var discountCards = await _discountCardService.SelectAll(token);

        var fullOrderInformationList = new List<FullOrderInformation>();

        foreach (var order in orders)
        {
            var orderClient = await _clientService.FindById(order.ClientId);
            var discountCard = await _discountCardService.FindById(order.ClientId);
            var orderEvent = (await _eventService.SelectAll(token)).FirstOrDefault(i => i.Id == order.CustomEventId);

            fullOrderInformationList.Add(new FullOrderInformation
            {
                OrderId = order.Id,
                ClientName = orderClient.Name,
                ClientEmail = orderClient.Email,
                DiscountValue = (await _discountService.FindById(discountCard.DiscountId)).Value,
                EventDescription = orderEvent.Description,
                StartTime = orderEvent.StartTime,
                PlaceId = (await _placeService.FindById(order.PlaceId)).Id,
                OrderStatus = order.Status,
            });
        }

        return Ok(fullOrderInformationList);
    }

    [HttpGet(ApiRoutes.OrderRoutes.GetOrders)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        var res = await _orderService.SelectAll(token);

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
        var foundObject = await _orderService.FindById(id, token);

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

        var createdId = await _orderService.Create(map, token);

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

        await _orderService.Update(newObject, token);

        return Ok();
    }

    [HttpDelete(ApiRoutes.OrderRoutes.DeleteOrder)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id,
        CancellationToken token)
    {
        await _orderService.Delete(id, token);

        return Ok();
    }
}
