using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace FMC
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            create_project_button = new Button();
            item_icons_flow_panel = new FlowLayoutPanel();
            iconSearchTextBox = new TextBox();
            iconProgressBar = new ProgressBar();
            project_name_text_box = new TextBox();
            mod_objects_flow_panel = new FlowLayoutPanel();
            mod_objects_tree_view = new TreeView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mod_object_data_grid_view = new DataGridView();
            modObjectBindingSource = new BindingSource(components);
            open_mod_object_button = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            create_mod_object_button = new Button();
            print_tree_view_button = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mod_object_data_grid_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modObjectBindingSource).BeginInit();
            SuspendLayout();
            // 
            // create_project_button
            // 
            create_project_button.Location = new Point(12, 40);
            create_project_button.Name = "create_project_button";
            create_project_button.Size = new Size(155, 23);
            create_project_button.TabIndex = 0;
            create_project_button.Text = "Projekt erstellen";
            create_project_button.UseVisualStyleBackColor = true;
            // 
            // item_icons_flow_panel
            // 
            item_icons_flow_panel.AutoScroll = true;
            item_icons_flow_panel.FlowDirection = FlowDirection.TopDown;
            item_icons_flow_panel.Location = new Point(726, 40);
            item_icons_flow_panel.Name = "item_icons_flow_panel";
            item_icons_flow_panel.Size = new Size(128, 418);
            item_icons_flow_panel.TabIndex = 2;
            item_icons_flow_panel.WrapContents = false;
            // 
            // iconSearchTextBox
            // 
            iconSearchTextBox.Location = new Point(726, 12);
            iconSearchTextBox.Name = "iconSearchTextBox";
            iconSearchTextBox.Size = new Size(128, 23);
            iconSearchTextBox.TabIndex = 3;
            // 
            // iconProgressBar
            // 
            iconProgressBar.BackColor = SystemColors.InactiveCaptionText;
            iconProgressBar.Cursor = Cursors.WaitCursor;
            iconProgressBar.Location = new Point(12, 552);
            iconProgressBar.MarqueeAnimationSpeed = 1000;
            iconProgressBar.Name = "iconProgressBar";
            iconProgressBar.Size = new Size(842, 10);
            iconProgressBar.Step = 1;
            iconProgressBar.Style = ProgressBarStyle.Continuous;
            iconProgressBar.TabIndex = 4;
            iconProgressBar.UseWaitCursor = true;
            iconProgressBar.Value = 100;
            // 
            // project_name_text_box
            // 
            project_name_text_box.Location = new Point(12, 11);
            project_name_text_box.Name = "project_name_text_box";
            project_name_text_box.Size = new Size(155, 23);
            project_name_text_box.TabIndex = 5;
            // 
            // mod_objects_flow_panel
            // 
            mod_objects_flow_panel.Location = new Point(12, 132);
            mod_objects_flow_panel.Name = "mod_objects_flow_panel";
            mod_objects_flow_panel.Size = new Size(155, 414);
            mod_objects_flow_panel.TabIndex = 6;
            // 
            // mod_objects_tree_view
            // 
            mod_objects_tree_view.ImeMode = ImeMode.Katakana;
            mod_objects_tree_view.Location = new Point(173, 11);
            mod_objects_tree_view.Name = "mod_objects_tree_view";
            mod_objects_tree_view.Size = new Size(213, 447);
            mod_objects_tree_view.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(mod_object_data_grid_view);
            flowLayoutPanel1.Location = new Point(392, 11);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(328, 535);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // mod_object_data_grid_view
            // 
            mod_object_data_grid_view.AllowUserToAddRows = false;
            mod_object_data_grid_view.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "None";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            mod_object_data_grid_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            mod_object_data_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mod_object_data_grid_view.Location = new Point(3, 3);
            mod_object_data_grid_view.Name = "mod_object_data_grid_view";
            mod_object_data_grid_view.ShowCellErrors = false;
            mod_object_data_grid_view.Size = new Size(325, 532);
            mod_object_data_grid_view.TabIndex = 0;
            // 
            // open_mod_object_button
            // 
            open_mod_object_button.Location = new Point(173, 508);
            open_mod_object_button.Name = "open_mod_object_button";
            open_mod_object_button.Size = new Size(103, 38);
            open_mod_object_button.TabIndex = 9;
            open_mod_object_button.Text = "Mod-Objekt öffnen";
            open_mod_object_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(726, 464);
            button1.Name = "button1";
            button1.Size = new Size(128, 38);
            button1.TabIndex = 11;
            button1.Text = "Factorio";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(726, 508);
            button2.Name = "button2";
            button2.Size = new Size(128, 38);
            button2.TabIndex = 12;
            button2.Text = "Projekt";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(283, 508);
            button3.Name = "button3";
            button3.Size = new Size(103, 38);
            button3.TabIndex = 13;
            button3.Text = "Mod-Objekt löschen";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 69);
            button4.Name = "button4";
            button4.Size = new Size(155, 23);
            button4.TabIndex = 14;
            button4.Text = "Projektordner öffnen";
            button4.UseVisualStyleBackColor = true;
            // 
            // create_mod_object_button
            // 
            create_mod_object_button.Location = new Point(173, 464);
            create_mod_object_button.Name = "create_mod_object_button";
            create_mod_object_button.Size = new Size(103, 38);
            create_mod_object_button.TabIndex = 15;
            create_mod_object_button.Text = "Mod-Objekt erstellen";
            create_mod_object_button.UseVisualStyleBackColor = true;
            // 
            // print_tree_view_button
            // 
            print_tree_view_button.Location = new Point(12, 98);
            print_tree_view_button.Name = "print_tree_view_button";
            print_tree_view_button.Size = new Size(155, 23);
            print_tree_view_button.TabIndex = 16;
            print_tree_view_button.Text = "TreeView printen";
            print_tree_view_button.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(867, 574);
            Controls.Add(print_tree_view_button);
            Controls.Add(create_mod_object_button);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(open_mod_object_button);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(mod_objects_tree_view);
            Controls.Add(mod_objects_flow_panel);
            Controls.Add(project_name_text_box);
            Controls.Add(iconProgressBar);
            Controls.Add(iconSearchTextBox);
            Controls.Add(item_icons_flow_panel);
            Controls.Add(create_project_button);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainWindow";
            Text = "FMC - Factorio Mod Creator";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mod_object_data_grid_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)modObjectBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_project_button;
        private FlowLayoutPanel item_icons_flow_panel;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel26;
        private Panel panel25;
        private TextBox iconSearchTextBox;
        private ProgressBar iconProgressBar;
        private TextBox project_name_text_box;
        private Button button1;
        private FlowLayoutPanel mod_objects_flow_panel;
        public TreeView mod_objects_tree_view;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button open_mod_object_button;
        private DataGridView mod_object_data_grid_view;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource modObjectBindingSource;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button create_mod_object_button;
        private Button print_tree_view_button;
    }
}
