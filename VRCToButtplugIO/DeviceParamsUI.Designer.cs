﻿namespace VRCToyController
{
    partial class DeviceParamsUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.y = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.motor = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.TextBox();
            this.tooltip_volume = new System.Windows.Forms.Label();
            this.groupVolume = new System.Windows.Forms.TableLayoutPanel();
            this.volume_depth = new System.Windows.Forms.TextBox();
            this.volume_width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tooltip_thrust = new System.Windows.Forms.Label();
            this.groupThrusting = new System.Windows.Forms.TableLayoutPanel();
            this.thrust_speed_scale = new System.Windows.Forms.TextBox();
            this.thrust_acceleration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thrust_depth_scale = new System.Windows.Forms.TextBox();
            this.tooltipRub = new System.Windows.Forms.Label();
            this.groupRubbing = new System.Windows.Forms.TableLayoutPanel();
            this.rub_scale = new System.Windows.Forms.TextBox();
            this.rub_acceleration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rem_button = new System.Windows.Forms.Button();
            this.label_pixel_found = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupVolume.SuspendLayout();
            this.groupThrusting.SuspendLayout();
            this.groupRubbing.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tooltip_volume);
            this.flowLayoutPanel1.Controls.Add(this.groupVolume);
            this.flowLayoutPanel1.Controls.Add(this.tooltip_thrust);
            this.flowLayoutPanel1.Controls.Add(this.groupThrusting);
            this.flowLayoutPanel1.Controls.Add(this.tooltipRub);
            this.flowLayoutPanel1.Controls.Add(this.groupRubbing);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(433, 244);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.x);
            this.flowLayoutPanel3.Controls.Add(this.y);
            this.flowLayoutPanel3.Controls.Add(this.label11);
            this.flowLayoutPanel3.Controls.Add(this.motor);
            this.flowLayoutPanel3.Controls.Add(this.label_pixel_found);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(429, 37);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(74, 3);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(50, 26);
            this.x.TabIndex = 1;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(130, 3);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(50, 26);
            this.y.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Motor:";
            // 
            // motor
            // 
            this.motor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motor.FormattingEnabled = true;
            this.motor.Location = new System.Drawing.Point(246, 3);
            this.motor.Name = "motor";
            this.motor.Size = new System.Drawing.Size(71, 28);
            this.motor.TabIndex = 4;
            this.motor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsInt);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.typeSelector);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.max);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(430, 38);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Calculation:";
            // 
            // typeSelector
            // 
            this.typeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Location = new System.Drawing.Point(100, 3);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(147, 28);
            this.typeSelector.TabIndex = 3;
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(253, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(301, 3);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(100, 26);
            this.max.TabIndex = 5;
            this.max.Text = "1.0";
            this.max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            this.max.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BoxFloatBetween0And1);
            // 
            // tooltip_volume
            // 
            this.tooltip_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tooltip_volume.AutoSize = true;
            this.tooltip_volume.Location = new System.Drawing.Point(3, 87);
            this.tooltip_volume.Name = "tooltip_volume";
            this.tooltip_volume.Size = new System.Drawing.Size(430, 20);
            this.tooltip_volume.TabIndex = 4;
            this.tooltip_volume.Text = "(strength = widthScale * width + depthScale * depth)";
            this.tooltip_volume.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupVolume
            // 
            this.groupVolume.ColumnCount = 2;
            this.groupVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupVolume.Controls.Add(this.volume_depth, 1, 1);
            this.groupVolume.Controls.Add(this.volume_width, 1, 0);
            this.groupVolume.Controls.Add(this.label3, 0, 0);
            this.groupVolume.Controls.Add(this.label2, 0, 1);
            this.groupVolume.Location = new System.Drawing.Point(3, 110);
            this.groupVolume.Name = "groupVolume";
            this.groupVolume.RowCount = 2;
            this.groupVolume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupVolume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupVolume.Size = new System.Drawing.Size(246, 70);
            this.groupVolume.TabIndex = 3;
            // 
            // volume_depth
            // 
            this.volume_depth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volume_depth.Location = new System.Drawing.Point(126, 39);
            this.volume_depth.Name = "volume_depth";
            this.volume_depth.Size = new System.Drawing.Size(100, 26);
            this.volume_depth.TabIndex = 1;
            this.volume_depth.Text = "0.5";
            this.volume_depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            // 
            // volume_width
            // 
            this.volume_width.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volume_width.Location = new System.Drawing.Point(126, 4);
            this.volume_width.Name = "volume_width";
            this.volume_width.Size = new System.Drawing.Size(100, 26);
            this.volume_width.TabIndex = 0;
            this.volume_width.Text = "0.5";
            this.volume_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "width scale:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "depth scale:";
            // 
            // tooltip_thrust
            // 
            this.tooltip_thrust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tooltip_thrust.AutoSize = true;
            this.tooltip_thrust.Location = new System.Drawing.Point(3, 183);
            this.tooltip_thrust.Name = "tooltip_thrust";
            this.tooltip_thrust.Size = new System.Drawing.Size(430, 40);
            this.tooltip_thrust.TabIndex = 6;
            this.tooltip_thrust.Text = "(strength = (depth*depthScale+thustSpeed*speedScale) *(acceleration*time))";
            this.tooltip_thrust.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupThrusting
            // 
            this.groupThrusting.ColumnCount = 2;
            this.groupThrusting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupThrusting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupThrusting.Controls.Add(this.thrust_speed_scale, 1, 1);
            this.groupThrusting.Controls.Add(this.thrust_acceleration, 1, 0);
            this.groupThrusting.Controls.Add(this.label6, 0, 0);
            this.groupThrusting.Controls.Add(this.label7, 0, 1);
            this.groupThrusting.Controls.Add(this.label5, 0, 2);
            this.groupThrusting.Controls.Add(this.thrust_depth_scale, 1, 2);
            this.groupThrusting.Location = new System.Drawing.Point(439, 3);
            this.groupThrusting.Name = "groupThrusting";
            this.groupThrusting.RowCount = 3;
            this.groupThrusting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupThrusting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupThrusting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.groupThrusting.Size = new System.Drawing.Size(246, 98);
            this.groupThrusting.TabIndex = 4;
            // 
            // thrust_speed_scale
            // 
            this.thrust_speed_scale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thrust_speed_scale.Location = new System.Drawing.Point(126, 35);
            this.thrust_speed_scale.Name = "thrust_speed_scale";
            this.thrust_speed_scale.Size = new System.Drawing.Size(100, 26);
            this.thrust_speed_scale.TabIndex = 1;
            this.thrust_speed_scale.Text = "1.0";
            this.thrust_speed_scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            // 
            // thrust_acceleration
            // 
            this.thrust_acceleration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thrust_acceleration.Location = new System.Drawing.Point(126, 3);
            this.thrust_acceleration.Name = "thrust_acceleration";
            this.thrust_acceleration.Size = new System.Drawing.Size(100, 26);
            this.thrust_acceleration.TabIndex = 0;
            this.thrust_acceleration.Text = "1.0";
            this.thrust_acceleration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "acceleration:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "speed scale:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "deoth scale:";
            // 
            // thrust_depth_scale
            // 
            this.thrust_depth_scale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thrust_depth_scale.Location = new System.Drawing.Point(126, 68);
            this.thrust_depth_scale.Name = "thrust_depth_scale";
            this.thrust_depth_scale.Size = new System.Drawing.Size(100, 26);
            this.thrust_depth_scale.TabIndex = 5;
            this.thrust_depth_scale.Text = "1.0";
            // 
            // tooltipRub
            // 
            this.tooltipRub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tooltipRub.AutoSize = true;
            this.tooltipRub.Location = new System.Drawing.Point(439, 104);
            this.tooltipRub.Name = "tooltipRub";
            this.tooltipRub.Size = new System.Drawing.Size(356, 20);
            this.tooltipRub.TabIndex = 7;
            this.tooltipRub.Text = "(strength = (rubSpeed*scale)*(acceleration*time))";
            this.tooltipRub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupRubbing
            // 
            this.groupRubbing.ColumnCount = 2;
            this.groupRubbing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupRubbing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupRubbing.Controls.Add(this.rub_scale, 1, 1);
            this.groupRubbing.Controls.Add(this.rub_acceleration, 1, 0);
            this.groupRubbing.Controls.Add(this.label8, 0, 0);
            this.groupRubbing.Controls.Add(this.label9, 0, 1);
            this.groupRubbing.Location = new System.Drawing.Point(439, 127);
            this.groupRubbing.Name = "groupRubbing";
            this.groupRubbing.RowCount = 2;
            this.groupRubbing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupRubbing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupRubbing.Size = new System.Drawing.Size(246, 70);
            this.groupRubbing.TabIndex = 5;
            // 
            // rub_scale
            // 
            this.rub_scale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rub_scale.Location = new System.Drawing.Point(126, 39);
            this.rub_scale.Name = "rub_scale";
            this.rub_scale.Size = new System.Drawing.Size(100, 26);
            this.rub_scale.TabIndex = 1;
            this.rub_scale.Text = "1.0";
            this.rub_scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            // 
            // rub_acceleration
            // 
            this.rub_acceleration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rub_acceleration.Location = new System.Drawing.Point(126, 4);
            this.rub_acceleration.Name = "rub_acceleration";
            this.rub_acceleration.Size = new System.Drawing.Size(100, 26);
            this.rub_acceleration.TabIndex = 0;
            this.rub_acceleration.Text = "1.0";
            this.rub_acceleration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressIsNumber);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "acceleration:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "scale:";
            // 
            // rem_button
            // 
            this.rem_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rem_button.AutoSize = true;
            this.rem_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rem_button.Location = new System.Drawing.Point(356, 214);
            this.rem_button.Name = "rem_button";
            this.rem_button.Size = new System.Drawing.Size(78, 30);
            this.rem_button.TabIndex = 5;
            this.rem_button.Text = "Remove";
            this.rem_button.UseVisualStyleBackColor = true;
            this.rem_button.Click += new System.EventHandler(this.rem_button_Click);
            // 
            // label_pixel_found
            // 
            this.label_pixel_found.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_pixel_found.AutoSize = true;
            this.label_pixel_found.Location = new System.Drawing.Point(323, 7);
            this.label_pixel_found.Name = "label_pixel_found";
            this.label_pixel_found.Size = new System.Drawing.Size(0, 20);
            this.label_pixel_found.TabIndex = 5;
            this.label_pixel_found.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeviceParamsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.rem_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DeviceParamsUI";
            this.Size = new System.Drawing.Size(439, 254);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupVolume.ResumeLayout(false);
            this.groupVolume.PerformLayout();
            this.groupThrusting.ResumeLayout(false);
            this.groupThrusting.PerformLayout();
            this.groupRubbing.ResumeLayout(false);
            this.groupRubbing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.NumericUpDown x;
        public System.Windows.Forms.NumericUpDown y;
        public System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel groupVolume;
        private System.Windows.Forms.Label tooltip_volume;
        private System.Windows.Forms.TableLayoutPanel groupThrusting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel groupRubbing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox thrust_acceleration;
        public System.Windows.Forms.TextBox thrust_speed_scale;
        public System.Windows.Forms.TextBox rub_acceleration;
        public System.Windows.Forms.TextBox rub_scale;
        public System.Windows.Forms.TextBox volume_width;
        public System.Windows.Forms.TextBox volume_depth;
        private System.Windows.Forms.Label tooltip_thrust;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox thrust_depth_scale;
        private System.Windows.Forms.Label tooltipRub;
        public System.Windows.Forms.TextBox max;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox motor;
        private System.Windows.Forms.Button rem_button;
        public System.Windows.Forms.Label label_pixel_found;
    }
}
