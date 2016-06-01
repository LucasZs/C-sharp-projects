using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MovieCatalog
{
    public partial class movieCollectionCatalogForm : Form
    {
        public movieCollectionCatalogForm()
        {
            InitializeComponent();
        }

        List<Movie> movies = new List<Movie>();
        List<Movie> resultList = new List<Movie>();

        private void movieCollectionCatalogForm_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\My Movie Collection Catalog"))
                Directory.CreateDirectory(path + "\\My Movie Collection Catalog");
            if (!File.Exists(path + "\\My Movie Collection Catalog\\settings.xml"))
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\My Movie Collection Catalog\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("Movies");
                xW.WriteEndElement();   
                xW.Close();
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\My Movie Collection Catalog\\settings.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("Movies/Movie"))
            {
                Movie m = new Movie();
                m.OriginalTitle = xNode.SelectSingleNode("OriginalTitle").InnerText;
                m.HungarianTitle = xNode.SelectSingleNode("HungarianTitle").InnerText;
                m.PremiereYear = xNode.SelectSingleNode("PremiereYear").InnerText;
                m.VideoFormat = xNode.SelectSingleNode("VideoFormat").InnerText;
                m.Notes = xNode.SelectSingleNode("Notes").InnerText;
                movies.Add(m);
                resultList.Add(m);
                moviesListView.Items.Add(m.OriginalTitle);
            }
        }

        private void btnAddAsNew_Click(object sender, EventArgs e)
        {
            if((originalTitleTextbox.Text.Length==0)
                &(videoFormatComboBox.Text.Length==0))
            {
                MessageBox.Show("The fields 'Original title' and 'Video format' cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (originalTitleTextbox.Text.Length == 0)
            {
                MessageBox.Show("The field 'Original title' cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (videoFormatComboBox.Text.Length == 0)
            {
                MessageBox.Show("The field 'Video format' cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(premiereYearTextbox.Text == ""))
            {
                if (!((premiereYearTextbox.Text.Length == 4)
                    & ((premiereYearTextbox.Text.StartsWith("18"))
                        || (premiereYearTextbox.Text.StartsWith("19"))
                        || (premiereYearTextbox.Text.StartsWith("20")))))
                {
                    MessageBox.Show("Filling the field 'Premiere year' is optional but the actually given data format is not correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   AddNewMovieToList();
                }
            }
            else
            {
                AddNewMovieToList();
            }
            saveToFileButton.Enabled = true;
        }

        void AddNewMovieToList()
        {
            Movie m = new Movie();
            m.OriginalTitle = originalTitleTextbox.Text;
            m.HungarianTitle = hungarianTitleTextbox.Text;
            m.PremiereYear = premiereYearTextbox.Text;
            m.VideoFormat = videoFormatComboBox.Text;
            m.Notes = notesTextbox.Text;
            movies.Add(m);
            resultList.Add(m);
            moviesListView.Items.Add(m.OriginalTitle);
            originalTitleTextbox.Text = "";
            hungarianTitleTextbox.Text = "";
            premiereYearTextbox.Text = "";
            videoFormatComboBox.Text = "";
            notesTextbox.Text = "";
        }

        private void moviesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moviesListView.SelectedItems.Count == 0) return;
            if (resultList.Count == 0)
            {
                originalTitleTextbox.Text = movies[moviesListView.SelectedItems[0].Index].OriginalTitle;
                hungarianTitleTextbox.Text = movies[moviesListView.SelectedItems[0].Index].HungarianTitle;
                premiereYearTextbox.Text = movies[moviesListView.SelectedItems[0].Index].PremiereYear;
                videoFormatComboBox.Text = movies[moviesListView.SelectedItems[0].Index].VideoFormat;
                notesTextbox.Text = movies[moviesListView.SelectedItems[0].Index].Notes;
                
            }
            else
            {
                originalTitleTextbox.Text = resultList[moviesListView.SelectedItems[0].Index].OriginalTitle;
                hungarianTitleTextbox.Text = resultList[moviesListView.SelectedItems[0].Index].HungarianTitle;
                premiereYearTextbox.Text = resultList[moviesListView.SelectedItems[0].Index].PremiereYear;
                videoFormatComboBox.Text = resultList[moviesListView.SelectedItems[0].Index].VideoFormat;
                notesTextbox.Text = resultList[moviesListView.SelectedItems[0].Index].Notes;
            }
            btnAddAsNew.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
            saveToFileButton.Enabled = true;
        }

        void Remove()
        {
            if (moviesListView.SelectedItems.Count == 0) return;
            

            Movie movie = movies[(int)moviesListView.SelectedItems[0].Index];
            movies.RemoveAt((int)moviesListView.SelectedItems[0].Index);
            moviesListView.Items.Remove(moviesListView.SelectedItems[0]);
            movies.Remove(movie);


            originalTitleTextbox.Text = "";
            hungarianTitleTextbox.Text = "";
            premiereYearTextbox.Text = "";
            videoFormatComboBox.Text = "";
            notesTextbox.Text = "";
            btnAddAsNew.Enabled = true;
        }
        
        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\My Movie Collection Catalog\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("Movies");
            xNode.RemoveAll();
            foreach (Movie m in movies)
            {
                XmlNode xTop = xDoc.CreateElement("Movie");
                XmlNode xOriginalTitle = xDoc.CreateElement("OriginalTitle");
                XmlNode xHungarianTitle = xDoc.CreateElement("HungarianTitle");
                XmlNode xPremiereYear = xDoc.CreateElement("PremiereYear");
                XmlNode xVideoFormat = xDoc.CreateElement("VideoFormat");
                XmlNode xNotes = xDoc.CreateElement("Notes");

                xOriginalTitle.InnerText = m.OriginalTitle;
                xHungarianTitle.InnerText = m.HungarianTitle;
                xPremiereYear.InnerText = m.PremiereYear.ToString();
                xVideoFormat.InnerText = m.VideoFormat;
                xNotes.InnerText = m.Notes;

                xTop.AppendChild(xOriginalTitle);
                xTop.AppendChild(xHungarianTitle);
                xTop.AppendChild(xPremiereYear);
                xTop.AppendChild(xVideoFormat);
                xTop.AppendChild(xNotes);

                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\My Movie Collection Catalog\\settings.xml");
            MessageBox.Show("The xml file is succesfully modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            moviesListView.Items.Clear();
            resultList.Clear();
                foreach (Movie movie in movies)
                {
                    if (movie.OriginalTitle.ToLower().Contains(searchTextbox.Text.ToLower())
                            ||movie.HungarianTitle.ToLower().Contains(searchTextbox.Text.ToLower())
                            ||(movie.PremiereYear.ToLower().Contains(searchTextbox.Text.ToLower())
                            ||movie.VideoFormat.ToLower().Contains(searchTextbox.Text.ToLower())
                            ||movie.Notes.ToLower().Contains(searchTextbox.Text.ToLower())))
                    {
                        resultList.Add(movie);
                        moviesListView.Items.Add(movie.OriginalTitle);
                    }
                }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            originalTitleTextbox.Text = "";
            hungarianTitleTextbox.Text = "";
            premiereYearTextbox.Text = "";
            videoFormatComboBox.Text = "";
            notesTextbox.Text = "";
            btnAddAsNew.Enabled = true;
        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            if (moviesListView.SelectedItems.Count == 0) return;
            resultList[moviesListView.SelectedItems[0].Index].OriginalTitle = originalTitleTextbox.Text;
            resultList[moviesListView.SelectedItems[0].Index].HungarianTitle = hungarianTitleTextbox.Text;
            resultList[moviesListView.SelectedItems[0].Index].PremiereYear = premiereYearTextbox.Text;
            resultList[moviesListView.SelectedItems[0].Index].VideoFormat = videoFormatComboBox.Text;
            resultList[moviesListView.SelectedItems[0].Index].Notes = notesTextbox.Text;
            saveToFileButton.Enabled = true;
        }

        class Movie
        {
            public string OriginalTitle { get; set; }
            public string HungarianTitle { get; set; }
            public string PremiereYear { get; set; }
            public string VideoFormat { get; set; }
            public string Notes { get; set; }
        }
    }
}


