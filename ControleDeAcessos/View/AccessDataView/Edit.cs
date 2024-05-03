using ControleDeAcessos.Data.Domain;
using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.View.AccessDataView;

public partial class Edit : Form
{
    private readonly int _accessDataId;
    private readonly IAccessDataService _accessDataService;
    private AccessData _accessData;

    public Edit(IServiceProvider serviceProvider, int accessDataId)
    {
        InitializeComponent();
        _accessDataId = accessDataId;
        _accessDataService = serviceProvider.GetRequiredService<IAccessDataService>();
        GetData();
    }

    private async void GetData()
    {
        _accessData = await _accessDataService.GetByIdAsync(_accessDataId);

        textBoxUsername.Text = _accessData.username;
        textBoxPassword.Text = await _accessDataService.DecryptPassword(_accessData.password);
        textBoxPlatform.Text = _accessData.platform;
        textBoxDescription.Text = _accessData.description;
    }

    private void buttonCancel_Click(object sender, EventArgs e) =>
        this.Close();

    private void buttonDisplayPassword_Click(object sender, EventArgs e) =>
        textBoxPassword.PasswordChar = (textBoxPassword.PasswordChar == '*') ? '\0' : '*';

    private async void buttonEdit_Click(object sender, EventArgs e)
    {
        if (textBoxUsername.Text.Length == 0 ||
            textBoxPassword.Text.Length == 0)
        {
            MessageBox.Show("Preencha os campos obrigatórios!", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _accessData.username = textBoxUsername.Text;
        _accessData.password = await _accessDataService.EncryptPassword(textBoxPassword.Text);
        _accessData.platform = textBoxPlatform.Text;
        _accessData.description = textBoxDescription.Text;
        await _accessDataService.UpdateAsync(_accessData);
        MessageBox.Show("Registro editado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}
