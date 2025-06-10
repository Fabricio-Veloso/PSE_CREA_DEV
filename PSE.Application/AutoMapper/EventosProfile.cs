// Copyright (c) Creape. All Rights Reserved.

using AutoMapper;
using PSE.Application.DTOs;
using PSE.Domain.Model;

namespace PSE.Application.AutoMapper
{
    public class EventosProfile : Profile
    {
        public EventosProfile()
        {
            CreateMap<Eventos, EventosDTO>()
            .ReverseMap();
        }
    }
}
