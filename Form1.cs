using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserChormeRobot
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Search("bnb");
		}

		private void btn_bitcoin_Click(object sender, EventArgs e)
		{
			Search("Bitcoin");
		}
		private void btn_ethereum_Click(object sender, EventArgs e)
		{
			Search("Ethereum");
		}

		private void btn_tether_Click(object sender, EventArgs e)
		{
			Search("Tether");
		}
		private void btn_dolar_Click(object sender, EventArgs e)
		{
			Search("Dolar");
		}

		private void btn_comprar_Click(object sender, EventArgs e)
		{
			var chromium = new ChromiumWebBrowser("https://www.cotacao.com.br/novo-cadastro/login/");
			chromium.FrameLoadEnd += (send, args) =>
			{
				string script = @"document.querySelector('#register-cpf-login').value = '016.545.654-88'

                                 document.querySelector('#register-senha-login').value='123456';";
				args.Frame.ExecuteJavaScriptAsync(script);

			};
			panel.Controls.Clear();
			panel.Controls.Add(chromium);
		}

		private void Search(string cotacao)
		{
			var chormiun = new ChromiumWebBrowser("https://www.google.com.br/");
			chormiun.FrameLoadEnd += (send, args) =>
			 {
				
				 string script = $"document.querySelector('body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input').value = '{cotacao}';";
				 args.Frame.ExecuteJavaScriptAsync(script);



				 string script_click = @"document.querySelector('body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b').click();";
				 args.Frame.ExecuteJavaScriptAsync(script_click);
			 };
			panel.Controls.Clear();
			panel.Controls.Add(chormiun);

		}

		private void panel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
