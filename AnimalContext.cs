using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace CS_HW_Patterns_18_5
{
    internal class AnimalContext : DbContext
    {
        public AnimalContext() : base()
        { Database.EnsureCreated(); }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ANIMALS_DB.db");
        }

        public ObservableCollection<Animal> Add_New_Random()
        {
            var new_animal = RandomAnimal.NewRandomAnimal();
            this.Add(new_animal);
            this.SaveChanges();
            this.Animals.Load();
            return this.Animals.Local.ToObservableCollection();
        }

        public ObservableCollection<Animal> LoadToObsCollection()
        {
            this.Animals.Load();
            return this.Animals.Local.ToObservableCollection();
        }

        public ObservableCollection<Animal> Delete(Animal selected_animal)
        {
            this.Animals.Remove(selected_animal);
            this.SaveChanges();
            this.Animals.Load();
            return this.Animals.Local.ToObservableCollection();
        }

        public ObservableCollection<Animal> Edit(Animal selected_animal)
        {
            this.Entry(selected_animal).State = EntityState.Modified;
            this.SaveChanges();
            this.Animals.Load();
            return this.Animals.Local.ToObservableCollection();
        }

        public ObservableCollection<Animal> DeleteAll()
        {
            this.Animals.ExecuteDelete();
            this.SaveChanges();
            return this.Animals.Local.ToObservableCollection();
        }
    }
}
