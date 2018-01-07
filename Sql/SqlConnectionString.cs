using System.Configuration;

namespace WcfServiceLibrary.Sql
{
    public static class SqlConnectionString
    {
        public static string ConnectionString
            => ConfigurationManager.ConnectionStrings["AwsWcfService"].ConnectionString;
    }
}
