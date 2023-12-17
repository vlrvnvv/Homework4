using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Homework4
{
    public class Zoo
    {
        private ObservableCollection<Animal> _animals = new ObservableCollection<Animal>();

        public Manager Manager { get; set; }

        public Zoo(Manager manager)
        {
            Manager = manager;
            _animals.CollectionChanged += Animals_CollectionChanged;
        }

        private void Animals_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:

                    if (e.NewItems?[0] is Animal animal)
                    {
                        animal.Notify += Manager.FeedAnimal;
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Animal oldAnimal)
                    {
                        oldAnimal.Notify -= Manager.FeedAnimal;
                    }
                    break;
            }
        }

        public void AddAnimal(Animal animal)
        {
            if (animal.Health > 30)
            {
                _animals.Add(animal);
            }
        }

        public void RemoveAnimal(Animal animal)
        {
            _animals.Remove(animal);
        }
    }
}
