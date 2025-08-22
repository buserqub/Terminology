using System.Security.Cryptography;

namespace Terminology.Domain
{
    public class Dictionary
    {
        /// <summary>
        /// Идентификатор записи справочника
        /// </summary>
        public Guid Id { get; private set; } = Guid.NewGuid();

        /// <summary>
        /// Название справочника в соответствии с НСИ
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// OID справочника
        /// </summary>
        public required string Oid { get; set; }

        /// <summary>
        /// Версия справочника
        /// </summary>
        public required string Version { get; set; }

        /// <summary>
        /// Список записей в справочнике
        /// </summary>
        public required List<Record> Records { get; set; }
    }
}
