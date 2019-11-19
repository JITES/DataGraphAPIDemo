namespace DataGrapiApi.Common.Email
{
    public interface IEmailProvider
    {
        int Port { get; }
        string Host { get; }
        string Server { get;  }
        string Password { get; }
        string UserName { get; }
    }

    
}
