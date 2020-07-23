using System.Collections.Generic;
using System.Threading.Tasks;
using TN_TeacherUpdate_WebService;

namespace ASA.Apim.NetStdLib.Interfaces
{
    public interface ITNTeacherService
    {
        Task<IEnumerable<TN_TeacherUpdate>> GetTeachers(string accountFromHeader, string filter = "", int size = 0);
        Task<IEnumerable<TN_TeacherUpdate>> GetTeachers(string accountFromHeader, TN_TeacherUpdate_Filter[] filter, int size = 0);
    }
}