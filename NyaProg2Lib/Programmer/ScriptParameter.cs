using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Programmer
{
    /// <summary>
    /// Один параметр скрипта
    /// </summary>
    public class ScriptParameter
    {
        /// <summary>
        /// Название параметра
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Описание параметра
        /// </summary>
        public readonly string Description;

        /// <summary>
        /// Тип параметра
        /// </summary>
        public readonly ScriptParameterType Type;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Название параметра</param>
        /// <param name="Description">Описание</param>
        public ScriptParameter(ScriptParameterType Type, string Name, string Description)
        {
            this.Type = Type;
            this.Name = Name;
            this.Description = Description;
        }

        /// <summary>
        /// Получить значение
        /// </summary>
        /// <returns>Значение параметра</returns>
        public virtual string GetValue() => null;
    }
}
