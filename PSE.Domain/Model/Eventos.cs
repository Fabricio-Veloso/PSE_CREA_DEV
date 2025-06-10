// Copyright (c) Creape. All Rights Reserved.

namespace PSE.Domain.Model
{
    /// <summary>
    /// model de Eventos
    /// </summary>
    public class Eventos
    {
        /// <summary>
        /// Gets or sets Id do evento.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets Nome do evento.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Gets or sets Descricao do evento.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Gets or sets duração do evento.
        /// </summary>
        public int Duracao { get; set; }

        /// <summary>
        /// Gets or sets Vagas Totais do evento.
        /// </summary>
        public int VagasTotais { get; set; }

        /// <summary>
        /// Gets or sets inicio do evento.
        /// </summary>
        public DateTime StartEvento { get; set; }
    }
}
