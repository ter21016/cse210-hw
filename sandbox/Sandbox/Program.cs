/*using System.Dynamic;

class Vehicle 
{
    public int wheels {get; set;}
    public string engine {get; set;}


    public void Move() {
        Console.WriteLine("The vehicle is moving")
    }


}

class Bike : Vehicle
{
    public Bike(){
        wheels = 2;
        engine = "none";
    }
}

class Truck : Vehicle
{
    public Truck()
    {
        wheels = 6;
        engine = "Diesel";

    }
}

class Car : Vehicle
{
    public Car(){
        wheels = 4;
        engine = "Gas"
    }
}

public class Employee
{
    protected string _name;
    protected string _idNumber;

    public Employee()
    {

    }
    

    public string GetName()
    {
        return  _name;


    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetidNumber()
    {
        return _idNumber;
    }


    public void SetidNumber(string idNumber)
    {
        _idNumber = idNumber;
    }

    public virtual float GetPay()
    {
        return -1;
    }

}

public class SalaryEmployee : Employee
{
    protected float _salary = 0;


    public float GetSalary()
    {
        return _salary;
    }

    public void SetSalary(float salary)
    {
        _salary = salary;
    }

    public override float GetPay()
    {
        return base.GetPay();
    }


}

public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;

    public float GetpayRate()
    {
        return _payRate;
    }

    public void SetpayRate( float _payRate)
    {
        _payRate = payRate;
    }
    
    public int GethourWorked()
    {
        return _hoursWorked;
    }

    public void SethoursWorked(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }

    public override float GetPay()
    {
        return _hoursWorked * _payRate;
    }
}

public class Program
{
    HourlyEmployee hEmployee = new HourlyEmployee();
    hEmployee.SetName("John");
    hEmployee.SetId("1234c");
    hEmployee.SetSpayRate("35);
    hEmployee.SerhoursWorked(15);

    SalaryEmployee sEmployee = new SalaryEmployee();
    sEmployee.SetName("Juan");
    sEmployee.SetId("425v");
    sEmployee.Salary(90000)

    DisplayEmployeeInformation(hEmployee);
    DisplayEmployeeInformation(sEmployee);

    Employee emp = new Employee();

    public static void DisplayEmployeeInformation(Employee employee)
    {
        
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay} ");
    }


}*/