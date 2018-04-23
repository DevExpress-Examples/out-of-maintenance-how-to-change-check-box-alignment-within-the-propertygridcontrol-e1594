using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RepositoryItemCheckEdit edit = new RepositoryItemCheckEdit();
            edit.Caption = "";
            edit.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            propertyGridControl1.RepositoryItems.Add(edit);
            propertyGridControl1.DefaultEditors.Add(typeof(bool), edit);
            propertyGridControl1.SelectedObject = new MyClass();
        }
    }

    class MyClass
    {
        private Boolean myVar;

        public Boolean MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
	
    }
}