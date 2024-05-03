using ControleDeAcessos.Data.Domain;
using ControleDeAcessos.Services;
using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.View.AccessDataView;

public partial class Details : Form
{
    private readonly int _accessDataId;
    private readonly IAccessDataService _accessDataService;
    private readonly IServiceProvider _serviceProvider;

    public Details(IServiceProvider serviceProvider, int accessDataId)
    {
        InitializeComponent();
        _accessDataId = accessDataId;
        _serviceProvider = serviceProvider;
        _accessDataService = serviceProvider.GetRequiredService<IAccessDataService>();

        GetData();
    }

    private async void GetData()
    {
        var accessData = await _accessDataService.GetByIdAsync(_accessDataId);

        textBoxUsername.Text = accessData.username;
        textBoxPassword.Text = await _accessDataService.DecryptPassword(accessData.password);
        textBoxPlatform.Text = accessData.platform;
        textBoxDescription.Text = accessData.description;
    }

    private void buttonClose_Click(object sender, EventArgs e) =>
        this.Close();

    private void buttonDisplayPassword_Click(object sender, EventArgs e) =>
        textBoxPassword.PasswordChar = (textBoxPassword.PasswordChar == '*') ? '\0' : '*';

    private void buttonCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(textBoxPassword.Text);
        MessageBox.Show("Conteúdo copiado para a área de transferência!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void buttonDelete_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show($"Deseja deletar o usuário?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            await _accessDataService.RemoveAsync(_accessDataId);
            this.Close();
        }
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        this.Hide();
        new AccessDataView.Edit(_serviceProvider, _accessDataId).ShowDialog();
        GetData();
        this.Show();
    }
}