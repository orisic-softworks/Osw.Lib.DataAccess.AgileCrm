﻿namespace SFS.AgileCRM.Library.Data.Static.Internal
{
    /// <summary>
    /// The Exception Message.
    /// </summary>
    internal static class ExceptionMessage
    {
        /// <summary>
        /// Bad request exception message.
        /// </summary>
        public const string BadRequest = "400 (Bad Request) : Input in wrong format or entity already exists.";

        /// <summary>
        /// No content exception message.
        /// </summary>
        public const string NoContent = "204 (No Content) : No entity with specified identififer.";

        /// <summary>
        /// Not acceptable exception message.
        /// </summary>
        public const string NotAcceptable = "406 (Not Acceptable) : The limit of contacts has been exceeded.";

        /// <summary>
        /// Unauthorized exception message.
        /// </summary>
        public const string Unauthorized = "401 (Unauthorized) : Provided configuration is not authorized.";
    }
}