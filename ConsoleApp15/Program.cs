using ConsoleApp15;

employe emp1=new fullTimeEmploye("Ali",12345, 1500, 20);
employe emp2 = new PartTimeEmploye("Ali",12345, 1500, 12);

employe[] employes = new employe[]{ emp1, emp2 };
foreach (employe emp in employes)
{
    emp.DisplayInfo();
}
