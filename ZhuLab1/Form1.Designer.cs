namespace ZhuLab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbZsuv = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tbAnalyze = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(13, 13);
            this.tbBefore.Multiline = true;
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBefore.Size = new System.Drawing.Size(259, 79);
            this.tbBefore.TabIndex = 0;
            this.tbBefore.Text = @"Реве та стогне Дніпр широкий,
Сердитий вітер завива,
Додолу верби гне високі,
Горами хвилю підійма.
І блідий місяць на ту пору
Із хмари де-де виглядав,
Неначе човен в синім морі,
То виринав, то потопав.
Ще треті півні не співали,
Ніхто нігде не гомонів,
Сичі в гаю перекликались,
Та ясен раз у раз скрипів.
В таку добу під горою,
Біля того гаю,
Що чорніє над водою,
Щось біле блукає.
Може, вийшла русалонька
Матері шукати,
А може, жде козаченька,
Щоб залоскотати.
Не русалонька блукає —
То дівчина ходить,
Й сама не зна (бо причинна),
Що такеє робить.
Так ворожка поробила,
Щоб меньше скучала,
Щоб, бач, ходя опівночі,
Спала й виглядала
Козаченька молодого,
Що торік покинув.
Обіщався вернутися,
Та, мабуть, і згинув!
Не китайкою покрились
Козацькії очі,
Не вимили біле личко
Слізоньки дівочі:
Орел вийняв карі очі
На чужому полі,
Біле тіло вовки з'їли, —
Така його доля.
Дарма щоніч дівчинонька";
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(12, 155);
            this.tbAfter.Multiline = true;
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAfter.Size = new System.Drawing.Size(260, 94);
            this.tbAfter.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(13, 98);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 51);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(190, 98);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(81, 51);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbZsuv
            // 
            this.tbZsuv.Location = new System.Drawing.Point(94, 129);
            this.tbZsuv.Name = "tbZsuv";
            this.tbZsuv.Size = new System.Drawing.Size(90, 20);
            this.tbZsuv.TabIndex = 4;
            this.tbZsuv.Text = "0";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(278, 16);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(36, 232);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // tbAnalyze
            // 
            this.tbAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnalyze.Location = new System.Drawing.Point(324, 8);
            this.tbAnalyze.Multiline = true;
            this.tbAnalyze.Name = "tbAnalyze";
            this.tbAnalyze.Size = new System.Drawing.Size(445, 447);
            this.tbAnalyze.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 468);
            this.Controls.Add(this.tbAnalyze);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.tbZsuv);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbZsuv;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox tbAnalyze;
    }
}

