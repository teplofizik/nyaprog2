using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Programmer
{
    /// <summary>
    /// Один скрипт с набором параметров и шагов
    /// </summary>
    public class Script
    {
        /// <summary>
        /// Получить шаги
        /// </summary>
        /// <returns>Шаги программированя для текущих параметров</returns>
        public virtual ScriptStep[] GetSteps()
        {
            return new ScriptStep[] { };
        }

        /// <summary>
        /// Получить список редактированных параметров
        /// </summary>
        /// <returns>список параметров</returns>
        public virtual ScriptParameter[] GetParameters()
        {
            return new ScriptParameter[] { };
        }

        /// <summary>
        /// Установить параметр программирования
        /// </summary>
        /// <param name="Name">Название параметра</param>
        /// <param name="Value">Значение параметра</param>
        public virtual void SetParameter(string Name, string Value)
        {

        }


    }
}
