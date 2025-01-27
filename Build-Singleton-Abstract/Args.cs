using System.Diagnostics;

public class ProcessArgs
{
    private static ProcessArgs empty = new ProcessArgs();
    public static ProcessArgs Empty => empty;
}

public class HiringArgs : ProcessArgs
{
    public Company Company {get; set;}
    public Employe Employe {get; set;}
}

public class DismissalArgs : ProcessArgs
{
    public Company Company { get; set; }
    public Employe Employe { get; set; }
}
public class WagePaymentArgs : ProcessArgs
{
    public Company Company { get; set; }
    public Employe Employe { get; set; }
}

public class VacationArgs : ProcessArgs{
    public Company Company {get; set;}

    public Employe Employe {get; set;}

    public int? Days {get; set;} 

}