using EntertaimentCenter.Contracts;
using Microsoft.AspNetCore.Mvc;
using EntertaimentCenter.Application.Interfaces;
using AutoMapper;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Api.Models.Event;

namespace EntertaimentCenter.Api.Controllers
{
    [ApiController]
    public class CustomEventController : ControllerBase
    {
        private readonly IServices<CustomEvent> _service;
        private readonly IMapper _mapper;

        public CustomEventController(IServices<CustomEvent> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet(ApiRoutes.CustomEventRoutes.GetEvents)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(CancellationToken token)
        {
            var res = await _service.SelectAll(token);

            var response = _mapper.Map<List<ResponseCustomEventModel>>(res);

            return Ok(response);
        }

        [HttpGet(ApiRoutes.CustomEventRoutes.GetEventById)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id,
            CancellationToken token)
        {
            var foundEvent = await _service.FindById(id, token);

            var response = _mapper.Map<ResponseCustomEventModel>(foundEvent);

            return Ok(response);
        }

        [HttpPost(ApiRoutes.CustomEventRoutes.CreateEvent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Create(RequestCustomEventModel request,
            CancellationToken token)
        {
            var map = _mapper.Map<CustomEvent>(request);

            var createdId = await _service.Create(map, token);

            return Ok(createdId);
        }

        [HttpPatch(ApiRoutes.CustomEventRoutes.UpdateEvent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int id, [FromBody] RequestCustomEventModel request,
            CancellationToken token)
        {
            var newEvent = _mapper.Map<CustomEvent>(request);

            newEvent.Id = id;

            await _service.Update(newEvent, token);

            return Ok();
        }

        [HttpDelete(ApiRoutes.CustomEventRoutes.DeleteEvent)]
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
}