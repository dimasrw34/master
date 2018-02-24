using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MetroFramework.Controls;
using  System.Windows.Forms;
using XFace.PanelBuilders;

namespace XFace
{

    
    class BuiderPanelAndOneGrid : AbsrtactPanelBuilder

    {
        private MetroPanel metroPanel;
        private MetroGrid metroGrid;

        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();


        public override void BuildMetroPanel()
        {
            metroPanel = new MetroFramework.Controls.MetroPanel();
            metroGrid = new MetroFramework.Controls.MetroGrid();

            metroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            metroPanel.HorizontalScrollbarBarColor = true;
            metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel.HorizontalScrollbarSize = 10;
            metroPanel.Location = new System.Drawing.Point(0, 0);
            metroPanel.Name = "metroPanel";
            metroPanel.Size = new System.Drawing.Size(1037, 443);
            metroPanel.TabIndex = 1;
            metroPanel.VerticalScrollbarBarColor = true;
            metroPanel.VerticalScrollbarHighlightOnWheel = false;
            metroPanel.VerticalScrollbarSize = 10;
            metroPanel.BackColor = Color.Blue;

            metroPanel.Controls.Add(metroGrid);
           metroPanel.ResumeLayout(true);

            ((System.ComponentModel.ISupportInitialize)(metroGrid)).BeginInit();
            

            metroGrid.AllowUserToAddRows = false;
            metroGrid.AllowUserToDeleteRows = false;
            metroGrid.AllowUserToResizeRows = false;
            metroGrid.RowHeadersVisible = false;
            metroGrid.Dock = DockStyle.Fill;
            metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            metroGrid.EnableHeadersVisualStyles = false;
            metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            metroGrid.Location = new System.Drawing.Point(-29, 65);
            metroGrid.Name = "metroGrid";
            metroGrid.ReadOnly = false;
            metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGrid.RowTemplate.Height = 24;
            metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            metroGrid.Size = new System.Drawing.Size(275, 163);
            metroGrid.TabIndex = 0;
            metroGrid.Theme = MetroFramework.MetroThemeStyle.Light;


            ((System.ComponentModel.ISupportInitialize)(metroGrid)).EndInit();
            metroPanel.ResumeLayout(false);

           
        }

        public override MetroPanel GetMetroPanel()
        {
            return metroPanel;
        }

        public override void AddColums(int columns)
        {


            for (int i = 0; i < columns ; i++)
            {

                metroGrid.Columns.Add("", "");
                metroGrid.Columns[i].Name = "Column" + i.ToString();
                metroGrid.Columns[i].HeaderText= "Column" + i.ToString();
                metroGrid.Columns[i].ReadOnly = true;
            }
        }

        public override MetroGrid MetroCurrGrid
        {
            get { return metroGrid; }
            
        }

        public override void Dispose()
        {
            this.metroPanel.Dispose();
        }


    }
}
