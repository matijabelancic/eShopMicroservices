using AutoMapper;
using MediatR;
using Ordering.Application.Contracts.Persistence;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList;

public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, List<OrdersVm>>
{
    private readonly IOrderingRepository _orderingRepository;
    private readonly IMapper _mapper;

    public GetOrdersListQueryHandler(IOrderingRepository orderingRepository, IMapper mapper)
    {
        _orderingRepository = orderingRepository;
        _mapper = mapper;
    }

    public async Task<List<OrdersVm>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
    {
        var orderList = await _orderingRepository.GetOrdersByUserName(request.UserName);
        return _mapper.Map<List<OrdersVm>>(orderList);
    }
}