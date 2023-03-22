using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ordering.Application.Features.Orders.Queries.GetOrdersList;

namespace Ordering.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
}