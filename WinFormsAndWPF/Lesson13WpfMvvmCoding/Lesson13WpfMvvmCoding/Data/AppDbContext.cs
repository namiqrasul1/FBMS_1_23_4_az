using Lesson13WpfMvvmCoding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson13WpfMvvmCoding.Data
{
    public class AppDbContext
    {
        public ObservableCollection<Person> People { get; set; }
        private const string FILENAME = "people.json";
        public AppDbContext()
        {
            if (Path.Exists(FILENAME))
            {
                var json = File.ReadAllText(FILENAME);
                People = JsonSerializer.Deserialize<ObservableCollection<Person>>(json)!;
            }
            else People = new();
        }

        public void AddPerson(Person person) => People.Add(person);
        public void RemovePerson(Person person) => People.Remove(person);

        public void SaveChanges()
        {
            var json = JsonSerializer.Serialize(People);
            File.WriteAllText(FILENAME, json);
        }


        //public void RemovePerson(int id) {// find => delete}

    }
}
