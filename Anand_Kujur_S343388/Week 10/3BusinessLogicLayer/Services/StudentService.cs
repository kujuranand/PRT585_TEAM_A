

using _1CommonInfrastructure.Enum;
using _1CommonInfrastructure.Interfaces;
using _1CommonInfrastructure.Models;
using _1CommonInfrastructure.Validations;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class StudentService :   BaseService, IStudentService
    {
        private readonly IStudentDal _studentDal;
       
        public StudentService(IStudentDal studentDal,
            ISecurityService securityService,
            ILoggingService loggingService
        //IStudentDal studentDal,
        //IAuditDal auditDal
        ) : base(securityService, loggingService)
        {
            _studentDal = studentDal;           
        }

        public async Task<StudentModel?> GetById(int studentId)
        {           
            return _studentDal.GetById(studentId);
        }

        public async Task<List<StudentModel>> GetAll()
        {            
            return _studentDal.GetAll();
        }

        public async Task<int> CreateStudent(StudentModel student)
        {
            //await IsAuthorisedToAccess("StudentView");  //good 

            await IsAuthorisedToAccess(SystemActionsEnum.StudentAdd.ToString());  //good 
                        
            try
            {
                //write validations here
                CheckFluentValidation(await new StudentValidator().ValidateAsync(student));

                //any logs 
                LogInformation("CreateStudent-starting", $"step1 create student", student);
                var newStudentId = _studentDal.CreateStudent(student);
                LogInformation("CreateStudent-finished", $"step2 create student", student);
                return newStudentId;

            }
            catch (Exception e)
            {
                LogError("Error-CreateStudent", $"Error trying to create student", student, e);
            }           
           return 0;
        }

        public async Task UpdateStudent(StudentModel student)
        {
            //write validations here 
            _studentDal.UpdateStudent(student);
        }

        public async Task DeleteStudent(int studentId)
        {            
            try
            {
                _studentDal.DeleteStudent(studentId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete student Id:{studentId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
