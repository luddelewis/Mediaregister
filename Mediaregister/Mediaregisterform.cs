﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Mediaregister
{
    public partial class Mediaregisterform : Form
    {
        //Lista för media 
        private List<Media> mediaList = new List<Media>();
        //Variabel för att lagra den valda radioknappen, startar som alla
        private string checkedBtn = "Alla";
        public Mediaregisterform()
        {
            InitializeComponent();

        }
        private void Add_Book_Btn(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                //Hämtar infon och skapar ett book-objekt med den
                Book book = new Book(bookTitelTextBox.Text, authorTextBox.Text, Convert.ToInt32(pagesUpDwn.Value));
                mediaList.Add(book);
                PanelUpdate();
            }
           
        }
        private void Add_Film_Btn(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                //Hämtar infon och skapar ett film-objekt med den
                Film film = new Film(filmTitelTextBox.Text, directorTextBox.Text, Convert.ToInt32(lengthUpDwn.Value));
                mediaList.Add(film);
                PanelUpdate();
            }           
            
        }
        //Funktion för uppdatering av visningsfönstret
        private void PanelUpdate()
        {
            //Rensa textlistan
            listaTextBox.Text = string.Empty;
            //switch för att kolla radiobtns
            switch (checkedBtn)
            {
                case "Alla":
                    //alla
                    foreach (Media m in mediaList)
                    {
                        listaTextBox.Text += m.ToString() + Environment.NewLine;
                    }
                    break;
                case "Filmer":
                    //Endast av klassen film
                    foreach (Film f in mediaList.OfType<Film>())
                    {
                        listaTextBox.Text += f.ToString() + Environment.NewLine;
                    }
                    break;
                case "Böcker":
                    //Endast av klassen book
                    foreach (Book b in mediaList.OfType<Book>())
                    {
                        listaTextBox.Text += b.ToString() + Environment.NewLine;
                    }
                    break;
            }

            
            
        }
        //Körs när någon av radiobtns ändras
        private void Radio_Changed(object sender, EventArgs e)
        {
            //Har alltid värdet aktuell radiobtn
            checkedBtn = (sender as RadioButton).Text;
            PanelUpdate();
        }

        private bool CheckInput()
        {
            bool checkResult = false;
            if (tabControl.SelectedIndex == 0 && bookTitelTextBox.Text != String.Empty && authorTextBox.Text != String.Empty && pagesUpDwn.Value != 0 )
            {
                checkResult = true;
            }
            else if(filmTitelTextBox.Text != String.Empty && directorTextBox.Text != String.Empty && lengthUpDwn.Value != 0)
            {
                checkResult = true;
            }
            return checkResult;
        }

        
    }
}
