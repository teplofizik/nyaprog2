using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Script
{
    /// <summary>
    /// База скриптов
    /// </summary>
    public class ScriptBase
    {
        /// <summary>
        /// Список генераторов
        /// </summary>
        List<ScriptStepGenerator> Generators = new List<ScriptStepGenerator>();

        /// <summary>
        /// Получить элемент для выполнения на основании информации для исполнения
        /// </summary>
        /// <param name="StepInfo">Информация для выполнения</param>
        /// <returns>Объект-выполнятор или null, если такой команды нет</returns>
        public virtual ScriptStep GetScriptStep(Programmer.ScriptStep StepInfo)
        {
            foreach(var G in Generators)
            {
                if(StepInfo.Name == G.Name)
                    return G.Get(StepInfo);
            }

            return null;
        }
    }
}
