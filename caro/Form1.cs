using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro
{
    public partial class Form1 : Form
    {
        BanCo newBanCo;
        QuanLiServer socket;
        public static int mode ;
        public Form1()
        {
            InitializeComponent();
            newBanCo = new BanCo(ptbDaiDien, labelName, prgTimeLine);
            newBanCo.ChienThang += NewBanCo_ChienThang;
            newBanCo.UndoFalse += NewBanCo_UndoFalse;
            newBanCo.PlayerMark += NewBanCo_PlayerMark;
            //PlayGame();
            socket = new QuanLiServer();
        }

        private void NewBanCo_PlayerMark(object sender, ButtonClickEvent e)
        {
            if (newBanCo.CheDoChoi == 2)
            {
                try
                {
                    pnlBanCo.Enabled = false;
                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
                    Listen();
                }
                catch { }
            }
        }
        
        public void PlayGame()
         {
            if(mode == 1)
            {
                pnlBanCo.Enabled = true;
                newBanCo.NewGamePvPC();
                undoToolStripMenuItem1.Enabled = true;
   
            }
            else if(mode == 2)
            {
                newBanCo.CheDoChoi = 1;
                newBanCo.NguoiChoi1 = new NguoiChoi("Hoang", Image.FromFile(Application.StartupPath + "\\Resources\\x.png"), 1);
                newBanCo.NguoiChoi2 = new NguoiChoi("Viet", Image.FromFile(Application.StartupPath + "\\Resources\\o.png"), 2);

                pnlBanCo.Enabled = true;
                newBanCo.NewGamePvsP();
                undoToolStripMenuItem1.Enabled = true;


               
            }
            else
            {
                //btnConnectLan.Enabled = true;
                newBanCo.NewGameLAN(); // cho thằng đang bấm new
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));// cho đối thủ cũng new theo
                prgTimeLine.Value = 0;
            }
        }

        private void NewBanCo_UndoFalse(object sender, EventArgs e)
        {
            // bắt sự kiện từ BanCo, khóa nút undo
            undoToolStripMenuItem1.Enabled = false;
            // done!
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            newBanCo.TaoBanCo(pnlBanCo);
            labelName.Text = "";
            labelName.Enabled = false;
            pnlBanCo.Enabled = false;
            //btnConnectLan.Enabled = true;

        }

        private void NewBanCo_ChienThang(object sender, EventArgs e)
        {
            timer1.Stop();
            KetThuc();
        }

        private void KetThuc()
        {
            pnlBanCo.Enabled = false;
            MessageBox.Show("Chúc mừng! Người chơi " + newBanCo.ThongTinNguoiThang() + " đã chiến thắng!" );
        }
 
      

        public void BtnLan()
        {
            newBanCo.CheDoChoi = 2;
            newBanCo.NguoiChoi1 = new NguoiChoi("Hoang", Image.FromFile(Application.StartupPath + "\\Resources\\X.png"), 1);
            newBanCo.NguoiChoi2 = new NguoiChoi("Viet", Image.FromFile(Application.StartupPath + "\\Resources\\O.png"), 2);
            socket.IP = txtIP.Text;
            if (!socket.ConnectServer())
            {
                socket.IsServer = true;
                pnlBanCo.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.IsServer = false;
                pnlBanCo.Enabled = false;
                Listen();
            }
        }
        private void btnConnectLan_Click(object sender, EventArgs e)
        {
            BtnLan();
        }
        public void multiPlay()
        {
            if (mode == 3)
            {
                txtIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
                if (string.IsNullOrEmpty(txtIP.Text))
                {
                    txtIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
                    
                    BtnLan();
                }
                
                BtnLan();

            }
            else
            {
                PlayGame();
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            multiPlay();
        }

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData Data)
        {
            switch(Data.Command)
            {
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pnlBanCo.Enabled = true;
                        newBanCo.OtherPlayerMark(Data.Point);
                    }));
                    break;
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(Data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        newBanCo.NewGameLAN();
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        newBanCo.UndoMethod();
                    }));

                    break;
                case (int)SocketCommand.REDO:
                    break;
                case (int)SocketCommand.EXIT:
                    MessageBox.Show("Người chơi còn lại đã thoát!");
                    break;
                default:
                    break;

            }
            Listen();
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBanCo.UndoMethod();
            timer1.Start();
            prgTimeLine.Value = 0;
            if (newBanCo.CheDoChoi == 2)
                socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(newBanCo.CheDoChoi == 2)
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.EXIT, "", new Point()));// cho đối thủ cũng exit theo
                }
                catch { }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newBanCo.UndoMethod();
            if (newBanCo.CheDoChoi == 2)
                socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chọnChếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormIndex frm = new FormIndex();
            frm.Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
        }
    }
}
