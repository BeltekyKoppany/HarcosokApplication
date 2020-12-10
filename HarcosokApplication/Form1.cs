using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class harcosForm : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public harcosForm()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Adatkapcsolati hiba!");
            }
            harcosokListaRefresh();
            kepessegekListaRefresh();
        }
        private void nevLetrehozas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nevTextBox.Text))
            {
                MessageBox.Show("Adjon meg első sorban egy nevet.");
                return;
            }
            //Kiolvasom a név értékét
            string hNev = nevTextBox.Text;
            // Név ellenőrzése adatbázisban
            if (isExistHarcos(hNev))
            {
                MessageBox.Show("Már létezik ilyen nevű harcos.");
                return;
            }
            if (beszuras(hNev))
            {
                MessageBox.Show("Sikeres beszúrás.");
                nevTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen beszúrás.");
            }
            harcosokListaRefresh();
        }

        private bool beszuras(string nev)
        {
            bool vissza = false;
            sql.CommandText = "INSERT INTO `harcosok` (`id`, `nev`, `letrehozas`) VALUES (NULL, '" + nev + "', current_timestamp());";
            if (sql.ExecuteNonQuery() == 1)
            {
                vissza = true;
            }
            return vissza;
        }

        private bool isExistHarcos(string nev)
        {
            bool vissza = false;
            sql.CommandText = "SELECT COUNT(*) AS db FROM `harcosok` WHERE `nev` LIKE \"" + nev + "\"";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (dr.GetInt32("db") > 0)
                    {
                        vissza = true;
                    }
                }
            };
            return vissza;
        }
        private void harcosokListaRefresh()
        {
            harcosokListBox.Items.Clear();
            hasznaloComboBox.Items.Clear();
            sql.CommandText = "SELECT `id`, `nev`, `letrehozas` FROM `harcosok` WHERE 1";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    Harcos uj = new Harcos(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDateTime("letrehozas"));
                    harcosokListBox.Items.Add(uj);
                    hasznaloComboBox.Items.Add(uj);
                }
            }
        }

        private void kepessegHozzaadButton_Click(object sender, EventArgs e)
        {
            string kNev = kepessegNeveTextBox.Text;
            string kLeiras = leirasTextBox.Text;
            string kHasznalo = hasznaloComboBox.Text;
            //Választott harcos ellenőrzése
            if (hasznaloComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon harcost, aki a képességet fogja használni");
                return;
            }
            //Képesség megadása
            if (string.IsNullOrWhiteSpace(kepessegNeveTextBox.Text))
            {
                MessageBox.Show("Adj meg egy képességet.");
                return;
            }
            //Leírást adott-e meg
            if (string.IsNullOrWhiteSpace(leirasTextBox.Text))
            {
                MessageBox.Show("Add meg a képesség leírását.");
                return;
            }
            if (isExistKepesseg(kNev))
            {
                MessageBox.Show("Már létezik ilyen nevű képesség.");
                return;
            }
            if (kepessegBeszuras(kNev, kLeiras))
            {
                MessageBox.Show("Sikeres beszúrás.");
                kepessegNeveTextBox.Text = "";
                leirasTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen beszúrás.");
            }
            kepessegekListaRefresh();
        }
        private bool kepessegBeszuras(string kepessegNev, string leiras)
        {
            int harcosId = ((Harcos)hasznaloComboBox.SelectedItem).Id;
            bool vissza = false;
            sql.CommandText = "INSERT INTO `kepessegek` (`id`, `nev`, `leiras`, `harcos_id`) VALUES (NULL, '" + kepessegNev + "', '" + leiras + "', '" + harcosId + "');";
            if (sql.ExecuteNonQuery() == 1)
            {
                vissza = true;
                MessageBox.Show("Sikeresen felvettél egy képességet.");
            }
            return vissza;
        }
        private bool isExistKepesseg(string nev)
        {
            bool vissza = false;
            sql.CommandText = "SELECT COUNT(*) AS db FROM `kepessegek` WHERE `nev` LIKE \"" + nev + "\"";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (dr.GetInt32("db") > 0)
                    {
                        vissza = true;
                    }
                }
            };
            return vissza;
        }
        private void kepessegekListaRefresh()
        {
            sql.CommandText = "SELECT `id`, `nev`, `leiras`, `harcos_id` FROM `kepessegek` WHERE 1";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    Kepesseg ujKepesseg = new Kepesseg(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("leiras"));
                    kepessegekListBox.Items.Add(ujKepesseg);
                }
            }
        }

        private void kepessegTorlesButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection kijeloltElem = new ListBox.SelectedObjectCollection(kepessegekListBox);
            kijeloltElem = kepessegekListBox.SelectedItems;
            int kepessegId = ((Kepesseg)kepessegekListBox.SelectedItem).Id;
            bool sikerult = false;
            sql.CommandText = "DELETE FROM `kepessegek` WHERE `kepessegek`.`id` = '" + kepessegId + "' ";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (kijeloltElem.Count != -1)
                    {
                        for (int i = kijeloltElem.Count - 1; i >= 0; i--)
                        {
                            kepessegekListBox.Items.Remove(kijeloltElem[i]);
                            sikerult = true;
                        }

                    }
                    if (sikerult = true)
                    {
                        MessageBox.Show("Sikeres képesség törlés");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen képesség törlés");
                    }
                }       
            }

        }

        private void karakterTorlesButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection kijeloltElem = new ListBox.SelectedObjectCollection(harcosokListBox);
            kijeloltElem = harcosokListBox.SelectedItems;
            int harcosId = ((Harcos)harcosokListBox.SelectedItem).Id;
            bool sikerult = false;
            sql.CommandText = "DELETE FROM `harcosok` WHERE `harcosok`.`id` = '" + harcosId + "' ";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (kijeloltElem.Count != -1)
                    {
                        for (int i = kijeloltElem.Count - 1; i >= 0; i--)
                        {
                            harcosokListBox.Items.Remove(kijeloltElem[i]);
                            sikerult = true;
                        }   
                    }
                }
                if (sikerult == true) { 
                    MessageBox.Show("Sikeresen kitörölted a kijelölt elemet.");
                }
                else
                {
                    MessageBox.Show("Sikertelenül törölted ki az elemet.");
                }
            }
        }
    }
}
            
        
    


