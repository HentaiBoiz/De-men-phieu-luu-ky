using DeMenPhieuLuuKy.CutScene;
using System;
using System.IO;
using System.Windows.Forms;
using static DeMenPhieuLuuKy.PlayerProfile;
using static DeMenPhieuLuuKy.Difficulty;

namespace DeMenPhieuLuuKy
{

    public partial class SaveData : Form
    {

        private int soLuongSave = 8;
        private String playerNameData;

        private Title_Screen titleScreen;


        public SaveData(Title_Screen titleScreen)
        {
            InitializeComponent();

            playerNameData = null;
            this.titleScreen = titleScreen;
        }

        public SaveData()
        {
            InitializeComponent();

            if (Program.SaveFolderPath != null)
            {
                ImportFromExcel();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            titleScreen.Enabled = true;
            titleScreen.Focus();
            this.Hide();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (saveDataGridView.RowCount > 0)
            {
                DialogResult result;

                result = MessageBox.Show("Bạn có thật sự muốn xóa bản lưu này ?", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.saveDataGridView.SelectedRows)
                    {
                        saveDataGridView.Rows.RemoveAt(item.Index);
                    }
                }
                ExportToExcel();
            }
              
        }


        //Thêm bản lưu mới
        public void AddNewPlayer(String playerName, int score, String levelName, string difficulty, int playerHealth, int playerPower, float playerJumpSpeed)
        {
            saveDataGridView.Rows.Add(playerName, score, levelName,difficulty, playerHealth, playerPower, playerJumpSpeed);
        }

        //Kiểm tra tên người chơi đã tồn tại chưa
        public bool CheckOverwrite(String playerName)
        {
            foreach (DataGridViewRow row in saveDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(playerName))
                {
                    return true;
                }
            }
            return false;
        }

        //Kiểm tra lượng file save đã đầy hay chưa
        public bool CheckFull()
        {
            if (saveDataGridView.Rows.Count >= soLuongSave) return true;
            return false;

        }

        //Tìm và xóa bản lưu đã có sẵn
        public void FindAndDelete(String playerName)
        {
            foreach (DataGridViewRow row in saveDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(playerName))
                {
                    saveDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        public void ImportFromExcel()
        {
            try
            {
                //Tạo một trình chạy excel
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                //Tạo một WorkBook
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                //Tạo một sheet mới 
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                //Phạm vi load dữ liệu
                Microsoft.Office.Interop.Excel.Range range;

                //Kiểm tra file lưu trước đó, nếu có rồi thì load vào gridview
                if (File.Exists(Program.SaveFilePath))
                {
                    //Mở file excel
                    workbook = app.Workbooks.Open(Program.SaveFilePath);
                    //Tham chiếu tới sheet thứ nhất. 
                    worksheet = workbook.ActiveSheet;
                    //Phạm vi tải dữ liệu lên
                    range = worksheet.UsedRange;

                    //Import từ hàng thứ 2, vì hàng thứ nhất là Header
                    for (int workSheetRowIndex = 2; workSheetRowIndex < range.Rows.Count + 1; workSheetRowIndex++)
                    {
                        saveDataGridView.Rows.Add(worksheet.Cells[workSheetRowIndex, 1].Value, worksheet.Cells[workSheetRowIndex, 2].Value, worksheet.Cells[workSheetRowIndex, 3].Value, worksheet.Cells[workSheetRowIndex, 4].Value, worksheet.Cells[workSheetRowIndex, 5].Value, worksheet.Cells[workSheetRowIndex, 6].Value, worksheet.Cells[workSheetRowIndex, 7].Value);
                    }
                }


                // Đóng file 

                workbook.Close();

                app.Quit();

                //killExcel();
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: Không tìm thấy bản lưu game !!!");
            }

        }

        public void ExportToExcel()
        {
            try
            {

                //Kiểm tra file lưu trước đó, nếu có rồi thì xóa đi
                if (File.Exists(Program.SaveFilePath))
                    File.Delete(Program.SaveFilePath);

                //Tạo một trình chạy excel
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                //Tạo một WorkBook
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                //Tạo một sheet mới 
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                //File excel sẽ mở lên
                app.Visible = false;
                //Tham chiếu tới sheet thứ nhất. Tên mặc định là Sheet1.
                worksheet = workbook.ActiveSheet;
                //Thay đổi tên sheet 
                worksheet.Name = "DeMenPhieuLuuKi_SaveData";
                //Lưu trữ phần Header vào file excel
                for (int i = 1; i < saveDataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = saveDataGridView.Columns[i - 1].HeaderText;
                }
                //Lưu trữ dữ liệu trong mỗi dòng và cột vào excel sheet
                for (int i = 0; i < saveDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < saveDataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = saveDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Lưu file  
                workbook.SaveAs(Program.SaveFilePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                // Đóng file 

                workbook.Close();

                app.Quit();
                //killExcel();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: Không tìm thấy bản lưu game !!!");
            }

        }

        //Tránh việc FileExcel chạy ngầm
        private void killExcel()
        {
            System.Diagnostics.Process[] PROC = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process PK in PROC)
            {
                if (PK.MainWindowTitle.Length == 0)
                {
                    PK.Kill();
                }
            }
        }
        private void Exit()
        {
            DialogResult result;

            result = MessageBox.Show("Bạn có thật sự muốn thoát khỏi trò chơi chứ ?", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(saveDataGridView.RowCount > 0){
                DialogResult result;

                result = MessageBox.Show("Bạn muốn chơi tiếp màn chơi này ?", "CẢNH BÁO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.saveDataGridView.SelectedRows)
                    {
                        titleScreen.saveDataDispose = true;
                        Program.playerNameData = item.Cells[0].Value.ToString();
                        Program.globalScore = Convert.ToInt32(item.Cells[1].Value.ToString());
                        difficulty = IntDifficulty(item.Cells[3].Value.ToString());
                        playerGobalHealth = Convert.ToInt32(item.Cells[4].Value.ToString());
                        playerPower = Convert.ToInt32(item.Cells[5].Value.ToString());
                        playerJumpSpeed = float.Parse(item.Cells[6].Value.ToString());
                        ContinueGame(item.Cells[2].Value.ToString());
                        titleScreen.Hide();
                        this.Close();
                    }
                }
            }
            
        }

        //Kiểm tra level và tải màn chơi
        private void ContinueGame(String level)
        {
            Form newWindow;
            switch (level)
            {
                case "Level 1":
                    newWindow = new CutScene_1();
                    newWindow.Show();

                    break;
                case "Level 2":
                    newWindow = new CutScene_2();
                    newWindow.Show();

                    break;
                case "Level 3":
                    newWindow = new CutScene_3();
                    newWindow.Show();

                    break;
                case "Level 4":
                    newWindow = new Level_4_1();
                    newWindow.Show();

                    break;
                case "Level 5":
                    newWindow = new CutScene_4();
                    newWindow.Show();

                    break;
                case "Final":
                    newWindow = new CutScene_5();
                    newWindow.Show();

                    break;
                default:
                    newWindow = new Level_1();
                    newWindow.Show();

                    break;
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Program.SaveFilePath = ofd.SelectedPath + "\\SaveData.xlsx";
                Program.SaveFolderPath = ofd.SelectedPath;
                Console.WriteLine(ofd.SelectedPath);
                ImportFromExcel();
            }
        }
    }


}
