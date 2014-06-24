using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;


namespace PicturePlinko
{
    public partial class Main : Form
    {

        #region [ Form Events ]

        /// <summary>
        /// Start of the application
        /// </summary>
        public Main()
        {
            InitializeComponent();

            txtSourceDirectory.Text = System.Configuration.ConfigurationManager.AppSettings.Get("SourceDirectory");
            txtTargetDirectory.Text = System.Configuration.ConfigurationManager.AppSettings.Get("TargetDirectory");

        }

        /// <summary>
        /// Form loading event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Select Source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSourceDirectory_Click(object sender, EventArgs e)
        {
            folderSelector.ShowNewFolderButton = false;
            folderSelector.SelectedPath = txtSourceDirectory.Text;


            DialogResult result = folderSelector.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSourceDirectory.Text = folderSelector.SelectedPath;
            }


        }

        /// <summary>
        /// Select Target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTargetDirectory_Click(object sender, EventArgs e)
        {

            folderSelector.ShowNewFolderButton = true;
            folderSelector.SelectedPath = txtTargetDirectory.Text;

            DialogResult result = folderSelector.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtTargetDirectory.Text = folderSelector.SelectedPath;
            }

        }


        /// <summary>
        /// Ends the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Logger.LogMessage("Exit", "Exiting Application");
            Application.Exit();
        }



        /// <summary>
        /// Runs the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                //Prep Form for running and send user to the logging tab
                txtSourceDirectory.Enabled = false;
                txtTargetDirectory.Enabled = false;
                btnSourceDirectory.Enabled = false;
                btnTargetDirectory.Enabled = false;
                btnClose.Enabled = false;
                btnRun.Enabled = false;
                tabMain.SelectedIndex = 1;

                //Reset Log
                txtLog.Clear();
                LogMessage("", "-----------------------------------------------------------");
                LogMessage("Begin", "Source Directory: " + txtSourceDirectory.Text);
                LogMessage("Begin", "Target Directory: " + txtTargetDirectory.Text);

                //Verify Inputs
                //Directory source = new Directory(txtSourceDirectory.Text);
                if (!Directory.Exists(txtSourceDirectory.Text) || !Directory.Exists(txtTargetDirectory.Text))
                {
                    LogMessage("Begin", "Invalid Source or Target Directories.  Please ensure the directories exist.");
                }
                else
                {
                    //Execute Plinko
                    Plinko(new DirectoryInfo(txtSourceDirectory.Text), new DirectoryInfo(txtTargetDirectory.Text));
                }


            }
            catch (Exception ex)
            {
                LogMessage("Error", ex.Message);
                MessageBox.Show("Error:" + ex.Message, "Error");
            }
            finally
            {
                LogMessage("", "-----------------------------------------------------------\n");
                txtSourceDirectory.Enabled = true;
                txtTargetDirectory.Enabled = true;
                btnSourceDirectory.Enabled = true;
                btnTargetDirectory.Enabled = true;
                btnClose.Enabled = true;
                btnRun.Enabled = true;
            }
        }

        /// <summary>
        /// View Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Application.log");
            }
            catch (Exception ex)
            {
                LogMessage("Error opening log file for viewing.", ex.Message);
                MessageBox.Show("Error:" + ex.Message, "Error Opening Log File");
            }

        }
        #endregion

        #region Logging


        /// <summary>
        /// Logs to the form and to the log file
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        private void LogMessage(string title, string message)
        {
            title = title.PadRight(10);

            //Log to Text File
            Logger.LogMessage(title, message);

            //Log to page
            txtLog.AppendText("\n" + System.DateTime.Now.ToShortTimeString() + ":   " + title + " - " + message);

            Application.DoEvents();
        }



        #endregion

        /// <summary>
        /// Plinko method copies the source files to the target directory with a defined directory structure
        /// Note, this could be a separate class, but then the logging would need event handlers so that this class could raise the log event back to the form
        /// </summary>
        /// <param name="sourceRoot"></param>
        /// <param name="targetRoot"></param>
        private void Plinko(DirectoryInfo sourceRoot, DirectoryInfo targetRoot)
        {
            try
            {


                FileInfo[] sourceFiles = sourceRoot.GetFiles("*.*", SearchOption.AllDirectories);
                foreach (FileInfo sourceFile in sourceFiles)
                {

                    DirectoryInfo targetSubFolder = GetTargetSubFolder(sourceFile, targetRoot);
                    FileInfo targetFile = CopyToTarget(sourceFile, targetSubFolder);



                    LogMessage("Plinko", "Source File: " + sourceFile.LastWriteTime.ToShortDateString() + " - " + sourceFile.FullName + "-->" + targetFile.FullName);


                }


            }
            catch (Exception ex)
            {
                LogMessage("Error", ex.Message);
                MessageBox.Show("Error:" + ex.Message, "Error in Plinko");
            }

        }



        /// <summary>
        /// Gets the folder name, Year and Quarter
        /// Ensures that the target folder exists and will create it if it does not exists
        /// </summary>
        /// <param name="fileCreatedDate"></param>
        /// <returns></returns>
        private DirectoryInfo GetTargetSubFolder(FileInfo sourceFile, DirectoryInfo targetRoot)
        {

            DateTime createDate = GetDateTakenFromImage(sourceFile);

            string targetFolderName;



            switch (createDate.Month)
            {
                case 1:
                case 2:
                case 3:
                    targetFolderName = createDate.Year.ToString() + "Q1";
                    break;
                case 4:
                case 5:
                case 6:
                    targetFolderName = createDate.Year.ToString() + "Q2";
                    break;
                case 7:
                case 8:
                case 9:
                    targetFolderName = createDate.Year.ToString() + "Q3";
                    break;
                case 10:
                case 11:
                case 12:
                    targetFolderName = createDate.Year.ToString() + "Q4";
                    break;
                default:
                    targetFolderName = createDate.Year.ToString();
                    break;
            }

            DirectoryInfo targetSubFolder = new DirectoryInfo(targetRoot.FullName + "\\" + targetFolderName);


            //Create Target Directory
            if (!targetSubFolder.Exists)
            {
                targetSubFolder = Directory.CreateDirectory(targetRoot.FullName + "\\" + targetFolderName);
            }

            return targetSubFolder;
        }



        /// <summary>
        /// http://stackoverflow.com/questions/180030/how-can-i-find-out-when-a-picture-was-actually-taken-in-c-sharp-running-on-vista
        /// retrieves the date time WITHOUT loading the whole image
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private DateTime GetDateTakenFromImage(FileInfo sourceFile)
        {
            DateTime result = sourceFile.LastWriteTime;
            try
            {
                Regex reg = new Regex(":");
                using (FileStream fs = new FileStream(sourceFile.FullName, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = reg.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);

                    //Ensure that this property has been set
                    if (!String.IsNullOrEmpty(dateTaken))
                    {

                        result = DateTime.Parse(dateTaken);
                    }
                }

                
            }
            catch (Exception ex)
            {
                LogMessage("Plinko", "Error, the Date Taken property was not set for the file.  The last write time [" + sourceFile.LastWriteTime.ToShortDateString() +"] will be used.  " + sourceFile.FullName + ". Error:" + ex.Message);

            }

            return result;
        }
        /// <summary>
        /// Copies the source file to the target sub directory.  Handles name conflicts by renaming the target file
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="targetSubFolder"></param>
        /// <returns></returns>
        private FileInfo CopyToTarget(FileInfo sourceFile, DirectoryInfo targetSubFolder)
        {

            FileInfo targetFile = new FileInfo(targetSubFolder.FullName + "\\" + sourceFile.Name);

            Int16 i = 0;
            while (targetFile.Exists)
            {
                //duck.jpg --> duck_001.jpg
                i++;
                targetFile = new FileInfo(targetSubFolder.FullName + "\\" + sourceFile.Name.Replace(sourceFile.Extension, "") + "_" + i.ToString().PadLeft(3, '0') + sourceFile.Extension);
            }

           File.Copy(sourceFile.FullName, targetFile.FullName);

            return targetFile;
        }



    }
}