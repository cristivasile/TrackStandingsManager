using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI
{
    public static class Utilities
    {

        /// <summary>
        /// Creates error label and appends it to a panel.
        /// </summary>
        /// <param name="error">Error message</param>
        /// <param name="parent">Panel to append to</param>
        
        public static void generateError(string error, FlowLayoutPanel parent)
        {
            Label newError = new Label();
            newError.Text = error;
            newError.Font = new Font("Consolas", 10);
            newError.ForeColor = System.Drawing.Color.Red;
            parent.Controls.Add(newError);
            newError.Width = Convert.ToInt32(0.75 * parent.Width);

        }

        /// <summary>
        /// Creates success label and appends it to a panel.
        /// </summary>
        /// <param name="success">Success message</param>
        /// <param name="panel">Panel to append to</param>
        public static void generateSuccess(string success, FlowLayoutPanel parent)
        {
            Label newSuccess = new Label();
            newSuccess.Text = success;
            newSuccess.Font = new Font("Consolas", 10);
            newSuccess.ForeColor = System.Drawing.Color.Green;
            parent.Controls.Add(newSuccess);
            newSuccess.Width = Convert.ToInt32(0.95 * parent.Width);
        }

    }
}
