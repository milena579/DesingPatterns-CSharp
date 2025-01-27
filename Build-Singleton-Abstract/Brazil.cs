public class BrazilDismissalProcess : DismissalProcess
{
    public override string Title => "Demissão de Funcionário";
    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 2 * args.Employe.Wage;
    }
}
public class BrazilWagePaymentProcess : WagePaymentProcess
{
    public override string Title => "Pagamento de Salário";
    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= 1.45m * args.Employe.Wage + 500;
    }
}

public class BrazilHirignProcess : HiringProcess
{
    public override string Title => "Contratação de Funcionário";

    public override void Apply(HiringArgs args)
    {
        args.Company.Money -= args.Employe.Wage;
    }
}
public class BrazilProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess() => new BrazilDismissalProcess();

    public HiringProcess CreateHiringProcess() => new BrazilHirignProcess();

    public WagePaymentProcess CreateWagePaymentProcess() => new BrazilWagePaymentProcess();
}