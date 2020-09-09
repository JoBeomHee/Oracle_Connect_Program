using Oracel_Connect_Program.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracel_Connect_Program
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.Load += FormLoad_Event;
        }

        /// <summary>
        /// 폼 Load 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad_Event(object sender, EventArgs e)
        {
            //Connect to DB
            if (OracleDBManager.Instance.GetConnection() == false)
            {
                MessageBox.Show("Failed to connect to DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
