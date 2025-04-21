using Microsoft.EntityFrameworkCore.Infrastructure;
using Task6.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Task6;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        DatabaseFacade facade = new DatabaseFacade(new ModelContext());
        facade.EnsureCreated();
    }
}

