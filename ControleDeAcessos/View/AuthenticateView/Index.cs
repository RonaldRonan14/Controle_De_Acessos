using ControleDeAcessos.Services;

namespace ControleDeAcessos.View.AuthenticateView;

public partial class Index : Form
{
    private readonly IServiceProvider _serviceProvider;

    public Index(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void buttonCreateAccount_Click(object sender, EventArgs e)
    {
        this.Hide();
        new UsersView.Create(_serviceProvider).ShowDialog();
        this.Show();
    }

    private async void buttonEnter_Click(object sender, EventArgs e)
    {
        var userId = await new AuthenticateService(_serviceProvider).ValidatesAccess(textBoxUsername.Text, textBoxPassword.Text);

        if (userId != 0)
        {
            this.Hide();
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            new AccessDataView.Index(userId, _serviceProvider).ShowDialog();
            this.Show();
        }
    }
}
