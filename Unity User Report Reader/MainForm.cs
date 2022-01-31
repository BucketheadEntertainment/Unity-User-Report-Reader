using Newtonsoft.Json;
using Unity_User_Report_Reader.Models;

namespace Unity_User_Report_Reader
{
    public partial class MainForm : Form
    {
        private string fileContent;
        private UserReport currentUserReport;

        private Image[] screenshots;
        private int currentScreenshotNo;


        public MainForm() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (currentUserReport == null)
                openJSONFileDialog.ShowDialog();
        }

        private void openJSONFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (sender is OpenFileDialog openFileDialog)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                        fileContent = reader.ReadToEnd();

                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        currentUserReport = JsonConvert.DeserializeObject<UserReport>(fileContent);
                        FillInForm();
                    }
                }

                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open file: " + ex.Message);
                Close();
            }
        }

        /// <summary>
        /// Fills in the entire form with the JSON file data.
        /// </summary>
        private void FillInForm()
        {
            FillInOverview();
            FillInImages();
            FillInDeviceMetaData();
            FillInEvents();
            FillInMeasures();
        }

        /// <summary>
        /// Fills in the overview of the form.
        /// </summary>
        private void FillInOverview()
        {
            thumbnailPictureBox.Image = !string.IsNullOrEmpty(currentUserReport.thumbnail.dataBase64) ? currentUserReport.thumbnail.dataBase64.ConvertBase64ToImage() : null;
            receivedOnTextBox.Text = currentUserReport.receivedOn.ToString();
            summaryTextBox.Text = !string.IsNullOrEmpty(currentUserReport.summary) ? currentUserReport.summary : null;
            categoryTextBox.Text = !string.IsNullOrEmpty(currentUserReport.fields[0].value) ? currentUserReport.fields[0].value : null;
            descriptionTextBox.Text = !string.IsNullOrEmpty(currentUserReport.fields[1].value) ? currentUserReport.fields[1].value : null;
        }

        /// <summary>
        /// Fills in the images of the form.
        /// </summary>
        private void FillInImages()
        {
            if (currentUserReport.screenshots.Length == 0)
                return;

            screenshots = new Image[currentUserReport.screenshots.Length];
            for (int i = 0; i < currentUserReport.screenshots.Length; i++)
                screenshots[i] = currentUserReport.screenshots[i].dataBase64.ConvertBase64ToImage();

            screenshotPictureBox.Image = screenshots[0];
            currentScreenshotNo = 0;
            UpdateImageCountTextBox();
        }

        /// <summary>
        /// Fills in the device's meta data.
        /// </summary>
        private void FillInDeviceMetaData()
        {
            for (int i = 0; i < currentUserReport.deviceMetadata.Length; i++)
                deviceMetadataGrid.Rows.Add(new string[2] { currentUserReport.deviceMetadata[i].name, currentUserReport.deviceMetadata[i].value });
        }

        /// <summary>
        /// Fills in the events data.
        /// </summary>
        private void FillInEvents()
        {
            for (int i = 0; i < currentUserReport.events.Length; i++)
                eventsDataGrid.Rows.Add(new string[7] { currentUserReport.events[i].exception, currentUserReport.events[i].frameNumber.ToString(), currentUserReport.events[i].fullMessage, currentUserReport.events[i].level.ToString(), currentUserReport.events[i].message, currentUserReport.events[i].stackTrace, currentUserReport.events[i].timestamp.ToString() });
        }

        private void FillInMeasures()
        {
            // TODO: Add graph.
        }

        /// <summary>
        /// Let the screenshot picture box browse to another image.
        /// </summary>
        /// <param name="nextImage">Is it the next image?</param>
        private void BrowseThroughImages(bool nextImage)
        {
            currentScreenshotNo = nextImage ? currentScreenshotNo + 1 : currentScreenshotNo - 1;

            if (nextImage && currentScreenshotNo >= screenshots.Length)
                currentScreenshotNo = 0;
            else if (!nextImage && currentScreenshotNo < 0)
                currentScreenshotNo = screenshots.Length - 1;

            screenshotPictureBox.Image = screenshots[currentScreenshotNo];
            UpdateImageCountTextBox();
        }

        /// <summary>
        /// Updates the text box with the image count.
        /// </summary>
        private void UpdateImageCountTextBox()
        {
            imageCountTextBox.Text = string.Format("{0}/{1}", currentScreenshotNo + 1, screenshots.Length);
        }

        private void previousImageButton_Click(object sender, EventArgs e)
        {
            BrowseThroughImages(false);
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {
            BrowseThroughImages(true);
        }
    }
}