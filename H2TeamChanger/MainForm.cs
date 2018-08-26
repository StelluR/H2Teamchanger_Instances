using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace H2TeamChanger
{
    public partial class MainForm : Form
    {

        int pid;
        public const String ProcessName = "halo2";
        Boolean LoadedProcess = false;
        Process[] process;
        Memory memory;

        IntPtr HealthMemAdr = IntPtr.Zero;
        IntPtr HealthMemAdr2 = IntPtr.Zero;
        IntPtr HealthMemAdr3 = IntPtr.Zero;

        int crazy = 0;
        int wire = 0;
        const int TEAM_Memory_Address = 0x51A6B4;
        const int CRAZY_Memory_Address = 0xA49490;
        const int WIRE_Memory_Address = 0x468174;
        byte PlayerTeam;
        public static bool running = false;
        public bool t2running = false;
        public static  bool t3running = false;

        private void findAllH2process()
        {
            int i = 0;
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                
                if(theprocess.ProcessName == "halo2")
                {
                    ListViewItem item = new ListViewItem(theprocess.MainWindowTitle);
                    item.SubItems.Add(theprocess.Id.ToString());
                    listView1.Items.Add(item);
                    Console.WriteLine("Process: {0} ID: {1} Window Title: {2}", theprocess.ProcessName, theprocess.Id, theprocess.MainWindowTitle);
                }
                
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            findAllH2process();
            process = Process.GetProcessesByName(ProcessName);
            UpdateTimer.Start();

            

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
       
                Thread t2 = new Thread(delegate ()
                {
                    t2running = true;
                    while (!running)
                    {
                        if (CheckIfProcessIsRunning(ProcessName))
                        {
                            
                            process = Process.GetProcessesByName(ProcessName);
                            running = true;


                        }
                        else
                        {
                            Thread.Sleep(10000);
                        }
                    }

                });
                t2.IsBackground = true;
                if (!t2running) t2.Start();
                if (running)
                {
                    try
                    {
                    if (process.Length > 0)
                    {
                        lblGameState.Text = "Running...";
                        lblGameState.ForeColor = System.Drawing.Color.LimeGreen;
                        if (pid.Equals(null) || pid.Equals(0))
                            {
                            process = Process.GetProcessesByName(ProcessName);
                            }
                            else
                            {
                                process[0] = Process.GetProcessById(pid);

                            }
                        memory = new Memory(process[0]);
                            HealthMemAdr = memory.GetAddress("\"halo2.exe\"+0x51A6B4");


                            DisplayTeam();


                        }
                    }
                    catch (System.IndexOutOfRangeException){
                        listView1.Items.Clear();
                        findAllH2process();
                        if (listView1.Items.Count < 1)
                        {
                            running = false;
                            t2.Abort();
                            t2running = false;
                        }
                }
                    catch (System.ArgumentException)
                    {
                        listView1.Items.Clear();
                        findAllH2process();
                        if(listView1.Items.Count < 1)
                        {
                            running = false;
                            t2.Abort();
                            t2running = false;
                            pid = 0;
                        }
                        else
                        {
                            ListViewItem item = listView1.Items[0];
                            Int32.TryParse(item.SubItems[1].Text, out pid);
                        }
                }


                    }
                else
                {
                    lblGameState.Text = "Game is NOT Active!";
                    lblGameState.ForeColor = System.Drawing.Color.Red;
                    txtTeam.Text = "?";
                }




        }

        public  bool CheckIfProcessIsRunning(string ProcessName)
        {

            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(ProcessName))
                {
                    return true;
                }
            }
            return false;
        }

        private void DisplayTeam()
        {

            PlayerTeam = memory.ReadByte(HealthMemAdr);

            if (PlayerTeam == 0)
                txtTeam.Text = "Red (0)";
            else if (PlayerTeam == 1)
                txtTeam.Text = "Blue (1)";
            else if (PlayerTeam == 2)
                txtTeam.Text = "Yellow (2)";
            else if (PlayerTeam == 3)
                txtTeam.Text = "Green (3)";
            else if (PlayerTeam == 4)
                txtTeam.Text = "Purple (4)";
            else if (PlayerTeam == 5)
                txtTeam.Text = "Orange (5)";
            else if (PlayerTeam == 6)
                txtTeam.Text = "Brown (6)";
            else if (PlayerTeam == 7)
                txtTeam.Text = "Pink (7)";
            else if (PlayerTeam == 255)
                txtTeam.Text = "Observers (255)";
            else
                txtTeam.Text = PlayerTeam.ToString();

        }

        private void SetTeam(byte team)
        {
            if (process.Length > 0)
            {
                memory.WriteByte(HealthMemAdr, team);
            }
        }



        #region TeamChangerButtons
        private void btnRedTeam_Click(object sender, EventArgs e)
        {
            SetTeam(0);
        }

        private void btnBlueTeam_Click(object sender, EventArgs e)
        {
            SetTeam(1);
        }

        private void btnYellowTeam_Click(object sender, EventArgs e)
        {
            SetTeam(2);
        }

        private void btnGreenTeam_Click(object sender, EventArgs e)
        {
            SetTeam(3);
        }

        private void btnPurpleTeam_Click(object sender, EventArgs e)
        {
            SetTeam(4);
        }

        private void btnOrangeTeam_Click(object sender, EventArgs e)
        {
            SetTeam(5);
        }

        private void btnBrownTeam_Click(object sender, EventArgs e)
        {
            SetTeam(6);
        }

        private void btnPinkTeam_Click(object sender, EventArgs e)
        {
            SetTeam(7);
        }

        private void btnObserverTeam_Click(object sender, EventArgs e)
        {
            SetTeam(255);
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                
                ListViewItem item = listView1.SelectedItems[0];
                Int32.TryParse(item.SubItems[1].Text, out pid);
                Console.WriteLine("This is the process id:" + pid);
                Console.WriteLine("This is the process name" + item.SubItems[1].Text);
                process[0] = Process.GetProcessById(pid);
                Console.WriteLine(item.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            findAllH2process();

        }
    }
}
