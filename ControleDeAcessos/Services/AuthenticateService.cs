using ControleDeAcessos.Services.Intefaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;

namespace ControleDeAcessos.Services;

public class AuthenticateService
{
    private readonly IUserService _userService;

    public AuthenticateService(IServiceProvider serviceProvider)
    {
        _userService = serviceProvider.GetRequiredService<IUserService>();
    }

    public async Task<int> ValidatesAccess(string username, string password)
    {
        var result = await _userService.GetAllAsync();
        var user = result
            .FirstOrDefault(r => r.username.ToUpper() == username.ToUpper());

        if (user == null)
        {
            MessageBox.Show("Usuário ou senha inválido!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        var validatePassword = new PasswordHasher<User>()
            .VerifyHashedPassword(null, user.password, password);

        if (validatePassword == PasswordVerificationResult.Failed)
        {
            MessageBox.Show("Usuário ou senha inválido!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        return user.id;
    }
}
