namespace Terminology.Domain
{
    public class Column
    {
        /// <summary>
        /// Идентификатор колонки записи справочника НСИ
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Идентификатор принадлежности к записи справочника НСИ
        /// </summary>
        public required Guid DictionaryId { get; set; }

        /// <summary>
        /// Название колонки
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Значение колонки
        /// </summary>
        public required string Value { get; set; }
    }
}
