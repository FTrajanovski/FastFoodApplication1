using System.Windows.Forms;

namespace FastFoodResturante
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_Front());
        }

       
    }
}

//private void EnableTextBoxes()
//{
   // Action<Control.ControlCollection> func = null;

  //  func = (controls) =>
    //{
      //  foreach (Control control in controls)
        //    if (control is TextBox)
          //      (control as TextBox).Enabled = false;
            //else
              //  func(control.Controls);
    //};
   // func(Controls);
//}