// Copyright (c) Creape. All Rights Reserved.

using MediatR;
using PSE.Application.DTOs;

namespace PSE.Application.Services.EventosService.Queries.ListEventosRequest
{
    public class ListEventosRequest: IRequest<List<EventosDTO>>
    {
    }
}
