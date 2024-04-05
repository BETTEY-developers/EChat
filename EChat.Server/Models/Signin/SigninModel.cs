namespace EChat.Server.Models.Signin;

internal enum SigninMode
{
    Signin,
    Signup
}

internal class SigninModel
{
    public SigninMode Mode { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}
