using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaProg2Lib.Projects
{
    /// <summary>
    /// Проект
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Путь к проекту
        /// </summary>
        public readonly string Path;

        /// <summary>
        /// Открыть проект
        /// </summary>
        /// <param name="Path">Путь к проекту</param>
        public Project(string Path)
        {
            this.Path = Path;
        }

        /// <summary>
        /// Загрузка проекта
        /// </summary>
        /// <returns>true, если загружено</returns>
        public bool Load()
        {
            return false;
        }

        /// <summary>
        /// Сохранение проекта
        /// </summary>
        public void Save()
        {

        }

        /// <summary>
        /// Получить название проекта
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return null;
        }

        /// <summary>
        /// Загружен ли проект
        /// </summary>
        /// <returns>true, если загружено</returns>
        public bool IsLoaded()
        {
            return false;
        }
    }
}
