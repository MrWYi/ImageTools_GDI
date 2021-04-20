using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 * 
 * 2021/4/20
 * ModernUI 2.0.5个人修改版
 * 需要使用该ui框架,请看原作者https://github.com/peters/winforms-modernui
 * 
 */

namespace ImageTools_GDI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTool());
        }
    }
}
