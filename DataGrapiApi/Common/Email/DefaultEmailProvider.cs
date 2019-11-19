using DataGrapiApi.Common.Email;

public class DefaultEmailProvider : IEmailProvider
{
    // Values to be fetched from appSettings.json 
    private int port = 25;
    private string host = "smtp.google.com";
    private string server = "google.com";
    private string password = "myPassHash";
    private string userName = "myUserName";

    public int Port { get { return this.port; } }
    public string Host { get { return this.host; } }
    public string Server { get { return this.server; } }
    public string Password { get { return this.password; } }
    public string UserName { get { return this.userName; } }
}


