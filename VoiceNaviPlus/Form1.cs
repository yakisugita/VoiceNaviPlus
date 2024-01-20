using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VoiceNaviPlus
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer player;

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
                MemoryMappedFile share_mem = MemoryMappedFile.OpenExisting("VoiceNaviPlus_Telemetry");
                MemoryMappedViewAccessor accessor = share_mem.CreateViewAccessor();

                // 共有メモリから読み出し
                char[] data3 = new char[64];
                int readsize = accessor.ReadArray<char>(0, data3, 0, 64);
                string voice = new string(data3);

                // 変わった時だけ処理する
                if (voice != last_voice)
                {
                    label1.Text = voice;
                    Console.WriteLine(label1.Text);

                    // イベント名判定
                    string voice_id = "";
                    if (label1.Text != "")
                    {
                        switch (label1.Text)
                        {
                            case "start": voice_id = "0010"; break;
                            case "finish": voice_id = "0020"; break;
                            case "recomputing": voice_id = "0030"; break;
                            case "speed_signal": voice_id = "0040"; break;
                            case "speed_warning": voice_id = "0050"; break;
                            case "u_turn": voice_id = "0060"; break;

                            case "turn_left": voice_id = "0110"; break;
                            case "turn_right": voice_id = "0120"; break;
                            case "go_straight": voice_id = "0130"; break;
                            case "exit_left": voice_id = "0140"; break;
                            case "exit_right": voice_id = "0150"; break;
                            case "exit_now": voice_id = "0160"; break;
                            case "keep_left": voice_id = "0170"; break;
                            case "keep_right": voice_id = "0180"; break;

                            case "and_then_exit_left": voice_id = "0210"; break;
                            case "and_then_exit_right": voice_id = "0220"; break;
                            case "and_then_go_straight": voice_id = "0230"; break;
                            case "and_then_keep_left": voice_id = "0240"; break;
                            case "and_then_keep_right": voice_id = "0250"; break;
                            case "and_then_turn_left": voice_id = "0260"; break;
                            case "and_then_turn_right": voice_id = "0270"; break;

                            case "prepare_exit_left": voice_id = "0310"; break;
                            case "prepare_exit_right": voice_id = "0320"; break;
                            case "prepare_turn_left": voice_id = "0330"; break;
                            case "prepare_turn_right": voice_id = "0340"; break;

                            case "roundabout_1": voice_id = "0410"; break;
                            case "roundabout_2": voice_id = "0420"; break;
                            case "roundabout_3": voice_id = "0430"; break;
                            case "roundabout_4": voice_id = "0440"; break;
                            case "roundabout_5": voice_id = "0450"; break;
                            case "roundabout_6": voice_id = "0460"; break;

                            case "compound_turn_left": voice_id = "0510"; break;
                            case "compound_turn_right": voice_id = "0520"; break;
                            case "compound_go_straight": voice_id = "0530"; break;
                            case "compound_exit_left": voice_id = "0540"; break;
                            case "compound_exit_right": voice_id = "0550"; break;
                            case "compound_keep_left": voice_id = "0560"; break;
                            case "compound_keep_right": voice_id = "0570"; break;

                            default: voice_id = "0000"; break;
                        }

                        // exeがあるディレクトリ\resを探索
                        const string profile = "res";
                        string profile_dir = Directory.GetParent(Assembly.GetExecutingAssembly().Location.ToString()) + "\\" + profile;
                        Console.WriteLine(profile_dir);

                        System.IO.DirectoryInfo dir_info = new System.IO.DirectoryInfo(profile_dir);
                        if (dir_info.Exists)
                        {
                            System.IO.FileInfo[] files = dir_info.GetFiles(voice_id + "*.wav", System.IO.SearchOption.AllDirectories);

                            if (files.Length >= 2)
                            {
                                // 同じIDのファイルが複数あればランダム再生
                                // 0～数-1の乱数生成
                                Random random = new Random();
                                int order = random.Next(files.Length);

                                player = new System.Media.SoundPlayer(files[order].FullName);
                                player.Play();
                            }
                            else if (files.Length == 1)
                            {
                                // ファイルが一個ならそのまま再生
                                player = new System.Media.SoundPlayer(files[0].FullName);
                                player.Play();

                            }

                            //結果を出力
                            foreach (System.IO.FileInfo f in files)
                            {
                                Console.WriteLine(f.FullName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("リソースフォルダが存在しません");
                        }
                    }
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
