using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToDto(this Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthsDay = student.BirthsDay,
                SchoolYear = student.SchoolYear,
                SchoolClass = student.SchoolClass,
                EducationLevel = student.EducationLevel,
                IsWoomen = student.IsWoomen,
            };
        }

        public static Student DtoToStuden(this StudentDto studentDto)
        {
            return new Student
            {
                Id = studentDto.Id,
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                BirthsDay = studentDto.BirthsDay,
                SchoolYear = studentDto.SchoolYear,
                SchoolClass = studentDto.SchoolClass,
                EducationLevel = studentDto.EducationLevel,
                IsWoomen = studentDto.IsWoomen,
            };
        }
    }
}
