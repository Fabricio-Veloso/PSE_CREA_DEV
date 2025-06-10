// Copyright (c) Creape. All Rights Reserved.

using PSE.Domain.Model;

namespace PSE.Domain.Interfaces.Repositories
{
    public interface IEventosRepository
    {
        Task<IEnumerable<Eventos>> ListAsycn();
    }
}
