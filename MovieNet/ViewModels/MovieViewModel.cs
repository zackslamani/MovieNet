using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using MovieNet.Models;
using MovieNet.Commands;
using System.Collections.ObjectModel;
namespace MovieNet.ViewModels
{
    public class MovieViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged (string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        MovieService ObjMovieService;
        public MovieViewModel()
        {
            ObjMovieService = new MovieService();
            LoadData();
            CurrentMovie = new MovieDTO();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
        }
        #region DisplayOperation
        private ObservableCollection<MovieDTO> moviesList;

        public ObservableCollection<MovieDTO> MoviesList
        {
            get { return moviesList; }
            set { moviesList = value; OnPropertyChanged("MoviesList"); }
        }

        private void LoadData()
        {
            MoviesList = new ObservableCollection<MovieDTO> (ObjMovieService.GetAll());
        }
        #endregion

        private MovieDTO currentMovie;

        public MovieDTO CurrentMovie
        {
            get { return currentMovie; }
            set { currentMovie = value; OnPropertyChanged("CurrentMovie"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region SaveOperation
        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }
        public void Save()
        {
            try
            {
                var IsSaved = ObjMovieService.Add(CurrentMovie);
                LoadData();
                if (IsSaved)
                    Message = "Employee saved";
                else
                    Message = "Save operation failed";
            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

        #region SearchOperation

        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }
        public void Search() 
        { 
            try
            {
                var ObjMovie = ObjMovieService.search(CurrentMovie.Id);
                if (ObjMovie != null)
                {
                    CurrentMovie = ObjMovie;
                }
                else
                {
                    Message = "Movie Not found";
                }
            } catch (Exception ex)
            {

            }
        }
        #endregion

        #region UpdateOperation

        private RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }
        public void Update()
        {
            try
            {
                var IsUpdated = ObjMovieService.Update(CurrentMovie);
                if(IsUpdated)
                {
                    Message = "Movie Updated";
                    LoadData();
                }
                else
                {
                    Message = "Update Operation Failed";
                }
            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

        #region DeleteOperation

        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
            
        }
        public void Delete()
        {
            try
            {
                var IsDelete = ObjMovieService.Delete(CurrentMovie.Id);
                if(IsDelete)
                {
                    Message = "Movie deleted";
                        LoadData();
                }
                else
                {
                    Message = "Delete operation failed";
                }
            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

    }
}
