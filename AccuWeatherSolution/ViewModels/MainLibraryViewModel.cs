using CommunityToolkit.Mvvm.ComponentModel;
using AccuWeatherSolution.Models;
using AccuWeatherSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace AccuWeatherSolution.ViewModels
{
    public partial class MainLibraryViewModel : ObservableObject
    {
        private ILibraryService _libraryService;
        private Book _selectedBook;
        private Book newBook;

        public MainLibraryViewModel(ILibraryService libraryService)
        {
            _libraryService = libraryService;
            Books = new ObservableCollection<Book>();
            newBook = new Book();
        }

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public ObservableCollection<Book> Books { get; set; }
        [RelayCommand]
        public async void LoadBooks()
        {
            var response = await _libraryService.GetAllBooksAsync();
            //var books = response.Data.ToList();
            var books = response.ToList();
            if (Books != null) { Books.Clear(); }
            foreach (var book in books)
                Books.Add(book);

        }
        

        public Book NewBook
        {
            get { return newBook; }
            set
            {
                if (newBook != value)
                {
                    newBook = value;
                    OnPropertyChanged(nameof(NewBook));
                }
            }
        }
       
        [RelayCommand]
        public async void CreateBook()
        {
            var book = NewBook;
            var response = _libraryService.CreateBookAsync(book);

        }
        
        //TODO: test update method (POST functionality) 
        [RelayCommand]
        public async void UpdateBook()
        {
            var book = NewBook;
            var response = _libraryService.EditBookAsync(book);

        }

        [RelayCommand]
        public async void DeleteBook()
        {
            var book = SelectedBook;
            var response = _libraryService.DeleteBookAsync(SelectedBook.Id);

        }

       
        [RelayCommand]
        public async void GetBook()
        {
            var book = newBook;
            var recievedBook = await _libraryService.GetBookAsync(newBook.Id);
            SelectedBook = recievedBook;
        }

    }
}
