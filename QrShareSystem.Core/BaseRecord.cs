using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrShareSystem.Core
{
    /// <summary>
    /// Структура обращения
    /// </summary>
    public class BaseRecord
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ФИО Заявителя
        /// </summary>
        public string ApplicantName { get; set; }

        /// <summary>
        /// ФИО руководителя
        /// </summary>
        public string ManagerName { get; set; }

        /// <summary>
        /// <b>Адрес</b> <br/>
        /// Адрес фактического проживания заявителя.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// <b>Тематика</b><br/>
        /// Тематика обращения, например, здравоохранение, ЖКХ, пенсионные вопросы.
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// <b>Содержание</b><br/>
        /// Краткое содержание обращения.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// <b>Резолюция</b><br/>
        /// Краткое решение руководителя по обращению
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// <b>Статус обращения</b><br/>
        /// Каждое обращение имеет несколько состояний «Создано» «Рассмотрено», «Отклонено
        /// </summary>
        public ResolutionStatus Status { get; set; }

        /// <summary>
        /// <b>Примечание</b><br/>
        /// Любая дополнительная информация по обращению.
        /// </summary>
        public string Comment { get; set; }
    }
}
