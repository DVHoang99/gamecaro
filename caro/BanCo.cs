using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro
{
    public class BanCo
    {
        #region Properties
        public static int ChieuRongBanCo = 20;
        public static int ChieuCaoBanCo = 19;
        Stack<Button> dsUndo;
        Stack<Button> dsoldbtn;
        public int LuotChoi;
        PictureBox ptb1;

        Label txt1;
        ProgressBar prg;
        public NguoiChoi NguoiChoi1 { get; set; }
        public NguoiChoi NguoiChoi2 { get; set; }
        private event EventHandler chienThang;
        public event EventHandler ChienThang
        {
            add
            {
                chienThang += value;

            }
            remove
            {
                chienThang += value;
            }
        }
        private event EventHandler<ButtonClickEvent> playerMark;
        public event EventHandler<ButtonClickEvent> PlayerMark
        {
            add
            {
                playerMark += value;

            }
            remove
            {
                playerMark += value;
            }
        }
        private event EventHandler undoFalse;
        public event EventHandler UndoFalse
        {
            add
            {
                undoFalse += value;
            }
            remove
            {
                undoFalse += value;
            }
        }
        
        List<List<Button>> ArroCo;
        public int CheDoChoi;
        public BanCo(PictureBox ptb, Label txt,ProgressBar prg1)
        {
            CheDoChoi = 1;
            NguoiChoi1 = new NguoiChoi("Hoang",Image.FromFile(Application.StartupPath + "\\Resources\\CaroX.png"),1);
            NguoiChoi2 = new NguoiChoi("Viet", Image.FromFile(Application.StartupPath + "\\Resources\\Caro0.png"),2);
            LuotChoi = 1;
            ptb1 = ptb;
            txt1 = txt;
            prg = prg1;
            dsUndo = new Stack<Button>();
            dsoldbtn = new Stack<Button>();

        }
        #endregion

        #region Methods
        public void TaoBanCo(Panel pnlBanCo)
        {
            Button btn = new Button();
            btn.Size = new Size(0, 0);
            ArroCo = new List<List<Button>>();
            for (int i = 0; i < 19; i++)
            {
                ArroCo.Add(new List<Button>()); // tạo ra 1 hàng
                for (int j = 0; j < 20; j++)
                {

                    Button btn1 = new Button();
                    btn1.Size = new Size(30,30);
                    btn1.Location = new Point(btn.Width + btn.Location.X, btn.Location.Y);
                    btn = btn1;
                    btn.Tag = i.ToString();
                    ArroCo[i].Add(btn);

                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += Btn_Click;
                    pnlBanCo.Controls.Add(btn);
                }
                btn = new Button()
                { Size = new Size(0, 0), Location = new Point(0, btn.Location.Y + btn.Height) };
            }
            ThongTinLuotDi();
        }

        private Point GetChessPoint(Button btn)
        {
            int Y = Convert.ToInt32(btn.Tag);
            int X = ArroCo[Y].IndexOf(btn);

            Point point = new Point(X,Y);

            return point;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button newbtn = sender as Button;
            Button oldbtn;
            if (newbtn.BackgroundImage != null)
                return;
            if(LuotChoi==NguoiChoi1.NgChoi)
            {
                newbtn.BackgroundImage = NguoiChoi1.HinhDaiDien;
                if(dsoldbtn.Count() != 0)
                {
                    foreach (var item in dsoldbtn)
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
                
            else
            {
                newbtn.BackgroundImage = NguoiChoi2.HinhDaiDien;
                if (dsoldbtn.Count() != 0)
                {
                    foreach (var item in dsoldbtn)
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
                
            if(playerMark!=null)
            {
                playerMark(this, new ButtonClickEvent(GetChessPoint(newbtn)));
            }
            if (KiemTraThangThua(newbtn))
            {
                chienThang(this, new EventArgs());
                return;
            }
            newbtn.BackColor = Color.Aqua;
            dsUndo.Push(newbtn);
            oldbtn = newbtn;
            dsoldbtn.Push(oldbtn);

            LuotChoi = LuotChoi == 1 ? 2 : 1;
            ThongTinLuotDi();
            if (CheDoChoi == 3 && LuotChoi == 1)
                ComChess();
        }
        private void ThongTinLuotDi()
        {
            if(LuotChoi==NguoiChoi1.NgChoi)
            {
                ptb1.Image = NguoiChoi1.HinhDaiDien;
                txt1.Text = NguoiChoi1.Ten;
            }
            else
            {
                ptb1.Image = NguoiChoi2.HinhDaiDien;
                txt1.Text = NguoiChoi2.Ten;
            }
        }
        #region Kiểm tra thắng thua - thông tin người thắng
        private bool KiemTraThangThua(Button btn)
        {
            return ThangHangDoc(btn) || ThangHangNgang(btn) || ThangCheoChinh(btn) || ThangCheoPhu(btn);
        }

        private bool ThangCheoPhu(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = ArroCo[vertical].IndexOf(btn);
            Point point = new Point(vertical, horizontal);
            int a = 0;
            int b = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.Y + i > ChieuRongBanCo || point.X - i < 0)
                    break;

                if (ArroCo[point.X - i][point.Y + i].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                else if(ArroCo[point.X - i][point.Y + i].BackgroundImage is null)
                {
                    break;
                }
                else
                {
                    b++;
                }
            }

            for (int i = 1; i <= ChieuRongBanCo - point.X; i++)
            {
                if (point.X + i >= ChieuCaoBanCo || point.Y - i < 0)
                    break;

                if (ArroCo[point.X + i][point.Y - i].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                if (ArroCo[point.X + i][point.Y - i].BackgroundImage is null)
                {
                    break;
                }
                else
                {
                    b++;
                }
            }
            return (a == 5 && b != 2 ) ;
    }

    private bool ThangCheoChinh(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = ArroCo[vertical].IndexOf(btn);
            Point point = new Point(vertical, horizontal);

            int a = 0;
            int b = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;

                if (ArroCo[point.X - i][point.Y - i].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                else if (ArroCo[point.X - i][point.Y - i].BackgroundImage is null)
                {
                    break;
                }
                else
                {
                    b++;
                }
            }
            for (int i = 1; i <= ChieuRongBanCo; i++)
            {
                if (point.X + i >= ChieuCaoBanCo || point.Y + i >= ChieuRongBanCo)
                    break;

                if (ArroCo[point.X + i][point.Y + i].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                if (ArroCo[point.X + i][point.Y + i].BackgroundImage is null)
                {
                    break;
                }
                else
                {
                    b++;
                }
            }

            return (a == 5 && b != 2);
        }

        private bool ThangHangNgang(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = ArroCo[vertical].IndexOf(btn);
            Point point = new Point(vertical, horizontal);
            int a = 0;
            int b = 0;

            for (int i = point.Y; i >= 0; i--)
            {
                if (ArroCo[point.X][i].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                else if (ArroCo[point.X][i].BackgroundImage is null)
                {
                    break;
                }
                else
                {
                    b++;
                }
                
            }

            for (int i = point.Y + 1; i < ChieuRongBanCo; i++)
            {
                if (ArroCo[point.X][i].BackgroundImage == btn.BackgroundImage)
                {

                    a++;
                }
                else if (ArroCo[point.X][i].BackgroundImage is null)
                {

                    break;
                }
                else
                {
                    b++;
                }
               
            }

            return (a == 5 && b !=2) ;
        }

        private bool ThangHangDoc(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = ArroCo[vertical].IndexOf(btn);
            Point point = new Point(vertical, horizontal); ;

            int a = 0;
            int b = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (ArroCo[i][point.Y].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                else if (ArroCo[i][point.Y].BackgroundImage is null)
                {
                    break;
                }
                else
                {
                    b++;
                }
            }

            
            for (int i = point.X + 1; i < ChieuCaoBanCo; i++)
            {
                if (ArroCo[i][point.Y].BackgroundImage == btn.BackgroundImage)
                {
                    a++;
                }
                else if (ArroCo[i][point.Y].BackgroundImage is null)
                {

                    break;
                }
                else
                {
                    b++;
                }
            }

            return (a == 5 && b !=2) ;
        }

        public string ThongTinNguoiThang()
        {
            return LuotChoi == NguoiChoi1.NgChoi ? NguoiChoi1.Ten : NguoiChoi2.Ten;
        }
        #endregion
        public void NewGamePvsP()
        {// cho chạy 2 vòng lập duyệt toàn bộ button trong List<list<btn>>

            for(int i=0; i <ArroCo.Count;i++)
            {
                for(int j=0; j < ArroCo[i].Count;j++)
                {
                    // đổi background image
                    ArroCo[i][j].BackgroundImage = null;
                }
                // chuyển về lượt người đầu tiên
                LuotChoi = 1;
                ThongTinLuotDi();
                dsUndo = new Stack<Button>();
            }
        }
        public void UndoMethod()
        {
            try
            {
                Button undobtn = dsUndo.Pop();

                undobtn.BackgroundImage = null;
                LuotChoi = LuotChoi == 1 ? 2 : 1;
                ThongTinLuotDi();
            }
            catch { }
            
            
        }
        
        public void NewGameLAN()
        {

            for (int i = 0; i < ArroCo.Count; i++)
            {
                for (int j = 0; j < ArroCo[i].Count; j++)
                {
                    // đổi background image
                    ArroCo[i][j].BackgroundImage = null;
                }
                // chuyển về lượt người đầu tiên
                LuotChoi = 1;
                ThongTinLuotDi();

                dsUndo = new Stack<Button>();
            }
        }
        public void OtherPlayerMark(Point point)
        {
            Button newbtn = ArroCo[point.Y][point.X];
            Button oldbtn;
            if (newbtn.BackgroundImage != null)
                return;
            if (LuotChoi == NguoiChoi1.NgChoi)
            {
                newbtn.BackgroundImage = NguoiChoi1.HinhDaiDien;
                if (dsoldbtn.Count() != 0)
                {
                    foreach (var item in dsoldbtn)
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
            else
            {
                newbtn.BackgroundImage = NguoiChoi2.HinhDaiDien;
                if (dsoldbtn.Count() != 0)
                {
                    foreach (var item in dsoldbtn)
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
            dsUndo.Push(newbtn);
            newbtn.BackColor = Color.Aqua;
            dsUndo.Push(newbtn);
            oldbtn = newbtn;
            dsoldbtn.Push(oldbtn);
            LuotChoi = LuotChoi == 1 ? 2 : 1;
            ThongTinLuotDi();
        }

        public void NewGamePvPC()
        {
            CheDoChoi = 3;
            for (int i = 0; i < ArroCo.Count; i++)
            {
                for (int j = 0; j < ArroCo[i].Count; j++)
                {
                    // đổi background image
                    ArroCo[i][j].BackgroundImage = null;
                }
               
                LuotChoi = 1;
                ThongTinLuotDi();
                dsUndo = new Stack<Button>();
                NguoiChoi1 = new NguoiChoi("Computer", Image.FromFile(Application.StartupPath + "\\Resources\\CaroX.png"), 1);
            }
            ComChess();
        }
        //mảng điểm phòng ngự và mảng điểm tấn công
        private long[] arrAttackPoint = { 0, 9, 54, 162, 1458, 13112, 118008 };
        private long[] arrDefendPoint = { 0, 3, 27, 99, 729, 6561, 59049 };

        private void ComChess()
        {
            if(dsUndo.Count == 0)
            {
                Btn_Click(ArroCo[ArroCo.Count/2][ArroCo[0].Count/2], new EventArgs());           
            }
            else
            {
                Button Shouldchess = SearchForChess();
                Point x = GetChessPoint(Shouldchess);
                Btn_Click(Shouldchess, new EventArgs());
            }

        }

        private Button SearchForChess()
        {
            Button Chess = new Button();
            long Temp = 0;
            long DiemTC = 0;
            long DiemPT = 0;
            long DiemMAX = 0;
            for (int i = 0; i < ArroCo.Count; i++)
            {
                for (int j = 0; j < ArroCo[i].Count; j++)
                {
                    if (ArroCo[i][j].BackgroundImage == null)
                    {
                        DiemTC = DiemTCDoc(i, j) + DiemTCNgang(i, j) + DiemTCCheoChinh(i, j) + DiemTCCheoPhu(i, j);
                        DiemPT = DiemPTDoc(i, j) + DiemPTNgang(i, j) + DiemPTCheoChinh(i, j) + DiemPTCheoPhu(i, j);
                        Temp = DiemTC > DiemPT ? DiemTC : DiemPT;
                        if (Temp > DiemMAX)
                        {
                            Chess = ArroCo[i][j];
                            DiemMAX = Temp;
                        }
                    }
                }
            }
            return Chess;
        }

        private long DiemTCCheoPhu(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            // 
            for (int count = 1; count < 6 && c + count < ArroCo[0].Count && r - count >=0; count++)
            {
                if (ArroCo[r - count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r - count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            /////
            for (int count = 1; (count < 6) && ((c - count) >= 0) && ((r + count) < ArroCo.Count); count++)
            {
                if (ArroCo[r + count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r + count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            Sum -= arrDefendPoint[enemy + 1];
            Sum += arrAttackPoint[teammate];

            return Sum;
        }

        private long DiemTCCheoChinh(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && c + count < ArroCo[0].Count && r + count < ArroCo.Count; count++)
            {
                if (ArroCo[r + count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r + count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            /////
            for (int count = 1; (count < 6) && ((c - count) >= 0) && ((r - count) >= 0); count++)
            {
                if (ArroCo[r - count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r - count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            Sum -= arrDefendPoint[enemy + 1];
            Sum += arrAttackPoint[teammate];

            return Sum;
        }

        private long DiemTCNgang(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && c + count < ArroCo[0].Count; count++)
            {
                if (ArroCo[r][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r][c + count].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            /////
            for (int count = 1; count < 6 && c - count >= 0; count++)
            {
                if (ArroCo[r][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r][c - count].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            Sum -= arrDefendPoint[enemy + 1];
            Sum += arrAttackPoint[teammate];

            return Sum;

        }

        private long DiemTCDoc(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && r + count < ArroCo.Count; count++)
            {
                if (ArroCo[r + count][c].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r + count][c].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            /////
            for (int count = 1; count < 6 && r - count >= 0; count++)
            {
                if (ArroCo[r - count][c].BackgroundImage == NguoiChoi1.HinhDaiDien)
                    teammate++;
                else if (ArroCo[r- count][c].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                    break;
                }
                else
                    break;
            }
            Sum -= arrDefendPoint[enemy + 1];
            Sum += arrAttackPoint[teammate];

            return Sum;
        }

        private long DiemPTCheoPhu(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && c + count < ArroCo[0].Count && r - count >= 0; count++)
            {
                if (ArroCo[r - count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r - count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            /////
            for (int count = 1; (count < 6) && ((c - count) >= 0) && ((r + count) < ArroCo.Count); count++)
            {
                if (ArroCo[r + count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r + count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            Sum += arrDefendPoint[enemy + 2];

            return Sum;
        }

        private long DiemPTCheoChinh(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && c + count < ArroCo[0].Count && r + count < ArroCo.Count; count++)
            {
                if (ArroCo[r + count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r + count][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            /////
            for (int count = 1; (count < 6) && ((c - count) >= 0) && ((r - count) >= 0); count++)
            {
                if (ArroCo[r - count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r - count][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            Sum += arrDefendPoint[enemy + 2];

            return Sum;
        }

        private long DiemPTNgang(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && c + count < ArroCo[0].Count; count++)
            {
                if (ArroCo[r][c + count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r][c + count].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            /////
            for (int count = 1; count < 6 && c - count >= 0; count++)
            {
                if (ArroCo[r][c - count].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r][c - count].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            Sum += arrDefendPoint[enemy + 2];
            return Sum;

        }

        private long DiemPTDoc(int r, int c)
        {
            long Sum = 0;
            int enemy = 0;
            int teammate = 0;
            for (int count = 1; count < 6 && r + count < ArroCo.Count; count++)
            {
                if (ArroCo[r + count][c].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }
                else if (ArroCo[r + count][c].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            /////
            for (int count = 1; count < 6 && r - count >= 0; count++)
            {
                if (ArroCo[r - count][c].BackgroundImage == NguoiChoi1.HinhDaiDien)
                {
                    teammate++;
                    break;
                }

                else if (ArroCo[r - count][c].BackgroundImage == NguoiChoi2.HinhDaiDien)
                {
                    enemy++;
                }
                else
                    break;
            }
            Sum += arrDefendPoint[enemy + 2];
            return Sum;
        }

        #endregion
    }
    public class ButtonClickEvent : EventArgs
    {
        public Point ClickedPoint { get; set; }

        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }

   
}
