using DataGrapiApi.Common.Email;
using System;

public class EmailProvider<T> where T : class, IEmailProvider
{
    public string GetType(T t)
    {
        return typeof(T).Name;
    }
    public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Server { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string ValidateProvider()
    {
        return "Validation Results";
    }
}


