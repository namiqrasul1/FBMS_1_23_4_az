using Lesson13WpfMvvmCoding.Commands;
using Lesson13WpfMvvmCoding.Data;
using Lesson13WpfMvvmCoding.Models;
using Lesson13WpfMvvmCoding.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lesson13WpfMvvmCoding.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {


        #region PropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
        }
        #endregion

        public MainViewModel()
        {
            DbContext = new();
            //People = new ObservableCollection<Person>();
            newPerson = new Person();
            SelectedPerson = null;

            AddCommand = new RelayCommand(AddPerson, obj => NewPerson.IsValid());

            DeleteCommand = new RelayCommand(execute: 
                                        obj => {
                                            DbContext.RemovePerson(SelectedPerson!); 
                                            DbContext.SaveChanges();
                                        },
                                             canExecute: obj => SelectedPerson is not null);

            EditCommand = new RelayCommand(GoEditPage, canEdit);

        }


        public AppDbContext DbContext { get; set; }

        //public ObservableCollection<Person> People { get; set; }
        private Person newPerson;

        public Person NewPerson
        {
            get { return newPerson; }
            set { newPerson = value; OnPropertyChanged(); }
        }

        private Person? selectedPerson;

        public Person? SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value; OnPropertyChanged(); }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        #region EditCommandSection
        public RelayCommand EditCommand { get; set; }

        public bool canEdit(object? obj)
        {
            Person? person = obj as Person;
            if (person is not null)
                return true;
            return false;
        }

        public void GoEditPage(object? obj)
        {
            Person? person = obj as Person;
            if(person is not null)
            {
                EditView editView = new EditView();
                editView.DataContext = new EditViewModel(person, DbContext);
                editView.ShowDialog();
            }
        }
        
        #endregion


        public void AddPerson(object? param)
        {
            DbContext.AddPerson(NewPerson);
            DbContext.SaveChanges();
            NewPerson = new();
        }


    }
}
