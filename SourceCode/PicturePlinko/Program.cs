using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace PicturePlinko
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {


                //Show Form
                Main formMain = new Main();
                ApplicationContext applicationContext = new ApplicationContext();
                applicationContext.MainForm = formMain;
                Application.Run(applicationContext);

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error while initializing (Program.Main).  Please ensure the configuration settings are correct. \n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogMessage("Error (Program.Main)", ex.Message);
                return 1;
            }
            finally
            {
                Application.Exit();
            }

        }



    }
}