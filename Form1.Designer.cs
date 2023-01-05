
namespace WebBrowserChormeRobot
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_dolar = new System.Windows.Forms.Button();
			this.btn_bitcoin = new System.Windows.Forms.Button();
			this.btn_ethereum = new System.Windows.Forms.Button();
			this.btn_bnb = new System.Windows.Forms.Button();
			this.btn_tether = new System.Windows.Forms.Button();
			this.btn_comprar = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btn_dolar
			// 
			this.btn_dolar.Location = new System.Drawing.Point(543, 24);
			this.btn_dolar.Name = "btn_dolar";
			this.btn_dolar.Size = new System.Drawing.Size(75, 23);
			this.btn_dolar.TabIndex = 0;
			this.btn_dolar.Text = "Dolar";
			this.btn_dolar.UseVisualStyleBackColor = true;
			this.btn_dolar.Click += new System.EventHandler(this.btn_dolar_Click);
			// 
			// btn_bitcoin
			// 
			this.btn_bitcoin.Location = new System.Drawing.Point(12, 24);
			this.btn_bitcoin.Name = "btn_bitcoin";
			this.btn_bitcoin.Size = new System.Drawing.Size(75, 23);
			this.btn_bitcoin.TabIndex = 0;
			this.btn_bitcoin.Text = "Bitcon";
			this.btn_bitcoin.UseVisualStyleBackColor = true;
			this.btn_bitcoin.Click += new System.EventHandler(this.btn_bitcoin_Click);
			// 
			// btn_ethereum
			// 
			this.btn_ethereum.Location = new System.Drawing.Point(145, 24);
			this.btn_ethereum.Name = "btn_ethereum";
			this.btn_ethereum.Size = new System.Drawing.Size(75, 23);
			this.btn_ethereum.TabIndex = 0;
			this.btn_ethereum.Text = "Ethereum";
			this.btn_ethereum.UseVisualStyleBackColor = true;
			this.btn_ethereum.Click += new System.EventHandler(this.btn_ethereum_Click);
			// 
			// btn_bnb
			// 
			this.btn_bnb.Location = new System.Drawing.Point(272, 24);
			this.btn_bnb.Name = "btn_bnb";
			this.btn_bnb.Size = new System.Drawing.Size(75, 23);
			this.btn_bnb.TabIndex = 0;
			this.btn_bnb.Text = "BNB";
			this.btn_bnb.UseVisualStyleBackColor = true;
			this.btn_bnb.Click += new System.EventHandler(this.button4_Click);
			// 
			// btn_tether
			// 
			this.btn_tether.Location = new System.Drawing.Point(409, 24);
			this.btn_tether.Name = "btn_tether";
			this.btn_tether.Size = new System.Drawing.Size(75, 23);
			this.btn_tether.TabIndex = 0;
			this.btn_tether.Text = "Tether";
			this.btn_tether.UseVisualStyleBackColor = true;
			this.btn_tether.Click += new System.EventHandler(this.btn_tether_Click);
			// 
			// btn_comprar
			// 
			this.btn_comprar.Location = new System.Drawing.Point(678, 24);
			this.btn_comprar.Name = "btn_comprar";
			this.btn_comprar.Size = new System.Drawing.Size(75, 23);
			this.btn_comprar.TabIndex = 0;
			this.btn_comprar.Text = "Comprar";
			this.btn_comprar.UseVisualStyleBackColor = true;
			this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(12, 71);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1076, 523);
			this.panel.TabIndex = 1;
			this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 594);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.btn_comprar);
			this.Controls.Add(this.btn_tether);
			this.Controls.Add(this.btn_bnb);
			this.Controls.Add(this.btn_ethereum);
			this.Controls.Add(this.btn_bitcoin);
			this.Controls.Add(this.btn_dolar);
			this.Name = "Form1";
			this.Text = "Robo de Busca ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_dolar;
		private System.Windows.Forms.Button btn_bitcoin;
		private System.Windows.Forms.Button btn_ethereum;
		private System.Windows.Forms.Button btn_bnb;
		private System.Windows.Forms.Button btn_tether;
		private System.Windows.Forms.Button btn_comprar;
		private System.Windows.Forms.Panel panel;
	}
}

