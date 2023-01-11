using _1;



Dispatcher dis = new Dispatcher();
Handler handler = new Handler();

// Додаємо метод до івенту в Dispatcher
dis.NameChange += handler.OnDispatcherNameChange;

string? disName = Console.ReadLine();

while (disName != "End")
{
    dis.Name = disName;
    disName = Console.ReadLine();
}
