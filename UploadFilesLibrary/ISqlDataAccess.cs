namespace UploadFilesLibrary
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T>(string storedProcedure, string connectionName, object parameters);
        Task SaveData(string storedProcedure, string connectionName, object parameters);
    }
}