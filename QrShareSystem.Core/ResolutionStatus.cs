using System;

namespace QrShareSystem.Core
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ReprAttribute : Attribute
    {
        public string Representation;
        public ReprAttribute(string representation)
        {
            Representation = representation;
        }
        public override string ToString()
        {
            return Representation;
        }
    }

    /// <summary>
    /// Статус заявления
    /// </summary>
    public enum ResolutionStatus : byte
    {
        /// <summary>
        /// Заявление создано
        /// </summary>
        [Repr("Создано")]
        Created,

        /// <summary>
        /// Заявление рассмотрено
        /// </summary>
        [Repr("Рассмотрено")]
        Considered,

        /// <summary>
        /// Заявление отклонено
        /// </summary>
        [Repr("Отклонено")]
        Rejected
    }
}