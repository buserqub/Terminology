namespace Terminology.Domain
{
    public class Record
    {
        /// <summary>
        /// Идентификатор записи справочника НСИ
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Идентификатор принадлежности к справочнику НСИ
        /// </summary>
        public required Guid DictionaryId { get; set; }
    }
}
