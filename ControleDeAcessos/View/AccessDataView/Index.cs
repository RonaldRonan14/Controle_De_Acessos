using ControleDeAcessos.Services.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos.View.AccessDataView;

public partial class Index : Form
{
    private readonly int _userId;
    private readonly IAccessDataService _accessDataService;
    private readonly IServiceProvider _serviceProvider;

    public Index(int userId, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _userId = userId;
        _serviceProvider = serviceProvider;
        _accessDataService = serviceProvider.GetRequiredService<IAccessDataService>();
        GetAllAccessData();
    }

    private void criarNovoAcessoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new AccessDataView.Create(_userId, _serviceProvider).ShowDialog();
        GetAllAccessData();
    }

    private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        int accessDataId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
        new AccessDataView.Details(_serviceProvider, accessDataId).ShowDialog();
        GetAllAccessData();
    }

    private async void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
    {
        var data = await _accessDataService.GetAllAsync(_userId);
        var dataFilter = data.Where(r =>
            r.username.ToUpper().Contains(textBoxSearch.Text.ToUpper()) ||
            r.description.ToUpper().Contains(textBoxSearch.Text.ToUpper()))
            .ToList();
        if (dataFilter.Count() == 0) return;
        dataGridView1.DataSource = dataFilter;
    }

    private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new UsersView.Details(_serviceProvider, _userId).ShowDialog();
    }

    private async void GetAllAccessData()
    {
        var data = await _accessDataService.GetAllAsync(_userId);
        if (data.Count() == 0) return;
        dataGridView1.DataSource = data;

        dataGridView1.Columns["id"].Visible = false;
        dataGridView1.Columns["password"].Visible = false;
        dataGridView1.Columns["userId"].Visible = false;
        dataGridView1.Columns["User"].Visible = false;

        dataGridView1.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridView1.Columns["username"].HeaderText = "Usuário";
        dataGridView1.Columns["description"].HeaderText = "Descrição";
        dataGridView1.Columns["platform"].HeaderText = "Plataforma/Link";
    }
}
