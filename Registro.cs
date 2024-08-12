using Catedra1.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catedra1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private Registro ReadJson(string FilePath)
        {
            try
            {
                string jsonData = File.ReadAllText(FilePath);
                Registro data = JsonSerializer.Deserialize<Registro>(jsonData);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON: {ex.Message}");
                return null;
            }
        }

        private List<Registro> LoadUsers(string FilePath) {
            try
            {
                string jsonString = File.ReadAllText(FilePath);                
                return JsonSerializer.Deserialize<List<Registro>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON: {ex.Message}");
                return new List<Registro>();
            }
        }

        private void DisplayUsersInGrid()
        {
            string FilePath = "C:/Users/nelso/OneDrive/Escritorio/Universidad Don Bosco/DSP/Catedra1/Catedra1/Utils/Data.json";
            List<Registro> data = LoadUsers(FilePath);
            dataGridView1.DataSource = data;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // string FilePathJson = @"C:\Users\nelso\OneDrive\Escritorio\Universidad Don Bosco\DSP\Catedra1\Catedra1\Utils\Data.json";
            string FilePathJson = "C:/Users/nelso/OneDrive/Escritorio/Universidad Don Bosco/DSP/Catedra1/Catedra1/Utils/Data.json";
            ReadJson(FilePathJson);
            DisplayUsersInGrid();
        }
    }
}
