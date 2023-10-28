using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_Setting
{
    public partial class Form_Backup : Form
    {
        private DB_FWDEntities DataBase;

        public Form_Backup()
        {
            InitializeComponent();
        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            Form_Message_wrong message_Wrong = new Form_Message_wrong();
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if(rs == DialogResult.OK)
                {
                    pictureBox1.Visible = false;
                    var result = await Task.Run(() => backup(folder));
                    if (result == true)
                    {
                        MessageBox.Show("تم النسخ الاحتياطى");
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        message_Wrong.Show();
                        pictureBox1.Visible = true;

                    }
                }


            }
            catch
            {
                message_Wrong.Show();
            }

        }

        private bool backup(FolderBrowserDialog folder)
        {
            try{
                DataBase = new DB_FWDEntities();
                string db_name = DataBase.Database.Connection.Database;
                string db_backup = "Back_Up " + DateTime.Now.ToString("yyyyMMddHHmm");
                var fullpath = folder.SelectedPath.ToString() + db_backup + ".bak";
            //    string sqlcomand = @"BACKUP DATABASE [{0}] TO DISK = '" + fullpath + "'WITH NOFORMAT, NOUNIT,NAME='DB_FWD',SKIP,NOREWIND,NOUNLOAD, STATS=10";
                string sqlcomand = @"BACKUP DATABASE [{0}] TO DISK = '" + fullpath + "' WITH NOFORMAT, NAME='DB_FWD', SKIP, NOREWIND, NOUNLOAD, STATS=10";

                int path = DataBase.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlcomand, db_name, db_backup));
                return true;
            }
            catch
            {
                return false;
            }
        }

            private async void simpleButton2_Click(object sender, EventArgs e)
            {
                Form_Message_wrong message_Wrong = new Form_Message_wrong();
           //     try
             //   {
                    OpenFileDialog folder = new OpenFileDialog();
                    var rs = folder.ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        pictureBox1.Visible = false;
                        var result = await Task.Run(() => restore_(folder));
                        if (result == true)
                        {
                            MessageBox.Show("تم استعادة النسخ الاحتياطى");
                            pictureBox1.Visible = true;
                        }
                        else
                        {
                            message_Wrong.Show();
                            pictureBox1.Visible = true;

                        }
                    }

                    /*
                }
                catch(Exception ex)
                {
                    message_Wrong.Show();
                }*/
            } 



            private bool restore_(OpenFileDialog folder)
            {
               //  try {
                    DataBase = new DB_FWDEntities();
                    string db_name = DataBase.Database.Connection.Database;
              
                    string sqlcomand = @"Use master;Restore DATABASE [{0}] From DISK = '" + folder.FileName + "'";

                    int path = DataBase.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlcomand, db_name));
                    return true;
            /*   }
                catch
                {
                    return false;
                }*/
            }

    }
} 
