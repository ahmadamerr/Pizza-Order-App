namespace Pizza
{
    partial class Piza_Order
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
            this.GbSize = new System.Windows.Forms.GroupBox();
            this.RdLarge = new System.Windows.Forms.RadioButton();
            this.RdMedium = new System.Windows.Forms.RadioButton();
            this.RdSmall = new System.Windows.Forms.RadioButton();
            this.LblPizza = new System.Windows.Forms.Label();
            this.GbCrust = new System.Windows.Forms.GroupBox();
            this.RdThick = new System.Windows.Forms.RadioButton();
            this.RdThin = new System.Windows.Forms.RadioButton();
            this.GbToppings = new System.Windows.Forms.GroupBox();
            this.CbGreen = new System.Windows.Forms.CheckBox();
            this.CbTomatoes = new System.Windows.Forms.CheckBox();
            this.CbOlives = new System.Windows.Forms.CheckBox();
            this.CbMushrooms = new System.Windows.Forms.CheckBox();
            this.CbOnion = new System.Windows.Forms.CheckBox();
            this.CbExtraCheese = new System.Windows.Forms.CheckBox();
            this.GbWhereToEat = new System.Windows.Forms.GroupBox();
            this.RbTakeAway = new System.Windows.Forms.RadioButton();
            this.RbEatIn = new System.Windows.Forms.RadioButton();
            this.BtnOrderPizza = new System.Windows.Forms.Button();
            this.BtnResetForm = new System.Windows.Forms.Button();
            this.GbOrderSummary = new System.Windows.Forms.GroupBox();
            this.LblToppings = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.Lblsize = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumbeOfPizza = new System.Windows.Forms.Label();
            this.GbSize.SuspendLayout();
            this.GbCrust.SuspendLayout();
            this.GbToppings.SuspendLayout();
            this.GbWhereToEat.SuspendLayout();
            this.GbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbSize
            // 
            this.GbSize.Controls.Add(this.RdLarge);
            this.GbSize.Controls.Add(this.RdMedium);
            this.GbSize.Controls.Add(this.RdSmall);
            this.GbSize.Location = new System.Drawing.Point(12, 94);
            this.GbSize.Name = "GbSize";
            this.GbSize.Size = new System.Drawing.Size(182, 90);
            this.GbSize.TabIndex = 0;
            this.GbSize.TabStop = false;
            this.GbSize.Text = "Size";
            // 
            // RdLarge
            // 
            this.RdLarge.AutoSize = true;
            this.RdLarge.Location = new System.Drawing.Point(26, 66);
            this.RdLarge.Name = "RdLarge";
            this.RdLarge.Size = new System.Drawing.Size(52, 17);
            this.RdLarge.TabIndex = 2;
            this.RdLarge.TabStop = true;
            this.RdLarge.Tag = "30";
            this.RdLarge.Text = "Large";
            this.RdLarge.UseVisualStyleBackColor = true;
            this.RdLarge.CheckedChanged += new System.EventHandler(this.RdLarge_CheckedChanged);
            // 
            // RdMedium
            // 
            this.RdMedium.AutoSize = true;
            this.RdMedium.Location = new System.Drawing.Point(26, 43);
            this.RdMedium.Name = "RdMedium";
            this.RdMedium.Size = new System.Drawing.Size(62, 17);
            this.RdMedium.TabIndex = 1;
            this.RdMedium.TabStop = true;
            this.RdMedium.Tag = "20";
            this.RdMedium.Text = "Medium";
            this.RdMedium.UseVisualStyleBackColor = true;
            this.RdMedium.CheckedChanged += new System.EventHandler(this.RdMedium_CheckedChanged);
            // 
            // RdSmall
            // 
            this.RdSmall.AutoSize = true;
            this.RdSmall.Location = new System.Drawing.Point(26, 20);
            this.RdSmall.Name = "RdSmall";
            this.RdSmall.Size = new System.Drawing.Size(50, 17);
            this.RdSmall.TabIndex = 0;
            this.RdSmall.TabStop = true;
            this.RdSmall.Tag = "10";
            this.RdSmall.Text = "Small";
            this.RdSmall.UseVisualStyleBackColor = true;
            this.RdSmall.CheckedChanged += new System.EventHandler(this.RdSmall_CheckedChanged);
            // 
            // LblPizza
            // 
            this.LblPizza.AutoSize = true;
            this.LblPizza.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPizza.ForeColor = System.Drawing.Color.Red;
            this.LblPizza.Location = new System.Drawing.Point(7, 309);
            this.LblPizza.Name = "LblPizza";
            this.LblPizza.Size = new System.Drawing.Size(251, 25);
            this.LblPizza.TabIndex = 1;
            this.LblPizza.Text = "How Many Pizza You Want";
            // 
            // GbCrust
            // 
            this.GbCrust.Controls.Add(this.RdThick);
            this.GbCrust.Controls.Add(this.RdThin);
            this.GbCrust.Location = new System.Drawing.Point(12, 238);
            this.GbCrust.Name = "GbCrust";
            this.GbCrust.Size = new System.Drawing.Size(182, 65);
            this.GbCrust.TabIndex = 2;
            this.GbCrust.TabStop = false;
            this.GbCrust.Text = "Crust Type";
            // 
            // RdThick
            // 
            this.RdThick.AutoSize = true;
            this.RdThick.Location = new System.Drawing.Point(26, 43);
            this.RdThick.Name = "RdThick";
            this.RdThick.Size = new System.Drawing.Size(52, 17);
            this.RdThick.TabIndex = 1;
            this.RdThick.TabStop = true;
            this.RdThick.Tag = "10";
            this.RdThick.Text = "Thick";
            this.RdThick.UseVisualStyleBackColor = true;
            this.RdThick.CheckedChanged += new System.EventHandler(this.RdThick_CheckedChanged);
            // 
            // RdThin
            // 
            this.RdThin.AutoSize = true;
            this.RdThin.Location = new System.Drawing.Point(26, 20);
            this.RdThin.Name = "RdThin";
            this.RdThin.Size = new System.Drawing.Size(46, 17);
            this.RdThin.TabIndex = 0;
            this.RdThin.TabStop = true;
            this.RdThin.Tag = "0";
            this.RdThin.Text = "Thin";
            this.RdThin.UseVisualStyleBackColor = true;
            this.RdThin.CheckedChanged += new System.EventHandler(this.RdThin_CheckedChanged);
            // 
            // GbToppings
            // 
            this.GbToppings.Controls.Add(this.CbGreen);
            this.GbToppings.Controls.Add(this.CbTomatoes);
            this.GbToppings.Controls.Add(this.CbOlives);
            this.GbToppings.Controls.Add(this.CbMushrooms);
            this.GbToppings.Controls.Add(this.CbOnion);
            this.GbToppings.Controls.Add(this.CbExtraCheese);
            this.GbToppings.Location = new System.Drawing.Point(304, 94);
            this.GbToppings.Name = "GbToppings";
            this.GbToppings.Size = new System.Drawing.Size(241, 90);
            this.GbToppings.TabIndex = 3;
            this.GbToppings.TabStop = false;
            this.GbToppings.Text = "Toppings";
            // 
            // CbGreen
            // 
            this.CbGreen.AutoSize = true;
            this.CbGreen.Location = new System.Drawing.Point(147, 66);
            this.CbGreen.Name = "CbGreen";
            this.CbGreen.Size = new System.Drawing.Size(97, 17);
            this.CbGreen.TabIndex = 9;
            this.CbGreen.Tag = "5";
            this.CbGreen.Text = "Green Pappers";
            this.CbGreen.UseVisualStyleBackColor = true;
            this.CbGreen.CheckedChanged += new System.EventHandler(this.CbGreen_CheckedChanged);
            // 
            // CbTomatoes
            // 
            this.CbTomatoes.AutoSize = true;
            this.CbTomatoes.Location = new System.Drawing.Point(6, 67);
            this.CbTomatoes.Name = "CbTomatoes";
            this.CbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.CbTomatoes.TabIndex = 8;
            this.CbTomatoes.Tag = "5";
            this.CbTomatoes.Text = "Tomatoes";
            this.CbTomatoes.UseVisualStyleBackColor = true;
            this.CbTomatoes.CheckedChanged += new System.EventHandler(this.CbTomatoes_CheckedChanged);
            // 
            // CbOlives
            // 
            this.CbOlives.AutoSize = true;
            this.CbOlives.Location = new System.Drawing.Point(147, 43);
            this.CbOlives.Name = "CbOlives";
            this.CbOlives.Size = new System.Drawing.Size(55, 17);
            this.CbOlives.TabIndex = 7;
            this.CbOlives.Tag = "5";
            this.CbOlives.Text = "Olives";
            this.CbOlives.UseVisualStyleBackColor = true;
            this.CbOlives.CheckedChanged += new System.EventHandler(this.CbOlives_CheckedChanged);
            // 
            // CbMushrooms
            // 
            this.CbMushrooms.AutoSize = true;
            this.CbMushrooms.Location = new System.Drawing.Point(6, 44);
            this.CbMushrooms.Name = "CbMushrooms";
            this.CbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.CbMushrooms.TabIndex = 6;
            this.CbMushrooms.Tag = "5";
            this.CbMushrooms.Text = "Mushrooms";
            this.CbMushrooms.UseVisualStyleBackColor = true;
            this.CbMushrooms.CheckedChanged += new System.EventHandler(this.CbMushrooms_CheckedChanged);
            // 
            // CbOnion
            // 
            this.CbOnion.AutoSize = true;
            this.CbOnion.Location = new System.Drawing.Point(147, 21);
            this.CbOnion.Name = "CbOnion";
            this.CbOnion.Size = new System.Drawing.Size(54, 17);
            this.CbOnion.TabIndex = 5;
            this.CbOnion.Tag = "5";
            this.CbOnion.Text = "Onion";
            this.CbOnion.UseVisualStyleBackColor = true;
            this.CbOnion.CheckedChanged += new System.EventHandler(this.CbOnion_CheckedChanged);
            // 
            // CbExtraCheese
            // 
            this.CbExtraCheese.AutoSize = true;
            this.CbExtraCheese.Location = new System.Drawing.Point(6, 21);
            this.CbExtraCheese.Name = "CbExtraCheese";
            this.CbExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.CbExtraCheese.TabIndex = 4;
            this.CbExtraCheese.Tag = "5";
            this.CbExtraCheese.Text = "Extra Cheese";
            this.CbExtraCheese.UseVisualStyleBackColor = true;
            this.CbExtraCheese.CheckedChanged += new System.EventHandler(this.CbExtraCheese_CheckedChanged);
            // 
            // GbWhereToEat
            // 
            this.GbWhereToEat.Controls.Add(this.RbTakeAway);
            this.GbWhereToEat.Controls.Add(this.RbEatIn);
            this.GbWhereToEat.Location = new System.Drawing.Point(304, 233);
            this.GbWhereToEat.Name = "GbWhereToEat";
            this.GbWhereToEat.Size = new System.Drawing.Size(202, 65);
            this.GbWhereToEat.TabIndex = 4;
            this.GbWhereToEat.TabStop = false;
            this.GbWhereToEat.Text = "Where To Eat";
            // 
            // RbTakeAway
            // 
            this.RbTakeAway.AutoSize = true;
            this.RbTakeAway.Location = new System.Drawing.Point(124, 25);
            this.RbTakeAway.Name = "RbTakeAway";
            this.RbTakeAway.Size = new System.Drawing.Size(79, 17);
            this.RbTakeAway.TabIndex = 1;
            this.RbTakeAway.TabStop = true;
            this.RbTakeAway.Text = "Take Away";
            this.RbTakeAway.UseVisualStyleBackColor = true;
            this.RbTakeAway.CheckedChanged += new System.EventHandler(this.RbTakeAway_CheckedChanged);
            // 
            // RbEatIn
            // 
            this.RbEatIn.AutoSize = true;
            this.RbEatIn.Location = new System.Drawing.Point(6, 25);
            this.RbEatIn.Name = "RbEatIn";
            this.RbEatIn.Size = new System.Drawing.Size(53, 17);
            this.RbEatIn.TabIndex = 0;
            this.RbEatIn.TabStop = true;
            this.RbEatIn.Text = "Eat In";
            this.RbEatIn.UseVisualStyleBackColor = true;
            this.RbEatIn.CheckedChanged += new System.EventHandler(this.RbEatIn_CheckedChanged);
            // 
            // BtnOrderPizza
            // 
            this.BtnOrderPizza.Location = new System.Drawing.Point(304, 338);
            this.BtnOrderPizza.Name = "BtnOrderPizza";
            this.BtnOrderPizza.Size = new System.Drawing.Size(95, 39);
            this.BtnOrderPizza.TabIndex = 5;
            this.BtnOrderPizza.Text = "Order Pizza";
            this.BtnOrderPizza.UseVisualStyleBackColor = true;
            this.BtnOrderPizza.Click += new System.EventHandler(this.BtnOrderPizza_Click);
            // 
            // BtnResetForm
            // 
            this.BtnResetForm.Location = new System.Drawing.Point(450, 338);
            this.BtnResetForm.Name = "BtnResetForm";
            this.BtnResetForm.Size = new System.Drawing.Size(95, 39);
            this.BtnResetForm.TabIndex = 6;
            this.BtnResetForm.Text = "Reset Form";
            this.BtnResetForm.UseVisualStyleBackColor = true;
            this.BtnResetForm.Click += new System.EventHandler(this.BtnResetForm_Click);
            // 
            // GbOrderSummary
            // 
            this.GbOrderSummary.Controls.Add(this.lblNumbeOfPizza);
            this.GbOrderSummary.Controls.Add(this.label5);
            this.GbOrderSummary.Controls.Add(this.LblToppings);
            this.GbOrderSummary.Controls.Add(this.LblPrice);
            this.GbOrderSummary.Controls.Add(this.label2);
            this.GbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.GbOrderSummary.Controls.Add(this.label4);
            this.GbOrderSummary.Controls.Add(this.lblCrustType);
            this.GbOrderSummary.Controls.Add(this.label3);
            this.GbOrderSummary.Controls.Add(this.label1);
            this.GbOrderSummary.Controls.Add(this.Size);
            this.GbOrderSummary.Controls.Add(this.Lblsize);
            this.GbOrderSummary.Location = new System.Drawing.Point(712, 70);
            this.GbOrderSummary.Name = "GbOrderSummary";
            this.GbOrderSummary.Size = new System.Drawing.Size(200, 336);
            this.GbOrderSummary.TabIndex = 7;
            this.GbOrderSummary.TabStop = false;
            this.GbOrderSummary.Text = "Order Summary";
            // 
            // LblToppings
            // 
            this.LblToppings.ForeColor = System.Drawing.Color.Red;
            this.LblToppings.Location = new System.Drawing.Point(19, 102);
            this.LblToppings.Name = "LblToppings";
            this.LblToppings.Size = new System.Drawing.Size(181, 42);
            this.LblToppings.TabIndex = 10;
            this.LblToppings.Text = "No Toppings Added";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.Red;
            this.LblPrice.Location = new System.Drawing.Point(80, 297);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(35, 24);
            this.LblPrice.TabIndex = 9;
            this.LblPrice.Text = "0 $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Price";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Red;
            this.lblWhereToEat.Location = new System.Drawing.Point(69, 215);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(43, 16);
            this.lblWhereToEat.TabIndex = 7;
            this.lblWhereToEat.Text = "Eat IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Where To Eat: ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Red;
            this.lblCrustType.Location = new System.Drawing.Point(81, 144);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(33, 16);
            this.lblCrustType.TabIndex = 5;
            this.lblCrustType.Text = "Thin";
            this.lblCrustType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crust Typ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toppings:";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.ForeColor = System.Drawing.Color.Red;
            this.Size.Location = new System.Drawing.Point(50, 32);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(41, 16);
            this.Size.TabIndex = 1;
            this.Size.Text = "Small";
            // 
            // Lblsize
            // 
            this.Lblsize.AutoSize = true;
            this.Lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsize.Location = new System.Drawing.Point(16, 32);
            this.Lblsize.Name = "Lblsize";
            this.Lblsize.Size = new System.Drawing.Size(39, 16);
            this.Lblsize.TabIndex = 0;
            this.Lblsize.Text = "Size: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(58, 349);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number Of Pizza";
            // 
            // lblNumbeOfPizza
            // 
            this.lblNumbeOfPizza.AutoSize = true;
            this.lblNumbeOfPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbeOfPizza.ForeColor = System.Drawing.Color.Red;
            this.lblNumbeOfPizza.Location = new System.Drawing.Point(72, 265);
            this.lblNumbeOfPizza.Name = "lblNumbeOfPizza";
            this.lblNumbeOfPizza.Size = new System.Drawing.Size(43, 16);
            this.lblNumbeOfPizza.TabIndex = 12;
            this.lblNumbeOfPizza.Text = "Eat IN";
            // 
            // Piza_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 418);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.GbOrderSummary);
            this.Controls.Add(this.BtnResetForm);
            this.Controls.Add(this.BtnOrderPizza);
            this.Controls.Add(this.GbWhereToEat);
            this.Controls.Add(this.GbToppings);
            this.Controls.Add(this.GbCrust);
            this.Controls.Add(this.LblPizza);
            this.Controls.Add(this.GbSize);
            this.Name = "Piza_Order";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Piza_Order_Load);
            this.GbSize.ResumeLayout(false);
            this.GbSize.PerformLayout();
            this.GbCrust.ResumeLayout(false);
            this.GbCrust.PerformLayout();
            this.GbToppings.ResumeLayout(false);
            this.GbToppings.PerformLayout();
            this.GbWhereToEat.ResumeLayout(false);
            this.GbWhereToEat.PerformLayout();
            this.GbOrderSummary.ResumeLayout(false);
            this.GbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSize;
        private System.Windows.Forms.Label LblPizza;
        private System.Windows.Forms.RadioButton RdLarge;
        private System.Windows.Forms.RadioButton RdMedium;
        private System.Windows.Forms.RadioButton RdSmall;
        private System.Windows.Forms.GroupBox GbCrust;
        private System.Windows.Forms.RadioButton RdThick;
        private System.Windows.Forms.RadioButton RdThin;
        private System.Windows.Forms.GroupBox GbToppings;
        private System.Windows.Forms.CheckBox CbGreen;
        private System.Windows.Forms.CheckBox CbTomatoes;
        private System.Windows.Forms.CheckBox CbOlives;
        private System.Windows.Forms.CheckBox CbMushrooms;
        private System.Windows.Forms.CheckBox CbOnion;
        private System.Windows.Forms.CheckBox CbExtraCheese;
        private System.Windows.Forms.GroupBox GbWhereToEat;
        private System.Windows.Forms.RadioButton RbTakeAway;
        private System.Windows.Forms.RadioButton RbEatIn;
        private System.Windows.Forms.Button BtnOrderPizza;
        private System.Windows.Forms.Button BtnResetForm;
        private System.Windows.Forms.GroupBox GbOrderSummary;
        private System.Windows.Forms.Label Lblsize;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblToppings;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblNumbeOfPizza;
        private System.Windows.Forms.Label label5;
    }
}

