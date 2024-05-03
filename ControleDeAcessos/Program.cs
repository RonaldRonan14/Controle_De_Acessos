using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos;

public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var serviceProvider = new ServiceCollection()
            .AddDependencyInjection()
            .BuildServiceProvider();

        Application.Run(new View.AuthenticateView.Index(serviceProvider));
    }
}