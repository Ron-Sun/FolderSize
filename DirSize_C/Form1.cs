using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirSize_C
{
    public partial class Form1 : Form
    {
        public bool AboutToClose = false; // True if form closing by user.
        private readonly FileSelect F = new FileSelect();   // frequent used.
        private readonly Lib L = new Lib();                 // frequent used.
        private string SelectedFolder;
        private string Original = "";
        private string[] Folders;
        private string[] ShortSizeFolder;
        private string[] LongSizeFolder;

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit_application();
        }

        private void FolderSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void FolderGetBtn_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        public void SelectFolder()
        {
            FolderPicker P = new FolderPicker(); // frequent used.
            SelectedFolder = P.GetFolder(this);

            if (SelectedFolder == "") { return; }

            ReadSelectedFolder(SelectedFolder);

        }

        public void ReadSelectedFolder(string path) 
        {
            FileBox.Clear();
            FolderBox.Text = path;
            Application.DoEvents();

            Original = F.GetFolders(path);
            Folders = Original.Split('\n');
            ShortSizeFolder = Original.Split('\n');
            LongSizeFolder = Original.Split('\n');

            GetFolderSize();

        }





        public void GetFolderSize()
        {
            long Size;
            long Total = 0; 
            int Pos = 0;

            WorkLabel.Visible = true;
            foreach (var line in Folders)
            {
                if (line.Length > 2)
                {
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(line);
                    Size = CalculateFolderSize(di);

                    if (Size != -1)         // -1 = Directory locked or faulty.
                    { Total += Size; }  

                    FileBox.AppendText(PositionSize(Size, false) + "  " + line + '\n');
                   // ShortSizeFolder[Pos] = PositionSize(Size, true) + "  " + ShortSizeFolder[Pos]; 
                    LongSizeFolder[Pos] = PositionSize(Size, false) + "  " + LongSizeFolder[Pos];
                    Application.DoEvents();
                    Pos += 1;
                }
            }

            WorkLabel.Visible = false;

            string Tmp;
            FileBox.AppendText('\n' + PositionSize(Total, true) + "  Total.");
            //Tmp = PositionSize(Total, true) + "  Total."; //"Total " + PositionSize(Total, true);
            //ShortSizeFolder[Pos] = Tmp;
            //System.Array.Sort(ShortSizeFolder);

            Tmp = PositionSize(Total, false) + "  Total.";  //"Total " + PositionSize(Total, false);
            LongSizeFolder[Pos] = Tmp;
            System.Array.Sort(LongSizeFolder);
          
            CreateSortedShortSizeFolder();
            ShowFolder(true);  // Show sorted short number.
        }


        public void CreateSortedShortSizeFolder()
        {
            long Size;
            int Pos = 0;

            foreach (var line in LongSizeFolder)
            {
                try
                {
                    Size = Convert.ToInt64(L.Left(line, 20));
                    ShortSizeFolder[Pos] = PositionSize(Size, true) + L.Right(line, line.Length - 23);
                }
                catch (Exception)
                {
                    Size = 0;
                    ShortSizeFolder[Pos] = PositionSize(Size, true) + " *" + L.Right(line, line.Length - 21); ; // startDirectorySize; //Return 0 Directory has security lock. 
                }
                Pos++;
            }
        }

        public void ShowFolder(bool ShortOrLong)
        {

            FileBox.Clear();

            // ShortSizeFolder

            if (ShortOrLong)
            {
                foreach (var line in ShortSizeFolder)
                {
                    if (line.Length > 2)
                        FileBox.AppendText(line + '\n');
                }
            }
            else
                foreach (var line in LongSizeFolder)
                {
                    if (line.Length > 2)
                        FileBox.AppendText(line + '\n');
                }
        }

        private string LongFill = "                       ";
        private string ShortFill = "             ";

        public string PositionSize(long Size, bool LS)
        {

            // Dim fromated As String = ""
            // For x = s.Length To 1 Step -1

            // Next

            string s = GbKbBt(Size, LS);
            //string tst = SizeSuffix(Size,2);
            if (LS)
            { 
                s = L.Left(ShortFill, ShortFill.Length - s.Length) + s;
                return s;
            }

            s = L.Left(LongFill, LongFill.Length - s.Length) + s;
            return s;
        }

        public string GbKbBt(long Size, bool LS)
        {
            if (!LS)
            { 
                return Size.ToString() + " --";
            }

            return SizeSuffix(Size, 2);
        }


        // https://stackoverflow.com/questions/468119/whats-the-best-way-to-calculate-the-size-of-a-directory-in-net
        // Credit : Ken Tseng
        private static readonly string[] SizeSuffixes =
           { "b.", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public static string SizeSuffix(long value, int decimalPlaces = 2)
        {
            // if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            // if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == -1) { return string.Format("{0:n" + decimalPlaces + "} **", 0); }
            if (value == 0)  { return string.Format("{0:n" + decimalPlaces + "} b.", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);               // Smart way to access Suffix.

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        // https://stackoverflow.com/questions/468119/whats-the-best-way-to-calculate-the-size-of-a-directory-in-net
        // Credit to : Ahmed Sabry
        public long CalculateFolderSize(System.IO.DirectoryInfo directoryInfo, bool recursive = true)
        {

            var startDirectorySize = default(long);

            if (directoryInfo == null || !directoryInfo.Exists)
            {
                return startDirectorySize; //Return 0 while Directory does not exist.
            }

            //Add size of files in the Current Directory to main size.

            try
            {
                foreach (var fileInfo in directoryInfo.GetFiles())
                    Interlocked.Add(ref startDirectorySize, fileInfo.Length);
            }
            catch (Exception)
            {
                return -1; // startDirectorySize; //Return 0 Directory has security lock. 
            }

 
            if (recursive) //Loop on Sub Direcotries in the Current Directory and Calculate it's files size.
                Parallel.ForEach(directoryInfo.GetDirectories(), (subDirectory) =>
                Interlocked.Add(ref startDirectorySize, CalculateFolderSize(subDirectory, recursive)));

            return startDirectorySize;  //Return full Size of this Directory.
        }

        public void Exit_application()
        {
            System.Environment.Exit(0);
        }
          private void Form1_Resize(object sender, EventArgs e)
        {

            Application.DoEvents();
            if (Width < 400)
                Width = 400; // Adjust for 4 colums. Absolut smallest window size
            if (Height < 300)
                Height = 300; // Adjust for 8 colums

            FolderBox.Width = Width - 82;

            FileBox.Width = Width - 20; // 18
            FileBox.Height = Height - 87; // 106
            Application.DoEvents();
        }

        private void ShortSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFolder(true);
        }

        private void FullSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFolder(false);
        }

        public string FindFilnameInString(string s)
        {
            for (var Pos = 0; Pos <= s.Length - 2; Pos++)    //
            {
                if (s.Substring(Pos, 2) == @":\")
                {
                    return s.Substring(Pos - 1, s.Length - Pos + 1);
                }
            }
            return "";      // not found.
        }


        public Boolean NotOneLine(string s)
        {   
            for (var Pos = 0; Pos <= s.Length -1; Pos++)    //
            {
                if (s.Substring(Pos, 1) == "\n")    // Varför funkar inte '\n' när "\n" funkar ?!?... Char vs sträng ?
                 return true;                       // Lf found.
            }
            // s.Substring(Pos, 1);
            return false;
        }


        public string TestPath(string s)
        {
 
            // string tst = ":\";

            if (s.Substring(1, 2) != @":\") 
            {
                return FindFilnameInString(s);  // Try to find directory in string.
            }   

            return s;
        }

        public string RemoveLeadTrailChar(string s)
        {
            return s.Trim(' ','\n');    // Remove leading and traling space or '\n'
        }

        public string TestValidFolderPath(string s)
        {      
            s = RemoveLeadTrailChar(s);
            if (s.Length < 1) { return ""; }                // Too short.

            if (NotOneLine(s)) { return ""; }               // Clear, not a single line
             
            s = TestPath(s);
            if (s.Length < 1) {return ""; }                 // Too short.


            return s;
        }

        public void MsgBox(string message, string caption)
        {
             MessageBox.Show(message, caption);
        }

        private void FileBox_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                string s = FileBox.SelectedText;
                if (s.Length < 2) { return; }       // To short.

                s = TestValidFolderPath(s);         // Validity test.
                if (s.Length < 1) { return; }

                { ReadSelectedFolder(s);  }

            }

        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsgBox("Click Open and select a directory.\n " +
                   "You get the size from each under directory.\n " +
                   "Zero sized directory marked ** are locked \n" +
                   "or virtual directories linked by Windows."
                 , "General help" );
        }

        private void quicPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsgBox("Mark a directory line.\n" + 
                   "Double click the line a few times.\n " +
                   "Right click the mouse.\n " +
                   "The directory will open."
                 , "Quick select.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsgBox("DirSize 1.0\n" +
                   "Created by Ronny Solheim.\n " +
                   "\n " +
                   "Contact: ronny@lexby.nu"
                 , "About.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)  // If the no button was pressed ...
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }
    }
}
