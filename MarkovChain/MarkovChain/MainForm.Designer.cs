namespace MarkovChain
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.button_count = new System.Windows.Forms.Button();
            this.button_load_matrix = new System.Windows.Forms.Button();
            this.groupBox_init_state = new System.Windows.Forms.GroupBox();
            this.radioButton_s5 = new System.Windows.Forms.RadioButton();
            this.radioButton_s4 = new System.Windows.Forms.RadioButton();
            this.radioButton_s3 = new System.Windows.Forms.RadioButton();
            this.radioButton_s2 = new System.Windows.Forms.RadioButton();
            this.radioButton_s1 = new System.Windows.Forms.RadioButton();
            this.numericUpDown_experiments = new System.Windows.Forms.NumericUpDown();
            this.label_experiments = new System.Windows.Forms.Label();
            this.numericUpDown_steps = new System.Windows.Forms.NumericUpDown();
            this.label_steps = new System.Windows.Forms.Label();
            this.chart_results = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_end_states_only = new System.Windows.Forms.CheckBox();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_init_state.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_experiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_results)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.checkBox_end_states_only);
            this.groupBox_settings.Controls.Add(this.button_count);
            this.groupBox_settings.Controls.Add(this.button_load_matrix);
            this.groupBox_settings.Controls.Add(this.groupBox_init_state);
            this.groupBox_settings.Controls.Add(this.numericUpDown_experiments);
            this.groupBox_settings.Controls.Add(this.label_experiments);
            this.groupBox_settings.Controls.Add(this.numericUpDown_steps);
            this.groupBox_settings.Controls.Add(this.label_steps);
            this.groupBox_settings.Location = new System.Drawing.Point(995, 12);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(219, 623);
            this.groupBox_settings.TabIndex = 0;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Настройки";
            // 
            // button_count
            // 
            this.button_count.Enabled = false;
            this.button_count.Location = new System.Drawing.Point(11, 594);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(196, 23);
            this.button_count.TabIndex = 8;
            this.button_count.Text = "Подсчитать вероятности";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // button_load_matrix
            // 
            this.button_load_matrix.Location = new System.Drawing.Point(10, 565);
            this.button_load_matrix.Name = "button_load_matrix";
            this.button_load_matrix.Size = new System.Drawing.Size(196, 23);
            this.button_load_matrix.TabIndex = 7;
            this.button_load_matrix.Text = "Считать матрицу из файла";
            this.button_load_matrix.UseVisualStyleBackColor = true;
            this.button_load_matrix.Click += new System.EventHandler(this.button_load_matrix_Click);
            // 
            // groupBox_init_state
            // 
            this.groupBox_init_state.Controls.Add(this.radioButton_s5);
            this.groupBox_init_state.Controls.Add(this.radioButton_s4);
            this.groupBox_init_state.Controls.Add(this.radioButton_s3);
            this.groupBox_init_state.Controls.Add(this.radioButton_s2);
            this.groupBox_init_state.Controls.Add(this.radioButton_s1);
            this.groupBox_init_state.Location = new System.Drawing.Point(11, 100);
            this.groupBox_init_state.Name = "groupBox_init_state";
            this.groupBox_init_state.Size = new System.Drawing.Size(196, 142);
            this.groupBox_init_state.TabIndex = 6;
            this.groupBox_init_state.TabStop = false;
            this.groupBox_init_state.Text = "Выбор начального состояния";
            // 
            // radioButton_s5
            // 
            this.radioButton_s5.AutoSize = true;
            this.radioButton_s5.Location = new System.Drawing.Point(10, 111);
            this.radioButton_s5.Name = "radioButton_s5";
            this.radioButton_s5.Size = new System.Drawing.Size(38, 17);
            this.radioButton_s5.TabIndex = 4;
            this.radioButton_s5.Text = "S5";
            this.radioButton_s5.UseVisualStyleBackColor = true;
            // 
            // radioButton_s4
            // 
            this.radioButton_s4.AutoSize = true;
            this.radioButton_s4.Location = new System.Drawing.Point(10, 88);
            this.radioButton_s4.Name = "radioButton_s4";
            this.radioButton_s4.Size = new System.Drawing.Size(38, 17);
            this.radioButton_s4.TabIndex = 3;
            this.radioButton_s4.Text = "S4";
            this.radioButton_s4.UseVisualStyleBackColor = true;
            // 
            // radioButton_s3
            // 
            this.radioButton_s3.AutoSize = true;
            this.radioButton_s3.Location = new System.Drawing.Point(10, 65);
            this.radioButton_s3.Name = "radioButton_s3";
            this.radioButton_s3.Size = new System.Drawing.Size(38, 17);
            this.radioButton_s3.TabIndex = 2;
            this.radioButton_s3.Text = "S3";
            this.radioButton_s3.UseVisualStyleBackColor = true;
            // 
            // radioButton_s2
            // 
            this.radioButton_s2.AutoSize = true;
            this.radioButton_s2.Location = new System.Drawing.Point(10, 42);
            this.radioButton_s2.Name = "radioButton_s2";
            this.radioButton_s2.Size = new System.Drawing.Size(38, 17);
            this.radioButton_s2.TabIndex = 1;
            this.radioButton_s2.Text = "S2";
            this.radioButton_s2.UseVisualStyleBackColor = true;
            // 
            // radioButton_s1
            // 
            this.radioButton_s1.AutoSize = true;
            this.radioButton_s1.Checked = true;
            this.radioButton_s1.Location = new System.Drawing.Point(10, 19);
            this.radioButton_s1.Name = "radioButton_s1";
            this.radioButton_s1.Size = new System.Drawing.Size(38, 17);
            this.radioButton_s1.TabIndex = 0;
            this.radioButton_s1.TabStop = true;
            this.radioButton_s1.Text = "S1";
            this.radioButton_s1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_experiments
            // 
            this.numericUpDown_experiments.Location = new System.Drawing.Point(135, 51);
            this.numericUpDown_experiments.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_experiments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_experiments.Name = "numericUpDown_experiments";
            this.numericUpDown_experiments.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_experiments.TabIndex = 5;
            this.numericUpDown_experiments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_experiments
            // 
            this.label_experiments.AutoSize = true;
            this.label_experiments.Location = new System.Drawing.Point(7, 54);
            this.label_experiments.Name = "label_experiments";
            this.label_experiments.Size = new System.Drawing.Size(121, 13);
            this.label_experiments.TabIndex = 4;
            this.label_experiments.Text = "Число экспериментов";
            // 
            // numericUpDown_steps
            // 
            this.numericUpDown_steps.Location = new System.Drawing.Point(135, 19);
            this.numericUpDown_steps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_steps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_steps.Name = "numericUpDown_steps";
            this.numericUpDown_steps.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_steps.TabIndex = 3;
            this.numericUpDown_steps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_steps
            // 
            this.label_steps.AutoSize = true;
            this.label_steps.Location = new System.Drawing.Point(32, 22);
            this.label_steps.Name = "label_steps";
            this.label_steps.Size = new System.Drawing.Size(73, 13);
            this.label_steps.TabIndex = 2;
            this.label_steps.Text = "Число шагов";
            // 
            // chart_results
            // 
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart_results.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_results.Legends.Add(legend1);
            this.chart_results.Location = new System.Drawing.Point(12, 12);
            this.chart_results.Name = "chart_results";
            this.chart_results.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Вероятности";
            this.chart_results.Series.Add(series1);
            this.chart_results.Size = new System.Drawing.Size(977, 623);
            this.chart_results.TabIndex = 1;
            this.chart_results.Text = "chart_results";
            // 
            // checkBox_end_states_only
            // 
            this.checkBox_end_states_only.AutoSize = true;
            this.checkBox_end_states_only.Location = new System.Drawing.Point(11, 259);
            this.checkBox_end_states_only.Name = "checkBox_end_states_only";
            this.checkBox_end_states_only.Size = new System.Drawing.Size(171, 17);
            this.checkBox_end_states_only.TabIndex = 9;
            this.checkBox_end_states_only.Text = "Только конечные состояния";
            this.checkBox_end_states_only.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 647);
            this.Controls.Add(this.chart_results);
            this.Controls.Add(this.groupBox_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конечные цепи Маркова";
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_init_state.ResumeLayout(false);
            this.groupBox_init_state.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_experiments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.GroupBox groupBox_init_state;
        private System.Windows.Forms.RadioButton radioButton_s2;
        private System.Windows.Forms.RadioButton radioButton_s1;
        private System.Windows.Forms.NumericUpDown numericUpDown_experiments;
        private System.Windows.Forms.Label label_experiments;
        private System.Windows.Forms.NumericUpDown numericUpDown_steps;
        private System.Windows.Forms.Label label_steps;
        private System.Windows.Forms.RadioButton radioButton_s5;
        private System.Windows.Forms.RadioButton radioButton_s4;
        private System.Windows.Forms.RadioButton radioButton_s3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_results;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.Button button_load_matrix;
        private System.Windows.Forms.CheckBox checkBox_end_states_only;
    }
}

