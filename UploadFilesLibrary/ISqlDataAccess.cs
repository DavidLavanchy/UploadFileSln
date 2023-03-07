namespace UploadFilesLibrary
{
    public interface ISqlDataAccess
    {
        Task SaveData(string storedProcedure, string connectionName, object parameters);
    }
}