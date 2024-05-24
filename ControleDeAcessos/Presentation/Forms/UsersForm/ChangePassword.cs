using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.Presentation.Forms.UsersForm;

public partial class ChangePassword : Form
{
    private readonly int _userId;
    private readonly IUserService _userService;

    public ChangePassword(IServiceProvider serviceProvider,
        int userId)
    {
        InitializeComponent();
        _userId = userId;
        _userService = serviceProvider.GetRequiredService<IUserService>();
    }

    private void buttonCancel_Click(object sender, EventArgs e) =>
        this.Close();

    private async void buttonConfirm_Click(object sender, EventArgs e)
    {
        if (textBoxPassword.Text.Length == 0 || textBoxConfirmPassword.Text.Length == 0)
        {
            MessageBox.Show("A senha não pode ser vazia", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (textBoxPassword.Text != textBoxConfirmPassword.Text)
        {
            MessageBox.Show("Senha diferentes", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var user = await _userService.GetByIdAsync(_userId);
        user.password = _userService.EncryptPassword(textBoxPassword.Text);
        await _userService.UpdateAsync(user);
        MessageBox.Show("Senha alterada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}
