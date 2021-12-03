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

namespace ArchiveExtract
{
    public partial class Form1 : Form
    {
        // Field to hold file 
        private FileStream fsCurrentFile = null;
        // Field to hold the current path
        private string strCurrentPath = null;
        public Form1() {
            InitializeComponent();
		}

		private void tsmiQuit_Click(object sender, EventArgs e) {
			this.Close();
		}

        private void dgvPageInfo_Click(object sender, EventArgs e) {
            int iRows = dgvPageInfo.RowCount;
            if (iRows > 0)
            {
                // Display the selected page
                vDisplayPage();
            }
        }

        // Function to convert 4 little endian bytes to int
        private int FourLEBytesToInt(FileStream fsFile)
        {
            byte[] byBuffer = new byte[4];
            fsFile.Read(byBuffer, 0, 4);
            int iValue = byBuffer[0];
            int iNextByte = byBuffer[1];
            iValue = iValue | (iNextByte << 8);
            iNextByte = byBuffer[2];
            iValue = iValue | (iNextByte << 16);
            iNextByte = byBuffer[3];
            iValue = iValue | (iNextByte << 24);
            return iValue;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            // Clear out the old rows data if there are any
            dgvPageInfo.Rows.Clear();
            // Open the open file dialog and store the result it returns
            DialogResult drResult = ofdArchive.ShowDialog();
            // Open and display file information if the dialog result is "OK"
            if (drResult == DialogResult.OK)
            {
                // Open the file
                fsCurrentFile = File.Open(ofdArchive.FileName, FileMode.Open, FileAccess.Read);
                // Save the file path
                strCurrentPath = ofdArchive.FileName;
                // Set the file position pointer to the beginning of the offset (1 bytes from end)
                fsCurrentFile.Seek(-1, SeekOrigin.End);
                // Array to store offset
                byte[] byPages = new byte[1];
                // Get the offset
                fsCurrentFile.Read(byPages, 0, 1);
                int iPages = byPages[0];
                int iOffset = iPages * 8 + 1;
                // The offset section is 1 byte long. Add this to the bytes read
                int iBytesRead = 1;
                // Make a list of FileInfo objects
                List<PageInfo> lstPages = new List<PageInfo>();
                // Set the file position pointer to the beginning of the index
                fsCurrentFile.Seek(-iOffset, SeekOrigin.End);
                // int to keep track of page number
                int iPage = 1;
                // Loop through the index to get each page information
                while (iBytesRead < iOffset)
                {
                    iBytesRead += 8;
                    PageInfo piPage = new PageInfo();
                    piPage.Offset = FourLEBytesToInt(fsCurrentFile);
                    piPage.Length = FourLEBytesToInt(fsCurrentFile);
                    piPage.Page = iPage;
                    lstPages.Add(piPage);
                    iPage++;
                }
                // Close the file
                fsCurrentFile.Close();
                fsCurrentFile = null;
                // All files are stored in list, display info in data grid view
                DisplayInfo(lstPages);               
            }
        }


        // Function to display info in datagrid view
        private void DisplayInfo(List<PageInfo> lstPages)
        {
            // Loop through the Pages in the list
            foreach (PageInfo piPage in lstPages)
            {
                // Make a new row and add the pages information into it
                int iNewRowNum = dgvPageInfo.Rows.Add();
                DataGridViewRow dgvrNewRow = dgvPageInfo.Rows[iNewRowNum];
                dgvrNewRow.Cells["PageNum"].Value = "Page " + piPage.Page.ToString();
                dgvrNewRow.Cells["Length"].Value = piPage.Length;
                dgvrNewRow.Cells["Offset"].Value = piPage.Offset;
            }
            // Display the contents of the selected cell (Page 1)
            vDisplayPage();
        }

        // Display the contents of the selected page
        private void vDisplayPage()
        {
            int iSelectedRow = dgvPageInfo.SelectedCells[1].RowIndex;
            DataGridViewRow dgvrSelectedRow = dgvPageInfo.Rows[iSelectedRow];
            int iPageLength = (int)dgvrSelectedRow.Cells["Length"].Value;
            // Set the file position pointer to the beginning of the file
            int iPageOffset = (int)dgvrSelectedRow.Cells["Offset"].Value;
            byte[] byPageContent = new byte[iPageLength];
            fsCurrentFile = File.Open(strCurrentPath, FileMode.Open, FileAccess.Read);
            fsCurrentFile.Seek(iPageOffset, SeekOrigin.Begin);
            fsCurrentFile.Read(byPageContent, 0, iPageLength);
            Encoding encUTF8 = Encoding.UTF8;
            rtbPageText.Text = encUTF8.GetString(byPageContent, 0, iPageLength);
            fsCurrentFile.Close();
            fsCurrentFile = null;
        }
    }
}
