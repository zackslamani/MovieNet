using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace MovieNet.Models
{
    public class MovieDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string titre;

        public string Titre 
        {
            get { return titre; }
            set { titre = value; OnPropertyChanged("Titre"); }
        }

        public string resume;
        public string Resume
        {
            get { return resume; }
            set { resume = value; OnPropertyChanged("Resume"); }
        }

        public string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; OnPropertyChanged("Genre"); }
        }
    }
}
