// Copyright (c) Creape. All Rights Reserved.

namespace PSE.Domain.Settings
{
    /// <summary>
    /// Dados de conexão.
    /// </summary>
    public class DbSettings
    {
        /// <summary>
        /// Gets or sets builder of DbProvider
        /// </summary>
        public string DbProvider { get; set; }

        /// <summary>
        /// Gets or sets UserSecret
        /// </summary>
        public bool UserSecret { get; set; }

        /// <summary>
        /// Gets or sets Server
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets Port
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// Gets or sets DataBase
        /// </summary>
        public string DataBase { get; set; }

        /// <summary>
        /// Gets or sets UID
        /// </summary>
        public string UID { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets SecrerName
        /// </summary>
        public string SecrerName { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        public string GetConnectionString => $"Host={Server};Port={Port};Database={DbProvider};Username={UID};Password={Password}; Command Timeout=180";
    }
}
