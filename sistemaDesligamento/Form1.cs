using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace sistemaDesligamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtAgendar_Click(object sender, EventArgs e)
        {
            // Obtém o horário selecionado
            DateTime horarioDesligamento = dateTimePicker1.Value;

            // Obtém a hora atual
            DateTime agora = DateTime.Now;

            // Calcular o tempo restante até o horário especificado

            TimeSpan tempoRestante = horarioDesligamento - agora;

            // Converter o tempo restante para segundos

            int tempoRestanteSegundos = (int)tempoRestante.TotalSeconds;

            // Agenda o Desligamento

            Process.Start(new ProcessStartInfo("shutdown", $" s/ /t {tempoRestanteSegundos}")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            });
        }
    }
}
