using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Projects
{
    public class ProjectBase
    {
        /// <summary>
        /// Путь к папке с проектами
        /// </summary>
        public readonly string Path;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Path">Путь к папке с проектами</param>
        public ProjectBase(string Path)
        {
            this.Path = Path;
        }


    }
}
