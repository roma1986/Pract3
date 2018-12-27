using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pract3
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Note> Notes { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Notes = new ObservableCollection<Note>
            {
                new Note { Name="Roman Romanov", Phone=94730, Birsday="01-01-2001" },
                new Note { Name ="Ivan Ivanov", Phone = 94736, Birsday = "01-05-2001" }
            };
            this.BindingContext = this;
        }

        public class Note
        {
            public string Name { get; set; }
            public double Phone { get; set; }
            public string Birsday { get; set; }
        }

        public override string ToString()
        {
            return NewName.Text + " " + NewSecName.Text;
        }

        // добавление объекта
        private void AddItem(object sender, EventArgs e)
        {
            string NameSecName = ToString();
            Notes.Add(new Note { Name = NameSecName, Phone = int.Parse(NewPhone.Text), Birsday = NewBirsday.Text });
        }

        // удаление выделенного объекта
        private void RemoveItem(object sender, EventArgs e)
        {
            Note Note = NoteList.SelectedItem as Note;
            if (Note != null)
            {
                Notes.Remove(Note);
                NoteList.SelectedItem = null;
            }
        }
    }
}
