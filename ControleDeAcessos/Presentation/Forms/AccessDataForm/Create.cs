using ControleDeAcessos.Services.Intefaces;
using ControleDeAcessos.Core.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.Presentation.Forms.AccessDataForm;

public partial class Create : Form
{
    private readonly int _userId;
    private readonly IAccessDataService _accessDataService;

    public Create(int userId, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _userId = userId;
        _accessDataService = serviceProvider.GetRequiredService<IAccessDataService>();
    }

    private void buttonCancel_Click(object sender, EventArgs e) =>
        this.Close();

    private async void buttonCreate_Click(object sender, EventArgs e)
    {
        if (textBoxUsername.Text.Length == 0 ||
            textBoxPassword.Text.Length == 0)
        {
            MessageBox.Show("Preencha os campos obrigatórios!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var newAccessData = new AccessData()
        {
            username = textBoxUsername.Text,
            password = await _accessDataService.EncryptPassword(textBoxPassword.Text),
            description = textBoxDescription.Text,
            platform = textBoxPlatform.Text,
            userId = _userId
        };

        await _accessDataService.AddAsync(newAccessData);

        MessageBox.Show("Criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.Close();
    }

    private void buttonDisplayPassword_Click(object sender, EventArgs e) =>
        textBoxPassword.PasswordChar = (textBoxPassword.PasswordChar == '*') ? '\0' : '*';
}
