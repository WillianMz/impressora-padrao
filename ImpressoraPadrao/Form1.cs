using System.Drawing.Printing;
using System.Management;
using System.Runtime.InteropServices;

namespace ImpressoraPadrao
{
    public partial class Form1 : Form
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDefaultPrinter(string Name);

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuscarImpressora_Click(object sender, EventArgs e)
        {
            ObterImpressoras();
        }

        private void ObterImpressoras()
        {
            lsbImpressoras.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                lsbImpressoras.Items.Add(printer);
            }
        }

        private void BtnObterPadrao_Click(object sender, EventArgs e)
        {
            ObterImpressoraPadrao();
        }

        private void ObterImpressoraPadrao()
        {
            PrinterSettings settings = new();
            MessageBox.Show($"Impressora padrão: {settings.PrinterName}");
        }

        private void BtnObterOrientacao_Click(object sender, EventArgs e)
        {
            ObterOrientacaoImpressao();
        }

        private void ObterOrientacaoImpressao()
        {
            PrinterSettings settings = new();

            if (!settings.IsValid)
            {
                MessageBox.Show("Impressora inválida");
                return;
            }

            PageSettings pageSettings = settings.DefaultPageSettings;
            string orientacao = pageSettings.Landscape ? "Paisagem" : "Retrato";
            MessageBox.Show($"Orientação de impressão: {orientacao}");
        }

        private void BtnObterPapel_Click(object sender, EventArgs e)
        {
            ObterTipoPapel();
        }

        private void ObterTipoPapel()
        {
            PrinterSettings settings = new();

            if (!settings.IsValid)
            {
                MessageBox.Show("Impressora inválida");
                return;
            }

            PageSettings pageSettings = settings.DefaultPageSettings;
            PaperSize papel = pageSettings.PaperSize;

            string mensagem = $"Tipo de papel: {papel.PaperName}\n" +
                              $"Dimensões: {papel.Width} x {papel.Height} (em centésimos de polegada)";

            MessageBox.Show(mensagem);
        }

        private void BtnPropriedades_Click(object sender, EventArgs e)
        {
            ObterPropriedadeImpressora();
        }

        private void ObterPropriedadeImpressora()
        {
            if (lsbImpressoras.SelectedItem == null) return;

            string nome = lsbImpressoras.SelectedItem.ToString()!;
            string info = "";
            var searcher = new ManagementObjectSearcher($"SELECT * FROM Win32_Printer WHERE Name = '{nome.Replace("\\", "\\\\")}'");

            foreach (ManagementObject printer in searcher.Get())
            {
                info += $"Nome: {printer["Name"]}\n";
                info += $"Porta: {printer["PortName"]}\n";
                info += $"Status: {printer["PrintStatus"]}\n";
                info += $"Padrão: {printer["Default"]}\n";
                info += $"Disponível: {printer["Availability"]}\n";
                info += $"Compartilhada: {printer["Shared"]}\n";
            }

            MessageBox.Show(info, "Propriedades");
        }

        private void BtnDefinirPadrao_Click(object sender, EventArgs e)
        {
            SelecionarImpressoraPadrao();
        }

        private void SelecionarImpressoraPadrao()
        {
            if (lsbImpressoras.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma impressora!");
                return;
            }

            string nomeImpressora = lsbImpressoras.SelectedItem.ToString()!;
            bool sucesso = SetDefaultPrinter(nomeImpressora);
            if (sucesso)
                MessageBox.Show($"Impressora \"{nomeImpressora}\" definida como padrão!");
            else
                MessageBox.Show("Erro ao definir impressora como padrão!");
        }

        private void BtnSelecionarOrientacao_Click(object sender, EventArgs e)
        {
            SelecionarOrientacaoImpressao();
        }

        private void SelecionarOrientacaoImpressao()
        {
            PrintDocument pd = new();
            pd.DefaultPageSettings.Landscape = RbPaisagem.Checked;
            MessageBox.Show($"Orientação configurada como: {(RbPaisagem.Checked ? "Paisagem" : "Retrato")}", "Orientação");
        }

        private void BtnSelecionarPapel_Click(object sender, EventArgs e)
        {
            SelecionarTamanhoPapel();
        }

        private void SelecionarTamanhoPapel()
        {
            PrinterSettings settings = new();
            PrintDocument pd = new();

            pd.PrinterSettings.PrinterName = settings.PrinterName;
            string paperName = ObterTamanhoPapel();
            //verifica se a impressora suporta o tamanho selecionado
            foreach (PaperSize size in pd.PrinterSettings.PaperSizes)
            {
                if(size.PaperName.Equals(paperName, StringComparison.OrdinalIgnoreCase))
                {
                    pd.DefaultPageSettings.PaperSize = size;
                    MessageBox.Show($"Tamanho do papel configurado para: {paperName}", "Configuração");
                    return;
                }
            }

            MessageBox.Show($"Tamanho de papel '{paperName}' não suportado por esta impressora!", "Erro");
        }

        private string ObterTamanhoPapel()
        {
            if (Rb_A4.Checked)
                return "A4";
            else if (Rb_Letter.Checked)
                return "Letter";//carta
            else if (Rb_Oficio.Checked)
                return "Oficio";

            return "";
        }
    }
}
