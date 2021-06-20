using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramm.Src.Zyrian.SchoolSimulator
{
    /// <summary>
    /// Школа.
    /// </summary>
    internal class School : IEnumerable<StudentGroup>
    {
        private readonly List<StudentGroup> _groups = new List<StudentGroup>();

        /// <summary>
        /// Метод, осуществляющий добавление группы.
        /// </summary>
        /// <param name="groupCode"> Код группы </param>
        public void AddGroup(string groupCode) => _groups.Add(new StudentGroup(groupCode));

        /// <summary>
        /// Удаление группы по её коду.
        /// </summary>
        /// <param name="groupCode"> Код группы </param>
        public void RemoveGroupByCode(string groupCode)
        {
            foreach (var group in _groups.ToList())
            {
                if (group.GroupCode.Equals(groupCode))
                {
                    _groups.Remove(group);
                }
            }
        }

        /// <summary>
        /// Нахождение группы по её коду.
        /// </summary>
        /// <param name="groupCode"> Код группы </param>
        /// <returns> group - группа, которая совпала с полученным кодом. 
        /// Если найти нужную группу не удалось, возвращается первая группа в списке групп.</returns>
        public StudentGroup FindGroup(string groupCode)
        {
            foreach (var group in _groups.ToList())
            {
                if (group.GroupCode.Equals(groupCode))
                {
                    return group;
                }  
            }
            return _groups.First();
        }

        public IEnumerator<StudentGroup> GetEnumerator() => _groups.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
