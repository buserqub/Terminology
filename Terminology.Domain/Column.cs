using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Terminology.Domain
{
    public class Column
    {
        /// <summary>
        /// Идентификатор колонки записи справочника НСИ
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Запись которой принадлежит пара колонка-значение
        /// </summary>
        public required Record Record { get; set; }

        /// <summary>
        /// Название колонки
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Значение колонки
        /// </summary>
        public string? Value { get; set; }
    }
}
