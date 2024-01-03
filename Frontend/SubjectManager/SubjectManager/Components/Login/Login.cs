using Microsoft.AspNetCore.Components;
using SubjectManager.Models;

namespace SubjectManager.Components;

public class Login
{
    public string? errorMessage;

    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = default!;

    [SupplyParameterFromForm]
    public LoginInput Input { set; get; } = new();

    private LoginInput defaultLogin = new()
    {
        Email = "anthonygabriel642@gmail.com",
        Password = "agas124578"
    };

    public void LoginUser()
    {
        if (Input.Email.Equals(defaultLogin.Email) && Input.Password.Equals(defaultLogin.Password))
            RedirectManager.RedirectTo("/");
        else
            errorMessage = "Verify your credencials";
    }

}