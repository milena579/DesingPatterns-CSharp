public class USDismissalProcess : DismissalProcess
{
    public override string Title => "Employee Dismissal";

    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 4 * args.Employe.Wage;
    }
}

public class USWagePaymentProcess : WagePaymentProcess
{
    public override string Title => "Wage Payment Process";

    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= 1.8m * args.Employe.Wage + 100;
    }
}

public class USHiringProcess : HiringProcess
{
    public override string Title => "Employee Hiring Process";

    public override void Apply(HiringArgs args)
    {
        args.Company.Money -= 0.3m * args.Employe.Wage;
    }
}

public class USVacation : VacationProcess
{
    public override string Title => throw new NotImplementedException();

    public override void Apply(VacationArgs args)
    {
        throw new NotImplementedException();
    }
}
public class USProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess() => new USDismissalProcess();

    public HiringProcess CreateHiringProcess() => new USHiringProcess();

    public WagePaymentProcess CreateWagePaymentProcess() => new USWagePaymentProcess();

    public VacationProcess CreateVacationProcess() => new USVacation();
}
