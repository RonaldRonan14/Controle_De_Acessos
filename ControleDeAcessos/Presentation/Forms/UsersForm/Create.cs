using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.Presentation.Forms.UsersForm;

public partial class Create : Form
{
    private readonly IUserService _userService;

    public Create(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _userService = serviceProvider.GetRequiredService<IUserService>();
    }

    private void buttonCancel_Click(object sender, EventArgs e) =>
        this.Close();

    private void buttonDisplayPassword_Click(object sender, EventArgs e) =>
        textBoxPassword.PasswordChar = (textBoxPassword.PasswordChar == '*') ? '\0' : '*';

    private async void buttonCreate_Click(object sender, EventArgs e)
    {
        if (textBoxUsername.Text.Length == 0 ||
            textBoxPassword.Text.Length == 0 ||
            textBoxName.Text.Length == 0)
        {
            MessageBox.Show("Preencha os campos obrigatórios!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var user = await _userService.GetAllAsync();
        var checkUserExists = (user.FirstOrDefault(r => r.username.ToUpper() == textBoxUsername.Text.ToUpper()) is null) ? false : true;
        if (checkUserExists)
        {
            MessageBox.Show($"O usuário \"{textBoxUsername.Text}\" já existe", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var newUser = new Core.Entities.Users()
        {
            username = textBoxUsername.Text,
            password = _userService.EncryptPassword(textBoxPassword.Text),
            email = textBoxEmail.Text,
            name = textBoxName.Text,
        };

        await _userService.AddAsync(newUser);

        MessageBox.Show("Usuário criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.Close();
    }
}
