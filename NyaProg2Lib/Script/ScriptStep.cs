using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Script
{
    public class ScriptStep
    {
        /// <summary>
        /// Проверка выполняемости шага (наличие файла, устройства и т.д.)
        /// </summary>
        /// <returns>true, если можно попробовать работать</returns>
        public virtual bool Check()
        {
            // Код проверки шага не реализован!
            return true;
        }

        /// <summary>
        /// Выполнение шага
        /// </summary>
        public virtual void Start()
        {

        }

        /// <summary>
        /// Выполняется ли ещё задача...
        /// </summary>
        /// <returns>true, если выполняется</returns>
        public virtual bool IsBusy()
        {
            return false;
        }

        /// <summary>
        /// Отмена выполнения!
        /// </summary>
        public virtual void Stop()
        {

        }
    }
}
