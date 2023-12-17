namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Zoo zoo = new Zoo(manager);

            Rabbit rabbit = new Rabbit() 
            { 
                Health = 40,
                Kindness = 100
            };
            
            // Добавили животное
            zoo.AddAnimal(rabbit);

            //Поставили здоровье меньше 0. Сработало событие и менеджер накормил животное
            rabbit.Health = -10;

            //Удалили животное из зоопарка
            zoo.RemoveAnimal(rabbit);

            //Снова поставили здоровье меньньше 0. Но т.к Менеджер уже отписался - он не покормил животное
            rabbit.Health = -10;
        }
    }
}
