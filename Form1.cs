using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WF = System.Windows.Forms;


namespace OS
{
    public partial class Form1 : Form
    {
        const int MIN_PROCESS_SLOT_WIDTH = 60;
        const int MAX_PAGE = 22;
        const int MAX_PROCESS_SLOT_WIDTH = 300;
        const int BURST_TIME_barrier = 5;

        int numOfProcess;

        Queue<Process> FCFS_Input_Queue = new Queue<Process>();
        Queue<Process> FCFS_Display_Queue = new Queue<Process>();
        int FCFS_QUEUE_SIZE = 0;
        int FCFS_ACC = 0;
        float FCFS_SumOfWaitTime = 0;
        float FCFS_SumOfTurnAroundTime = 0;
        bool FCFS_Live = false;
        bool FCFS_Jump = false;
        bool FCFS_Page = false;
        int FCFS_NextPossibleSlot = 0;

        Queue<Process> SJF_Input_Queue = new Queue<Process>();
        Queue<Process> SJF_Display_Queue = new Queue<Process>();
        int SJF_QUEUE_SIZE = 0;
        int SJF_ACC = 0;
        float SJF_SumOfWaitTime = 0;
        float SJF_SumOfTurnAroundTime = 0;
        bool SJF_Preemtive_Version = false;
        bool SJF_Live = false;
        bool SJF_Jump = false;
        int SJF_NextPossibleSlot = 0;

        Queue<Process> PIOR_Input_Queue = new Queue<Process>();
        Queue<Process> PIOR_Display_Queue = new Queue<Process>();
        int PIOR_QUEUE_SIZE = 0;
        int PIOR_ACC = 0;
        float PIOR_SumOfWaitTime = 0;
        float PIOR_SumOfTurnAroundTime = 0;
        bool PIOR_Preemtive_Version = false;
        bool PIOR_Live = false;
        bool PIOR_Jump = false;
        int PIOR_NextPossibleSlot = 0;

        Queue<Process> RR_Input_Queue = new Queue<Process>();
        Queue<Process> RR_Display_Queue = new Queue<Process>();
        Queue<Process> RRRR = new Queue<Process>();
        int RR_QUEUE_SIZE = 0;
        int RR_ACC = 0;
        float RR_SumOfWaitTime = 0;
        float RR_SumOfTurnAroundTime = 0;
        bool RR_Live = false;
        bool RR_Jump = false;
        int RR_NextPossibleSlot = 0;
        int RR_QuantamTime;

        public Form1()
        {
            InitializeComponent();
            Reset();
            // make form fixed size
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(960, 780);
            MinimumSize = MaximumSize;
        }





        /*---------------------------------------------------------reset------------------------------------------------------------------------*/
        private void Reset()
        {
            FCFS_Rest();
            SJF_Rest();
            PIOR_Rest();
            RR_Rest();
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------*/





        /*--------------------------------------------------------Start of FCFS functions--------------------------------------------------------*/
        private void FCFS_Insert_btn_Click(object sender, EventArgs e)
        {
            if (FCFS_Mode_comboBox.Text == "Static")
            {
                if (
                       string.IsNullOrEmpty(FCFS_ArrivalTime_textbook.Text)
                    || string.IsNullOrEmpty(FCFS_BurstTime_textbook.Text)
                    || (!int.TryParse(FCFS_ArrivalTime_textbook.Text, out int value1) || value1 < 0)
                    || (!int.TryParse(FCFS_BurstTime_textbook.Text, out int value2) || value2 <= 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                Process tempProcess = new Process();
                tempProcess.Pid = FCFS_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(FCFS_BurstTime_textbook.Text);
                tempProcess.arrival_time = int.Parse(FCFS_ArrivalTime_textbook.Text);
                FCFS_Input_Queue.Enqueue(tempProcess);
                FCFS_QUEUE_SIZE++;

                FCFS_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time);

                FCFS_ArrivalTime_textbook.Clear();
                FCFS_BurstTime_textbook.Clear();

                if (numOfProcess == FCFS_QUEUE_SIZE)
                {
                    FCFS_Insert_btn.Enabled = false;

                    FCFS_Static_Logic_Display();
                    
                    FCFS_ArrivalTime_textbook.Clear();
                    FCFS_ArrivalTime_textbook.Enabled = false;

                    FCFS_BurstTime_textbook.Clear();
                    FCFS_BurstTime_textbook.Enabled = false;

                    FCFS_hScrollBar.Enabled = true;
                    FCFS_hScrollBar.Visible = true;

                    FCFS_sumWaitingTime_label.Enabled = true;
                    FCFS_sumWaitingTime_label.Visible = true;
                    FCFS_avgWaitingTime_label.Visible =true;
                    FCFS_avgWaitingTime_label.Enabled =true;
                    FCFS_sumTurnAroundTime_label.Visible = true;
                    FCFS_sumTurnAroundTime_label.Enabled = true;
                    FCFS_avgTurnAroundTime_label.Visible =true;
                    FCFS_avgTurnAroundTime_label.Enabled =true;

                    FCFS_sumWaitingTime_textBox.Enabled = true;
                    FCFS_sumWaitingTime_textBox.Visible = true;
                    FCFS_avgWaitingTime_textBox.Enabled = true;
                    FCFS_avgWaitingTime_textBox.Visible = true;
                    FCFS_sumTurnAroundTime_textBox.Enabled = true;
                    FCFS_sumTurnAroundTime_textBox.Visible = true;
                    FCFS_avgTurnAroundTime_textBox.Enabled = true;
                    FCFS_avgTurnAroundTime_textBox.Visible = true;
                    FCFS_sumWaitingTime_textBox.ReadOnly = true;
                    FCFS_avgWaitingTime_textBox.ReadOnly = true;
                    FCFS_sumTurnAroundTime_textBox.ReadOnly = true;
                    FCFS_avgTurnAroundTime_textBox.ReadOnly = true;
                }
            }
            else if (FCFS_Mode_comboBox.Text == "Dynamic")
            {
                if (
                    string.IsNullOrEmpty(FCFS_BurstTime_textbook.Text)
                    || (!int.TryParse(FCFS_BurstTime_textbook.Text, out int value2) || value2 <= 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                Process tempProcess = new Process();
                tempProcess.Pid = FCFS_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(FCFS_BurstTime_textbook.Text);
                tempProcess.arrival_time = FCFS_ACC;
                FCFS_Input_Queue.Enqueue(tempProcess);
                FCFS_QUEUE_SIZE++;

                /*--------------update average waiting time-----------------------*/
                if (FCFS_dataGridView.Rows.Count != 0)
                {
                    FCFS_SumOfWaitTime++;
                    FCFS_sumWaitingTime_textBox.Text = FCFS_SumOfWaitTime.ToString();
                    if (FCFS_QUEUE_SIZE != 0)
                        FCFS_avgWaitingTime_textBox.Text = (FCFS_SumOfWaitTime/FCFS_QUEUE_SIZE).ToString("F2");
                    else
                        FCFS_avgWaitingTime_textBox.Text = "0";
                }
                /*--------------update average turnaround time-----------------------*/
                FCFS_SumOfTurnAroundTime++;      
                FCFS_sumTurnAroundTime_textBox.Text =  FCFS_SumOfTurnAroundTime.ToString();
                if (FCFS_QUEUE_SIZE != 0)
                    FCFS_avgTurnAroundTime_textBox.Text = (FCFS_SumOfTurnAroundTime/FCFS_QUEUE_SIZE).ToString("F2");
                else
                    FCFS_avgTurnAroundTime_textBox.Text = "0";


                FCFS_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time);

                FCFS_ArrivalTime_textbook.Clear();
                FCFS_BurstTime_textbook.Clear();    
            }
        }

        /*----------------------------------static Logic--------------------------------*/
        private void FCFS_Ok_btn_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(FCFS_NoOfProcesses_textbook.Text)
                || (!int.TryParse(FCFS_NoOfProcesses_textbook.Text, out int value2) || value2 <= 0)
               )
            {
               // MessageBox.Show("Input is not a valid integer.");
                return;
            }

            numOfProcess = int.Parse(FCFS_NoOfProcesses_textbook.Text);
            FCFS_Time_flowLayoutPanel.Controls.Clear();
            FCFS_Process_flowLayoutPanel.Controls.Clear();

            FCFS_ArrivalTime_label.Enabled = true;
            FCFS_ArrivalTime_label.Visible = true;
            FCFS_ArrivalTime_textbook.Enabled = true;
            FCFS_ArrivalTime_textbook.Visible = true;
            FCFS_BurstTime_label.Enabled = true;
            FCFS_BurstTime_label.Visible = true;
            FCFS_BurstTime_textbook.Enabled = true;
            FCFS_BurstTime_textbook.Visible = true;

            FCFS_Insert_btn.Enabled = true;
            FCFS_Insert_btn.Visible = true;


            FCFS_Ok_btn.Enabled = false;
            FCFS_NoOfProcesses_textbook.ReadOnly = true;
        }
        private void FCFS_updateScrolling()
        {
            // Recalculate the total width of the panel's contents
            int totalWidth = FCFS_Process_flowLayoutPanel.Controls.Cast<Control>().Sum(control => control.Width + control.Margin.Horizontal);

            // Set the maximum value of the external scrollbar to the total width
            FCFS_hScrollBar.Maximum = totalWidth;

            // Set the small change and large change values of the scrollbar
            FCFS_hScrollBar.SmallChange = 10;
            FCFS_hScrollBar.LargeChange = FCFS_Process_flowLayoutPanel.ClientSize.Width;
        }
        private void FCFS_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            FCFS_Time_flowLayoutPanel.HorizontalScroll.Value = FCFS_hScrollBar.Value;
            FCFS_Process_flowLayoutPanel.HorizontalScroll.Value = FCFS_hScrollBar.Value;
            FCFS_updateScrolling();
        }
        private void FCFS_Static_Logic_Display()
        {
            int noOfIdleSlot = 0;
            /*-----------sort the queue of processes-------*/
            Process[] array = FCFS_Input_Queue.ToArray();
            Array.Sort(array, new ArrivalTimeComparer());

            Process tempProcess;
            for (int i = 0; i < array.Length; i++)
            {
                tempProcess = array[i];
                if (FCFS_ACC < tempProcess.arrival_time)
                {
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = FCFS_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    FCFS_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    FCFS_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*--------------------update FCFS__ACC------------------------*/
                    noOfIdleSlot += (tempProcess.arrival_time - FCFS_ACC);
                    FCFS_ACC = tempProcess.arrival_time;
                    i--;
                }
                else
                {
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = FCFS_ACC.ToString();
                    if (tempProcess.burst_time < BURST_TIME_barrier)
                        tempLabel_Time.Width = tempProcess.burst_time*MIN_PROCESS_SLOT_WIDTH;
                    else
                        tempLabel_Time.Width = MAX_PROCESS_SLOT_WIDTH;      
                    FCFS_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
                    if (tempProcess.burst_time < BURST_TIME_barrier)
                        tempLabel_Process.Width = tempProcess.burst_time*MIN_PROCESS_SLOT_WIDTH;
                    else
                        tempLabel_Process.Width = MAX_PROCESS_SLOT_WIDTH;
                    FCFS_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*--------------------update FCFS_ACC-------------------------*/
                    FCFS_ACC += tempProcess.burst_time;
                    /*--------------average waiting time-----------------------*/
                    FCFS_SumOfWaitTime += (FCFS_ACC- tempProcess.arrival_time-tempProcess.burst_time);
                    FCFS_sumWaitingTime_textBox.Text = FCFS_SumOfWaitTime.ToString();
                    if (FCFS_QUEUE_SIZE != 0)
                        FCFS_avgWaitingTime_textBox.Text = (FCFS_SumOfWaitTime/FCFS_QUEUE_SIZE).ToString("F2");
                    else
                        FCFS_avgWaitingTime_textBox.Text = "0";
                }
            }
            /*---------------average turnaround time--------------------*/
            FCFS_SumOfTurnAroundTime = FCFS_SumOfWaitTime + FCFS_ACC - noOfIdleSlot;
            FCFS_sumTurnAroundTime_textBox.Text = FCFS_SumOfTurnAroundTime.ToString();
            if (FCFS_QUEUE_SIZE != 0)
                FCFS_avgTurnAroundTime_textBox.Text = (FCFS_SumOfTurnAroundTime/FCFS_QUEUE_SIZE).ToString("F2");
            else
                FCFS_avgTurnAroundTime_textBox.Text = "0";
            /*-------------------last time label---------------------------------*/
            WF.Label lastTimeLabel = new WF.Label();
            lastTimeLabel.Text = FCFS_ACC.ToString();
            FCFS_Time_flowLayoutPanel.Controls.Add(lastTimeLabel);
        }       

        /*---------------------------------Dynamic Logic--------------------------------*/
        private void FCFS_Logic()
        {
            Process tempProcess = FCFS_Input_Queue.Dequeue();
            FCFS_NextPossibleSlot = FCFS_ACC + tempProcess.burst_time;
            int counter = tempProcess.burst_time;
            int x = FCFS_ACC;
            for (int i = 0; i < counter; i++)
            {
                FCFS_Display_Queue.Enqueue(new Process(tempProcess.Pid, 1+x, x));
                x++;
            }
        }
        private void FCFS_Display()
        {
            int FCFS_Time_Acc = FCFS_Display_Queue.Peek().arrival_time;
            Process tempProcess;
            tempProcess = FCFS_Display_Queue.Dequeue();
            /*-----------------time chart---------------------------------*/
            WF.Label tempLabel_Time = new WF.Label();
            tempLabel_Time.Text = FCFS_Time_Acc.ToString();
            tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
            if (!FCFS_Page)
                FCFS_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
            else
                FCFS_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
            /*------------------gantt chart code--------------------------*/
            WF.Label tempLabel_Process = new WF.Label();
            tempLabel_Process.Enabled = true;
            tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
            tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
            tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
            tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
            if(!FCFS_Page)
                FCFS_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
            else
                FCFS_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
        }
        private void FCFS_updateTable()
        {
            /*---------------- update table---------------------*/
            foreach (DataGridViewRow row in FCFS_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == FCFS_Display_Queue.Peek().Pid.ToString())
                {
                    int currentValue = Convert.ToInt32(row.Cells[2].Value);
                    if (currentValue != 1)
                        row.Cells[2].Value = (currentValue - 1).ToString();
                    else
                        FCFS_dataGridView.Rows.RemoveAt(row.Index);
                }
            }
            if (FCFS_dataGridView.Rows.Count != 0)
            {
                /*--------------average waiting time-----------------------*/
                FCFS_SumOfWaitTime += FCFS_dataGridView.Rows.Count-1;
                FCFS_sumWaitingTime_textBox.Text = FCFS_SumOfWaitTime.ToString();
                if (FCFS_QUEUE_SIZE != 0)
                    FCFS_avgWaitingTime_textBox.Text = (FCFS_SumOfWaitTime/FCFS_QUEUE_SIZE).ToString("F2");
                else
                    FCFS_avgWaitingTime_textBox.Text = "0";
                /*--------------turnaround waiting time-----------------------*/
                FCFS_SumOfTurnAroundTime += FCFS_dataGridView.Rows.Count;
                FCFS_sumTurnAroundTime_textBox.Text =  FCFS_SumOfTurnAroundTime.ToString();
                if (FCFS_QUEUE_SIZE != 0)
                    FCFS_avgTurnAroundTime_textBox.Text = (FCFS_SumOfTurnAroundTime/FCFS_QUEUE_SIZE).ToString("F2");
                else
                    FCFS_avgTurnAroundTime_textBox.Text = "0";
            }
        }
        private void FCFS_Timer_Tick(object sender, EventArgs e)
        {
            if (!FCFS_Jump)
            {
                if (FCFS_ACC != 0 && FCFS_ACC % MAX_PAGE == 0 && FCFS_Page)
                {
                    FCFS_Time_flowLayoutPanel2.Controls.Clear();
                    FCFS_Process_flowLayoutPanel2.Controls.Clear();
                    FCFS_Time_flowLayoutPanel3.Controls.Clear();
                    FCFS_Process_flowLayoutPanel3.Controls.Clear();
                    FCFS_Page = !FCFS_Page;
                }
                else if (FCFS_ACC != 0 && FCFS_ACC % (MAX_PAGE/2) == 0)
                    FCFS_Page = !FCFS_Page;


                if (FCFS_Input_Queue.Count != 0  && FCFS_ACC == FCFS_NextPossibleSlot)
                {
                    FCFS_Timer.Stop();
                    FCFS_Logic();
                }

                if (FCFS_Display_Queue.Count != 0)
                {
                    FCFS_updateTable();
                    FCFS_Display();
                }
                else
                {
                    FCFS_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = FCFS_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!FCFS_Page)
                        FCFS_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        FCFS_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!FCFS_Page)
                        FCFS_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        FCFS_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }

                FCFS_Timer.Start();
                FCFS_ACC++;
                FCFS_CurrentSlot_label.Text = FCFS_ACC.ToString();
            }
            else
            {
                FCFS_JUMPHandler();
            }
        }
        private void FCFS_JUMPHandler()
        {
            while(true)
            {
                if (FCFS_ACC != 0 && FCFS_ACC % MAX_PAGE == 0 && FCFS_Page)
                {
                    FCFS_Time_flowLayoutPanel2.Controls.Clear();
                    FCFS_Process_flowLayoutPanel2.Controls.Clear();
                    FCFS_Time_flowLayoutPanel3.Controls.Clear();
                    FCFS_Process_flowLayoutPanel3.Controls.Clear();
                    FCFS_Page = !FCFS_Page;
                }
                else if (FCFS_ACC != 0 && FCFS_ACC % (MAX_PAGE/2) == 0)
                    FCFS_Page = !FCFS_Page;


                if (FCFS_Input_Queue.Count != 0 && FCFS_ACC == FCFS_NextPossibleSlot)
                    FCFS_Logic();
                if (FCFS_Display_Queue.Count != 0)
                {
                    FCFS_updateTable();
                    FCFS_Display();
                }
                else
                {
                    FCFS_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = FCFS_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!FCFS_Page)
                        FCFS_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        FCFS_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!FCFS_Page)
                        FCFS_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        FCFS_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }
                FCFS_ACC++;
                FCFS_CurrentSlot_label.Text = FCFS_ACC.ToString();

                if (FCFS_Display_Queue.Count == 0 && FCFS_Input_Queue.Count == 0 || !FCFS_Jump)
                    break;
            }
        }
        private void FCFS_trackBar_Scroll(object sender, EventArgs e)
        {
            if (FCFS_trackBar.Value != 0)
                FCFS_Timer.Interval = FCFS_trackBar.Value*1000;
            else
                FCFS_Timer.Interval = 1000;

        }

        /*----------------------------------Check box handler----------------------------*/
        private void FCFS_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FCFS_Live_checkBox.Checked)
            {
                FCFS_Live = true;
                FCFS_Jump_checkBox.Enabled = true;
                FCFS_Timer.Start();
                FCFS_Insert_btn.Enabled = true;
                FCFS_BurstTime_textbook.Enabled = true;
            }
            else
            {
                FCFS_Live = false;
                FCFS_Jump_checkBox.Enabled = true;
                FCFS_Timer.Stop();
                FCFS_Insert_btn.Enabled = false;
                FCFS_BurstTime_textbook.Enabled = false;
            }
        }
        private void FCFS_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FCFS_Jump_checkBox.Checked)
            {
                FCFS_Jump = true;
            }
            else
            {
                FCFS_Jump = false;
            }
        }

        /*----------------------------------Combo box handler----------------------------*/
        private void FCFS_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FCFS_Mode_comboBox.Text == "Static")
            {
                FCFS_hScrollBar.Enabled = false;
                FCFS_hScrollBar.Visible = false;


                FCFS_Ok_btn.Enabled = true;
                FCFS_Ok_btn.Visible = true;


                FCFS_ArrivalTime_label.Enabled = false;
                FCFS_ArrivalTime_label.Visible = false;
                FCFS_ArrivalTime_textbook.Enabled = false;
                FCFS_ArrivalTime_textbook.Visible = false;


                FCFS_BurstTime_label.Enabled = false;
                FCFS_BurstTime_label.Visible = false;
                FCFS_BurstTime_textbook.Enabled = false;
                FCFS_BurstTime_textbook.Visible = false;


                FCFS_dataGridView.Enabled = true;
                FCFS_dataGridView.Visible = true;


                FCFS_Slot_label.Enabled = false;
                FCFS_Slot_label.Visible = false;
                FCFS_CurrentSlot_label.Enabled = false;
                FCFS_CurrentSlot_label.Visible = false;


                FCFS_Insert_btn.Enabled = false;
                FCFS_Insert_btn.Visible = false;


                FCFS_NoOfProcesses_textbook.Enabled = true;
                FCFS_NoOfProcesses_textbook.Visible = true;
                FCFS_NoOfProcesses_Label.Enabled = true;
                FCFS_NoOfProcesses_Label.Visible = true;


                FCFS_Live_checkBox.Enabled = false;
                FCFS_Live_checkBox.Visible = false;

                FCFS_Jump_checkBox.Enabled = false;
                FCFS_Jump_checkBox.Visible = false;


                FCFS_sumWaitingTime_label.Enabled = false;
                FCFS_sumWaitingTime_label.Visible = false;
                FCFS_sumWaitingTime_textBox.Enabled = false;
                FCFS_sumWaitingTime_textBox.Visible = false;


                FCFS_avgWaitingTime_label.Enabled = false;
                FCFS_avgWaitingTime_label.Visible = false;
                FCFS_avgWaitingTime_textBox.Enabled = false;
                FCFS_avgWaitingTime_textBox.Visible = false;

                FCFS_sumTurnAroundTime_textBox.Enabled = false;
                FCFS_sumTurnAroundTime_textBox.Visible = false;
                FCFS_sumTurnAroundTime_label.Enabled = false;
                FCFS_sumTurnAroundTime_label.Visible = false;

                FCFS_avgTurnAroundTime_textBox.Enabled = false;
                FCFS_avgTurnAroundTime_textBox.Visible = false;
                FCFS_avgTurnAroundTime_label.Enabled = false;
                FCFS_avgTurnAroundTime_label.Visible = false;

                FCFS_trackBar.Enabled = false;
                FCFS_trackBar.Visible = false;
            }
            else if (FCFS_Mode_comboBox.Text == "Dynamic")
            {
                FCFS_trackBar.Enabled = true;
                FCFS_trackBar.Visible = true;

                FCFS_hScrollBar.Enabled = false;
                FCFS_hScrollBar.Visible = false;

                FCFS_Ok_btn.Enabled = false;
                FCFS_Ok_btn.Visible = false;

                FCFS_ArrivalTime_label.Enabled = false;
                FCFS_ArrivalTime_label.Visible = false;
                FCFS_ArrivalTime_textbook.Enabled = false;
                FCFS_ArrivalTime_textbook.Visible = false;

                FCFS_BurstTime_label.Enabled = true;
                FCFS_BurstTime_label.Visible = true;
                FCFS_BurstTime_textbook.Enabled = true;
                FCFS_BurstTime_textbook.Visible = true;

                FCFS_dataGridView.Enabled = true;
                FCFS_dataGridView.Visible = true;

                FCFS_Slot_label.Enabled = true;
                FCFS_Slot_label.Visible = true;
                FCFS_CurrentSlot_label.Enabled = true;
                FCFS_CurrentSlot_label.Visible = true;

                FCFS_Insert_btn.Enabled = true;
                FCFS_Insert_btn.Visible = true;

                FCFS_NoOfProcesses_textbook.Enabled = false;
                FCFS_NoOfProcesses_textbook.Visible = false;
                FCFS_NoOfProcesses_Label.Enabled = false;
                FCFS_NoOfProcesses_Label.Visible = false;

                FCFS_Live_checkBox.Enabled = true;
                FCFS_Live_checkBox.Visible = true;

                FCFS_Jump_checkBox.Enabled = true;
                FCFS_Jump_checkBox.Visible = true;

                FCFS_sumWaitingTime_label.Enabled = true;
                FCFS_sumWaitingTime_label.Visible = true;
                FCFS_sumWaitingTime_textBox.Enabled = true;
                FCFS_sumWaitingTime_textBox.Visible = true;

                FCFS_avgWaitingTime_label.Enabled = true;
                FCFS_avgWaitingTime_label.Visible = true;
                FCFS_avgWaitingTime_textBox.Enabled = true;
                FCFS_avgWaitingTime_textBox.Visible = true;

                FCFS_sumTurnAroundTime_textBox.Enabled = true;
                FCFS_sumTurnAroundTime_textBox.Visible = true;
                FCFS_sumTurnAroundTime_label.Enabled = true;
                FCFS_sumTurnAroundTime_label.Visible = true;

                FCFS_avgTurnAroundTime_textBox.Enabled = true;
                FCFS_avgTurnAroundTime_textBox.Visible = true;
                FCFS_avgTurnAroundTime_label.Enabled = true;
                FCFS_avgTurnAroundTime_label.Visible = true;

                FCFS_sumWaitingTime_textBox.ReadOnly = true;
                FCFS_avgWaitingTime_textBox.ReadOnly = true;
                FCFS_sumTurnAroundTime_textBox.ReadOnly = true;
                FCFS_avgTurnAroundTime_textBox.ReadOnly = true;
            }
        }

        /*--------------------------------------Reset------------------------------------*/
        private void FCFS_Rest()
        {
            FCFS_hScrollBar.Enabled = false;
            FCFS_hScrollBar.Visible = false;

            FCFS_Page = false;
            FCFS_Live = false;
            FCFS_Jump = false;

            FCFS_Timer.Stop();

            FCFS_NoOfProcesses_textbook.ReadOnly = false;
            FCFS_NoOfProcesses_textbook.Clear();

            FCFS_ACC = 0;
            FCFS_NextPossibleSlot = 0;
            FCFS_QUEUE_SIZE = 0;
            FCFS_SumOfWaitTime = 0;
            FCFS_SumOfTurnAroundTime = 0;
            FCFS_CurrentSlot_label.Text = "0";


            FCFS_Input_Queue.Clear();
            FCFS_Display_Queue.Clear();
           
            FCFS_Time_flowLayoutPanel.Controls.Clear();
            FCFS_Process_flowLayoutPanel.Controls.Clear();
            FCFS_Time_flowLayoutPanel2.Controls.Clear();
            FCFS_Process_flowLayoutPanel2.Controls.Clear();
            FCFS_Time_flowLayoutPanel3.Controls.Clear();
            FCFS_Process_flowLayoutPanel3.Controls.Clear();

            FCFS_Ok_btn.Enabled = false;
            FCFS_Ok_btn.Visible = false;

            FCFS_ArrivalTime_label.Enabled = false;
            FCFS_ArrivalTime_label.Visible = false;
            FCFS_ArrivalTime_textbook.Enabled = false;
            FCFS_ArrivalTime_textbook.Clear();
            FCFS_ArrivalTime_textbook.Visible = false;

            FCFS_BurstTime_label.Enabled = false;
            FCFS_BurstTime_label.Visible = false;
            FCFS_BurstTime_textbook.Enabled = false;
            FCFS_BurstTime_textbook.Clear();
            FCFS_BurstTime_textbook.Visible = false;

            FCFS_dataGridView.Enabled = false;
            FCFS_dataGridView.Visible = false;

            FCFS_Slot_label.Enabled = false;
            FCFS_Slot_label.Visible = false;
            FCFS_CurrentSlot_label.Enabled = false;
            FCFS_CurrentSlot_label.Visible = false;

            FCFS_Insert_btn.Enabled = false;
            FCFS_Insert_btn.Visible = false;

            FCFS_NoOfProcesses_textbook.Enabled = false;
            FCFS_NoOfProcesses_textbook.Visible = false;
            FCFS_NoOfProcesses_Label.Enabled = false;
            FCFS_NoOfProcesses_Label.Visible = false;

            FCFS_Live_checkBox.Enabled = false;
            FCFS_Live_checkBox.Visible = false;
            FCFS_Live_checkBox.Checked = false;

            FCFS_Jump_checkBox.Enabled = false;
            FCFS_Jump_checkBox.Visible = false;
            FCFS_Jump_checkBox.Checked = false;

            FCFS_Mode_comboBox.SelectedIndex = -1;
            FCFS_dataGridView.Rows.Clear();

            FCFS_sumWaitingTime_label.Enabled = false;
            FCFS_sumWaitingTime_label.Visible = false;
            FCFS_sumWaitingTime_textBox.Enabled = false;
            FCFS_sumWaitingTime_textBox.Visible = false;
            FCFS_sumWaitingTime_textBox.Text = "0";

            FCFS_avgWaitingTime_label.Enabled = false;
            FCFS_avgWaitingTime_label.Visible = false;
            FCFS_avgWaitingTime_textBox.Enabled = false;
            FCFS_avgWaitingTime_textBox.Visible = false;
            FCFS_avgWaitingTime_textBox.Text = "0";

            FCFS_sumTurnAroundTime_textBox.Enabled = false;
            FCFS_sumTurnAroundTime_textBox.Visible = false;
            FCFS_sumTurnAroundTime_label.Enabled = false;
            FCFS_sumTurnAroundTime_label.Visible = false;
            FCFS_sumTurnAroundTime_textBox.Text = "0";

            FCFS_avgTurnAroundTime_textBox.Enabled = false;
            FCFS_avgTurnAroundTime_textBox.Visible = false;
            FCFS_avgTurnAroundTime_label.Enabled = false;
            FCFS_avgTurnAroundTime_label.Visible = false;
            FCFS_avgTurnAroundTime_textBox.Text = "0";

            FCFS_trackBar.Enabled = false;
            FCFS_trackBar.Visible = false;
            FCFS_trackBar.Value = 0;
            FCFS_Timer.Interval = 1000;
        }
        private void FCFS_Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /*--------------------------------------------------------End of FCFS functions--------------------------------------------------------*/






        /*--------------------------------------------------------Start of SJF functions--------------------------------------------------------*/
        private void SJF_Insert_btn_Click(object sender, EventArgs e)
        {
            if (SJF_Mode_comboBox.Text == "Static")
            {
                if (
                      string.IsNullOrEmpty(SJF_ArrivalTime_textbook.Text)
                   || string.IsNullOrEmpty(SJF_BurstTime_textbook.Text)
                   || (!int.TryParse(SJF_ArrivalTime_textbook.Text, out int value1) || value1 < 0)
                   || (!int.TryParse(SJF_BurstTime_textbook.Text, out int value2) || value2 <= 0)
                  )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                Process tempProcess = new Process();
                tempProcess.Pid = SJF_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(SJF_BurstTime_textbook.Text);
                tempProcess.arrival_time = int.Parse(SJF_ArrivalTime_textbook.Text);

                SJF_Input_Queue.Enqueue(tempProcess);
                SJF_QUEUE_SIZE++;


                SJF_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time, tempProcess.burst_time);

                SJF_ArrivalTime_textbook.Clear();
                SJF_BurstTime_textbook.Clear();

                if (numOfProcess == SJF_QUEUE_SIZE)
                {
                    SJF_Insert_btn.Enabled = false;

                    SJF_Static_Logic();
                    SJF_Static_Display();

                    SJF_ArrivalTime_textbook.Enabled = false;
                    SJF_ArrivalTime_textbook.Clear();

                    SJF_BurstTime_textbook.Enabled = false;
                    SJF_BurstTime_textbook.Clear();

                    SJF_Version_checkBox.Enabled = false;

                    SJF_hScrollBar.Enabled = true;
                    SJF_hScrollBar.Visible = true;

                    SJF_sumWaitingTime_label.Enabled = true;
                    SJF_sumWaitingTime_label.Visible = true;
                    SJF_avgWaitingTime_label.Visible =true;
                    SJF_avgWaitingTime_label.Enabled =true;
                    SJF_sumTurnAroundTime_label.Visible = true;
                    SJF_sumTurnAroundTime_label.Enabled = true;
                    SJF_avgTurnAroundTime_label.Visible =true;
                    SJF_avgTurnAroundTime_label.Enabled =true;

                    SJF_sumWaitingTime_textBox.Enabled = true;
                    SJF_sumWaitingTime_textBox.Visible = true;
                    SJF_avgWaitingTime_textBox.Enabled = true;
                    SJF_avgWaitingTime_textBox.Visible = true;
                    SJF_sumTurnAroundTime_textBox.Enabled = true;
                    SJF_sumTurnAroundTime_textBox.Visible = true;
                    SJF_avgTurnAroundTime_textBox.Enabled = true;
                    SJF_avgTurnAroundTime_textBox.Visible = true;
                    SJF_sumWaitingTime_textBox.ReadOnly = true;
                    SJF_avgWaitingTime_textBox.ReadOnly = true;
                    SJF_sumTurnAroundTime_textBox.ReadOnly = true;
                    SJF_avgTurnAroundTime_textBox.ReadOnly = true;
                }
            }
            else if (SJF_Mode_comboBox.Text == "Dynamic")
            {
                if (
                     string.IsNullOrEmpty(SJF_BurstTime_textbook.Text)
                    || (!int.TryParse(SJF_BurstTime_textbook.Text, out int value2) || value2 <= 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                Process tempProcess = new Process();
                tempProcess.Pid = SJF_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(SJF_BurstTime_textbook.Text);
                tempProcess.arrival_time = SJF_ACC;

                SJF_Input_Queue.Enqueue(tempProcess);
                SJF_QUEUE_SIZE++;

                /*--------------update average waiting time-----------------------*/
                if (SJF_dataGridView.Rows.Count != 0)
                {
                    SJF_SumOfWaitTime++;
                    SJF_sumWaitingTime_textBox.Text = SJF_SumOfWaitTime.ToString();
                    if (SJF_QUEUE_SIZE != 0)
                        SJF_avgWaitingTime_textBox.Text = (SJF_SumOfWaitTime/SJF_QUEUE_SIZE).ToString("F2");
                    else
                        SJF_avgWaitingTime_textBox.Text = "0";
                }
                /*--------------update average turnaround time-----------------------*/
                SJF_SumOfTurnAroundTime++;
                SJF_sumTurnAroundTime_textBox.Text =  SJF_SumOfTurnAroundTime.ToString();
                if (SJF_QUEUE_SIZE != 0)
                    SJF_avgTurnAroundTime_textBox.Text = (SJF_SumOfTurnAroundTime/SJF_QUEUE_SIZE).ToString("F2");
                else
                    SJF_avgTurnAroundTime_textBox.Text = "0";


                SJF_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time, tempProcess.burst_time);

                SJF_ArrivalTime_textbook.Clear();
                SJF_BurstTime_textbook.Clear();
            }
        }

        /*-------------------------------------static Logic------------------------------*/
        private void SJF_Ok_btn_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrEmpty(SJF_NoOfProcesses_textbook.Text)
               || (!int.TryParse(SJF_NoOfProcesses_textbook.Text, out int value2) || value2 <= 0)
              )
            {
                // MessageBox.Show("Input is not a valid integer.");
                return;
            }

            numOfProcess = int.Parse(SJF_NoOfProcesses_textbook.Text);
            SJF_Time_flowLayoutPanel.Controls.Clear();
            SJF_Process_flowLayoutPanel.Controls.Clear();

            SJF_ArrivalTime_label.Enabled = true;
            SJF_ArrivalTime_label.Visible = true;
            SJF_ArrivalTime_textbook.Enabled = true;
            SJF_ArrivalTime_textbook.Visible = true;
            SJF_BurstTime_label.Enabled = true;
            SJF_BurstTime_label.Visible = true;
            SJF_BurstTime_textbook.Enabled = true;
            SJF_BurstTime_textbook.Visible = true;

            SJF_Insert_btn.Enabled = true;
            SJF_Insert_btn.Visible = true;


            SJF_Ok_btn.Enabled = false;
            SJF_NoOfProcesses_textbook.ReadOnly = true;
        }
        private void SJF_Static_Logic()
        {
            int len, timeGivenToProcessOnCpu, first_index, last_index;
            Process[] array;
            while (true)
            {
                /*-----------------------------------------------------sort the queue of processes------------------------------------------------------------*/
                array = SJF_Input_Queue.ToArray();
                Array.Sort(array, new ArrivalTimeComparer());
                len = SJF_Input_Queue.Count;
                first_index = 0;
                SJF_ACC = array[0].arrival_time;

                /*-----select  processes that have min arrival time then choose from them the process whose burst time is minimum -------*/
                for (int i = 0; i<len; i++)
                {
                    if (array[i].arrival_time <= SJF_ACC && array[i].burst_time < array[first_index].burst_time)
                        first_index = i;
                }
                last_index = first_index;
                while (last_index < len-1 && array[first_index].arrival_time == array[last_index+1].arrival_time)
                    last_index++;

                /*------------------------OPTION Run part of remaining time-------------*/
                if (SJF_Preemtive_Version
                    && last_index < len-1
                    && array[first_index].burst_time + array[first_index].arrival_time > array[last_index+1].arrival_time)
                {
                    timeGivenToProcessOnCpu = array[last_index+1].arrival_time - array[last_index].arrival_time;
                    array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);
                    SJF_Display_Queue.Enqueue(array[first_index].copy(timeGivenToProcessOnCpu));
                }
                /*----------------------------OPTION Run all remaining time-------------*/
                else
                {
                    timeGivenToProcessOnCpu = array[first_index].burst_time;
                    array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);
                    SJF_Display_Queue.Enqueue(array[first_index].copy(timeGivenToProcessOnCpu));
                }
                /*-----------------------Update arrival time-----------------------------*/
                for (int i = 0; i<len; i++)
                {
                    if (array[i].arrival_time == SJF_ACC)
                        array[i].increaseArrivalTime(timeGivenToProcessOnCpu);
                    else if (array[i].arrival_time < timeGivenToProcessOnCpu + SJF_ACC)
                        array[i].arrival_time = timeGivenToProcessOnCpu + SJF_ACC;
                }
                SJF_Input_Queue = new Queue<Process>(array);
                SJF_Input_Queue = new Queue<Process>(SJF_Input_Queue.Where(obj => obj.burst_time != 0));
                /*--------------------Check Fininshing algorith---------------------------*/
                if (SJF_Input_Queue.Count == 0)
                    break;
            }
        }
        private void SJF_updateScrolling()
        {
            // Recalculate the total width of the panel's contents
            int totalWidth = SJF_Process_flowLayoutPanel.Controls.Cast<Control>().Sum(control => control.Width + control.Margin.Horizontal);
            // Set the maximum value of the external scrollbar to the total width
            SJF_hScrollBar.Maximum = totalWidth;
            // Set the small change and large change values of the scrollbar
            SJF_hScrollBar.SmallChange = 10;
            SJF_hScrollBar.LargeChange = SJF_Process_flowLayoutPanel.ClientSize.Width;
        }
        private void SJF_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            SJF_Time_flowLayoutPanel.HorizontalScroll.Value = SJF_hScrollBar.Value;
            SJF_Process_flowLayoutPanel.HorizontalScroll.Value = SJF_hScrollBar.Value;
            SJF_updateScrolling();
        }
        private void SJF_Static_Display()
        {
            int noOfIdleSlot = 0;
            int SJF_Time_Acc = 0;
            Process tempProcess;
            while (SJF_Display_Queue.Count != 0)
            {
                tempProcess = SJF_Display_Queue.Peek();
                if (SJF_Time_Acc < tempProcess.arrival_time)
                {
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = SJF_Time_Acc.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    SJF_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    SJF_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*--------------------update SJF__ACC------------------------*/
                    noOfIdleSlot =+(tempProcess.arrival_time- SJF_Time_Acc);
                    SJF_Time_Acc = tempProcess.arrival_time;
                }
                else
                {
                    tempProcess = SJF_Display_Queue.Dequeue();
                    /*----------------------------------time chart---------------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = SJF_Time_Acc.ToString();
                    if (tempProcess.burst_time-tempProcess.arrival_time < BURST_TIME_barrier)
                        tempLabel_Time.Width = (tempProcess.burst_time-tempProcess.arrival_time) *MIN_PROCESS_SLOT_WIDTH;
                    else
                        tempLabel_Time.Width =  MAX_PROCESS_SLOT_WIDTH;
                    SJF_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------------------gantt chart code--------------------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
                    if (tempProcess.burst_time-tempProcess.arrival_time < BURST_TIME_barrier)
                        tempLabel_Process.Width = (tempProcess.burst_time-tempProcess.arrival_time) *MIN_PROCESS_SLOT_WIDTH;
                    else
                        tempLabel_Process.Width = MAX_PROCESS_SLOT_WIDTH;   
                    SJF_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*---------------------------------update SJF_ACC-------------------------------------*/
                    SJF_Time_Acc += (tempProcess.burst_time-tempProcess.arrival_time);

                    foreach(DataGridViewRow row in SJF_dataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == tempProcess.Pid.ToString())
                        {
                            int currentValue = Convert.ToInt32(row.Cells[3].Value);
                            if (currentValue != tempProcess.burst_time-tempProcess.arrival_time)
                                row.Cells[3].Value = (currentValue - tempProcess.burst_time+tempProcess.arrival_time).ToString();
                            else
                            {
                                /*--------------update average waiting time-----------------------*/
                                SJF_SumOfWaitTime += (SJF_Time_Acc-Convert.ToInt32(row.Cells[1].Value)-Convert.ToInt32(row.Cells[2].Value));
                                SJF_sumWaitingTime_textBox.Text = SJF_SumOfWaitTime.ToString();
                                if (SJF_QUEUE_SIZE != 0)
                                    SJF_avgWaitingTime_textBox.Text = (SJF_SumOfWaitTime/SJF_QUEUE_SIZE).ToString("F2");
                                else
                                    SJF_avgWaitingTime_textBox.Text = "0";
                            }
                            break;
                        }
                    }
                }
            }
            /*---------------update average turnaround time--------------------*/
            SJF_SumOfTurnAroundTime = SJF_SumOfWaitTime + SJF_Time_Acc - noOfIdleSlot;
            SJF_sumTurnAroundTime_textBox.Text = SJF_SumOfTurnAroundTime.ToString();
            if (SJF_QUEUE_SIZE != 0)
                SJF_avgTurnAroundTime_textBox.Text = (SJF_SumOfTurnAroundTime/SJF_QUEUE_SIZE).ToString("F2");
            else
                SJF_avgTurnAroundTime_textBox.Text = "0";
            /*-----------------last time label---------------------------------*/
            WF.Label lastTimeLabel = new WF.Label();
            lastTimeLabel.Text = SJF_Time_Acc.ToString();
            SJF_Time_flowLayoutPanel.Controls.Add(lastTimeLabel);
        }

        /*------------------------------------Dynamic Logic------------------------------*/
        private void SJF_Logic()
        {
            int len, timeGivenToProcessOnCpu, first_index, last_index;
            Process[] array;

            /*---------------sort the queue of processes---------*/
            array = SJF_Input_Queue.ToArray();
            Array.Sort(array, new ArrivalTimeComparer());
            len = SJF_Input_Queue.Count;
            first_index = 0;
            SJF_ACC = array[0].arrival_time;
            /*-----from processes that have min arrival time choose the process whose burst time is minimum -------*/
            for (int i = 0; i<len; i++)
            {
                if (array[i].arrival_time <= SJF_ACC && array[i].burst_time < array[first_index].burst_time)
                    first_index = i;
            }
            last_index = first_index;
            while (last_index < len-1 && array[first_index].arrival_time == array[last_index+1].arrival_time)
                last_index++;
            /*------------------------OPTION Add 1S of process to Display Queue---------------*/
            if (SJF_Preemtive_Version)
            {
                timeGivenToProcessOnCpu = 1;
                array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);

                SJF_Display_Queue.Enqueue(array[first_index].copy(timeGivenToProcessOnCpu));
            }
            /*---------------OPTION Add many 1s of process to Display Queue-------------------*/
            else
            {
                timeGivenToProcessOnCpu = array[first_index].burst_time;
                array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);

                int counter = timeGivenToProcessOnCpu;
                int x = array[first_index].arrival_time;
                for (int i = 0; i < counter; i++)
                    SJF_Display_Queue.Enqueue(new Process(array[first_index].Pid, 1+x, x++));
            }

            SJF_NextPossibleSlot = SJF_ACC + timeGivenToProcessOnCpu;
            /*-------------------Update arrival time----------------------------------------------*/
            for (int i = 0; i<len; i++)
            {
                if (array[i].arrival_time == SJF_ACC)
                    array[i].increaseArrivalTime(timeGivenToProcessOnCpu);
                else if (array[i].arrival_time < timeGivenToProcessOnCpu + SJF_ACC)
                    array[i].arrival_time = timeGivenToProcessOnCpu + SJF_ACC;
            }
            SJF_Input_Queue = new Queue<Process>(array);
            SJF_Input_Queue = new Queue<Process>(SJF_Input_Queue.Where(obj => obj.burst_time != 0));
        }
        private void SJF_Display()
        {
            int SJF_Time_Acc = SJF_Display_Queue.Peek().arrival_time;
            Process tempProcess;

            tempProcess = SJF_Display_Queue.Dequeue();
            /*----------------------------------time chart---------------------------------------*/
            WF.Label tempLabel_Time = new WF.Label();
            tempLabel_Time.Text = SJF_Time_Acc.ToString();
            tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
            if (!SJF_Page)
                SJF_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
            else
                SJF_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
            /*------------------------------gantt chart code--------------------------------------*/
            WF.Label tempLabel_Process = new WF.Label();
            tempLabel_Process.Enabled = true;
            tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
            tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
            tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
            tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
            if (!SJF_Page)
                SJF_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
            else
                SJF_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
        }
        private void SJF_updateTable()
        {
            /*---------------- update table---------------------*/
            foreach (DataGridViewRow row in SJF_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == SJF_Display_Queue.Peek().Pid.ToString())
                {
                    int currentValue = Convert.ToInt32(row.Cells[2].Value);
                    if (currentValue != 1)
                        row.Cells[2].Value = (currentValue - 1).ToString();
                    else
                        SJF_dataGridView.Rows.RemoveAt(row.Index);

                    break;
                }
            }
            if (SJF_dataGridView.Rows.Count != 0)
            {
                /*--------------average waiting time-----------------------*/
                SJF_SumOfWaitTime += SJF_dataGridView.Rows.Count-1;
                SJF_sumWaitingTime_textBox.Text = SJF_SumOfWaitTime.ToString();
                if (SJF_QUEUE_SIZE != 0)
                    SJF_avgWaitingTime_textBox.Text = (SJF_SumOfWaitTime/SJF_QUEUE_SIZE).ToString("F2");
                else
                    SJF_avgWaitingTime_textBox.Text = "0";
                /*--------------turnaround waiting time-----------------------*/
                SJF_SumOfTurnAroundTime += SJF_dataGridView.Rows.Count;
                SJF_sumTurnAroundTime_textBox.Text = SJF_SumOfTurnAroundTime.ToString();
                if (SJF_QUEUE_SIZE != 0)
                    SJF_avgTurnAroundTime_textBox.Text = (SJF_SumOfTurnAroundTime/SJF_QUEUE_SIZE).ToString("F2");
                else
                    SJF_avgTurnAroundTime_textBox.Text = "0";
            }
        }

        bool SJF_Page = false;
        private void SJF_Timer_Tick(object sender, EventArgs e)
        {
            if (!SJF_Jump)
            {
                if (SJF_ACC != 0 && SJF_ACC %MAX_PAGE == 0 && SJF_Page)
                {
                    SJF_Time_flowLayoutPanel2.Controls.Clear();
                    SJF_Process_flowLayoutPanel2.Controls.Clear();
                    SJF_Time_flowLayoutPanel3.Controls.Clear();
                    SJF_Process_flowLayoutPanel3.Controls.Clear();
                    SJF_Page = !SJF_Page;
                }
                else if (SJF_ACC != 0 && SJF_ACC % (MAX_PAGE/2) == 0)
                    SJF_Page = !SJF_Page;

                if (!SJF_Preemtive_Version && SJF_Input_Queue.Count != 0 && SJF_ACC == SJF_NextPossibleSlot)
                {
                    SJF_Timer.Stop();
                    foreach (Process obj in SJF_Input_Queue)
                    {
                        if (obj.arrival_time < SJF_ACC)
                            obj.arrival_time = SJF_ACC;
                    }
                    SJF_Logic();
                }
                else if (SJF_Preemtive_Version && SJF_Input_Queue.Count != 0)
                {
                    SJF_Timer.Stop();
                    SJF_Logic();
                }

                if (SJF_Display_Queue.Count != 0)
                {
                    SJF_updateTable();
                    SJF_Display();
                }
                else
                {
                    SJF_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = SJF_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!SJF_Page)
                        SJF_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        SJF_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!SJF_Page)
                        SJF_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        SJF_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }
                SJF_Timer.Start();
                SJF_ACC++;
                SJF_CurrentSlot_label.Text = SJF_ACC.ToString();
            }
            else
            {
                SJF_JUMPHandler();
            }
        }
        private void SJF_JUMPHandler()
        {
            while (true)
            {
                if (SJF_ACC != 0 && SJF_ACC %MAX_PAGE == 0 && SJF_Page)
                {
                    SJF_Time_flowLayoutPanel2.Controls.Clear();
                    SJF_Process_flowLayoutPanel2.Controls.Clear();
                    SJF_Time_flowLayoutPanel3.Controls.Clear();
                    SJF_Process_flowLayoutPanel3.Controls.Clear();
                    SJF_Page = !SJF_Page;
                }
                else if (SJF_ACC != 0 && SJF_ACC % (MAX_PAGE/2) == 0)
                    SJF_Page = !SJF_Page;


                if (SJF_Input_Queue.Count != 0 && SJF_ACC == SJF_NextPossibleSlot)
                    SJF_Logic();
                if (SJF_Display_Queue.Count != 0)
                {
                    SJF_updateTable();
                    SJF_Display();
                }
                else
                {
                    SJF_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = SJF_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!SJF_Page)
                        SJF_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        SJF_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!SJF_Page)
                        SJF_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        SJF_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }
                SJF_ACC++;
                SJF_CurrentSlot_label.Text = SJF_ACC.ToString();

                if (SJF_Display_Queue.Count == 0 && SJF_Input_Queue.Count == 0 || !SJF_Jump)
                    break;
            }
        }
        private void SJF_trackBar_Scroll(object sender, EventArgs e)
        {
            if (SJF_trackBar.Value != 0)
                SJF_Timer.Interval = SJF_trackBar.Value*1000;
            else
                SJF_Timer.Interval = 1000;
        }
        /*-------------------------------------Check box handler--------------------------*/
        private void SJF_Version_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SJF_Version_checkBox.Checked)
                SJF_Preemtive_Version = true;
            else
                SJF_Preemtive_Version = false;
        }
        private void SJF_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SJF_Live_checkBox.Checked)
            {
                SJF_Live = true;
                SJF_Jump_checkBox.Enabled = true;
                SJF_Timer.Start();
                SJF_Insert_btn.Enabled = true;
                SJF_BurstTime_textbook.Enabled = true;
            }
            else
            {
                SJF_Live = false;
                SJF_Jump_checkBox.Enabled = true;
                SJF_Timer.Stop();
                SJF_Insert_btn.Enabled = false;
                SJF_BurstTime_textbook.Enabled = false;
            }
        }
        private void SJF_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SJF_Jump_checkBox.Checked)
            {
                SJF_Jump = true;
            }
            else
            {
                SJF_Jump = false;
            }
        }

        /*----------------------------------Combo box handler----------------------------*/
        private void SJF_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SJF_Mode_comboBox.Text == "Static")
            {
                SJF_hScrollBar.Enabled = false;
                SJF_hScrollBar.Visible = false;


                SJF_Ok_btn.Enabled = true;
                SJF_Ok_btn.Visible = true;


                SJF_ArrivalTime_label.Enabled = false;
                SJF_ArrivalTime_label.Visible = false;
                SJF_ArrivalTime_textbook.Enabled = false;
                SJF_ArrivalTime_textbook.Visible = false;


                SJF_BurstTime_label.Enabled = false;
                SJF_BurstTime_label.Visible = false;
                SJF_BurstTime_textbook.Enabled = false;
                SJF_BurstTime_textbook.Visible = false;


                SJF_dataGridView.Enabled = true;
                SJF_dataGridView.Visible = true;


                SJF_Slot_label.Enabled = false;
                SJF_Slot_label.Visible = false;
                SJF_CurrentSlot_label.Enabled = false;
                SJF_CurrentSlot_label.Visible = false;


                SJF_Insert_btn.Enabled = false;
                SJF_Insert_btn.Visible = false;


                SJF_NoOfProcesses_textbook.Enabled = true;
                SJF_NoOfProcesses_textbook.Visible = true;
                SJF_NoOfProcesses_Label.Enabled = true;
                SJF_NoOfProcesses_Label.Visible = true;


                SJF_Live_checkBox.Enabled = false;
                SJF_Live_checkBox.Visible = false;

                SJF_Jump_checkBox.Enabled = false;
                SJF_Jump_checkBox.Visible = false;


                SJF_sumWaitingTime_label.Enabled = false;
                SJF_sumWaitingTime_label.Visible = false;
                SJF_sumWaitingTime_textBox.Enabled = false;
                SJF_sumWaitingTime_textBox.Visible = false;


                SJF_avgWaitingTime_label.Enabled = false;
                SJF_avgWaitingTime_label.Visible = false;
                SJF_avgWaitingTime_textBox.Enabled = false;
                SJF_avgWaitingTime_textBox.Visible = false;

                SJF_sumTurnAroundTime_textBox.Enabled = false;
                SJF_sumTurnAroundTime_textBox.Visible = false;
                SJF_sumTurnAroundTime_label.Enabled = false;
                SJF_sumTurnAroundTime_label.Visible = false;

                SJF_avgTurnAroundTime_textBox.Enabled = false;
                SJF_avgTurnAroundTime_textBox.Visible = false;
                SJF_avgTurnAroundTime_label.Enabled = false;
                SJF_avgTurnAroundTime_label.Visible = false;

                SJF_Version_checkBox.Enabled = true;
                SJF_Version_checkBox.Visible = true;

                SJF_trackBar.Enabled = false;
                SJF_trackBar.Visible = false;
            }
            else if (SJF_Mode_comboBox.Text == "Dynamic")
            {
                SJF_trackBar.Enabled = true;
                SJF_trackBar.Visible = true;

                SJF_hScrollBar.Enabled = false;
                SJF_hScrollBar.Visible = false;

                SJF_Ok_btn.Enabled = false;
                SJF_Ok_btn.Visible = false;

                SJF_ArrivalTime_label.Enabled = false;
                SJF_ArrivalTime_label.Visible = false;
                SJF_ArrivalTime_textbook.Enabled = false;
                SJF_ArrivalTime_textbook.Visible = false;

                SJF_BurstTime_label.Enabled = true;
                SJF_BurstTime_label.Visible = true;
                SJF_BurstTime_textbook.Enabled = true;
                SJF_BurstTime_textbook.Visible = true;

                SJF_dataGridView.Enabled = true;
                SJF_dataGridView.Visible = true;

                SJF_Slot_label.Enabled = true;
                SJF_Slot_label.Visible = true;
                SJF_CurrentSlot_label.Enabled = true;
                SJF_CurrentSlot_label.Visible = true;

                SJF_Insert_btn.Enabled = true;
                SJF_Insert_btn.Visible = true;

                SJF_NoOfProcesses_textbook.Enabled = false;
                SJF_NoOfProcesses_textbook.Visible = false;
                SJF_NoOfProcesses_Label.Enabled = false;
                SJF_NoOfProcesses_Label.Visible = false;

                SJF_Live_checkBox.Enabled = true;
                SJF_Live_checkBox.Visible = true;

                SJF_Jump_checkBox.Enabled = true;
                SJF_Jump_checkBox.Visible = true;

                SJF_sumWaitingTime_label.Enabled = true;
                SJF_sumWaitingTime_label.Visible = true;
                SJF_sumWaitingTime_textBox.Enabled = true;
                SJF_sumWaitingTime_textBox.Visible = true;

                SJF_avgWaitingTime_label.Enabled = true;
                SJF_avgWaitingTime_label.Visible = true;
                SJF_avgWaitingTime_textBox.Enabled = true;
                SJF_avgWaitingTime_textBox.Visible = true;

                SJF_sumTurnAroundTime_textBox.Enabled = true;
                SJF_sumTurnAroundTime_textBox.Visible = true;
                SJF_sumTurnAroundTime_label.Enabled = true;
                SJF_sumTurnAroundTime_label.Visible = true;

                SJF_avgTurnAroundTime_textBox.Enabled = true;
                SJF_avgTurnAroundTime_textBox.Visible = true;
                SJF_avgTurnAroundTime_label.Enabled = true;
                SJF_avgTurnAroundTime_label.Visible = true;

                SJF_sumWaitingTime_textBox.ReadOnly = true;
                SJF_avgWaitingTime_textBox.ReadOnly = true;
                SJF_sumTurnAroundTime_textBox.ReadOnly = true;
                SJF_avgTurnAroundTime_textBox.ReadOnly = true;

                SJF_Version_checkBox.Enabled = true;
                SJF_Version_checkBox.Visible = true;
            }
        }

        /*--------------------------------------Reset------------------------------------*/
        private void SJF_Rest()
        {
            SJF_hScrollBar.Enabled = false;
            SJF_hScrollBar.Visible = false;

            SJF_Page = false;
            SJF_Live = false;
            SJF_Jump = false;

            SJF_Timer.Stop();

            SJF_NoOfProcesses_textbook.ReadOnly = false;
            SJF_NoOfProcesses_textbook.Clear();

            SJF_ACC = 0;
            SJF_NextPossibleSlot = 0;
            SJF_QUEUE_SIZE = 0;
            SJF_SumOfWaitTime = 0;
            SJF_SumOfTurnAroundTime = 0;
            SJF_CurrentSlot_label.Text = "0";


            SJF_Input_Queue.Clear();
            SJF_Display_Queue.Clear();

            SJF_Time_flowLayoutPanel.Controls.Clear();
            SJF_Process_flowLayoutPanel.Controls.Clear();
            SJF_Time_flowLayoutPanel2.Controls.Clear();
            SJF_Process_flowLayoutPanel2.Controls.Clear();
            SJF_Time_flowLayoutPanel3.Controls.Clear();
            SJF_Process_flowLayoutPanel3.Controls.Clear();

            SJF_Ok_btn.Enabled = false;
            SJF_Ok_btn.Visible = false;

            SJF_ArrivalTime_label.Enabled = false;
            SJF_ArrivalTime_label.Visible = false;
            SJF_ArrivalTime_textbook.Enabled = false;
            SJF_ArrivalTime_textbook.Clear();
            SJF_ArrivalTime_textbook.Visible = false;

            SJF_BurstTime_label.Enabled = false;
            SJF_BurstTime_label.Visible = false;
            SJF_BurstTime_textbook.Enabled = false;
            SJF_BurstTime_textbook.Clear();
            SJF_BurstTime_textbook.Visible = false;

            SJF_dataGridView.Enabled = false;
            SJF_dataGridView.Visible = false;

            SJF_Slot_label.Enabled = false;
            SJF_Slot_label.Visible = false;
            SJF_CurrentSlot_label.Enabled = false;
            SJF_CurrentSlot_label.Visible = false;

            SJF_Insert_btn.Enabled = false;
            SJF_Insert_btn.Visible = false;

            SJF_NoOfProcesses_textbook.Enabled = false;
            SJF_NoOfProcesses_textbook.Visible = false;
            SJF_NoOfProcesses_Label.Enabled = false;
            SJF_NoOfProcesses_Label.Visible = false;

            SJF_Live_checkBox.Enabled = false;
            SJF_Live_checkBox.Visible = false;
            SJF_Live_checkBox.Checked = false;

            SJF_Jump_checkBox.Enabled = false;
            SJF_Jump_checkBox.Visible = false;
            SJF_Jump_checkBox.Checked = false;

            SJF_Mode_comboBox.SelectedIndex = -1;
            SJF_dataGridView.Rows.Clear();

            SJF_sumWaitingTime_label.Enabled = false;
            SJF_sumWaitingTime_label.Visible = false;
            SJF_sumWaitingTime_textBox.Enabled = false;
            SJF_sumWaitingTime_textBox.Visible = false;
            SJF_sumWaitingTime_textBox.Text = "0";

            SJF_avgWaitingTime_label.Enabled = false;
            SJF_avgWaitingTime_label.Visible = false;
            SJF_avgWaitingTime_textBox.Enabled = false;
            SJF_avgWaitingTime_textBox.Visible = false;
            SJF_avgWaitingTime_textBox.Text = "0";

            SJF_sumTurnAroundTime_textBox.Enabled = false;
            SJF_sumTurnAroundTime_textBox.Visible = false;
            SJF_sumTurnAroundTime_label.Enabled = false;
            SJF_sumTurnAroundTime_label.Visible = false;
            SJF_sumTurnAroundTime_textBox.Text = "0";

            SJF_avgTurnAroundTime_textBox.Enabled = false;
            SJF_avgTurnAroundTime_textBox.Visible = false;
            SJF_avgTurnAroundTime_label.Enabled = false;
            SJF_avgTurnAroundTime_label.Visible = false;
            SJF_avgTurnAroundTime_textBox.Text = "0";

            SJF_Version_checkBox.Checked = false;
            SJF_Version_checkBox.Enabled = false;
            SJF_Version_checkBox.Visible = false;

            SJF_trackBar.Enabled = false;
            SJF_trackBar.Visible = false;
            SJF_trackBar.Value = 0;
            SJF_Timer.Interval = 1000;
        }
        private void SJF_Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /*--------------------------------------------------------End of SJF functions--------------------------------------------------------*/






        /*--------------------------------------------------------Start of PIOR functions--------------------------------------------------------*/
        private void PIOR_Insert_btn_Click(object sender, EventArgs e)
        {
            if (PIOR_Mode_comboBox.Text == "Static")
            {
                if (
                     string.IsNullOrEmpty(PIOR_ArrivalTime_textbook.Text)
                  || string.IsNullOrEmpty(PIOR_BurstTime_textbook.Text)
                  || string.IsNullOrEmpty(PIOR_Piority_textbook.Text)
                  || (!int.TryParse(PIOR_ArrivalTime_textbook.Text, out int value1) || value1 < 0)
                  || (!int.TryParse(PIOR_BurstTime_textbook.Text, out int value2) || value2 <= 0)
                  || (!int.TryParse(PIOR_Piority_textbook.Text, out int value3) || value3 < 0)
                 )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }


                Process tempProcess = new Process();
                tempProcess.Pid = PIOR_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(PIOR_BurstTime_textbook.Text);
                tempProcess.piority  = int.Parse(PIOR_Piority_textbook.Text);

                tempProcess.arrival_time = int.Parse(PIOR_ArrivalTime_textbook.Text);

                PIOR_Input_Queue.Enqueue(tempProcess);
                PIOR_QUEUE_SIZE++;

                PIOR_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time, tempProcess.piority, tempProcess.burst_time);

                PIOR_ArrivalTime_textbook.Clear();
                PIOR_BurstTime_textbook.Clear();
                PIOR_Piority_textbook.Clear();


                if (numOfProcess == PIOR_QUEUE_SIZE)
                {    
                    PIOR_Insert_btn.Enabled = false;

                    PIOR_Static_Logic();
                    PIOR_Static_Display();

                    PIOR_ArrivalTime_textbook.Enabled = false;
                    PIOR_ArrivalTime_textbook.Clear();

                    PIOR_BurstTime_textbook.Enabled = false;
                    PIOR_BurstTime_textbook.Clear();

                    PIOR_Version_checkBox.Enabled = false;
                    PIOR_Piority_textbook.Enabled = false;

                    PIOR_hScrollBar.Enabled = true;
                    PIOR_hScrollBar.Visible = true;

                    PIOR_sumWaitingTime_label.Enabled = true;
                    PIOR_sumWaitingTime_label.Visible = true;
                    PIOR_avgWaitingTime_label.Visible =true;
                    PIOR_avgWaitingTime_label.Enabled =true;
                    PIOR_sumTurnAroundTime_textBox.Visible = true;
                    PIOR_sumTurnAroundTime_textBox.Enabled = true;
                    PIOR_avgTurnAroundTime_label.Visible =true;
                    PIOR_avgTurnAroundTime_label.Enabled =true;

                    PIOR_sumWaitingTime_textBox.Enabled = true;
                    PIOR_sumWaitingTime_textBox.Visible = true;
                    PIOR_avgWaitingTime_textBox.Enabled = true;
                    PIOR_avgWaitingTime_textBox.Visible = true;
                    PIOR_sumTurnAroundTime_label.Enabled = true;
                    PIOR_sumTurnAroundTime_label.Visible = true;
                    PIOR_avgTurnAroundTime_textBox.Enabled = true;
                    PIOR_avgTurnAroundTime_textBox.Visible = true;
                    PIOR_sumWaitingTime_textBox.ReadOnly = true;
                    PIOR_avgWaitingTime_textBox.ReadOnly = true;
                    PIOR_sumTurnAroundTime_textBox.ReadOnly = true;
                    PIOR_avgTurnAroundTime_textBox.ReadOnly = true;
                }
            }
            else if (PIOR_Mode_comboBox.Text == "Dynamic")
            {
                if (
                     string.IsNullOrEmpty(PIOR_BurstTime_textbook.Text)
                  || string.IsNullOrEmpty(PIOR_Piority_textbook.Text)
                  || (!int.TryParse(PIOR_BurstTime_textbook.Text, out int value2) || value2 <= 0)
                  || (!int.TryParse(PIOR_Piority_textbook.Text, out int value3) || value3 < 0)
                 )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }


                Process tempProcess = new Process();
                tempProcess.Pid = PIOR_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(PIOR_BurstTime_textbook.Text);
                tempProcess.piority  = int.Parse(PIOR_Piority_textbook.Text);

                tempProcess.arrival_time = PIOR_ACC;

                PIOR_Input_Queue.Enqueue(tempProcess);
                PIOR_QUEUE_SIZE++;

                /*--------------update average waiting time-----------------------*/
                if (PIOR_dataGridView.Rows.Count != 0)
                {
                    PIOR_SumOfWaitTime++;
                    PIOR_sumWaitingTime_textBox.Text = PIOR_SumOfWaitTime.ToString();
                    if (PIOR_QUEUE_SIZE != 0)
                        PIOR_avgWaitingTime_textBox.Text = (PIOR_SumOfWaitTime/PIOR_QUEUE_SIZE).ToString("F2");
                    else
                        PIOR_avgWaitingTime_textBox.Text = "0";
                }
                /*--------------update average turnaround time-----------------------*/
                PIOR_SumOfTurnAroundTime++;
                PIOR_sumTurnAroundTime_textBox.Text =  PIOR_SumOfTurnAroundTime.ToString();
                if (PIOR_QUEUE_SIZE != 0)
                    PIOR_avgTurnAroundTime_textBox.Text = (PIOR_SumOfTurnAroundTime/PIOR_QUEUE_SIZE).ToString("F2");
                else
                    PIOR_avgTurnAroundTime_textBox.Text = "0";


                PIOR_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time, tempProcess.piority);

                PIOR_ArrivalTime_textbook.Clear();
                PIOR_BurstTime_textbook.Clear();
                PIOR_Piority_textbook.Clear();
            }

        }

        /*-------------------------------------static Logic------------------------------*/
        private void PIOR_Ok_btn_Click(object sender, EventArgs e)
        {
            if (
                  string.IsNullOrEmpty(PIOR_NoOfProcesses_textbook.Text)
                  || (!int.TryParse(PIOR_NoOfProcesses_textbook.Text, out int value1) || value1 <= 0)
               )
            {
                //MessageBox.Show("Input is not a valid integer.");
                return;
            }

            numOfProcess = int.Parse(PIOR_NoOfProcesses_textbook.Text);
            PIOR_Time_flowLayoutPanel.Controls.Clear();
            PIOR_Process_flowLayoutPanel.Controls.Clear();

            PIOR_ArrivalTime_label.Enabled = true;
            PIOR_ArrivalTime_label.Visible = true;
            PIOR_ArrivalTime_textbook.Enabled = true;
            PIOR_ArrivalTime_textbook.Visible = true;
            PIOR_BurstTime_label.Enabled = true;
            PIOR_BurstTime_label.Visible = true;
            PIOR_BurstTime_textbook.Enabled = true;
            PIOR_BurstTime_textbook.Visible = true;
            PIOR_Piority_label.Enabled = true;
            PIOR_Piority_label.Visible = true;
            PIOR_Piority_textbook.Enabled = true;
            PIOR_Piority_textbook.Visible = true;

            PIOR_Insert_btn.Enabled = true;
            PIOR_Insert_btn.Visible = true;

            PIOR_Ok_btn.Enabled = false;
            PIOR_NoOfProcesses_textbook.ReadOnly = true;
        }
        private void PIOR_Static_Logic()
        {
            int len, timeGivenToProcessOnCpu, first_index, last_index;
            Process[] array;
            while (true)
            {
                /*-----------------------------------------------------sort the queue of processes------------------------------------------------------------*/
                array = PIOR_Input_Queue.ToArray();
                Array.Sort(array, new ArrivalTimeComparer());
                len = PIOR_Input_Queue.Count;
                first_index = 0;
                PIOR_ACC = array[0].arrival_time;

                /*-----from processes that have min arrival time choose the process whose piority is minimum -------*/
                for (int i = 0; i<len; i++)
                {
                    if (array[i].arrival_time <= PIOR_ACC && array[i].piority < array[first_index].piority)
                        first_index = i;
                }
                last_index = first_index;
                while (last_index < len-1 && array[first_index].arrival_time == array[last_index+1].arrival_time)
                    last_index++;

                /*------------------------OPTION Run part of remaining time-------------*/
                if (PIOR_Preemtive_Version
                    && last_index < len-1
                    && array[first_index].burst_time + array[first_index].arrival_time > array[last_index+1].arrival_time)
                {
                    timeGivenToProcessOnCpu = array[last_index+1].arrival_time - array[last_index].arrival_time;
                    array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);
                    PIOR_Display_Queue.Enqueue(array[first_index].copy(timeGivenToProcessOnCpu));
                }
                /*----------------------------OPTION Run all remaining time-------------*/
                else
                {
                    timeGivenToProcessOnCpu = array[first_index].burst_time;
                    array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);
                    PIOR_Display_Queue.Enqueue(array[first_index].copy(timeGivenToProcessOnCpu));
                }
                /*------------------------Update arrival time---------------------------*/
                for (int i = 0; i<len; i++)
                {
                    if (array[i].arrival_time == PIOR_ACC)
                        array[i].increaseArrivalTime(timeGivenToProcessOnCpu);
                    else if (array[i].arrival_time < timeGivenToProcessOnCpu + PIOR_ACC)
                        array[i].arrival_time = timeGivenToProcessOnCpu + PIOR_ACC;
                }
                PIOR_Input_Queue = new Queue<Process>(array);
                PIOR_Input_Queue = new Queue<Process>(PIOR_Input_Queue.Where(obj => obj.burst_time != 0));
                /*-----------------------------Check Fininshing algorith----------------*/
                if (PIOR_Input_Queue.Count == 0)
                    break;
            }
        }
        private void PIOR_updateScrolling()
        {
            // Recalculate the total width of the panel's contents
            int totalWidth = PIOR_Process_flowLayoutPanel.Controls.Cast<Control>().Sum(control => control.Width + control.Margin.Horizontal);

            // Set the maximum value of the external scrollbar to the total width
            PIOR_hScrollBar.Maximum = totalWidth;

            // Set the small change and large change values of the scrollbar
            PIOR_hScrollBar.SmallChange = 10;
            PIOR_hScrollBar.LargeChange = PIOR_Process_flowLayoutPanel.ClientSize.Width;
        }
        private void PIOR_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            PIOR_Time_flowLayoutPanel.HorizontalScroll.Value = PIOR_hScrollBar.Value;
            PIOR_Process_flowLayoutPanel.HorizontalScroll.Value = PIOR_hScrollBar.Value;
            PIOR_updateScrolling();
        }
        private void PIOR_Static_Display()
        {
            int noOfIdleSlot = 0;
            int PIOR_Time_Acc = 0;
            Process tempProcess;
            while (PIOR_Display_Queue.Count != 0)
            {
                tempProcess = PIOR_Display_Queue.Peek();
                if (PIOR_Time_Acc < tempProcess.arrival_time)
                {
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = PIOR_Time_Acc.ToString();
                    tempLabel_Time.Width =  MIN_PROCESS_SLOT_WIDTH;
                    PIOR_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width =  MIN_PROCESS_SLOT_WIDTH;
                    PIOR_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*--------------------update PIOR_ACC-------------------------*/
                    noOfIdleSlot += (tempProcess.arrival_time-PIOR_Time_Acc);
                    PIOR_Time_Acc = tempProcess.arrival_time;
                    
                }
                else
                {
                    tempProcess = PIOR_Display_Queue.Dequeue();
                    /*----------------------------------time chart---------------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = PIOR_Time_Acc.ToString();
                    if (tempProcess.burst_time-tempProcess.arrival_time < BURST_TIME_barrier)
                        tempLabel_Time.Width = (tempProcess.burst_time-tempProcess.arrival_time) *MIN_PROCESS_SLOT_WIDTH;
                    else
                        tempLabel_Time.Width = MAX_PROCESS_SLOT_WIDTH;
                    PIOR_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------------------gantt chart code--------------------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
                    if (tempProcess.burst_time-tempProcess.arrival_time < BURST_TIME_barrier)
                        tempLabel_Process.Width = (tempProcess.burst_time-tempProcess.arrival_time) *MIN_PROCESS_SLOT_WIDTH;
                    else
                        tempLabel_Process.Width = MAX_PROCESS_SLOT_WIDTH;
                    PIOR_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*---------------------------------update SJF_ACC-------------------------------------*/
                    PIOR_Time_Acc += (tempProcess.burst_time-tempProcess.arrival_time);

                    foreach (DataGridViewRow row in PIOR_dataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == tempProcess.Pid.ToString())
                        {
                            int currentValue = Convert.ToInt32(row.Cells[4].Value);
                            if (currentValue != tempProcess.burst_time-tempProcess.arrival_time)
                                row.Cells[4].Value = (currentValue - tempProcess.burst_time+tempProcess.arrival_time).ToString();
                            else
                            {
                                /*--------------update average waiting time-----------------------*/
                                PIOR_SumOfWaitTime += (PIOR_Time_Acc-Convert.ToInt32(row.Cells[1].Value)-Convert.ToInt32(row.Cells[2].Value));
                                PIOR_sumWaitingTime_textBox.Text = PIOR_SumOfWaitTime.ToString();
                                if (PIOR_QUEUE_SIZE != 0)
                                    PIOR_avgWaitingTime_textBox.Text = (PIOR_SumOfWaitTime/PIOR_QUEUE_SIZE).ToString("F2");
                                else
                                    PIOR_avgWaitingTime_textBox.Text = "0";
                            }
                            break;
                        }
                    }
                }
            }
            /*---------------update average turnaround time--------------------*/
            PIOR_SumOfTurnAroundTime = PIOR_SumOfWaitTime + PIOR_Time_Acc - noOfIdleSlot;
            PIOR_sumTurnAroundTime_textBox.Text = PIOR_SumOfTurnAroundTime.ToString();
            if (PIOR_QUEUE_SIZE != 0)
                PIOR_avgTurnAroundTime_textBox.Text = (PIOR_SumOfTurnAroundTime/PIOR_QUEUE_SIZE).ToString("F2");
            else
                PIOR_avgTurnAroundTime_textBox.Text = "0";
            /*-----------------last time label---------------------------------*/
            WF.Label lastTimeLabel = new WF.Label();
            lastTimeLabel.Text = PIOR_Time_Acc.ToString();
            PIOR_Time_flowLayoutPanel.Controls.Add(lastTimeLabel);
        }

        /*------------------------------------Dynamic Logic------------------------------*/
        private void PIOR_Logic()
        {
            int len, timeGivenToProcessOnCpu, first_index, last_index;
            Process[] array;

            /*-----------------------------------------------------sort the queue of processes------------------------------------------------------------*/
            array = PIOR_Input_Queue.ToArray();
            Array.Sort(array, new ArrivalTimeComparer());
            len = PIOR_Input_Queue.Count;
            first_index = 0;
            PIOR_ACC = array[0].arrival_time;

            /*-----select  processes that have min arrival time then choose from them the process whose burst time is minimum -------*/
            for (int i = 0; i<len; i++)
            {
                if (array[i].arrival_time <= PIOR_ACC && array[i].piority < array[first_index].piority)
                    first_index = i;
            }
            last_index = first_index;
            while (last_index < len-1 && array[first_index].arrival_time == array[last_index+1].arrival_time)
                last_index++;

            /*----------------------------OPTION Add 1S of process to Display Queue---------------*/
            if (PIOR_Preemtive_Version)
            {
                timeGivenToProcessOnCpu = 1;
                array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);

                PIOR_Display_Queue.Enqueue(array[first_index].copy(timeGivenToProcessOnCpu));
            }
            /*----------------------------OPTION Add many 1s of process to Display Queue----------*/
            else
            {
                timeGivenToProcessOnCpu = array[first_index].burst_time;
                array[first_index].decreaseBurstTime(timeGivenToProcessOnCpu);

                int counter = timeGivenToProcessOnCpu;
                int x = array[first_index].arrival_time;
                for (int i = 0; i < counter; i++)
                    PIOR_Display_Queue.Enqueue(new Process(array[first_index].Pid, 1+x, x++));
            }

            PIOR_NextPossibleSlot = PIOR_ACC + timeGivenToProcessOnCpu;
            /*---------------------------------------------------------------------------Update arrival time-----------------------------------------------*/
            for (int i = 0; i<len; i++)
            {
                if (array[i].arrival_time == PIOR_ACC)
                    array[i].increaseArrivalTime(timeGivenToProcessOnCpu);
                else if (array[i].arrival_time < timeGivenToProcessOnCpu + PIOR_ACC)
                    array[i].arrival_time = timeGivenToProcessOnCpu + PIOR_ACC;
            }
            PIOR_Input_Queue = new Queue<Process>(array);
            PIOR_Input_Queue = new Queue<Process>(PIOR_Input_Queue.Where(obj => obj.burst_time != 0));
        }
        private void PIOR_Display()
        {
            int PIOR_Time_Acc = PIOR_Display_Queue.Peek().arrival_time;
            Process tempProcess;
           
            tempProcess = PIOR_Display_Queue.Dequeue();
            /*----------------------------------time chart---------------------------------------*/
            WF.Label tempLabel_Time = new WF.Label();
            tempLabel_Time.Text = PIOR_Time_Acc.ToString();
            tempLabel_Time.Width =  MIN_PROCESS_SLOT_WIDTH;
            if (!PIOR_Page)
                PIOR_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
            else
                PIOR_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
            /*------------------------------gantt chart code--------------------------------------*/
            WF.Label tempLabel_Process = new WF.Label();
            tempLabel_Process.Enabled = true;
            tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
            tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
            tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
            tempLabel_Process.Width =  MIN_PROCESS_SLOT_WIDTH;
            if (!PIOR_Page)
                PIOR_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
            else
                PIOR_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
        }
        private void PIOR_updateTable()
        {
            /*---------------- update table---------------------*/
            foreach (DataGridViewRow row in PIOR_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == PIOR_Display_Queue.Peek().Pid.ToString())
                {
                    int currentValue = Convert.ToInt32(row.Cells[2].Value);
                    if (currentValue != 1)
                        row.Cells[2].Value = (currentValue - 1).ToString();
                    else
                        PIOR_dataGridView.Rows.RemoveAt(row.Index);

                    break;
                }
            }
            if (PIOR_dataGridView.Rows.Count != 0)
            {
                /*--------------average waiting time-----------------------*/
                PIOR_SumOfWaitTime += PIOR_dataGridView.Rows.Count-1;
                PIOR_sumWaitingTime_textBox.Text = PIOR_SumOfWaitTime.ToString();
                if (PIOR_QUEUE_SIZE != 0)
                    PIOR_avgWaitingTime_textBox.Text = (PIOR_SumOfWaitTime/PIOR_QUEUE_SIZE).ToString("F2");
                else
                    PIOR_avgWaitingTime_textBox.Text = "0";
                /*--------------turnaround waiting time-----------------------*/
                PIOR_SumOfTurnAroundTime += PIOR_dataGridView.Rows.Count;
                PIOR_sumTurnAroundTime_textBox.Text = PIOR_SumOfTurnAroundTime.ToString();
                if (PIOR_QUEUE_SIZE != 0)
                    PIOR_avgTurnAroundTime_textBox.Text = (PIOR_SumOfTurnAroundTime/PIOR_QUEUE_SIZE).ToString("F2");
                else
                    PIOR_avgTurnAroundTime_textBox.Text = "0";
            }
        }

        bool PIOR_Page = false;
        private void PIOR_Timer_Tick(object sender, EventArgs e)
        {
            if (!PIOR_Jump)
            {
                if (PIOR_ACC != 0 && PIOR_ACC % MAX_PAGE == 0 && PIOR_Page)
                {
                    PIOR_Time_flowLayoutPanel2.Controls.Clear();
                    PIOR_Process_flowLayoutPanel2.Controls.Clear();
                    PIOR_Time_flowLayoutPanel3.Controls.Clear();
                    PIOR_Process_flowLayoutPanel3.Controls.Clear();
                    PIOR_Page = !PIOR_Page;
                }
                else if (PIOR_ACC != 0 && PIOR_ACC % (MAX_PAGE/2) == 0)
                    PIOR_Page = !PIOR_Page;


                if (!PIOR_Preemtive_Version && PIOR_Input_Queue.Count != 0 && PIOR_ACC == PIOR_NextPossibleSlot)
                {
                    PIOR_Timer.Stop();
                    foreach (Process obj in PIOR_Input_Queue)
                    {
                        if (obj.arrival_time < PIOR_ACC)
                            obj.arrival_time = PIOR_ACC;
                    }
                    PIOR_Logic();
                }
                else if (PIOR_Preemtive_Version && PIOR_Input_Queue.Count != 0)
                {
                    PIOR_Timer.Stop();
                    PIOR_Logic();
                }

                if (PIOR_Display_Queue.Count != 0)
                {
                    PIOR_updateTable();
                    PIOR_Display();
                }
                else
                {
                    PIOR_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = PIOR_ACC.ToString();
                    tempLabel_Time.Width =  MIN_PROCESS_SLOT_WIDTH;
                    if (!PIOR_Page)
                        PIOR_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        PIOR_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width =  MIN_PROCESS_SLOT_WIDTH;
                    if (!PIOR_Page)
                        PIOR_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        PIOR_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }
                PIOR_Timer.Start();
                PIOR_ACC++;
                PIOR_CurrentSlot_label.Text = PIOR_ACC.ToString();
            }
            else
            {
                PIOR_JUMPHandler();
            }
        }
        private void PIOR_JUMPHandler()
        {
            while (true)
            {
                if (PIOR_ACC != 0 && PIOR_ACC %MAX_PAGE == 0 && PIOR_Page)     
                {
                    PIOR_Time_flowLayoutPanel2.Controls.Clear();
                    PIOR_Process_flowLayoutPanel2.Controls.Clear();
                    PIOR_Time_flowLayoutPanel3.Controls.Clear();
                    PIOR_Process_flowLayoutPanel3.Controls.Clear();
                    PIOR_Page = !PIOR_Page;
                }
                else if (PIOR_ACC != 0 && PIOR_ACC % (MAX_PAGE/2) == 0)  
                    PIOR_Page = !PIOR_Page;


                if (PIOR_Input_Queue.Count != 0 && PIOR_ACC == PIOR_NextPossibleSlot)
                    PIOR_Logic();
                if (PIOR_Display_Queue.Count != 0)
                {
                    PIOR_updateTable();
                    PIOR_Display();
                }
                else
                {
                    PIOR_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = PIOR_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!PIOR_Page)
                        PIOR_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        PIOR_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!PIOR_Page)
                        PIOR_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        PIOR_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }
                PIOR_ACC++;
                PIOR_CurrentSlot_label.Text = PIOR_ACC.ToString();

                if (PIOR_Display_Queue.Count == 0 && PIOR_Input_Queue.Count == 0 || !PIOR_Jump)
                    break;
            }
        }
        private void PIOR_trackBar_Scroll(object sender, EventArgs e)
        {
            if (PIOR_trackBar.Value != 0)
                PIOR_Timer.Interval = PIOR_trackBar.Value*1000;
            else
                PIOR_Timer.Interval = 1000;
        }
        /*-------------------------------------Check box handler--------------------------*/
        private void PIOR_Version_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIOR_Version_checkBox.Checked)
                PIOR_Preemtive_Version = true;
            else
                PIOR_Preemtive_Version = false;
        }
        private void PIOR_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIOR_Jump_checkBox.Checked)
            {
                PIOR_Jump = true;
            }
            else
            {
                PIOR_Jump = false;
            }
        }
        private void PIOR_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIOR_Live_checkBox.Checked)
            {
                PIOR_Live = true;
                PIOR_Jump_checkBox.Enabled = true;
                PIOR_Timer.Start();
                PIOR_Insert_btn.Enabled = true;
                PIOR_BurstTime_textbook.Enabled = true;
            }
            else
            {
                PIOR_Live = false;
                PIOR_Jump_checkBox.Enabled = true;
                PIOR_Timer.Stop();
                PIOR_Insert_btn.Enabled = false;
                PIOR_BurstTime_textbook.Enabled = false;
            }
        }

        /*----------------------------------Combo box handler----------------------------*/
        private void PIOR_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PIOR_Mode_comboBox.Text == "Static")
            {
                PIOR_trackBar.Enabled = false;
                PIOR_trackBar.Visible = false;

                PIOR_hScrollBar.Enabled = false;
                PIOR_hScrollBar.Visible = false;

                PIOR_Ok_btn.Enabled = true;
                PIOR_Ok_btn.Visible = true;

                PIOR_ArrivalTime_label.Enabled = false;
                PIOR_ArrivalTime_label.Visible = false;
                PIOR_ArrivalTime_textbook.Enabled = false;
                PIOR_ArrivalTime_textbook.Visible = false;

                PIOR_BurstTime_label.Enabled = false;
                PIOR_BurstTime_label.Visible = false;
                PIOR_BurstTime_textbook.Enabled = false;
                PIOR_BurstTime_textbook.Visible = false;

                PIOR_dataGridView.Enabled = true;
                PIOR_dataGridView.Visible = true;

                PIOR_Slot_label.Enabled = false;
                PIOR_Slot_label.Visible = false;
                PIOR_CurrentSlot_label.Enabled = false;
                PIOR_CurrentSlot_label.Visible = false;

                PIOR_Insert_btn.Enabled = false;
                PIOR_Insert_btn.Visible = false;

                PIOR_NoOfProcesses_textbook.Enabled = true;
                PIOR_NoOfProcesses_textbook.Visible = true;
                PIOR_NoOfProcesses_Label.Enabled = true;
                PIOR_NoOfProcesses_Label.Visible = true;

                PIOR_Live_checkBox.Enabled = false;
                PIOR_Live_checkBox.Visible = false;

                PIOR_Jump_checkBox.Enabled = false;
                PIOR_Jump_checkBox.Visible = false;

                PIOR_sumWaitingTime_label.Enabled = false;
                PIOR_sumWaitingTime_label.Visible = false;
                PIOR_sumWaitingTime_textBox.Enabled = false;
                PIOR_sumWaitingTime_textBox.Visible = false;

                PIOR_avgWaitingTime_label.Enabled = false;
                PIOR_avgWaitingTime_label.Visible = false;
                PIOR_avgWaitingTime_textBox.Enabled = false;
                PIOR_avgWaitingTime_textBox.Visible = false;

                PIOR_sumTurnAroundTime_textBox.Enabled = false;
                PIOR_sumTurnAroundTime_textBox.Visible = false;
                PIOR_sumTurnAroundTime_label.Enabled = false;
                PIOR_sumTurnAroundTime_label.Visible = false;

                PIOR_avgTurnAroundTime_textBox.Enabled = false;
                PIOR_avgTurnAroundTime_textBox.Visible = false;
                PIOR_avgTurnAroundTime_label.Enabled = false;
                PIOR_avgTurnAroundTime_label.Visible = false;

                PIOR_Version_checkBox.Enabled = true;
                PIOR_Version_checkBox.Visible = true;

                PIOR_Piority_label.Enabled = false;
                PIOR_Piority_label.Visible = false;
                PIOR_Piority_textbook.Enabled = false;
                PIOR_Piority_textbook.Visible = false;
            }
            else if (PIOR_Mode_comboBox.Text == "Dynamic")
            {
                PIOR_trackBar.Enabled = true;
                PIOR_trackBar.Visible = true;

                PIOR_hScrollBar.Enabled = false;
                PIOR_hScrollBar.Visible = false;

                PIOR_Ok_btn.Enabled = false;
                PIOR_Ok_btn.Visible = false;

                PIOR_ArrivalTime_label.Enabled = false;
                PIOR_ArrivalTime_label.Visible = false;
                PIOR_ArrivalTime_textbook.Enabled = false;
                PIOR_ArrivalTime_textbook.Visible = false;

                PIOR_BurstTime_label.Enabled = true;
                PIOR_BurstTime_label.Visible = true;
                PIOR_BurstTime_textbook.Enabled = true;
                PIOR_BurstTime_textbook.Visible = true;

                PIOR_dataGridView.Enabled = true;
                PIOR_dataGridView.Visible = true;

                PIOR_Slot_label.Enabled = true;
                PIOR_Slot_label.Visible = true;
                PIOR_CurrentSlot_label.Enabled = true;
                PIOR_CurrentSlot_label.Visible = true;

                PIOR_Insert_btn.Enabled = true;
                PIOR_Insert_btn.Visible = true;

                PIOR_NoOfProcesses_textbook.Enabled = false;
                PIOR_NoOfProcesses_textbook.Visible = false;
                PIOR_NoOfProcesses_Label.Enabled = false;
                PIOR_NoOfProcesses_Label.Visible = false;

                PIOR_Live_checkBox.Enabled = true;
                PIOR_Live_checkBox.Visible = true;

                PIOR_Jump_checkBox.Enabled = true;
                PIOR_Jump_checkBox.Visible = true;

                PIOR_sumWaitingTime_label.Enabled = true;
                PIOR_sumWaitingTime_label.Visible = true;
                PIOR_sumWaitingTime_textBox.Enabled = true;
                PIOR_sumWaitingTime_textBox.Visible = true;

                PIOR_avgWaitingTime_label.Enabled = true;
                PIOR_avgWaitingTime_label.Visible = true;
                PIOR_avgWaitingTime_textBox.Enabled = true;
                PIOR_avgWaitingTime_textBox.Visible = true;

                PIOR_sumTurnAroundTime_textBox.Enabled = true;
                PIOR_sumTurnAroundTime_textBox.Visible = true;
                PIOR_sumTurnAroundTime_label.Enabled = true;
                PIOR_sumTurnAroundTime_label.Visible = true;

                PIOR_avgTurnAroundTime_textBox.Enabled = true;
                PIOR_avgTurnAroundTime_textBox.Visible = true;
                PIOR_avgTurnAroundTime_label.Enabled = true;
                PIOR_avgTurnAroundTime_label.Visible = true;

                PIOR_sumWaitingTime_textBox.ReadOnly = true;
                PIOR_avgWaitingTime_textBox.ReadOnly = true;
                PIOR_sumTurnAroundTime_textBox.ReadOnly = true;
                PIOR_avgTurnAroundTime_textBox.ReadOnly = true;

                PIOR_Version_checkBox.Enabled = true;
                PIOR_Version_checkBox.Visible = true;

                PIOR_Piority_label.Enabled = true;
                PIOR_Piority_label.Visible = true;
                PIOR_Piority_textbook.Enabled = true;
                PIOR_Piority_textbook.Visible = true;
            }
        }

        /*--------------------------------------Reset------------------------------------*/
        private void PIOR_Rest()
        {
            PIOR_hScrollBar.Enabled = false;
            PIOR_hScrollBar.Visible = false;

            PIOR_Page = false;
            PIOR_Live = false;
            PIOR_Jump = false;

            PIOR_Timer.Stop();

            PIOR_NoOfProcesses_textbook.ReadOnly = false;
            PIOR_NoOfProcesses_textbook.Clear();

            PIOR_ACC = 0;
            PIOR_NextPossibleSlot = 0;
            PIOR_QUEUE_SIZE = 0;
            PIOR_SumOfWaitTime = 0;
            PIOR_SumOfTurnAroundTime = 0;
            PIOR_CurrentSlot_label.Text = "0";

            PIOR_Input_Queue.Clear();
            PIOR_Display_Queue.Clear();

            PIOR_Time_flowLayoutPanel.Controls.Clear();
            PIOR_Process_flowLayoutPanel.Controls.Clear();
            PIOR_Time_flowLayoutPanel2.Controls.Clear();
            PIOR_Process_flowLayoutPanel2.Controls.Clear();
            PIOR_Time_flowLayoutPanel3.Controls.Clear();
            PIOR_Process_flowLayoutPanel3.Controls.Clear();

            PIOR_Ok_btn.Enabled = false;
            PIOR_Ok_btn.Visible = false;

            PIOR_ArrivalTime_label.Enabled = false;
            PIOR_ArrivalTime_label.Visible = false;
            PIOR_ArrivalTime_textbook.Enabled = false;
            PIOR_ArrivalTime_textbook.Clear();
            PIOR_ArrivalTime_textbook.Visible = false;

            PIOR_BurstTime_label.Enabled = false;
            PIOR_BurstTime_label.Visible = false;
            PIOR_BurstTime_textbook.Enabled = false;
            PIOR_BurstTime_textbook.Clear();
            PIOR_BurstTime_textbook.Visible = false;

            PIOR_dataGridView.Enabled = false;
            PIOR_dataGridView.Visible = false;

            PIOR_Slot_label.Enabled = false;
            PIOR_Slot_label.Visible = false;
            PIOR_CurrentSlot_label.Enabled = false;
            PIOR_CurrentSlot_label.Visible = false;

            PIOR_Insert_btn.Enabled = false;
            PIOR_Insert_btn.Visible = false;

            PIOR_NoOfProcesses_textbook.Enabled = false;
            PIOR_NoOfProcesses_textbook.Visible = false;
            PIOR_NoOfProcesses_Label.Enabled = false;
            PIOR_NoOfProcesses_Label.Visible = false;

            PIOR_Live_checkBox.Enabled = false;
            PIOR_Live_checkBox.Visible = false;
            PIOR_Live_checkBox.Checked = false;

            PIOR_Jump_checkBox.Enabled = false;
            PIOR_Jump_checkBox.Visible = false;
            PIOR_Jump_checkBox.Checked = false;

            PIOR_Mode_comboBox.SelectedIndex = -1;
            PIOR_dataGridView.Rows.Clear();

            PIOR_sumWaitingTime_label.Enabled = false;
            PIOR_sumWaitingTime_label.Visible = false;
            PIOR_sumWaitingTime_textBox.Enabled = false;
            PIOR_sumWaitingTime_textBox.Visible = false;
            PIOR_sumWaitingTime_textBox.Text = "0";

            PIOR_avgWaitingTime_label.Enabled = false;
            PIOR_avgWaitingTime_label.Visible = false;
            PIOR_avgWaitingTime_textBox.Enabled = false;
            PIOR_avgWaitingTime_textBox.Visible = false;
            PIOR_avgWaitingTime_textBox.Text = "0";

            PIOR_sumTurnAroundTime_textBox.Enabled = false;
            PIOR_sumTurnAroundTime_textBox.Visible = false;
            PIOR_sumTurnAroundTime_label.Enabled = false;
            PIOR_sumTurnAroundTime_label.Visible = false;
            PIOR_sumTurnAroundTime_textBox.Text = "0";

            PIOR_avgTurnAroundTime_textBox.Enabled = false;
            PIOR_avgTurnAroundTime_textBox.Visible = false;
            PIOR_avgTurnAroundTime_label.Enabled = false;
            PIOR_avgTurnAroundTime_label.Visible = false;
            PIOR_avgTurnAroundTime_textBox.Text = "0";

            PIOR_Version_checkBox.Checked = false;
            PIOR_Version_checkBox.Enabled = false;
            PIOR_Version_checkBox.Visible = false;

            PIOR_Piority_label.Enabled = false;
            PIOR_Piority_label.Visible = false;
            PIOR_Piority_textbook.Enabled = false;
            PIOR_Piority_textbook.Clear();
            PIOR_Piority_textbook.Visible = false;

            PIOR_trackBar.Enabled = false;
            PIOR_trackBar.Visible = false;
            PIOR_trackBar.Value = 0;
            PIOR_Timer.Interval = 1000;
        }
        private void PIOR_Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /*--------------------------------------------------------End of PIOR functions--------------------------------------------------------*/






        /*--------------------------------------------------------Start of RR functions--------------------------------------------------------*/
        private void RR_Insert_btn_Click(object sender, EventArgs e)
        {
            if (RR_Mode_comboBox.Text == "Static")
            {
                if (
                 string.IsNullOrEmpty(RR_BurstTime_textbook.Text)
                 || string.IsNullOrEmpty(RR_ArrivalTime_textbook.Text)
                 || (!int.TryParse(RR_BurstTime_textbook.Text, out int value1) || value1 <= 0)
                 || (!int.TryParse(RR_ArrivalTime_textbook.Text, out int value2) || value2 < 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                Process tempProcess = new Process();
                tempProcess.Pid = RR_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(RR_BurstTime_textbook.Text);
                tempProcess.arrival_time = int.Parse(RR_ArrivalTime_textbook.Text);
                RR_Input_Queue.Enqueue(tempProcess);
                RR_QUEUE_SIZE++;

                RR_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time);

                RR_ArrivalTime_textbook.Clear();
                RR_BurstTime_textbook.Clear();

                if (numOfProcess == RR_QUEUE_SIZE)
                {
                    RR_Insert_btn.Enabled = false;

                    RR_Static_Logic_Display();

                    RR_ArrivalTime_textbook.Clear();
                    RR_ArrivalTime_textbook.Enabled = false;

                    RR_BurstTime_textbook.Clear();
                    RR_BurstTime_textbook.Enabled = false;

                    RR_hScrollBar.Enabled = true;
                    RR_hScrollBar.Visible = true;

                    RR_sumWaitingTime_label.Enabled = true;
                    RR_sumWaitingTime_label.Visible = true;
                    RR_avgWaitingTime_label.Visible =true;
                    RR_avgWaitingTime_label.Enabled =true;
                    RR_sumTurnAroundTime_label.Visible = true;
                    RR_sumTurnAroundTime_label.Enabled = true;
                    RR_avgTurnAroundTime_label.Visible =true;
                    RR_avgTurnAroundTime_label.Enabled =true;

                    RR_sumWaitingTime_textBox.Enabled = true;
                    RR_sumWaitingTime_textBox.Visible = true;
                    RR_avgWaitingTime_textBox.Enabled = true;
                    RR_avgWaitingTime_textBox.Visible = true;
                    RR_sumTurnAroundTime_textBox.Enabled = true;
                    RR_sumTurnAroundTime_textBox.Visible = true;
                    RR_avgTurnAroundTime_textBox.Enabled = true;
                    RR_avgTurnAroundTime_textBox.Visible = true;
                    RR_sumWaitingTime_textBox.ReadOnly = true;
                    RR_avgWaitingTime_textBox.ReadOnly = true;
                    RR_sumTurnAroundTime_textBox.ReadOnly = true;
                    RR_avgTurnAroundTime_textBox.ReadOnly = true;
                }
            }
            else if(RR_Mode_comboBox.Text == "Dynamic")
            {
                if (
                     string.IsNullOrEmpty(RR_BurstTime_textbook.Text)
                   || (!int.TryParse(RR_BurstTime_textbook.Text, out int value1) || value1 <= 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                Process tempProcess = new Process();
                tempProcess.Pid = RR_QUEUE_SIZE + 1;
                tempProcess.burst_time = int.Parse(RR_BurstTime_textbook.Text);
                tempProcess.arrival_time = RR_ACC;
                RR_Input_Queue.Enqueue(tempProcess);
                RR_QUEUE_SIZE++;

                /*--------------update average waiting time-----------------------*/
                if (RR_dataGridView.Rows.Count != 0)
                {
                    RR_SumOfWaitTime++;
                    RR_sumWaitingTime_textBox.Text = RR_SumOfWaitTime.ToString();
                    if (RR_QUEUE_SIZE != 0)
                        RR_avgWaitingTime_textBox.Text = (RR_SumOfWaitTime/RR_QUEUE_SIZE).ToString("F2");
                    else
                        RR_avgWaitingTime_textBox.Text = "0";
                }
                /*--------------update average turnaround time-----------------------*/
                RR_SumOfTurnAroundTime++;
                RR_sumTurnAroundTime_textBox.Text =  RR_SumOfTurnAroundTime.ToString();
                if (RR_QUEUE_SIZE != 0)
                    RR_avgTurnAroundTime_textBox.Text = (RR_SumOfTurnAroundTime/RR_QUEUE_SIZE).ToString("F2");
                else
                    RR_avgTurnAroundTime_textBox.Text = "0";


                RR_dataGridView.Rows.Add(tempProcess.Pid, tempProcess.arrival_time, tempProcess.burst_time);

                RR_ArrivalTime_textbook.Clear();
                RR_BurstTime_textbook.Clear();
            }
        }

        /*----------------------------------static Logic--------------------------------*/
        private void RR_Ok_btn_Click(object sender, EventArgs e)
        {
            if (RR_Mode_comboBox.Text == "Static")
            {
                if (
                 string.IsNullOrEmpty(RR_NoOfProcesses_textbook.Text)
                 || string.IsNullOrEmpty(RR_QuantamTime_textBox.Text)
                 || (!int.TryParse(RR_NoOfProcesses_textbook.Text, out int value1) || value1 <= 0)
                 || (!int.TryParse(RR_QuantamTime_textBox.Text, out int value2) || value2 <= 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                numOfProcess = int.Parse(RR_NoOfProcesses_textbook.Text);
                RR_QuantamTime = int.Parse(RR_QuantamTime_textBox.Text);
                RR_QuantamTime_textBox.ReadOnly = true;
                RR_Time_flowLayoutPanel.Controls.Clear();
                RR_Process_flowLayoutPanel.Controls.Clear();

                RR_ArrivalTime_label.Enabled = true;
                RR_ArrivalTime_label.Visible = true;
                RR_ArrivalTime_textbook.Enabled = true;
                RR_ArrivalTime_textbook.Visible = true;

                RR_BurstTime_label.Enabled = true;
                RR_BurstTime_label.Visible = true;
                RR_BurstTime_textbook.Enabled = true;
                RR_BurstTime_textbook.Visible = true;

                RR_Insert_btn.Enabled = true;
                RR_Insert_btn.Visible = true;

                RR_Ok_btn.Enabled = false;
                RR_NoOfProcesses_textbook.ReadOnly = true;
            }
            else if(RR_Mode_comboBox.Text == "Dynamic")
            {
                if (
                  string.IsNullOrEmpty(RR_QuantamTime_textBox.Text)
                  || (!int.TryParse(RR_QuantamTime_textBox.Text, out int value2) || value2 <= 0)
                   )
                {
                    //MessageBox.Show("Input is not a valid integer.");
                    return;
                }

                RR_QuantamTime = int.Parse(RR_QuantamTime_textBox.Text);
                RR_Time_flowLayoutPanel.Controls.Clear();
                RR_Process_flowLayoutPanel.Controls.Clear();

                RR_Live_checkBox.Enabled = true;
                RR_Live_checkBox.Visible = true;

                RR_Jump_checkBox.Enabled = true;
                RR_Jump_checkBox.Visible = true;

                RR_BurstTime_label.Enabled = true;
                RR_BurstTime_label.Visible = true;
                RR_BurstTime_textbook.Enabled = true;
                RR_BurstTime_textbook.Visible = true;

                RR_Insert_btn.Enabled = true;
                RR_Insert_btn.Visible = true;

                RR_dataGridView.Enabled = true;
                RR_dataGridView.Visible = true;

                RR_QuantamTime_textBox.ReadOnly = true;
                RR_Ok_btn.Enabled = false;
            }
        }

        private void RR_updateScrolling()
        {
            // Recalculate the total width of the panel's contents
            int totalWidth = RR_Process_flowLayoutPanel.Controls.Cast<Control>().Sum(control => control.Width + control.Margin.Horizontal);

            // Set the maximum value of the external scrollbar to the total width
            RR_hScrollBar.Maximum = totalWidth;

            // Set the small change and large change values of the scrollbar
            RR_hScrollBar.SmallChange = 10;
            RR_hScrollBar.LargeChange = RR_Process_flowLayoutPanel.ClientSize.Width;
        }

        private void RR_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            RR_Time_flowLayoutPanel.HorizontalScroll.Value = RR_hScrollBar.Value;
            RR_Process_flowLayoutPanel.HorizontalScroll.Value = RR_hScrollBar.Value;
            RR_updateScrolling();
        }

        private void RR_Static_Logic_Display()
        {
            int noOfIdleSlot = 0;
            /*-----------sort the queue of processes-------*/
            Process[] array = RR_Input_Queue.ToArray();
            Array.Sort(array, new ArrivalTimeComparer());
            RR_Input_Queue = new Queue<Process>(array);
            int timeGiven;
            Process tempProcess;
            while(RR_Input_Queue.Count != 0)
            { 
                tempProcess = RR_Input_Queue.Peek();
                if (RR_ACC < tempProcess.arrival_time)
                {
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = RR_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    RR_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    RR_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*--------------------update RR_ACC--------------------------*/
                    noOfIdleSlot += (tempProcess.arrival_time - RR_ACC);
                    RR_ACC = tempProcess.arrival_time;
                }
                else
                {
                    RR_Input_Queue.Dequeue(); 
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = RR_ACC.ToString();

                    if (tempProcess.burst_time > RR_QuantamTime)
                        timeGiven = RR_QuantamTime;
                    else
                        timeGiven = tempProcess.burst_time;

                    if (timeGiven < 5)
                        tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH*timeGiven;
                    else
                        tempLabel_Time.Width = MAX_PROCESS_SLOT_WIDTH;
                    RR_Time_flowLayoutPanel.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
                    if (timeGiven < 5)
                        tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH*timeGiven;
                    else
                        tempLabel_Process.Width = MAX_PROCESS_SLOT_WIDTH;
                    RR_Process_flowLayoutPanel.Controls.Add(tempLabel_Process);
                    /*--------------------update RR_ACC---------------------------*/
                    RR_ACC += timeGiven;
                    tempProcess.burst_time -= timeGiven;
                    if (tempProcess.burst_time != 0)
                    {
                        int count = 0;
                        Queue<Process> copiedQueue = new Queue<Process>(RR_Input_Queue);
                        foreach (Process p in copiedQueue)
                        {
                            if (p.arrival_time > RR_ACC)
                            {
                                List<Process> tempList = new List<Process>(RR_Input_Queue); // convert the array into a list
                                tempList.Insert(count, tempProcess); // insert the new object at the desired index
                                RR_Input_Queue = new Queue<Process>(tempList);
                                break;
                            }
                            count++;
                        }
                        if(count == copiedQueue.Count)
                            RR_Input_Queue.Enqueue(tempProcess);
                    }
                    /*--------------average waiting time-----------------------*/
                    else
                    {
                        foreach (DataGridViewRow row in RR_dataGridView.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == tempProcess.Pid.ToString())
                            {
                                RR_SumOfWaitTime +=  ( RR_ACC - int.Parse(row.Cells[1].Value.ToString()) - int.Parse(row.Cells[2].Value.ToString()));
                                RR_sumWaitingTime_textBox.Text = RR_SumOfWaitTime.ToString();
                                if (RR_QUEUE_SIZE != 0)
                                    RR_avgWaitingTime_textBox.Text = (RR_SumOfWaitTime/RR_QUEUE_SIZE).ToString("F2");
                                else
                                    RR_avgWaitingTime_textBox.Text = "0";
                                break;
                            }
                        }
                    }
                }
            }
            /*---------------average turnaround time--------------------*/
            RR_SumOfTurnAroundTime = RR_SumOfWaitTime + RR_ACC - noOfIdleSlot;
            RR_sumTurnAroundTime_textBox.Text = RR_SumOfTurnAroundTime.ToString();
            if (RR_QUEUE_SIZE != 0)
                RR_avgTurnAroundTime_textBox.Text = (RR_SumOfTurnAroundTime/RR_QUEUE_SIZE).ToString("F2");
            else
                RR_avgTurnAroundTime_textBox.Text = "0";
            /*-----------------last time label---------------------------------*/
            WF.Label lastTimeLabel = new WF.Label();
            lastTimeLabel.Text = RR_ACC.ToString();
            RR_Time_flowLayoutPanel.Controls.Add(lastTimeLabel);
        }

        /*---------------------------------Dynamic Logic--------------------------------*/
        bool flag = false;
        private void RR_Logic()
        {
            Process tempProcess = RR_Input_Queue.Dequeue();

            if(tempProcess.burst_time <= RR_QuantamTime)
                RR_NextPossibleSlot = RR_ACC + tempProcess.burst_time;
            else
                RR_NextPossibleSlot = RR_ACC + RR_QuantamTime;

            int counter = tempProcess.burst_time;
            int x = RR_ACC;
            if (counter <= RR_QuantamTime)
            {
                for (int i = 0; i < counter; i++)
                {
                    RR_Display_Queue.Enqueue(new Process(tempProcess.Pid, 1+x, x));
                    x++;
                }
            }
            else
            {
                for (int i = 0; i < RR_QuantamTime; i++)
                {
                    RR_Display_Queue.Enqueue(new Process(tempProcess.Pid, 1+x, x));
                    x++;
                }
                tempProcess.burst_time -= RR_QuantamTime;
                tempProcess.arrival_time += RR_QuantamTime;
                RRRR.Enqueue(tempProcess);
                flag = true;
            }
        }
        private void RR_Display()
        {
            int RR_Time_Acc = RR_Display_Queue.Peek().arrival_time;
            Process tempProcess;
            tempProcess = RR_Display_Queue.Dequeue();
            /*-----------------time chart---------------------------------*/
            WF.Label tempLabel_Time = new WF.Label();
            tempLabel_Time.Text = RR_Time_Acc.ToString();
            tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
            if (!RR_Page)
                RR_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
            else
                RR_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
            /*------------------gantt chart code--------------------------*/
            WF.Label tempLabel_Process = new WF.Label();
            tempLabel_Process.Enabled = true;
            tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
            tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
            tempLabel_Process.Text = "P" + tempProcess.Pid.ToString();
            tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
            if (!RR_Page)
                RR_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
            else
                RR_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
        }
        private void RR_updateTable()
        {
            /*---------------- update table---------------------*/
            foreach (DataGridViewRow row in RR_dataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == RR_Display_Queue.Peek().Pid.ToString())
                {
                    int currentValue = Convert.ToInt32(row.Cells[2].Value);
                    if (currentValue != 1)
                        row.Cells[2].Value = (currentValue - 1).ToString();
                    else
                        RR_dataGridView.Rows.RemoveAt(row.Index);

                    break;
                }
            }
            if (RR_dataGridView.Rows.Count != 0)
            {
                /*--------------average waiting time-----------------------*/
                RR_SumOfWaitTime += RR_dataGridView.Rows.Count-1;
                RR_sumWaitingTime_textBox.Text = RR_SumOfWaitTime.ToString();
                if (RR_QUEUE_SIZE != 0)
                    RR_avgWaitingTime_textBox.Text = (RR_SumOfWaitTime/RR_QUEUE_SIZE).ToString("F2");
                else
                    RR_avgWaitingTime_textBox.Text = "0";
                /*--------------turnaround waiting time-----------------------*/
                RR_SumOfTurnAroundTime += RR_dataGridView.Rows.Count;
                RR_sumTurnAroundTime_textBox.Text =  RR_SumOfTurnAroundTime.ToString();
                if (RR_QUEUE_SIZE != 0)
                    RR_avgTurnAroundTime_textBox.Text = (RR_SumOfTurnAroundTime/RR_QUEUE_SIZE).ToString("F2");
                else
                    RR_avgTurnAroundTime_textBox.Text = "0";
            }
        }

        bool RR_Page = false;
        private void RR_Timer_Tick(object sender, EventArgs e)
        {
            if (!RR_Jump)
            {
                if (RR_ACC != 0 && RR_ACC %MAX_PAGE == 0 && RR_Page)
                {
                    RR_Time_flowLayoutPanel2.Controls.Clear();
                    RR_Process_flowLayoutPanel2.Controls.Clear();
                    RR_Time_flowLayoutPanel3.Controls.Clear();
                    RR_Process_flowLayoutPanel3.Controls.Clear();
                    RR_Page = !RR_Page;
                }
                else if (RR_ACC != 0 && RR_ACC % (MAX_PAGE/2) == 0)
                    RR_Page = !RR_Page;


                if (flag && RR_ACC == RR_NextPossibleSlot)
                {
                    while (RRRR.Count != 0)
                    {
                        RR_Input_Queue.Enqueue(RRRR.Dequeue());
                    }
                    flag = false;
                }

                if (RR_Input_Queue.Count != 0  && RR_ACC == RR_NextPossibleSlot)
                {
                    RR_Timer.Stop();
                    RR_Logic();
                }

                if (RR_Display_Queue.Count != 0)
                {
                    RR_updateTable();
                    RR_Display();
                }
                else
                {
                    RR_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = RR_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!RR_Page)
                        RR_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        RR_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!RR_Page)
                        RR_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        RR_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);
                }

                RR_Timer.Start();
                RR_ACC++;
                RR_CurrentSlot_label.Text = RR_ACC.ToString();
            }
            else
            {
                RR_JUMPHandler();
            }
        }
        private void RR_JUMPHandler()
        {
            while (true)
            {
                if (RR_ACC != 0 && RR_ACC %MAX_PAGE == 0 && RR_Page)
                {
                    RR_Time_flowLayoutPanel2.Controls.Clear();
                    RR_Process_flowLayoutPanel2.Controls.Clear();
                    RR_Time_flowLayoutPanel3.Controls.Clear();
                    RR_Process_flowLayoutPanel3.Controls.Clear();
                    RR_Page = !RR_Page;
                }
                else if (RR_ACC != 0 && RR_ACC % (MAX_PAGE/2) == 0)
                    RR_Page = !RR_Page;



                if (flag && RR_ACC == RR_NextPossibleSlot)
                {
                    while (RRRR.Count != 0)
                    {
                        RR_Input_Queue.Enqueue(RRRR.Dequeue());
                    }
                    flag = false;
                }

                if (RR_Input_Queue.Count != 0 && RR_ACC == RR_NextPossibleSlot)
                    RR_Logic();
                if (RR_Display_Queue.Count != 0)
                {
                    RR_updateTable();
                    RR_Display();


                    ////////////////////////
                    RR_Timer.Interval = 1;
                    ////////////////////////
                }
                else
                {
                    RR_NextPossibleSlot++;
                    /*-----------------time chart---------------------------------*/
                    WF.Label tempLabel_Time = new WF.Label();
                    tempLabel_Time.Text = RR_ACC.ToString();
                    tempLabel_Time.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!RR_Page)
                        RR_Time_flowLayoutPanel2.Controls.Add(tempLabel_Time);
                    else
                        RR_Time_flowLayoutPanel3.Controls.Add(tempLabel_Time);
                    /*------------------gantt chart code--------------------------*/
                    WF.Label tempLabel_Process = new WF.Label();
                    tempLabel_Process.Enabled = true;
                    tempLabel_Process.BorderStyle = BorderStyle.FixedSingle;
                    tempLabel_Process.Font = new Font("Arial", 10, FontStyle.Bold);
                    tempLabel_Process.Text = "IDLE";
                    tempLabel_Process.Width = MIN_PROCESS_SLOT_WIDTH;
                    if (!RR_Page)
                        RR_Process_flowLayoutPanel2.Controls.Add(tempLabel_Process);
                    else
                        RR_Process_flowLayoutPanel3.Controls.Add(tempLabel_Process);

                    ////////////////////////
                    if (RR_trackBar.Value != 0)
                        RR_Timer.Interval = RR_trackBar.Value*1000;
                    else
                        RR_Timer.Interval = 1000;
                    /////////////////////////
                }
                RR_ACC++;
                RR_CurrentSlot_label.Text = RR_ACC.ToString();

                if (RR_Display_Queue.Count == 0 && RR_Input_Queue.Count == 0 || !RR_Jump)
                    break;
            }
        }
        private void RR_trackBar_Scroll(object sender, EventArgs e)
        {
            if (RR_trackBar.Value != 0)
                RR_Timer.Interval = RR_trackBar.Value*1000;
            else
                RR_Timer.Interval = 1000;
        }
        /*----------------------------------Check box handler----------------------------*/
        private void RR_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RR_Live_checkBox.Checked)
            {
                RR_Live = true;
                RR_Jump_checkBox.Enabled = true;
                RR_Timer.Start();
                RR_Insert_btn.Enabled = true;
                RR_ArrivalTime_textbook.Enabled = true;
                RR_BurstTime_textbook.Enabled = true;
                RR_Ok_btn.Enabled = false;
                RR_NoOfProcesses_textbook.Enabled = false;
                RR_NoOfProcesses_Label.Enabled = false;
                RR_ArrivalTime_textbook.Enabled = false;
                RR_ArrivalTime_label.Enabled = false;
            }
            else
            {
                RR_Live = false;
                RR_Jump_checkBox.Enabled = true;
                RR_Timer.Stop();
                RR_Insert_btn.Enabled = false;
                RR_ArrivalTime_textbook.Enabled = false;
                RR_BurstTime_textbook.Enabled = false;
                RR_Ok_btn.Enabled = true;
                RR_NoOfProcesses_textbook.Enabled = true;
                RR_NoOfProcesses_Label.Enabled = true;
                RR_ArrivalTime_textbook.Enabled = true;
                RR_ArrivalTime_label.Enabled = true;
            }
        }
        private void RR_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RR_Jump_checkBox.Checked)
            {
                RR_Jump = true;
            }
            else
            {
                RR_Jump = false;
                ////////////////////////////////////////////////
                if (RR_trackBar.Value != 0)
                    RR_Timer.Interval = RR_trackBar.Value*1000;
                else
                    RR_Timer.Interval = 1000;
                ///////////////////////////////////////////////
            }
        }

        /*----------------------------------Combo box handler----------------------------*/
        private void RR_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RR_Mode_comboBox.Text == "Static")
            {
                RR_trackBar.Enabled = false;
                RR_trackBar.Visible = false;

                RR_hScrollBar.Enabled = false;
                RR_hScrollBar.Visible = false;
                RR_QuantamTime_Label.Enabled = true;
                RR_QuantamTime_Label.Visible = true;
                RR_QuantamTime_textBox.Enabled = true;
                RR_QuantamTime_textBox.Visible = true;
                RR_Ok_btn.Enabled = true;
                RR_Ok_btn.Visible = true;
                RR_ArrivalTime_label.Enabled = false;
                RR_ArrivalTime_label.Visible = false;
                RR_ArrivalTime_textbook.Enabled = false;
                RR_ArrivalTime_textbook.Visible = false;
                RR_BurstTime_label.Enabled = false;
                RR_BurstTime_label.Visible = false;
                RR_BurstTime_textbook.Enabled = false;
                RR_BurstTime_textbook.Visible = false;
                RR_dataGridView.Enabled = true;
                RR_dataGridView.Visible = true;
                RR_Slot_label.Enabled = false;
                RR_Slot_label.Visible = false;
                RR_CurrentSlot_label.Enabled = false;
                RR_CurrentSlot_label.Visible = false;
                RR_Insert_btn.Enabled = false;
                RR_Insert_btn.Visible = false;
                RR_NoOfProcesses_textbook.Enabled = true;
                RR_NoOfProcesses_textbook.Visible = true;
                RR_NoOfProcesses_Label.Enabled = true;
                RR_NoOfProcesses_Label.Visible = true;
                RR_Live_checkBox.Enabled = false;
                RR_Live_checkBox.Visible = false;
                RR_Jump_checkBox.Enabled = false;
                RR_Jump_checkBox.Visible = false;

                RR_sumWaitingTime_label.Enabled = false;
                RR_sumWaitingTime_label.Visible = false;
                RR_sumWaitingTime_textBox.Enabled = false;
                RR_sumWaitingTime_textBox.Visible = false;

                RR_avgWaitingTime_label.Enabled = false;
                RR_avgWaitingTime_label.Visible = false;
                RR_avgWaitingTime_textBox.Enabled = false;
                RR_avgWaitingTime_textBox.Visible = false;

                RR_sumTurnAroundTime_textBox.Enabled = false;
                RR_sumTurnAroundTime_textBox.Visible = false;
                RR_sumTurnAroundTime_label.Enabled = false;
                RR_sumTurnAroundTime_label.Visible = false;

                RR_avgTurnAroundTime_textBox.Enabled = false;
                RR_avgTurnAroundTime_textBox.Visible = false;
                RR_avgTurnAroundTime_label.Enabled = false;
                RR_avgTurnAroundTime_label.Visible = false;
            }
            else if (RR_Mode_comboBox.Text == "Dynamic")
            {
                RR_trackBar.Enabled = true;
                RR_trackBar.Visible = true;

                RR_hScrollBar.Enabled = false;
                RR_hScrollBar.Visible = false;
                RR_QuantamTime_Label.Enabled = true;
                RR_QuantamTime_Label.Visible = true;
                RR_QuantamTime_textBox.Enabled = true;
                RR_QuantamTime_textBox.Visible = true;
                RR_Ok_btn.Enabled = true;
                RR_Ok_btn.Visible = true;
                RR_ArrivalTime_label.Enabled = false;
                RR_ArrivalTime_label.Visible = false;
                RR_ArrivalTime_textbook.Enabled = false;
                RR_ArrivalTime_textbook.Visible = false;
                RR_BurstTime_label.Enabled = false;
                RR_BurstTime_label.Visible = false;
                RR_BurstTime_textbook.Enabled = false;
                RR_BurstTime_textbook.Visible = false;
                RR_dataGridView.Enabled = true;
                RR_dataGridView.Visible = true;
                RR_Slot_label.Enabled = true;
                RR_Slot_label.Visible = true;
                RR_CurrentSlot_label.Enabled = true;
                RR_CurrentSlot_label.Visible = true;
                RR_Insert_btn.Enabled = false;
                RR_Insert_btn.Visible = false;
                RR_NoOfProcesses_textbook.Enabled = false;
                RR_NoOfProcesses_textbook.Visible = false;
                RR_NoOfProcesses_Label.Enabled = false;
                RR_NoOfProcesses_Label.Visible = false;
                RR_Live_checkBox.Enabled = false;
                RR_Live_checkBox.Visible = false;
                RR_Jump_checkBox.Enabled = false;
                RR_Jump_checkBox.Visible = false;

                RR_sumWaitingTime_label.Enabled = true;
                RR_sumWaitingTime_label.Visible = true;
                RR_sumWaitingTime_textBox.Enabled = true;
                RR_sumWaitingTime_textBox.Visible = true;

                RR_avgWaitingTime_label.Enabled = true;
                RR_avgWaitingTime_label.Visible = true;
                RR_avgWaitingTime_textBox.Enabled = true;
                RR_avgWaitingTime_textBox.Visible = true;

                RR_sumTurnAroundTime_textBox.Enabled = true;
                RR_sumTurnAroundTime_textBox.Visible = true;
                RR_sumTurnAroundTime_label.Enabled = true;
                RR_sumTurnAroundTime_label.Visible = true;

                RR_avgTurnAroundTime_textBox.Enabled = true;
                RR_avgTurnAroundTime_textBox.Visible = true;
                RR_avgTurnAroundTime_label.Enabled = true;
                RR_avgTurnAroundTime_label.Visible = true;
            }
        }

        /*--------------------------------------Reset------------------------------------*/
        private void RR_Rest()
        {
            RR_hScrollBar.Enabled = false;
            RR_hScrollBar.Visible = false;
            RR_Page = false; 
            RR_Timer.Stop();
            RR_NoOfProcesses_textbook.Clear();
            RR_QuantamTime_textBox.Clear();
            RR_NoOfProcesses_textbook.ReadOnly = false;
            RR_QuantamTime_textBox.ReadOnly = false;
            RR_Input_Queue.Clear();
            RR_Display_Queue.Clear();
            RRRR.Clear();
            RR_ACC = 0;
            RR_Live = false;
            RR_Jump = false;
            RR_NextPossibleSlot = 0;
            RR_CurrentSlot_label.Text = "0";
            RR_SumOfWaitTime = 0;
            RR_SumOfTurnAroundTime = 0;
            RR_Time_flowLayoutPanel.Controls.Clear();
            RR_Process_flowLayoutPanel.Controls.Clear();
            RR_Time_flowLayoutPanel2.Controls.Clear();
            RR_Process_flowLayoutPanel2.Controls.Clear();
            RR_Time_flowLayoutPanel3.Controls.Clear();
            RR_Process_flowLayoutPanel3.Controls.Clear();
            RR_QuantamTime_Label.Enabled = false;
            RR_QuantamTime_Label.Visible = false;
            RR_QuantamTime_textBox.Enabled = false;
            RR_QuantamTime_textBox.Visible = false;
            RR_Ok_btn.Enabled = false;
            RR_Ok_btn.Visible = false;
            RR_ArrivalTime_label.Enabled = false;
            RR_ArrivalTime_label.Visible = false;
            RR_ArrivalTime_textbook.Enabled = false;
            RR_ArrivalTime_textbook.Clear();
            RR_ArrivalTime_textbook.Visible = false;
            RR_BurstTime_label.Enabled = false;
            RR_BurstTime_label.Visible = false;
            RR_BurstTime_textbook.Enabled = false;
            RR_BurstTime_textbook.Clear();
            RR_BurstTime_textbook.Visible = false;
            RR_dataGridView.Enabled = false;
            RR_dataGridView.Visible = false;
            RR_Slot_label.Enabled = false;
            RR_Slot_label.Visible = false;
            RR_CurrentSlot_label.Enabled = false;
            RR_CurrentSlot_label.Visible = false;
            RR_Insert_btn.Enabled = false;
            RR_Insert_btn.Visible = false;
            RR_NoOfProcesses_textbook.Enabled = false;
            RR_NoOfProcesses_textbook.Visible = false;
            RR_NoOfProcesses_Label.Enabled = false;
            RR_NoOfProcesses_Label.Visible = false;
            RR_Live_checkBox.Enabled = false;
            RR_Live_checkBox.Visible = false;
            RR_Jump_checkBox.Enabled = false;
            RR_Jump_checkBox.Visible = false;

            RR_sumWaitingTime_label.Enabled = false;
            RR_sumWaitingTime_label.Visible = false;
            RR_sumWaitingTime_textBox.Enabled = false;
            RR_sumWaitingTime_textBox.Visible = false;
            RR_sumWaitingTime_textBox.Text = "0";

            RR_avgWaitingTime_label.Enabled = false;
            RR_avgWaitingTime_label.Visible = false;
            RR_avgWaitingTime_textBox.Enabled = false;
            RR_avgWaitingTime_textBox.Visible = false;
            RR_avgWaitingTime_textBox.Text = "0";

            RR_sumTurnAroundTime_textBox.Enabled = false;
            RR_sumTurnAroundTime_textBox.Visible = false;
            RR_sumTurnAroundTime_label.Enabled = false;
            RR_sumTurnAroundTime_label.Visible = false;
            RR_sumTurnAroundTime_textBox.Text = "0";

            RR_avgTurnAroundTime_textBox.Enabled = false;
            RR_avgTurnAroundTime_textBox.Visible = false;
            RR_avgTurnAroundTime_label.Enabled = false;
            RR_avgTurnAroundTime_label.Visible = false;
            RR_avgTurnAroundTime_textBox.Text = "0";

            RR_Mode_comboBox.SelectedIndex = -1;
            RR_dataGridView.Rows.Clear();
            RR_Live_checkBox.Checked = false;
            RR_Jump_checkBox.Checked = false;
            RR_QUEUE_SIZE = 0;

            RR_trackBar.Enabled = false;
            RR_trackBar.Visible = false;
            RR_trackBar.Value = 0;
            RR_Timer.Interval = 1000;
        }
        private void RR_Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        /*--------------------------------------------------------End of RR functions--------------------------------------------------------*/        
    }
}

class Process
{
    public int Pid;
    public int burst_time;
    public int arrival_time;

    public int last_active = 0;
    public int waiting_time;
    public int piority;

    public Process() { }
    public Process(int pid, int burstTime, int arrivalTime)
    {
        this.Pid = pid;
        this.burst_time = burstTime;
        this.arrival_time = arrivalTime;
    }

    public void increaseBurstTime(int value)
    {
        burst_time += value;
    }
    public void increaseArrivalTime(int value)
    {
        arrival_time += value;
    }

    public void decreaseBurstTime(int value)
    {
        burst_time -= value;
    }
    public void decreaseArrivalTime(int value)
    {
        arrival_time -= value;
    }

    public Process copy(int k)
    {
        return new Process(Pid, k+arrival_time, arrival_time);
    }
}
class ArrivalTimeComparer : IComparer<Process>
{
    public int Compare(Process x, Process y)
    {
        return x.arrival_time.CompareTo(y.arrival_time);
    }
}














/*
        first_index : store index of process that has minimum arrival time --> minimum burst time not 0
        last_index  : store index of process that has minimum arrival time --> last 
*/



/*
                        Arrival time     burst time
                                4               10           <--- first_index
        last_index --->         4               17                                  ***************
                                8               4                                   *  if  block  *
                                10              5                                   ***************



                        Arrival time     burst time
                                4               10           <--- first_index
                                4               17                                  ***************
        last_index --->         4               4                                   *  if  block  *
                                10              5                                   ***************


                        Arrival time     burst time
                                4               10           <--- first_index
                                4               17                                 ****************
                                4               4                                  *  else block  *
        last_index --->         4               5                                  ****************



            Arrival time     burst time
                                0               2           
                                0               3                                  ****************
                                0               4                                  *  else block  *
        last_index --->         0               1        <--- first_index          **************** 



                            Arrival time     burst time
                                4               2        <--- first_index
        last_index --->         4               3                                  ****************
                                8               4                                  *  else block  *
                                10              5                                  ****************



                        Arrival time     burst time
                            4               2           <--- first_index
                            4               3                                   ****************
                            4               4                                   *  else block  *
        last_index --->     4               5                                   ****************                                                   



                        Arrival time     burst time
                            4               2          
                            4               3                                  ****************
                            4               4                                  *  else block  *
        last_index --->     4               1           <--- first_index       ****************

*/


/*    idea to calculate waiting time in static mode
    
       waiting time = leaving time - burst time - arrival time

*/

/*      Functions 
 
		private void reset()
		
		private void FCFS_Insert_btn_Click(object sender, EventArgs e)
        private void FCFS_Ok_btn_Click(object sender, EventArgs e)
        private void FCFS_updateScrolling()
        private void FCFS_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        private void FCFS_Static_Logic_Display()
        private void FCFS_Logic()
        private void FCFS_Display()
        private void FCFS_updateTable()      
        private void FCFS_Timer_Tick(object sender, EventArgs e)
        private void FCFS_JUMPHandler()
        private void FCFS_trackBar_Scroll(object sender, EventArgs e)
        private void FCFS_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        private void FCFS_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        private void FCFS_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        private void FCFS_Rest()
        private void FCFS_Reset_btn_Click(object sender, EventArgs e)

		private void SJF_Insert_btn_Click(object sender, EventArgs e)
		private void SJF_Ok_btn_Click(object sender, EventArgs e)
		private void SJF_Static_Logic()
        private void SJF_updateScrolling()
        private void SJF_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        private void SJF_Static_Display()
        private void SJF_Logic()
        private void SJF_Display()
        private void SJF_updateTable()
        private void SJF_Timer_Tick(object sender, EventArgs e)
        private void SJF_JUMPHandler()
        private void SJF_trackBar_Scroll(object sender, EventArgs e)
        private void SJF_Version_checkBox_CheckedChanged(object sender, EventArgs e)
        private void SJF_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        private void SJF_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        private void SJF_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        private void SJF_Rest()
		private void SJF_Reset_btn_Click(object sender, EventArgs e)
    
		private void PIOR_Insert_btn_Click(object sender, EventArgs e)
        private void PIOR_Ok_btn_Click(object sender, EventArgs e)
        private void PIOR_Static_Logic()
        private void PIOR_updateScrolling()
        private void PIOR_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        private void PIOR_Static_Display()
        private void PIOR_Logic()
        private void PIOR_Display()
        private void PIOR_updateTable()
        private void PIOR_Timer_Tick(object sender, EventArgs e)
        private void PIOR_JUMPHandler()
        private void PIOR_trackBar_Scroll(object sender, EventArgs e)
        private void PIOR_Version_checkBox_CheckedChanged(object sender, EventArgs e)
        private void PIOR_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        private void PIOR_Live_checkBox_CheckedChanged(object sender, EventArgs e)   
        private void PIOR_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        private void PIOR_Rest()
        private void PIOR_Reset_btn_Click(object sender, EventArgs e)
        	
		private void RR_Insert_btn_Click(object sender, EventArgs e)
        private void RR_Ok_btn_Click(object sender, EventArgs e)
        private void RR_updateScrolling()
        private void RR_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        private void RR_Static_Logic_Display()     
        private void RR_Logic()
        private void RR_Display()
        private void RR_updateTable()
        private void RR_Timer_Tick(object sender, EventArgs e)
        private void RR_JUMPHandler()
        private void RR_trackBar_Scroll(object sender, EventArgs e)
        private void RR_Live_checkBox_CheckedChanged(object sender, EventArgs e)
        private void RR_Jump_checkBox_CheckedChanged(object sender, EventArgs e)
        private void RR_Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        private void RR_Rest()
        private void RR_Reset_btn_Click(object sender, EventArgs e)
*/