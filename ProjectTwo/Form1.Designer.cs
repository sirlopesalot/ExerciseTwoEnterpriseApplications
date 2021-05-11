
namespace ProjectTwo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dressing = new System.Windows.Forms.GroupBox();
            this.blueCheese = new System.Windows.Forms.RadioButton();
            this.appleVinegrette = new System.Windows.Forms.RadioButton();
            this.ranch = new System.Windows.Forms.RadioButton();
            this.toppings = new System.Windows.Forms.GroupBox();
            this.pepitas = new System.Windows.Forms.CheckBox();
            this.cranberries = new System.Windows.Forms.CheckBox();
            this.pecans = new System.Windows.Forms.CheckBox();
            this.bacon = new System.Windows.Forms.CheckBox();
            this.croutons = new System.Windows.Forms.CheckBox();
            this.mainCourse = new System.Windows.Forms.ListBox();
            this.composed = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dressing.SuspendLayout();
            this.toppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dressing
            // 
            this.dressing.Controls.Add(this.blueCheese);
            this.dressing.Controls.Add(this.appleVinegrette);
            this.dressing.Controls.Add(this.ranch);
            this.dressing.Location = new System.Drawing.Point(17, 179);
            this.dressing.Name = "dressing";
            this.dressing.Size = new System.Drawing.Size(200, 100);
            this.dressing.TabIndex = 0;
            this.dressing.TabStop = false;
            this.dressing.Text = "Salad Dressing";
            // 
            // blueCheese
            // 
            this.blueCheese.AutoSize = true;
            this.blueCheese.Location = new System.Drawing.Point(6, 72);
            this.blueCheese.Name = "blueCheese";
            this.blueCheese.Size = new System.Drawing.Size(89, 19);
            this.blueCheese.TabIndex = 10;
            this.blueCheese.TabStop = true;
            this.blueCheese.Text = "Blue Cheese";
            this.blueCheese.UseVisualStyleBackColor = true;
            // 
            // appleVinegrette
            // 
            this.appleVinegrette.AutoSize = true;
            this.appleVinegrette.Location = new System.Drawing.Point(6, 47);
            this.appleVinegrette.Name = "appleVinegrette";
            this.appleVinegrette.Size = new System.Drawing.Size(113, 19);
            this.appleVinegrette.TabIndex = 2;
            this.appleVinegrette.TabStop = true;
            this.appleVinegrette.Text = "Apple Vinegrette";
            this.appleVinegrette.UseVisualStyleBackColor = true;
            // 
            // ranch
            // 
            this.ranch.AutoSize = true;
            this.ranch.Location = new System.Drawing.Point(6, 22);
            this.ranch.Name = "ranch";
            this.ranch.Size = new System.Drawing.Size(58, 19);
            this.ranch.TabIndex = 1;
            this.ranch.TabStop = true;
            this.ranch.Text = "Ranch";
            this.ranch.UseVisualStyleBackColor = true;
            // 
            // toppings
            // 
            this.toppings.Controls.Add(this.pepitas);
            this.toppings.Controls.Add(this.cranberries);
            this.toppings.Controls.Add(this.pecans);
            this.toppings.Controls.Add(this.bacon);
            this.toppings.Controls.Add(this.croutons);
            this.toppings.Location = new System.Drawing.Point(17, 285);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(200, 100);
            this.toppings.TabIndex = 1;
            this.toppings.TabStop = false;
            this.toppings.Text = "Salad Toppings";
            // 
            // pepitas
            // 
            this.pepitas.AutoSize = true;
            this.pepitas.Location = new System.Drawing.Point(111, 47);
            this.pepitas.Name = "pepitas";
            this.pepitas.Size = new System.Drawing.Size(64, 19);
            this.pepitas.TabIndex = 14;
            this.pepitas.Text = "Pepitas";
            this.pepitas.UseVisualStyleBackColor = true;
            // 
            // cranberries
            // 
            this.cranberries.AutoSize = true;
            this.cranberries.Location = new System.Drawing.Point(111, 22);
            this.cranberries.Name = "cranberries";
            this.cranberries.Size = new System.Drawing.Size(86, 19);
            this.cranberries.TabIndex = 13;
            this.cranberries.Text = "Cranberries";
            this.cranberries.UseVisualStyleBackColor = true;
            // 
            // pecans
            // 
            this.pecans.AutoSize = true;
            this.pecans.Location = new System.Drawing.Point(6, 72);
            this.pecans.Name = "pecans";
            this.pecans.Size = new System.Drawing.Size(101, 19);
            this.pecans.TabIndex = 12;
            this.pecans.Text = "Glazed Pecans";
            this.pecans.UseVisualStyleBackColor = true;
            // 
            // bacon
            // 
            this.bacon.AutoSize = true;
            this.bacon.Location = new System.Drawing.Point(6, 47);
            this.bacon.Name = "bacon";
            this.bacon.Size = new System.Drawing.Size(59, 19);
            this.bacon.TabIndex = 11;
            this.bacon.Text = "Bacon";
            this.bacon.UseVisualStyleBackColor = true;
            // 
            // croutons
            // 
            this.croutons.AutoSize = true;
            this.croutons.Location = new System.Drawing.Point(6, 22);
            this.croutons.Name = "croutons";
            this.croutons.Size = new System.Drawing.Size(75, 19);
            this.croutons.TabIndex = 10;
            this.croutons.Text = "Croutons";
            this.croutons.UseVisualStyleBackColor = true;
            // 
            // mainCourse
            // 
            this.mainCourse.FormattingEnabled = true;
            this.mainCourse.ItemHeight = 15;
            this.mainCourse.Items.AddRange(new object[] {
            "Pork Chops",
            "Beef Steak",
            "Salmon",
            "Chicken Breast",
            "Vegan Chicken"});
            this.mainCourse.Location = new System.Drawing.Point(17, 79);
            this.mainCourse.Name = "mainCourse";
            this.mainCourse.Size = new System.Drawing.Size(120, 94);
            this.mainCourse.TabIndex = 2;
            // 
            // composed
            // 
            this.composed.FormattingEnabled = true;
            this.composed.ItemHeight = 15;
            this.composed.Location = new System.Drawing.Point(223, 79);
            this.composed.Name = "composed";
            this.composed.Size = new System.Drawing.Size(639, 274);
            this.composed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dinner List";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(223, 362);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(138, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(367, 362);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(138, 23);
            this.remove.TabIndex = 7;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(511, 362);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(728, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please select a main course and the appropriate salad dressing and toppings.  The" +
    " order will not be added unless a main course is chosen.";
            // 
            // Form1
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.composed);
            this.Controls.Add(this.mainCourse);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.dressing);
            this.Name = "Form1";
            this.Text = "Catering Order Management System";
            this.dressing.ResumeLayout(false);
            this.dressing.PerformLayout();
            this.toppings.ResumeLayout(false);
            this.toppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dressing;
        private System.Windows.Forms.GroupBox toppings;
        private System.Windows.Forms.ListBox mainCourse;
        private System.Windows.Forms.ListBox composed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton blueCheese;
        private System.Windows.Forms.RadioButton appleVinegrette;
        private System.Windows.Forms.RadioButton ranch;
        private System.Windows.Forms.CheckBox pecans;
        private System.Windows.Forms.CheckBox bacon;
        private System.Windows.Forms.CheckBox croutons;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.CheckBox pepitas;
        private System.Windows.Forms.CheckBox cranberries;
        private System.Windows.Forms.Label label3;
    }
}

