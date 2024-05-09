using Microsoft.AspNetCore.Components;
using SubjectManager.Models;

namespace SubjectManager.Components.Pages;

public partial class Login
{
    public string? ErrorMessage;

    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = default!;

    [SupplyParameterFromForm]
    public LoginInput Input { set; get; } = new();

    private LoginInput _defaultLogin = new()
    {
        Email = "anthonygabriel642@gmail.com",
        Password = "agas124578"
    };

    public void LoginUser()
    {
        if (Input.Email.Equals(_defaultLogin.Email) && Input.Password.Equals(_defaultLogin.Password))
            RedirectManager.RedirectTo("/");
        else
            ErrorMessage = "Verify your credencials";
    }

}