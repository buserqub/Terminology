using System.ComponentModel.DataAnnotations.Schema;

namespace Terminology.Domain
{
    public class Record
    {
        /// <summary>
        /// Идентификатор записи справочника НСИ
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Справочник которому принадледит запись
        /// </summary>
        [Column("DictionaryId")]
        public required Dictionary Dictionary { get; set; }

        /// <summary>
        /// Список пар колонка-значение в записи
        /// </summary>
        public required List<Column> Columns { get; set; }
    }
}
