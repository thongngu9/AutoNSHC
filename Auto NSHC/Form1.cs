using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Auto_NSHC
{
    public partial class Form1 : Form
    {
        Bitmap img00a, img00b;
        Bitmap imgnv00a, imgnv00b, imgnv00c, imgnv00d;
        Bitmap imgls00, imgls02, imgls04, imgls05, imgls06, imgls07, imgls08, imgls09, imgls10, imgls12, imgls13, imgls14;
        Bitmap imgnv01a, imgnv01b, imgnv01c, imgnv01d;
        Bitmap imgnv02a;
        Bitmap imgnv03a;
        Bitmap imgnv04a, imgnv04b, imgnv04c;
        Bitmap imgnv04b00a, imgnv04b00b, imgnv04b01, imgnv04b02, imgnv04b03;
        Bitmap imgnv04d01, imgnv04d02, imgnv04d03, imgnv04d04, imgnv04d05, imgnv04d06, imgnv04d07, imgnv04d08, imgnv04d09;
        Bitmap imgnv05a, imgnv05b, imgnv05c;
        Bitmap imgnv05d01, imgnv05d02, imgnv05e01, imgnv05e02, imgnv05e03, imgnv05e04, imgnv05e05, imgnv05e06, imgnv05e07, imgnv05e08;
        Bitmap imgnv06a, imgnv06b, imgnv06c;
        Bitmap imgnv06b01, imgnv06d01;
        Bitmap imgnv07a, imgnv07b, imgnv07c;
        Bitmap imgnv09a, imgnv09b, imgnv09c;
        Bitmap imgnv10a, imgnv10b, imgnv10c;
        Bitmap imgnv12a, imgnv12b, imgnv12c;
        Bitmap imgnv13a, imgnv13b, imgnv13c;
        Bitmap imgnv14a, imgnv14b, imgnv14c, imgnv14d;
        Bitmap imgnv15a01, imgnv15a02, imgnv15a03, imgnv15b, imgnv15c01, imgnv15c02, imgnv15c03;
        Bitmap imgnv15a04, imgnv15a05a, imgnv15a05b, imgnv15a06a, imgnv15a06b, imgnv15a07a, imgnv15a07b, imgnv15a07c, imgnv15a08a, imgnv15a08b, imgnv15a09a, imgnv15a09b;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            // Login
            img00a = (Bitmap)Bitmap.FromFile("images//img00a.png");
            img00b = (Bitmap)Bitmap.FromFile("images//img00b.png");

            imgnv00a = (Bitmap)Bitmap.FromFile("images//imgnv00a.png");
            imgnv00b = (Bitmap)Bitmap.FromFile("images//imgnv00b.png");

            // Danh sách
            imgnv00d = (Bitmap)Bitmap.FromFile("images//imgnv00d.png");

            imgls00 = (Bitmap)Bitmap.FromFile("images//imgls00.png");
            imgls02 = (Bitmap)Bitmap.FromFile("images//imgls02.png");
            imgls04 = (Bitmap)Bitmap.FromFile("images//imgls04.png");
            imgls05 = (Bitmap)Bitmap.FromFile("images//imgls05.png");
            imgls06 = (Bitmap)Bitmap.FromFile("images//imgls06.jpg");
            imgls07 = (Bitmap)Bitmap.FromFile("images//imgls07.png");
            imgls08 = (Bitmap)Bitmap.FromFile("images//imgls08.png");
            imgls09 = (Bitmap)Bitmap.FromFile("images//imgls09.png");
            imgls10 = (Bitmap)Bitmap.FromFile("images//imgls10.png");

            imgls12 = (Bitmap)Bitmap.FromFile("images//imgls12.png");
            imgls13 = (Bitmap)Bitmap.FromFile("images//imgls13.png");
            imgls14 = (Bitmap)Bitmap.FromFile("images//imgls14.png");

            // 01 - Thiên nhân
            imgnv01a = (Bitmap)Bitmap.FromFile("images//imgnv01a.png");
            imgnv01b = (Bitmap)Bitmap.FromFile("images//imgnv01b.png");
            imgnv01c = (Bitmap)Bitmap.FromFile("images//imgnv01c.png");
            imgnv01d = (Bitmap)Bitmap.FromFile("images//imgnv01d.png");
            // 02 - Kỳ ngộ
            imgnv02a = (Bitmap)Bitmap.FromFile("images//imgnv02a.png");
            // 03 - Điểm danh
            imgnv03a = (Bitmap)Bitmap.FromFile("images//imgnv03a.png");
            // 04 - Truyện kỳ Thời Trang
            imgnv04a = (Bitmap)Bitmap.FromFile("images//imgnv04a.png");
            imgnv04b = (Bitmap)Bitmap.FromFile("images//imgnv04b.png");
            imgnv04c = (Bitmap)Bitmap.FromFile("images//imgnv04c.png");
            // Chọn cuốn ải
            imgnv04b00a = (Bitmap)Bitmap.FromFile("images//imgnv04b00a.png");
            imgnv04b00b = (Bitmap)Bitmap.FromFile("images//imgnv04b00b.png");
            imgnv04b01 = (Bitmap)Bitmap.FromFile("images//imgnv04b01.png");
            imgnv04b02 = (Bitmap)Bitmap.FromFile("images//imgnv04b02.png");
            imgnv04b03 = (Bitmap)Bitmap.FromFile("images//imgnv04b03.png");
            // Thái Văn Cơ
            imgnv04d01 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d01.png");
            imgnv04d02 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d02.png");
            imgnv04d03 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d03.png");
            imgnv04d04 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d04.png");
            imgnv04d05 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d05.png");
            imgnv04d06 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d06.png");
            imgnv04d07 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d07.png");
            imgnv04d08 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d08.png");
            imgnv04d09 = (Bitmap)Bitmap.FromFile("images//ThaiVanCo//imgnv04d09.png");
            // 05 - Boss bang
            imgnv05a = (Bitmap)Bitmap.FromFile("images//imgnv05a.png");
            imgnv05b = (Bitmap)Bitmap.FromFile("images//imgnv05b.png");
            imgnv05c = (Bitmap)Bitmap.FromFile("images//imgnv05c.png");
            imgnv05d01 = (Bitmap)Bitmap.FromFile("images//imgnv05d01.png");
            imgnv05d02 = (Bitmap)Bitmap.FromFile("images//imgnv05d02.png");
            imgnv05e01 = (Bitmap)Bitmap.FromFile("images//imgnv05e01.png");
            imgnv05e02 = (Bitmap)Bitmap.FromFile("images//imgnv05e02.png");
            imgnv05e03 = (Bitmap)Bitmap.FromFile("images//imgnv05e03.png");
            imgnv05e04 = (Bitmap)Bitmap.FromFile("images//imgnv05e04.png");
            imgnv05e05 = (Bitmap)Bitmap.FromFile("images//imgnv05e05.png");
            imgnv05e06 = (Bitmap)Bitmap.FromFile("images//imgnv05e06.png");
            imgnv05e07 = (Bitmap)Bitmap.FromFile("images//imgnv05e07.png");
            imgnv05e08 = (Bitmap)Bitmap.FromFile("images//imgnv05e08.png");
            // 06 - Đấu trường
            imgnv06a = (Bitmap)Bitmap.FromFile("images//imgnv06a.png");
            imgnv06b = (Bitmap)Bitmap.FromFile("images//imgnv06b.png");
            imgnv06c = (Bitmap)Bitmap.FromFile("images//imgnv06c.png");
            // Solo
            imgnv06b01 = (Bitmap)Bitmap.FromFile("images//imgnv06b01.png");
            imgnv06d01 = (Bitmap)Bitmap.FromFile("images//imgnv06d01.png");
            // 07 - Bộ bộ tâm kinh
            imgnv07a = (Bitmap)Bitmap.FromFile("images//imgnv07a.png");
            imgnv07b = (Bitmap)Bitmap.FromFile("images//imgnv07b.png");
            imgnv07c = (Bitmap)Bitmap.FromFile("images//imgnv07c.png");
            // 08 - Nên mua
            // 09 - Tặng hoa
            imgnv09a = (Bitmap)Bitmap.FromFile("images//imgnv09a.png");
            imgnv09b = (Bitmap)Bitmap.FromFile("images//imgnv09b.png");
            imgnv09c = (Bitmap)Bitmap.FromFile("images//imgnv09c.png");
            // 10 - Tăng tài nghệ
            imgnv10a = (Bitmap)Bitmap.FromFile("images//imgnv10a.png");
            imgnv10b = (Bitmap)Bitmap.FromFile("images//imgnv10b.png");
            imgnv10c = (Bitmap)Bitmap.FromFile("images//imgnv10c.png");
            // 11 - Pháp trận
            // 12 - Đơn dược
            imgnv12a = (Bitmap)Bitmap.FromFile("images//imgnv12a.png");
            imgnv12b = (Bitmap)Bitmap.FromFile("images//imgnv12b.png");
            imgnv12c = (Bitmap)Bitmap.FromFile("images//imgnv12c.png");
            // 13 - Cường hóa
            imgnv13a = (Bitmap)Bitmap.FromFile("images//imgnv13a.png");
            imgnv13b = (Bitmap)Bitmap.FromFile("images//imgnv13b.png");
            imgnv13c = (Bitmap)Bitmap.FromFile("images//imgnv13c.png");
            // 14 - Triều bái
            imgnv14b = (Bitmap)Bitmap.FromFile("images//imgnv14b.png");
            imgnv14c = (Bitmap)Bitmap.FromFile("images//imgnv14c.png");
            imgnv14d = (Bitmap)Bitmap.FromFile("images//imgnv14d.png");
            // 15 - Thăm
            imgnv15a01 = (Bitmap)Bitmap.FromFile("images//imgnv15a01.png");
            imgnv15a02 = (Bitmap)Bitmap.FromFile("images//imgnv15a02.png");
            imgnv15a03 = (Bitmap)Bitmap.FromFile("images//imgnv15a03.png");
            imgnv15b = (Bitmap)Bitmap.FromFile("images//imgnv15b.png");
            imgnv15c01 = (Bitmap)Bitmap.FromFile("images//imgnv15c01.png");
            imgnv15c02 = (Bitmap)Bitmap.FromFile("images//imgnv15c02.png");
            imgnv15c03 = (Bitmap)Bitmap.FromFile("images//imgnv15c03.png");
            // 15 - Trồng cây
            imgnv15a04 = (Bitmap)Bitmap.FromFile("images//imgnv15a04.png");
            imgnv15a05a = (Bitmap)Bitmap.FromFile("images//imgnv15a05a.png");
            imgnv15a05b = (Bitmap)Bitmap.FromFile("images//imgnv15a05b.png");
            imgnv15a06a = (Bitmap)Bitmap.FromFile("images//imgnv15a06a.png");
            imgnv15a06b = (Bitmap)Bitmap.FromFile("images//imgnv15a06b.png");
            imgnv15a07a = (Bitmap)Bitmap.FromFile("images//imgnv15a07a.png");
            imgnv15a07b = (Bitmap)Bitmap.FromFile("images//imgnv15a07b.png");
            imgnv15a07c = (Bitmap)Bitmap.FromFile("images//imgnv15a07c.png");
            imgnv15a08a = (Bitmap)Bitmap.FromFile("images//imgnv15a08a.png");
            imgnv15a08b = (Bitmap)Bitmap.FromFile("images//imgnv15a08b.png");
            imgnv15a09a = (Bitmap)Bitmap.FromFile("images//imgnv15a09a.png");
            imgnv15a09b = (Bitmap)Bitmap.FromFile("images//imgnv15a09b.png");
            // 16 - Nấu ăn

        }

        bool isStop = false;

        void Auto()
        {
            List<string> devices = new List<string>();
            var listDevice = KAutoHelper.ADBHelper.GetDevices();
            if (listDevice != null && listDevice.Count > 0)
            {
                devices = listDevice;
            }

            foreach (var deviceID in devices)
            {
                Task t = new Task(() =>
                {
                    while (true)
                    {
                        // Đăng nhập
                        //Login(deviceID);

                        //GoList(deviceID);

                        //GoTrongCay(deviceID);

                        int nv01 = 0, nv02 = 0, nv03 = 0, nv04 = 0, nv05 = 0, nv06 = 0, nv07 = 0, nv09 = 0, nv10 = 0, nv12 = 0, nv13 = 0, nv14 = 0, nv15 = 0;
                        //int nv01 = 1, nv02 = 1, nv03 = 1, nv04 = 1, nv05 = 1, nv06 = 0, nv07 = 1, nv09 = 1, nv10 = 1, nv12 = 1, nv13 = 1, nv14 = 1, nv15 = 1;
                        // Thiên Nhân
                        if (nv01 == 0)
                            GoThienNhan(deviceID, 5, 1);

                        // Kỳ ngộ
                        if (nv02 == 0)
                            GoKyNgo(deviceID);

                        // Điểm danh
                        if (nv03 == 0)
                            GoDiemDanh(deviceID);

                        // Truyện kỳ Thời Trang
                        if (nv04 == 0)
                            GoTKTT(deviceID, 2);

                        // Boss bang
                        if (nv05 == 0)
                            GoBossBang(deviceID, 5);

                        // Đấu trường
                        if (nv06 == 0)
                            GoDauTruong(deviceID, 5, 5);

                        // Bộ bộ tâm kinh
                        if (nv07 == 0)
                            GoBBTK(deviceID);

                        // Tặng hoa
                        if (nv09 == 0)
                            GoTangHoa(deviceID);

                        // Tài nghệ
                        if (nv10 == 0)
                            GoTaiNghe(deviceID);

                        // Đơn dược
                        if (nv12 == 0)
                            GoDonDuoc(deviceID);

                        // Cường hóa
                        if (nv13 == 0)
                            GoCuongHoa(deviceID);

                        // Triều bái
                        if (nv14 == 0)
                            GoTrieuBai(deviceID);

                        // Thăm
                        if (nv15 == 0)
                            GoTham(deviceID);
                        //GoTrongCay(deviceID);

                        //isStop = true;


                        // Thoát ứng dụng
                        //Exit(deviceID);


                        Delay(3600);


                        //// Nhập địa chỉ
                        //if (isStop)
                        //    return;
                        //KAutoHelper.ADBHelper.InputText(deviceID, "http://thongdang.herokuapp.com");
                        //Delay(1);

                        //// Nhấn Enter
                        //if (isStop)
                        //    return;
                        //KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_ENTER);
                        //Delay(25);

                        //// Kéo xuống
                        //Random rnd = new Random();
                        //int timesDown = rnd.Next(8, 12);
                        //for (int i = 1; i < timesDown; i++)
                        //{
                        //    // Kéo 50% trang
                        //    if (isStop)
                        //        return;
                        //    KAutoHelper.ADBHelper.Swipe(deviceID, 620, 1133, 748, 811);
                        //    Delay(2);
                        //}

                        //// Kéo lên
                        //for (int j = 1; j < timesDown; j++)
                        //{
                        //    // Kéo 100% trang
                        //    if (isStop)
                        //        return;
                        //    KAutoHelper.ADBHelper.Swipe(deviceID, 748, 811, 620, 1133);
                        //    Delay(2);
                        //}
                    }
                });
                t.Start();
            }
        }

        //------------------------------------------------------------------------------
        // Hỗ trợ nhiệm vụ
        //------------------------------------------------------------------------------
        // Kiểm tra ảnh - không lấy tọa độ
        bool CheckPoint(string deviceID, Bitmap image)
        {
            try
            {
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, image);
                if (point != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Kiểm tra ảnh - lấy tọa độ
        public struct Coordinates
        {
            public readonly int x;
            public readonly int y;

            public Coordinates(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }

        public Coordinates Location(string deviceID, Bitmap image)
        {
            try
            {
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var point = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, image);
                return (point != null) ? new Coordinates(point.Value.X, point.Value.Y) : new Coordinates(-1, -1);
            }
            catch (Exception)
            {
                return new Coordinates(-1, -1);
            }
        }

        //------------------------------------------------------------------------------
        // Các nhóm
        //------------------------------------------------------------------------------
        // Đăng nhập
        //------------------------------------------------------------------------------
        void Login(string deviceID)
        {
            // Click vào game
            if (TapAndCheck(deviceID, 176, 140, img00a, 120) == true) goto Step02;
            else Exit(deviceID);

            // Click đồng ý
            Step02: if (isStop) return;
            if (TapAndCheck(deviceID, 290, 288, img00b, 120) == true) goto Step03;
            else Exit(deviceID);

            // Click chơi ngay
            Step03: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 85);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv00a) == true || CheckPoint(deviceID, imgnv00b) == true) break;
                    else Delay(1);
                }
            }
            goto Step04;

        // Nếu nền tối thì kiểm tra và thoát quảng cáo đến khi nền sáng ->
        Step04: for (int i = 1; i <= 120; i++)
            {
                if (CheckPoint(deviceID, img00b) == true)
                {
                    if (isStop)
                        return;
                    KAutoHelper.ADBHelper.Tap(deviceID, 35, 264);
                    goto Finish;
                }
                else if (CheckPoint(deviceID, imgnv00a) == true)
                {
                    goto Finish;
                }
            }
            Exit(deviceID);

        // Xong
        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 00 - Nhiệm vụ mỗi ngày
        //------------------------------------------------------------------------------
        void GoList(string deviceID)
        {
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

            // Bấm vào nhiệm vụ mỗi ngày
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 4, 40, imgnv00d, 120) == true) MessageBox.Show("Ok");
            else Exit(deviceID);


            int fnv00 = 0, fnv02 = 0, fnv04 = 0, fnv05 = 0, fnv06 = 0, fnv07 = 0, fnv08 = 0, fnv09 = 0, fnv10 = 0, fnv12 = 0, fnv13 = 0;
            if (fnv00 == 0 || fnv02 == 0 || fnv04 == 0 | fnv05 == 0 || fnv06 == 0 || fnv07 == 0 || fnv08 == 0 || fnv09 == 0 || fnv10 == 0 || fnv12 == 0 || fnv13 == 0)
            {
                for (int i = 1; i <= 13; i++)
                {
                    // Kiểm tra nhiệm vụ Facebook
                    if (CheckPoint(deviceID, imgls00) == true) MessageBox.Show("Facebook");

                    // Kiểm tra nhiệm vụ Kỳ Ngộ
                    if (CheckPoint(deviceID, imgls02) == true) MessageBox.Show("Kỳ ngộ");

                    // Kiểm tra nhiệm vụ Thời Trang
                    if (CheckPoint(deviceID, imgls04) == true) MessageBox.Show("Thời trang");

                    // Kiểm tra nhiệm vụ Boss Bang
                    if (CheckPoint(deviceID, imgls05) == true) MessageBox.Show("Boss bang");
                    //KAutoHelper.ADBHelper.Tap(deviceID, 510, GetPoint(deviceID, nvBossBang, "Y"));

                    // Kiểm tra nhiệm vụ Đấu Trường
                    if (CheckPoint(deviceID, imgls06) == true) MessageBox.Show("Đấu trường");

                    // Kiểm tra nhiệm vụ Bộ Bộ Kinh Tâm
                    if (CheckPoint(deviceID, imgls07) == true) MessageBox.Show("Bộ Bộ Kinh Tâm");

                    // Kiểm tra nhiệm vụ Nên Mua
                    if (CheckPoint(deviceID, imgls08) == true) MessageBox.Show("Nên mua");

                    // Kiểm tra nhiệm vụ Tặng Hoa
                    if (CheckPoint(deviceID, imgls09) == true) MessageBox.Show("Tặng hoa");

                    // Kiểm tra nhiệm vụ Tài Nghệ
                    if (CheckPoint(deviceID, imgls10) == true) MessageBox.Show("Tài nghệ");

                    // Kiểm tra nhiệm vụ Đơn Dược
                    if (CheckPoint(deviceID, imgls12) == true) MessageBox.Show("Đơn dược");

                    // Kiểm tra nhiệm vụ Cường Hóa
                    if (CheckPoint(deviceID, imgls13) == true) MessageBox.Show("Cường hóa");

                    // Kéo xuống tìm nhiệm vụ
                    if (isStop) return;
                    KAutoHelper.ADBHelper.Swipe(deviceID, 430, 160, 430, 90);
                    Delay(1);
                }
            }
        }
        //------------------------------------------------------------------------------
        // 01 - Thiên nhân
        //------------------------------------------------------------------------------
        void GoThienNhan(string deviceID, int count1, int count2)
        {

            // *Chú thích*: a = thiên nhân xanh, b = thiên nhân tím 
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

        // Vào thiên nhân
        Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 30, 75, imgnv01a, 120) == true) goto Step02;
            else Exit(deviceID);

        // Chọn thiên nhân xanh
        Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 18, 40, imgnv01c, 120) == true) goto Step03;
            else Exit(deviceID);

        // Kiểm tra share
        Step03: if (isStop) return;
            if (CheckPoint(deviceID, imgnv01b) == true) goto Step04;
            else goto Step06;

        // Có share
        Step04: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 51, 87, imgnv01d, 120) == true) goto Step05;
            else Exit(deviceID);

        // Quay về nút tiếp
        Step05: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 25, 11, imgnv01c, 120) == true) goto Step06;
            else Exit(deviceID);

        // Không share
        Step06: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 70, 90, imgnv01a, 120) == true) goto backMain;
            else Exit(deviceID);

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;

        }
        //------------------------------------------------------------------------------
        // 02 - Kỳ ngộ
        //------------------------------------------------------------------------------
        void GoKyNgo(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

        // Vào kỳ ngộ
        Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 90, 70, imgnv02a, 120) == true) goto Step02;
            else Exit(deviceID);

        // Vào Thái Hòa Điện
        Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 40, 40, imgnv04b03, 120) == true) goto Step03;
            else Exit(deviceID);

        // Đồng ý
        Step03: if (isStop) return;
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 59, 69);
            Delay(1);
            goto backMain;

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;

        }
        //------------------------------------------------------------------------------
        // 03 - Điểm danh
        //------------------------------------------------------------------------------
        void GoDiemDanh(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step02;
            else return;

        // Vào điểm danh
        Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 96, 63, imgnv03a, 120) == true) goto Step03;
            else Exit(deviceID);

        // Điểm danh
        Step03: if (isStop) return;
            DateTime date = DateTime.Now;
            int col = (((date.Day % 5 == 0) ? 5 : date.Day % 5) * 10) + 26;
            KAutoHelper.ADBHelper.TapByPercent(deviceID, col, 30);
            Delay(1);
            goto backMain;

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;

        }
        //------------------------------------------------------------------------------
        // 04 - Truyền kỳ thời trang
        //------------------------------------------------------------------------------
        // Vào truyện kỳ thời trang
        void GoTKTT(string deviceID, int count)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step02;
            else return;

            // Vào truyện kỳ
            Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 80, 50, imgnv04a, 120) == true) goto Step03;
            else Exit(deviceID);

            // Vào thời trang
            Step03: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 75, 75, imgnv04b, 120) == true) goto Step04;
            else Exit(deviceID);

            // Tìm và chọn cuốn Thái Văn Cơ
            Step04: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv04b00a) == true || CheckPoint(deviceID, imgnv04b00b) == true) break;
                    else
                    {
                        // Kéo trái sang phải
                        if (isStop) return;
                        KAutoHelper.ADBHelper.SwipeByPercent(deviceID, 41, 35, 75, 35);
                        Delay(1);
                    }
                }
            }
            // Chọn cuốn Thái Văn Cơ
            if (isStop) return;
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 41, 35);
            // Kiểm tra trạng thái cuốn ải
            goto Step05;

        // Kiểm tra trạng thái cuốn ải
        Step05: int val01 = 0, val02 = 0;
            if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv04b01) == true)
                    {
                        val01++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv04b02) == true)
                    {
                        val02++;
                        break;
                    }
                }
            }
            if (val01 > 0) goto Step07;
            else if (val02 > 0) goto Step06;

        // Tạo lại
        Step06: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    // Bấm tạo lại
                    if (isStop) return;
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 42, 55);
                    Delay(1);
                    // Đồng ý
                    if (CheckPoint(deviceID, imgnv04b03) == true) break;
                    else Delay(1);
                }
            }
            if (isStop) return;
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 59, 69);
            goto Step07;

        // Vào ải
        Step07: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    // Vào ải
                    if (isStop) return;
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 60, 55);
                    Delay(1);
                    // Nếu vào được ải là thành công
                    if (CheckPoint(deviceID, imgnv04c) == true) break;
                    else Delay(1);
                }   
            }
            goto Level01;

        // Ải 1
        Level01: if (isStop) return;
            CangQuetTKTT(deviceID, 21, 75, imgnv04d01);
            goto Level02;
        // Ải 2
        Level02: if (isStop) return;
            CangQuetTKTT(deviceID, 28, 55, imgnv04d02);
            goto Level03;
        // Ải 3
        Level03: if (isStop) return;
            CangQuetTKTT(deviceID, 45, 40, imgnv04d03);
            goto Level04;
        // Ải 4
        Level04: if (isStop) return;
            CangQuetTKTT(deviceID, 61, 65, imgnv04d04);
            goto Level05;
        // Ải 5
        Level05: if (isStop) return;
            CangQuetTKTT(deviceID, 78, 55, imgnv04d05);
            goto Level06;
        // Ải 6
        Level06: if (isStop) return;
            CangQuetTKTT(deviceID, 70, 45, imgnv04d06);
            goto Level07;
        // Ải 7
        Level07: if (isStop) return;
            CangQuetTKTT(deviceID, 68, 35, imgnv04d07);
            goto Level08;
        // Ải 8
        Level08: if (isStop) return;
            CangQuetTKTT(deviceID, 82, 35, imgnv04d08);
            goto Level09;
        // Ải 9
        Level09: if (isStop) return;
            CangQuetTKTT(deviceID, 76, 75, imgnv04d09);
            goto Back;

        // Thoát ải
        Back: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 98, 5, imgnv04b, 120) == true) goto Step08;
            else Exit(deviceID);

        // Thoát đến chọn thời trang
        Step08: if (isStop) return;
            count--;
            if (count == 0) goto backMain;
            else
            {
                if (TapByPercentAndCheck(deviceID, 98, 5, imgnv04a, 120) == true) goto Step03;
                else Exit(deviceID);
            }

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;

        }

        // Càng quét truyện kỳ thời trang
        void CangQuetTKTT(string deviceID, int x, int y, Bitmap img)
        {
            // Click vào ải
            if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, x, y);
                    Delay(1);
                    // Nếu đến bước 2 thì bước 1 thành công
                    if (CheckPoint(deviceID, img) == true) break;
                    else Delay(1);
                }
            }
            goto Step02;

        // Quá trình càng quét
        Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    // Kiểm tra càng quét
                    var p04d = Location(deviceID, img);
                    if (p04d.x > -1)
                    {
                        // Click càng quét
                        KAutoHelper.ADBHelper.Tap(deviceID, p04d.x - 48, p04d.y + 5);
                        break;
                    }
                    else Delay(1);
                }
            }
            goto Step03;

        // Click Đồng Ý
        Step03: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv04b03) == true) break;
                    else Delay(1);
                }
            }
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 82);
            goto Finish;

        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 05 - Boss bang
        //------------------------------------------------------------------------------
        void GoBossBang(string deviceID, int count)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

        // Vào bang
        Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 75, 86, imgnv05a, 120) == true) goto Step02;
            else Exit(deviceID);

        // Vào boss bang
        Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 65, 30, imgnv05b, 120) == true) goto Step03;
            else Exit(deviceID);

        // Chọn boss bang
        // Vị trí 1 - 60%
        Step03: if (isStop) return;
            if (count == 0) return;
            int value1 = 0, value2 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 60, 60);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05d01) == true || CheckPoint(deviceID, imgnv05d02) == true)
                    {
                        value1++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv05c) == true)
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 90, 20);
                        Delay(1);
                        value2++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (value1 > value2) goto Step07;
            else goto Step04;

        // Vị trí 2 - 90%
        Step04: if (isStop) return;
            value1 = 0; value2 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 90, 60);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05d01) == true || CheckPoint(deviceID, imgnv05d02) == true)
                    {
                        value1++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv05c) == true)
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 90, 20);
                        Delay(1);
                        value2++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (value1 > value2) goto Step07;
            else goto Step05;

        // Vị trí 3 - 10%
        Step05: if (isStop) return;
            value1 = 0; value2 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 10, 60);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05d01) == true || CheckPoint(deviceID, imgnv05d02) == true)
                    {
                        value1++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv05c) == true)
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 90, 20);
                        Delay(1);
                        value2++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (value1 > value2) goto Step07;
            else goto Step06;

        // Vị trí 4 - 30%
        Step06: if (isStop) return;
            value1 = 0; value2 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 30, 60);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05d01) == true || CheckPoint(deviceID, imgnv05d02) == true)
                    {
                        value1++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv05c) == true)
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 90, 20);
                        Delay(1);
                        value2++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (value1 > value2) goto Step07;
            else goto backMain;

        // Nhấn chiến đấu
        Step07: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 70);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05e01) == true || CheckPoint(deviceID, imgnv05e03) == true) break;
                    else Delay(1);
                }
            }
            goto Step08;

        // Nhấn kết thúc
        Step08: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (count == 5 && (CheckPoint(deviceID, imgnv05e05) == true || CheckPoint(deviceID, imgnv05e07) == true)) KAutoHelper.ADBHelper.TapByPercent(deviceID, 96, 93);
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 4, 93);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05e02) == true || CheckPoint(deviceID, imgnv05e04) == true) break;
                    else Delay(1);
                }
            }
            goto Step09;

        // Nhấn để tiếp tục
        Step09: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 83);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05d01) == true || CheckPoint(deviceID, imgnv05d02) == true || CheckPoint(deviceID, imgnv05b) == true) break;
                    else Delay(1);
                }
            }
            goto Step10;

        // Lặp lại
        Step10: if (isStop) return;
            count--;
            if (count == 0) goto backMain;
            else
            {
                int val01 = 0, val02 = 0;
                for (int i = 1; i <= 120; i++)
                {
                    if (i == 120) Exit(deviceID);
                    else
                    {
                        if (CheckPoint(deviceID, imgnv05d01) == true || CheckPoint(deviceID, imgnv05d02) == true)
                        {
                            val01++;
                            break;
                        }
                        else if (CheckPoint(deviceID, imgnv05b) == true)
                        {
                            val02++;
                            break;
                        }
                        else Delay(1);
                    }
                }
                if (val01 > val02) goto Step07;
                else goto Step03;
            }

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 06 - Đấu trường
        //------------------------------------------------------------------------------
        // Vào đấu trường
        void GoDauTruong(string deviceID, int count1, int count2)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step02;
            else return;

            // Vào đấu trường
            Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 11, 50, imgnv06a, 120) == true) goto Step03;
            else Exit(deviceID);

            // Đấu trường phu thê
            Step03: if (isStop) return;
            ChonDauTruong(deviceID, 74, 40, count2);
            goto Step04;

        // Đấu trường cá nhân
        Step04: if (isStop) return;
            ChonDauTruong(deviceID, 49, 40, count1);
            goto backMain;

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;

        }

        // Chọn loại đấu trường
        void ChonDauTruong(string deviceID, int x, int y, int count)
        {
            if (isStop) return;
            if (count == 0) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, x, y);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv06b) == true || CheckPoint(deviceID, imgnv06c) == true) break;
                    else Delay(1);
                }
            }
            goto Step02;

        // Vào solo
        Step02: if (isStop) return;
            SoloDauTruong(deviceID, count);
            goto Finish;

        // Xong
        Finish: return;
        }

        // Chọn đối thủ đấu trường
        void SoloDauTruong(string deviceID, int count)
        {
            if (count == 0) goto Finish;
            else goto Step00;
            //*Chú thích* Người 1 là 23%, người 2 là 50%, người 3 là 77%
            // Kiểm tra đối thoại
            Step00: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 77, 50);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv06c) == true) break;
                    else Delay(1);
                }
            }
            goto Step01;

        // Chọn người solo
        Step01: if (isStop) return;
            for (int i = 0; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 77, 50);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv06b01) == true) break;
                    else Delay(1);
                }
            }
            // Bấm nút chiến
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 60, 90);
            Delay(1);
            goto Step02;

        // Chờ xong trận
        Step02: if (isStop) return;
            for (int i = 1; i <= 60; i++)
            {
                if (i == 60) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv06d01) == true) break;
                    else Delay(5);
                }
            }
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 90);
            Delay(1);
            goto Back;

        // Quay ra mục đấu trường
        Back: if (isStop) return;
            count--;
            if (count == 0)
            {
                for (int i = 1; i <= 120; i++)
                {
                    if (i == 120) Exit(deviceID);
                    else
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 98, 5);
                        Delay(1);
                        if (CheckPoint(deviceID, imgnv06a) == true) break;
                        else Delay(1);
                    }
                }
                goto Finish;
            }
            else goto Step00;

            // Xong
            Finish: return;
        }
        //------------------------------------------------------------------------------
        // 07 - Bộ Bộ Tâm Kinh
        //------------------------------------------------------------------------------
        void GoBBTK(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

            // Vào bộ bộ tâm kinh
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 60, 40, imgnv07a, 120) == true) goto Step02;
            else Exit(deviceID);

            // Chọn dễ
            Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 55, 32, imgnv07b, 120) == true) goto Step03;
            else Exit(deviceID);

            // Vào ải 1
            Step03: if (isStop) return;
            if (SoloBBTK(deviceID, 11, 61) == true) goto Step04;
            else goto backMain;

            // Vào ải 2
            Step04: if (isStop) return;
            if (SoloBBTK(deviceID, 29, 31) == true) goto Step05;
            else goto backMain;

        // Vào ải 3
        Step05: if (isStop) return;
            if (SoloBBTK(deviceID, 49, 69) == true) goto Step06;
            else goto backMain;

        // Vào ải 4
        Step06: if (isStop) return;
            if (SoloBBTK(deviceID, 55, 35) == true) goto Step07;
            else goto backMain;

        // Vào ải 5
        Step07: if (isStop) return;
            if (SoloBBTK(deviceID, 82, 41) == true) goto Step08;
            else goto backMain;

        // Vào ải 6
        Step08: if (isStop) return;
            if (SoloBBTK(deviceID, 51, 75) == true) goto Step09;
            else goto backMain;

        // Vào ải 7 ->
        Step09: if (isStop) return;
            if (SoloBBTK(deviceID, 72, 80) == true) goto Step10;
            //SoloBBTK(deviceID, 52, 80);
            else goto backMain;

        // Vào ải 8
        Step10: if (isStop) return;
            if (SoloBBTK(deviceID, 58, 30) == true) goto Step11;
            else goto backMain;

        // Vào ải 9
        Step11: if (isStop) return;
            if (SoloBBTK(deviceID, 79, 35) == true) goto Step12;
            else goto backMain;

        // Vào ải 10
        Step12: if (isStop) return;
            if (SoloBBTK(deviceID, 85, 60) == true) goto backMain;
            else goto backMain;

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }

        bool SoloBBTK(string deviceID, int x, int y)
        {
            // Chọn ải
            int count = 0;

        Step01: if (isStop) return false;
            if (TapByPercentAndCheck(deviceID, x, y, imgnv07c, 120) == true) goto Step02;
            else Exit(deviceID);

            // Vào ải
            Step02: if (isStop) return false;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 60, 78);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv05e01) == true || CheckPoint(deviceID, imgnv05e03) == true) break;
                    else Delay(1);
                }
            }
            goto Step03;

        // Chờ kết thúc
        Step03: if (isStop) return false;
            for (int i = 1; i <= 60; i++)
            {
                if (i == 60) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv05e05) == true || CheckPoint(deviceID, imgnv05e07) == true) KAutoHelper.ADBHelper.TapByPercent(deviceID, 96, 93);
                    if (CheckPoint(deviceID, imgnv04b03) == true || CheckPoint(deviceID, imgnv06d01)) break;
                    else Delay(5);
                }
            }
            goto Step04;

        // Nhấn đồng ý
        Step04: if (isStop) return false;
            int val01 = 0, val02 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (CheckPoint(deviceID, imgnv04b03) == true)
                {
                    val01++;
                    break;
                }
                else if (CheckPoint(deviceID, imgnv06d01) == true)
                {
                    val02++;
                    break;
                }
                else Delay(1);
            }
            if (val01 > val02)
            {
                if (TapByPercentAndCheck(deviceID, 50, 83, imgnv07b, 120) == true) goto Finish;
                else Exit(deviceID);
            }
            else
            {
                if (TapByPercentAndCheck(deviceID, 50, 90, imgnv07b, 120) == true) goto Repeat;
                else Exit(deviceID);
            }

        // Lặp lại
        Repeat: if (isStop) return false;
            count++;
            //if (count < 3) goto Step01;
            //else return false;
            return false;

        // Xong
        Finish: return true;
        }
        //------------------------------------------------------------------------------
        // 09 - Danh sách - Tặng hoa
        //------------------------------------------------------------------------------
        void GoTangHoa(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else if (CheckPoint(deviceID, imgnv00d) == true) goto Step02;
            else return;

            // Vào danh sách nhiệm vụ
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 4, 40, imgnv00d, 120) == true) goto Step02;
            else Exit(deviceID);

            // Vào nhiệm vụ
            Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgls09) == true) break;
                    else
                    {
                        KAutoHelper.ADBHelper.Swipe(deviceID, 430, 160, 430, 90);
                        Delay(1);
                    }
                }
            }
            goto Step03;

        // Bấm vào đi đến
        Step03: if (isStop) return;
            if (TapAndCheck(deviceID, 510, Location(deviceID, imgls09).y, imgnv09a, 120) == true) goto Step04;
            else Exit(deviceID);

        // Bấm Dùng
        Step04: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 37, 47, imgnv09b, 120) == true) goto Step05;
            else Exit(deviceID);

            // Chọn người tặng
            Step05: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 62, 24, imgnv09c, 120) == true) goto Step06;
            else Exit(deviceID);

            // Bấm chọn người
            Step06: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 50, 24, imgnv09b, 120) == true) goto Step07;
            else Exit(deviceID);

            // Tặng
            Step07: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 60, 82, imgnv09a, 120) == true) goto backMain;
            else Exit(deviceID);

            // Thoát đến main
            backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 10 - Danh sách - Tài nghệ
        //------------------------------------------------------------------------------
        void GoTaiNghe(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else if (CheckPoint(deviceID, imgnv00d) == true) goto Step02;
            else return;

            // Vào danh sách nhiệm vụ
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 4, 40, imgnv00d, 120) == true) goto Step02;
            else Exit(deviceID);

            // Vào nhiệm vụ
            Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgls10) == true) break;
                    else
                    {
                        KAutoHelper.ADBHelper.Swipe(deviceID, 430, 160, 430, 90);
                        Delay(1);
                    }
                }
            }
            goto Step03;

        // Bấm vào đi đến
        Step03: if (isStop) return;
            if (TapAndCheck(deviceID, 510, Location(deviceID, imgls10).y, imgnv10a, 120) == true) goto Step04;
            else Exit(deviceID);

        // Chọn Thư Pháp
        Step04: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 80, 30, imgnv10b, 120) == true) goto Step05;
            else Exit(deviceID);

            // Chọn tướng
            Step05: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 80, 50, imgnv10c, 120) == true) goto Step06;
            else Exit(deviceID);

            // Nhấn đồng ý
            Step06: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 76, 85, imgnv10b, 120) == true) goto backMain;
            else Exit(deviceID);

            // Thoát đến main
            backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 12 - Danh sách - Đơn dược
        //------------------------------------------------------------------------------
        void GoDonDuoc(string deviceID)
        {
            if (isStop) return;
            int count = 5;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else if (CheckPoint(deviceID, imgnv00d) == true) goto Step02;
            else return;

            // Vào danh sách nhiệm vụ
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 4, 40, imgnv00d, 120) == true) goto Step02;
            else Exit(deviceID);

            // Vào nhiệm vụ
            Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgls12) == true) break;
                    else
                    {
                        KAutoHelper.ADBHelper.Swipe(deviceID, 430, 160, 430, 90);
                        Delay(1);
                    }
                }
            }
            goto Step03;

        // Bấm vào đi đến
        Step03: if (isStop) return;
            if (TapAndCheck(deviceID, 510, Location(deviceID, imgls12).y, imgnv12a, 120) == true) goto Step04;
            else Exit(deviceID);

            // Bấm Nuôi Dưỡng
            Step04: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 79, 78, imgnv12b, 120) == true) goto Step05;
            else Exit(deviceID);

            // Bấm lưu hoặc hủy
            Step05: if (isStop) return;
            int val01 = 0, val02 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv12c) == true)
                    {
                        val01++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv12b) == true)
                    {
                        val02++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (val01 > val02)
            {
                if (TapByPercentAndCheck(deviceID, 74, 78, imgnv12a, 120) == true) goto Step06;
                else Exit(deviceID);
            }
            else
            {
                if (TapByPercentAndCheck(deviceID, 84, 78, imgnv12a, 120) == true) goto Step06;
                else Exit(deviceID);
            }

        // Lặp lại
        Step06: if (isStop) return;
            count--;
            if (count == 0) goto backMain;
            else goto Step04;

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 13 - Danh sách - Cường hóa
        //------------------------------------------------------------------------------
        void GoCuongHoa(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else if (CheckPoint(deviceID, imgnv00d) == true) goto Step02;
            else return;

            // Vào danh sách nhiệm vụ
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 4, 40, imgnv00d, 120) == true) goto Step02;
            else Exit(deviceID);

            // Vào nhiệm vụ
            Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgls13) == true) break;
                    else
                    {
                        KAutoHelper.ADBHelper.Swipe(deviceID, 430, 160, 430, 90);
                        Delay(1);
                    }
                }
            }
            goto Step03;

        // Bấm vào đi đến
        Step03: if (isStop) return;
            if (TapAndCheck(deviceID, 510, Location(deviceID, imgls13).y, imgnv13a, 120) == true) goto Step04;
            else Exit(deviceID);

        // Chọn ngẫu nhiên nhân vật
        Step04: if (isStop) return;
            int[] mans = { 25, 40, 55, 70 };
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 20, mans[RandomNumber(0, 3)]);
            Delay(1);
            goto Step05;

        // Chọn ngẫu nhiên vật phẩm
        Step05: if (isStop) return;
            int[] item = { 25, 40, 55, 70, 85 };
            int val01 = 0, val02 = 0;
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 40, item[RandomNumber(0, 4)]);
            Delay(1);
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv13a) == true)
                    {
                        val01++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv13b) == true)
                    {
                        val02++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (val01 > val02) goto Step06;
            else goto Step04;

        // Nhấn cường hóa
        Step06: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 79, 88, imgnv13c, 120) == true) goto Step07;
            else Exit(deviceID);

            // Nhấn để tiếp tục
            Step07: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 92);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv13a) == true || CheckPoint(deviceID, imgnv13b) == true) break;
                    else Delay(1);
                }
            }
            goto backMain;

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }
        //------------------------------------------------------------------------------
        // 14 - Danh sách - Triều bái
        //------------------------------------------------------------------------------
        void GoTrieuBai(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else if (CheckPoint(deviceID, imgnv00d) == true) goto Step02;
            else return;

            // Vào danh sách nhiệm vụ
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 4, 40, imgnv00d, 120) == true) goto Step02;
            else Exit(deviceID);

            // Vào nhiệm vụ
            Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgls14) == true) break;
                    else
                    {
                        KAutoHelper.ADBHelper.Swipe(deviceID, 430, 160, 430, 90);
                        Delay(1);
                    }
                }
            }
            goto Step03;

        // Bấm vào đi đến
        Step03: if (isStop) return;
            if (TapAndCheck(deviceID, 510, Location(deviceID, imgls14).y, imgnv14b, 120) == true) goto Step04;
            else Exit(deviceID);

            // Bấm triều bái
            Step04: if (isStop) Exit(deviceID);
            if (TapByPercentAndCheck(deviceID, 50, 74, imgnv14c, 120) == true) goto Step05;
            else Exit(deviceID);

            // Bấm nhận
            Step05: if (isStop) return;
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 70);
            Delay(1);
            goto Step06;

        // Mở quà
        Step06: if (isStop) return;
            int[] num = { 20, 35, 50, 65, 80 };
            if (TapByPercentAndCheck(deviceID, num[RandomNumber(0, 4)], 55, imgnv14d, 120) == true) goto backMain;
            else Delay(1);

        // Thoát đến main
        backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;

        }
        //------------------------------------------------------------------------------
        // 15 - Thăm
        //------------------------------------------------------------------------------
        void GoTham(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

            // Vào dinh thự
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 82, 86, imgnv15a01, 120) == true) goto Step02;
            else Exit(deviceID);

            // Bấm danh sách thăm
            Step02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 64, 87, imgnv15a02, 120) == true) goto Step03;
            else Exit(deviceID);

            // Tìm người thăm hết giờ
            Step03: if (isStop) return;
            var s01 = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            var p01 = KAutoHelper.ImageScanOpenCV.FindOutPoints(s01, imgnv15b);
            if (p01 != null)
            {
                if (p01.Count != 0)
                {
                    Point i01 = p01[0];
                    if (TapAndCheck(deviceID, 371, i01.Y, imgnv15a01, 120) == true) goto Step04;
                    else Exit(deviceID);
                }
                else goto backMain;
            }
            else goto backMain;

            // Vào phòng khách
            Step04: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 72, 25, imgnv15c01, 120) == true) goto Step05;
            else Exit(deviceID);

            // Tìm ghế trống
            Step05: if (isStop) return;
            Delay(3);
            int val01 = 0, val02 = 0;
            var s02 = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            var p02 = KAutoHelper.ImageScanOpenCV.FindOutPoints(s02, imgnv15c02);
            if (p02 != null)
            {
                if (p02.Count() != 0)
                {
                    Point i02 = p02[0];
                    KAutoHelper.ADBHelper.Tap(deviceID, i02.X, i02.Y);
                    Delay(1);
                    for (int i = 1; i <= 120; i++)
                    {
                        if (i == 120) Exit(deviceID);
                        else
                        {
                            if (CheckPoint(deviceID, imgnv15c03) == true)
                            {
                                val01++;
                                break;
                            }
                            else if (CheckPoint(deviceID, imgnv15c01) == true)
                            {
                                val02++;
                                if (val02 == 3) break;
                            }
                            else Delay(1);
                        }
                    }
                    if (val01 > val02)
                    {
                        if (TapByPercentAndCheck(deviceID, 55, 70, imgnv15c01, 120) == true) goto Step05;
                        else Exit(deviceID);
                    }
                    else goto backHome01;
                }
                else goto backMain;
            }
            else goto backMain;

            // Về nhà
            backHome01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 98, 5, imgnv15a01, 120) == true) goto backHome02;
            else Exit(deviceID);

            backHome02: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 96, 86, imgnv15a03, 120) == true) goto Step02;
            else Exit(deviceID);

            // Thoát đến main
            backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

        // Xong
        Finish: return;
        }
        void GoTrongCay(string deviceID)
        {
            if (isStop) return;
            if (CheckPoint(deviceID, imgnv00a) == true) goto Step01;
            else return;

            // Vào dinh thự
            Step01: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 82, 86, imgnv15a01, 120) == true) goto Step02;
            else Exit(deviceID);

            // Kéo phải sang trái
            Step02: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.SwipeByPercent(deviceID, 90, 50, 10, 50);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv15a04) == true) break;
                    else Delay(1);
                }
            }
            goto Step03;
        //goto Step08;

        // Bấm vào tiệm
        Step03: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 95, 86, imgnv15a06a, 120) == true) goto Step04;
            else Exit(deviceID);

            // Chọn hạt giống
            Step04: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 64, 6, imgnv15a07a, 120) == true) goto Step05;
            else Exit(deviceID);

            // Bấm mua
            Step05: if (isStop) return;
            if (TapAndCheck(deviceID, Location(deviceID, imgnv15a07a).x + 20, Location(deviceID, imgnv15a07a).y + 90, imgnv04b03, 120) == true) goto Step06;
            else Exit(deviceID);

            // Chọn số lượng và bấm đồng ý
            Step06: if (isStop) return;
            for (int i = 0; i < 10; i++)
            {
                KAutoHelper.ADBHelper.TapByPercent(deviceID, 58, 67);
            }
            Delay(1);
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 50, 79);
            Delay(1);
            goto Step07;

        // Trở ra trồng cây
        Step07: if (isStop) return;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, 98, 5);
                    Delay(1);
                    if (CheckPoint(deviceID, imgnv15a05a) == true || CheckPoint(deviceID, imgnv15a05b) == true) break;
                    else Delay(1);
                }
            }
            goto Step08;

        // Kiểm tra trồng thủ công hay thú chăm
        Step08: if (isStop) return;
            int val01 = 0, val02 = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i == 120) Exit(deviceID);
                else
                {
                    if (CheckPoint(deviceID, imgnv15a05a) == true)
                    {
                        val01++;
                        break;
                    }
                    else if (CheckPoint(deviceID, imgnv15a05b) == true)
                    {
                        val02++;
                        break;
                    }
                    else Delay(1);
                }
            }
            if (val01 > val02) goto Step09a;
            else goto Step09b;

            // Thủ công thu hoạch
            Step09a: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 37, 68, imgnv15a05b, 120) == true) goto Step10a;
            else Exit(deviceID);

            // Chưa rõ
            Step09b: if (isStop) return;
            if (CheckPoint(deviceID, imgnv15a05b) == true)
            {
                int val03 = 0, val04 = 0;
                for (int i = 1; i <= 120; i++)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, Location(deviceID, imgnv15a05b).x - 50, Location(deviceID, imgnv15a05b).y - 60);
                    Delay(1);
                    if (i == 120) Exit(deviceID);
                    else if (i == 5 && CheckPoint(deviceID, imgnv15a05b) == true)
                    {
                        val03++;
                        break;
                    }
                    else
                    {
                        if (CheckPoint(deviceID, imgnv12b) == true)
                        {
                            val04++;
                            break;
                        }
                        else Delay(1);
                    }
                }
                if (val04 > val03) goto Step10b;
                else goto backMain;
            }
            else goto backMain;

            // Bấm gieo từng ô
            Step10a: if (isStop) return;
            int[] holeXs = { 50, 60, 70, 80, 90 };
            foreach (var holeX in holeXs)
            {
                //int val03 = 0, val04 = 0;
                for (int i = 1; i <= 120; i++)
                {
                    if (i == 120) Exit(deviceID);
                    else
                    {
                        KAutoHelper.ADBHelper.TapByPercent(deviceID, holeX, 70);
                        Delay(1);
                        if (CheckPoint(deviceID, imgnv15a07c) == true) break;
                    }
                }

                if (CheckPoint(deviceID, imgnv15a07c) == true)
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, Location(deviceID, imgnv15a07c).x, Location(deviceID, imgnv15a07c).y);
                    Delay(1);
                }
            }
            return;

            // Có thú, bấm vào thú bỏ hạt giống
            Step10b: if (isStop) return;
            int[] boxXs = { 38, 48, 58, 68 };
            foreach (var boxX in boxXs)
            {
                int val03 = 0, val04 = 0;
                for (int i = 1; i <= 120; i++)
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, boxX, 63);
                    Delay(1);
                    if (i == 120) Exit(deviceID);
                    else if ((i == 3 || i == 6 || i == 9) && CheckPoint(deviceID, imgnv12b) == true)
                    {
                        val03++;
                        break;
                    }
                    else
                    {
                        if (CheckPoint(deviceID, imgnv15a08b) == true)
                        {
                            val04++;
                            break;
                        }
                        else Delay(1);
                    }
                }
                if (val04 > val03) break;
            }
            goto Step11b;

            // Chọn vào hạt giống
            Step11b: if (isStop) return;
            if (TapAndCheck(deviceID, Location(deviceID, imgnv15a07b).x, Location(deviceID, imgnv15a07b).y, imgnv15a08a, 120) == true) goto Step12b;
            else Exit(deviceID);

            // Bấm đồng ý
            Step12b: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 50, 85, imgnv15a09a, 120) == true) goto Step13b;
            else Exit(deviceID);

            // Bấm tối đa
            Step13b: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 63, 63, imgnv15a09b, 120) == true) goto Step14b;
            else Exit(deviceID);

            // Bấm đồng ý
            Step14b: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 50, 75, imgnv12b, 120) == true) goto Step15b;
            else Exit(deviceID);

            // Bấm lưu
            Step15b: if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 50, 78, imgnv15a05b, 120) == true) goto backMain;
            else Exit(deviceID);

            // Thoát đến main
            backMain: if (isStop) return;
            backMain(deviceID);
            goto Finish;

            // Xong
            Finish: return;
        }
        //------------------------------------------------------------------------------
        // Random number
        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //------------------------------------------------------------------------------
        // Bấm và kiểm tra
        bool TapAndCheck(string deviceID, int x, int y, Bitmap img, int time)
        {
            for (int i = 1; i <= time; i++)
            {
                if (i == time) return false;
                else
                {
                    KAutoHelper.ADBHelper.Tap(deviceID, x, y);
                    Delay(1);
                    if (CheckPoint(deviceID, img) == true) break;
                    else Delay(1);
                }
            }
            return true;
        }
        bool TapByPercentAndCheck(string deviceID, int x, int y, Bitmap img, int time)
        {
            for (int i = 1; i <= time; i++)
            {
                if (i == time) return false;
                else
                {
                    KAutoHelper.ADBHelper.TapByPercent(deviceID, x, y);
                    Delay(1);
                    if (CheckPoint(deviceID, img) == true) break;
                    else Delay(1);
                }
            }
            return true;
        }

        // Thoát app
        void Exit(string deviceID)
        {
            // Thoát ứng dụng
            if (isStop) return;
            KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_APP_SWITCH);
            Delay(1);
            // Kéo ngang để đóng hẳn ứng dụng
            if (isStop) return;
            KAutoHelper.ADBHelper.SwipeByPercent(deviceID, 40, 60, 90, 60);
            Delay(1);
        }

        // Chờ 2 phút để thoát ra hoàn toàn
        void backMain(string deviceID)
        {
            if (isStop) return;
            if (TapByPercentAndCheck(deviceID, 98, 5, imgnv00a, 120) == true) return;
            else Exit(deviceID);
        }
        //------------------------------------------------------------------------------

        void Delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                delay--;
                if (isStop)
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                isStop = false;
                Auto();
            });
            t.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isStop = true;
        }

    }
}
