using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VoiceNaviPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string last_voice = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // 共有メモリ開く
                MemoryMappedFile share_mem = MemoryMappedFile.OpenExisting("YAKIJAKE_MEM");
                MemoryMappedViewAccessor accessor = share_mem.CreateViewAccessor();

                // 共有メモリから読み出し
                char[] data3 = new char[64];
                int readsize = accessor.ReadArray<char>(0, data3, 0, 64);
                string voice = new string(data3);

                // 変わった時だけ処理する
                if (voice != last_voice)
                {
                    label1.Text = voice;
                    Console.WriteLine(voice.ToString());
                }
                last_voice = voice;

                // Dispose resource
                accessor.Dispose();
                share_mem.Dispose();
            }
            catch (Exception error)
            {
                Debug.Write(error);
            }
        }
    }
}
