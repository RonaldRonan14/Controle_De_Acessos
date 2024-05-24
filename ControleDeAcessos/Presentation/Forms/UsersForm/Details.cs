using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.Presentation.Forms.UsersForm;

public partial class Details : Form
{
    private readonly int _userId;
    private readonly IUserService _userService;
    private readonly IServiceProvider _serviceProvider;

    public Details(IServiceProvider serviceProvider, int userId)
    {
        InitializeComponent();
        _userId = userId;
        _serviceProvider = serviceProvider;
        _userService = serviceProvider.GetRequiredService<IUserService>();

        GetDataAsync();
    }

    private void buttonCancel_Click(object sender, EventArgs e) =>
        Close();

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        Hide();
        new Edit(_serviceProvider, _userId).ShowDialog();
        GetDataAsync();
        Show();
    }

    private void buttonResetPassword_Click(object sender, EventArgs e)
    {
        Hide();
        new ChangePassword(_serviceProvider, _userId).ShowDialog();
        Show();
    }

    private async void GetDataAsync()
    {
        var user = await _userService.GetByIdAsync(_userId);
        textBoxUsername.Text = user.username;
        textBoxName.Text = user.name;
        textBoxEmail.Text = user.email;
    }
}
