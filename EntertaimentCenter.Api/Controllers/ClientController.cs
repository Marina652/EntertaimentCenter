using AutoMapper;
using EntertaimentCenter.Api.Models.Client;
using EntertaimentCenter.Api.Models.Event;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using EntertaimentCenter.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntertaimentCenter.Api.Controllers;

[ApiController]
public class ClientController : ControllerBase
{
    private readonly IServices<Client> _service;
    private readonly IMapper _mapper;

    public ClientController(IServices<Client> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(ApiRoutes.ClientRoutes.GetClients)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        var res = await _service.SelectAll(token);

        var response = _mapper.Map<List<ResponceClientModel>>(res);

        return Ok(response);
    }

    [HttpGet(ApiRoutes.ClientRoutes.GetClientById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id,
        CancellationToken token)
    {
        var foundClient = await _service.FindById(id, token);

        var response = _mapper.Map<ResponceClientModel>(foundClient);

        return Ok(response);
    }

    [HttpPost(ApiRoutes.ClientRoutes.CreateClient)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create(RequestClientModel request,
        CancellationToken token)
    {
        var map = _mapper.Map<Client>(request);

        var createdId = await _service.Create(map, token);

        return Ok(createdId);
    }

    [HttpPatch(ApiRoutes.ClientRoutes.UpdateClient)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] RequestClientModel request,
        CancellationToken token)
    {
        var newObject = _mapper.Map<Client>(request);

        newObject.Id = id;

        await _service.Update(newObject, token);

        return Ok();
    }

    [HttpDelete(ApiRoutes.ClientRoutes.DeleteClient)]
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
