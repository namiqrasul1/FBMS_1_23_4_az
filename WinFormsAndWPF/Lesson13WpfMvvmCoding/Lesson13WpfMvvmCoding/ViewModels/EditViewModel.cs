using Lesson13WpfMvvmCoding.Commands;
using Lesson13WpfMvvmCoding.Data;
using Lesson13WpfMvvmCoding.Models;
using Lesson13WpfMvvmCoding.Views;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Lesson13WpfMvvmCoding.ViewModels;

public class EditViewModel : INotifyPropertyChanged
{
    private Person? personForEdit;
    private Person? copyPersonForEdit;
    public Person? PersonForEdit { get => personForEdit; set { personForEdit = value; OnPropertyChanged(); } }
    public Person? CopyPersonForEdit { get => copyPersonForEdit; set { copyPersonForEdit = value; OnPropertyChanged(); } }

    public AppDbContext DbContext { get; set; }
    public EditViewModel(Person? personForEdit, AppDbContext dbContext)
    {
        DbContext = dbContext;
        PersonForEdit = personForEdit;
        CopyPersonForEdit = personForEdit?.Clone() as Person;
        CancelCommand = new RelayCommand(CloseEditPage);
        SaveCommand = new RelayCommand(Save, CanSaving);
    }

    // -----------------------------------------------------------------
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }

    // -----------------------------------------------------------------


    #region CancelCommandSection
    public RelayCommand CancelCommand{ get; set; }

    public void CloseEditPage(object? obj)
    {
        EditView? editView = obj as EditView;
        if(editView is not null)
            editView.Close();
    }

    #endregion

    #region SaveCommandSection
    public RelayCommand SaveCommand { get; set; }

    public bool CanSaving(object? obj)
    {
        return !(CopyPersonForEdit! == PersonForEdit!);
    }

    public void Save(object? obj)
    {
        //PersonForEdit = CopyPersonForEdit;
        DbContext.RemovePerson(PersonForEdit);
        PersonForEdit!.SetValue(CopyPersonForEdit!);
        DbContext.AddPerson(PersonForEdit);
        DbContext.SaveChanges();
    }


    #endregion
}
