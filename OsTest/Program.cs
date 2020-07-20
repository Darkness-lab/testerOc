using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using System.Windows.Forms;

namespace OsTest
{
    class Program
    {
        static void Main(string[] args)
        {   var os = Environment.OSVersion;
            int mj = os.Version.Major;
            int mi = os.Version.Minor;
            if(mj == 6 && mi == 2)
            {
                Process.Start("Program.exe");
            }
            else
            {
                MessageBox.Show("0x8985", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
