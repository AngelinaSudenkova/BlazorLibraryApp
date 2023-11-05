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
        private string _responseText;
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

        public string ResponseText
        {
            get { return _responseText; }
            set
            {
                if (_responseText != value)
                {
                    _responseText = value;
                    OnPropertyChanged(nameof(ResponseText));
                }
            }
        }

        public ObservableCollection<Book> Books { get; set; }
        [RelayCommand]
        public async void LoadBooks()
        {
            var response = await _libraryService.GetAllBooksAsync();
            var books = response.Data.ToList();
            if (Books != null) { Books.Clear(); }
            foreach (var book in books)
                Books.Add(book);

            ResponseText = response.Message;

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
            var response = await _libraryService.CreateBookAsync(book);
            ResponseText = response.Message.ToString();

        }
         
        [RelayCommand]
        public async void UpdateBook()
        {
            var book = NewBook;
            var response = await _libraryService.EditBookAsync(book);
            ResponseText = response.Message.ToString();

        }

        [RelayCommand]
        public async void DeleteBook()
        {
            var book = SelectedBook;
            var response = await _libraryService.DeleteBookAsync(SelectedBook.Id);
            ResponseText = response.Message.ToString();

        }

       
        [RelayCommand]
        public async void GetBook()
        {
            var book = newBook;
            var recievedBook = await _libraryService.GetBookAsync(newBook.Id);
            SelectedBook = recievedBook.Data;
            ResponseText = recievedBook.Message.ToString();
        }

    }
}
