using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediaregister
{
    public partial class Mediaregisterform : Form
    {
        //Lista för 
        private List<Media> mediaList = new List<Media>();
        public Mediaregisterform()
        {
            InitializeComponent();
            
        }      
        private void addBookBtn(object sender, EventArgs e)
        {
            //Hämtar infon och skapar ett book-objekt med den
            Book book = new Book(bokTitelTextBox.Text, authorTextBox.Text, Convert.ToInt32(pagesUpDwn.Value));
            //Lägger till i listan
            mediaList.Add(book);

            listaTextBox.Text += book.ToString()+Environment.NewLine;


        }
    }
}
