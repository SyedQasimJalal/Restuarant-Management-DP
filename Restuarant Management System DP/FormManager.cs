using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_Management_System_DP
{
    internal class FormManager
    {
        
        public void OpenNewForm(Form thisForm, Form newForm)
        {
            newForm.Show();
            CloseForm(thisForm);
        }

        private void CloseForm(Form thisForm)
        {
            thisForm.Hide();
        }
    }
}
