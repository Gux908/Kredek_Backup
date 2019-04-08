using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KacperStudennyZadanieDomoweLab1
{
    public partial class FormEvent : Form
    {
        /// <summary>
        /// Konsturktor, przekazywany jest string z wiadomością która się wyświetli
        /// </summary>
        /// <param name="message"></param>
        public FormEvent(String message)
        {
            InitializeComponent();
            labelMessage.Parent = pictureBoxLetter;
            labelMessage.Text = message;
            Show();
        }
    }
}
