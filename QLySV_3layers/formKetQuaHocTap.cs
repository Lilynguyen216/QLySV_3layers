using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLySV_3layers
{
    public partial class formKetQuaHocTap : Form
    {
        public formKetQuaHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }

        private void formKetQuaHocTap_Load(object sender, EventArgs e)
        {

        }
        private string msv;
    }
}
