using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Liga_Mistru
{
    public enum FotbalovyKlub
    {
        None,
        FC_Porto,
        Arsenal,
        Real_Madrid,
        Chelsea,
        Barcelona
    }


    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
