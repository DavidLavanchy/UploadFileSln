
namespace UploadFilesLibrary
{
    public class CustomerService
    {
        private readonly ISqlDataAccess _sqlDataAccess;

        public CustomerService(ISqlDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }

        
    }
}
