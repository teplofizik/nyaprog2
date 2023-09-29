using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Script
{
    /// <summary>
    /// Генератор шага
    /// </summary>
    class ScriptStepGenerator
    {
        /// <summary>
        /// Название шага
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Получить объект для выполнения этапа программирования
        /// </summary>
        /// <param name="StepInfo">Информация для генерации</param>
        /// <returns>Выполнятор</returns>
        public virtual ScriptStep Get(Programmer.ScriptStep StepInfo) => null;
    }
}
