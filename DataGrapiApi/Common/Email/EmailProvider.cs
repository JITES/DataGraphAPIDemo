using DataGrapiApi.Common.Email;
using System;

public class EmailProvider<T> where T : class, IEmailProvider
{
    public string GetType(T t)
    {
        return typeof(T).Name;
    }
    public int Port { get; set ; }
    public string Host { get ; set ; }
    public string Server { get ; set ; }
    public string Password { get ; set ; }
    public string UserName { get ; set ; }

    public string ValidateProvider()
    {
        return "Validation Results";
    }
}
