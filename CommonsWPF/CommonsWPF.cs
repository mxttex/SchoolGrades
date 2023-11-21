using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace SharedWPF
{
    internal class CommonsWPF
    {
        public enum MessageBoxButtons;
        internal static bool CheckIfStudentChosen(Student CurrentStudent)
        {
            if (CurrentStudent == null)
            {
                MessageBox.Show("Scegliere un allievo"
                    , "Operazione non possibile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}
