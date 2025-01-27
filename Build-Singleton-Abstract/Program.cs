using System.Diagnostics;

var builder = Company.GetBuilder();
builder
    .SetName("Mercado Libre")
    .InArgentina()
    .SetInitialCapital(20_000_000);
builder
    .AddEmploye("Marquitos Guapo", 50_000)
    .AddEmploye("Paulito Pino", 20_000);
    Company.New(builder);
// Me rendí, me voy a Brasil
builder = Company.GetBuilder();
builder
    .SetName("Mercado Livre")
    .InBrazil()
    .SetInitialCapital(1_000_000);

builder
    .AddEmploye("Marcos Bonito", 2_500)
    .AddEmploye("Paulo Pinheiro", 1_000);

Company.New(builder);
Employe employe = new Employe();
employe.Name = "Xispita";
employe.Wage = 2_000;
Company.Current.Contract(employe);
Company.Current.Dismiss("Marcos Bonito");
Company.Current.PayWages(); 

builder = Company.GetBuilder();

builder.AddEmploye("Mark Pretty", 90_000);
builder.AddEmploye("Paul Pine", 70_000);

builder
    .SetName("Free Market")
    .InUnitedStates()
    .SetInitialCapital(800_000_000);

Company eua = builder.Build();

Company.New(builder);

Console.WriteLine(Company.Current.Money);

Employe newEmployee = new();
newEmployee.Name = "Milena";
newEmployee.Wage = 130_000;

Company.Current.Contract(newEmployee);

Console.WriteLine(Company.Current.Money);


foreach (var item in Company.Current.Employes)
{
    Console.WriteLine(item.Name);
}

