// Copyright (c) Creape. All Rights Reserved.

using AutoMapper;
using MediatR;
using PSE.Application.DTOs;
using PSE.Domain.Interfaces.Repositories;

namespace PSE.Application.Services.EventosService.Queries.ListEventosRequest
{
    public class ListEventosRequestHandler : IRequestHandler<ListEventosRequest, List<EventosDTO>>
    {
        private readonly IMapper mapper;
        private readonly IEventosRepository eventosRepository;

        public ListEventosRequestHandler(
            IMapper mapper,
            IEventosRepository eventosRepository)
        {
            this.mapper = mapper;
            this.eventosRepository = eventosRepository; 
        }

        ///<inheritdoc/>
        public async Task<List<EventosDTO>> Handle(ListEventosRequest request, CancellationToken cancellationToken)
        {
            try 
            {
                var list = await this.eventosRepository.ListAsycn();

                var dtos = this.mapper.Map<List<EventosDTO>>(list);

                return dtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }   
    }
}
