using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.Presentation.Forms.UsersForm;

public partial class Edit : Form
{
    private readonly int _userId;
    private readonly IUserService _userService;

    public Edit(IServiceProvider serviceProvider,
        int userId)
    {
        InitializeComponent();
        _userId = userId;
        _userService = serviceProvider.GetRequiredService<IUserService>();

        GetData();
    }

    private void buttonCancel_Click(object sender, EventArgs e) =>
        this.Close();

    private async void buttonEdit_ClickAsync(object sender, EventArgs e)
    {
        if (textBoxName.Text.Length == 0)
        {
            MessageBox.Show("Preencha os campos obrigatórios!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var user = await _userService.GetByIdAsync(_userId);
        user.name = textBoxName.Text;
        user.email = textBoxEmail.Text;

        await _userService.UpdateAsync(user);

        MessageBox.Show("Dados editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }

    private async void GetData()
    {
        var user = await _userService.GetByIdAsync(_userId);
        textBoxName.Text = user.name;
        textBoxEmail.Text = user.email;
    }
}
