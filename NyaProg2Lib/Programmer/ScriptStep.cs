using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Programmer
{
    /// <summary>
    /// Один шаг скрипта (информация для выполнения только)
    /// </summary>
    public class ScriptStep
    {
        /// <summary>
        /// Название шага
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Название шага</param>
        public ScriptStep(string Name)
        {
            this.Name = Name;
        }

    }
}
