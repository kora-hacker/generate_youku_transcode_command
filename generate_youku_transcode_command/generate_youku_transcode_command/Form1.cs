using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace generate_youku_transcode_command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string simple_uuid_string()
        {
            string s = System.Guid.NewGuid().ToString();
            s = s.Substring(0, 8);
            return s;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /* 设置一些默认值 */
            ui_textbox_src.Text = @"D:\Youku Files\download";
            ui_textbox_des.Text = @"D:\Youku Files\transcode";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 读取src中的文件夹，然后开始生成转换命令
            string[] src_file_path = Directory.GetFiles(ui_textbox_src.Text, "*.kux");
            
            /*ui_msg_out.AppendText(Convert.ToString(src_file_path.Length) + "\n");*/

            /*for (int i = 0; i < src_file_path.Length; i++)
            {
                ui_msg_out.AppendText(src_file_path[i] + "\n");
            }

            for (int i = 0; i < src_file_path.Length; i++)
            {
                string file_name = Path.GetFileNameWithoutExtension(src_file_path[i]);
                ui_msg_out.AppendText(file_name + "\n");
            }*/

            StreamWriter sw = new StreamWriter(/*@"C:\Documents and Settings\kora.hacker\桌面\" +*/ simple_uuid_string() + ".bat");
            
            ui_msg_out.AppendText("@echo off\r\n");
            ui_msg_out.AppendText("cls\r\n");

            sw.WriteLine("@echo off");
            sw.WriteLine("cls");


            for (int i = 0; i < src_file_path.Length; i++)
            {
                string command_string = "ffmpeg -y -i \"" + src_file_path[i] + "\"  -vcodec copy -acodec copy -f mp4 \"" + ui_textbox_des.Text + "\\" + Path.GetFileNameWithoutExtension(src_file_path[i]) + ".mp4\"";
                ui_msg_out.AppendText(command_string + "\r\n");
                sw.WriteLine(command_string);
                string move_string = "move \"" + src_file_path[i] + "\" \"" + ui_textbox_src.Text + "\\done\"";
                ui_msg_out.AppendText(move_string + "\r\n");
                sw.WriteLine(move_string);
            }
            
            ui_msg_out.AppendText("pause\r\n");
            sw.WriteLine("pause");

            sw.Close();
        }

        
    }
}
