namespace OS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SJF_Timer = new System.Windows.Forms.Timer(this.components);
            this.FCFS_Timer = new System.Windows.Forms.Timer(this.components);
            this.PIOR_Timer = new System.Windows.Forms.Timer(this.components);
            this.RR_Timer = new System.Windows.Forms.Timer(this.components);
            this.Round_Robin = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.RR_trackBar = new System.Windows.Forms.TrackBar();
            this.RR_avgTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.RR_avgWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.RR_sumTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.RR_sumWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.RR_QuantamTime_textBox = new System.Windows.Forms.TextBox();
            this.RR_BurstTime_textbook = new System.Windows.Forms.TextBox();
            this.RR_ArrivalTime_textbook = new System.Windows.Forms.TextBox();
            this.RR_NoOfProcesses_textbook = new System.Windows.Forms.TextBox();
            this.RR_avgTurnAroundTime_label = new System.Windows.Forms.Label();
            this.RR_avgWaitingTime_label = new System.Windows.Forms.Label();
            this.RR_sumTurnAroundTime_label = new System.Windows.Forms.Label();
            this.RR_sumWaitingTime_label = new System.Windows.Forms.Label();
            this.RR_Process_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RR_Process_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.RR_Time_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.RR_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.RR_Time_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RR_Process_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RR_Time_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RR_Reset_btn = new System.Windows.Forms.Button();
            this.RR_Mode_Label = new System.Windows.Forms.Label();
            this.RR_Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.RR_QuantamTime_Label = new System.Windows.Forms.Label();
            this.RR_NoOfProcesses_Label = new System.Windows.Forms.Label();
            this.RR_BurstTime_label = new System.Windows.Forms.Label();
            this.RR_ArrivalTime_label = new System.Windows.Forms.Label();
            this.RR_Insert_btn = new System.Windows.Forms.Button();
            this.RR_Ok_btn = new System.Windows.Forms.Button();
            this.RR_Jump_checkBox = new System.Windows.Forms.CheckBox();
            this.RR_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RR_Live_checkBox = new System.Windows.Forms.CheckBox();
            this.RR_CurrentSlot_label = new System.Windows.Forms.Label();
            this.RR_Slot_label = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PIOR_trackBar = new System.Windows.Forms.TrackBar();
            this.PIOR_avgTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.PIOR_avgWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.PIOR_sumTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.PIOR_sumWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.PIOR_Piority_textbook = new System.Windows.Forms.TextBox();
            this.PIOR_BurstTime_textbook = new System.Windows.Forms.TextBox();
            this.PIOR_ArrivalTime_textbook = new System.Windows.Forms.TextBox();
            this.PIOR_NoOfProcesses_textbook = new System.Windows.Forms.TextBox();
            this.PIOR_avgTurnAroundTime_label = new System.Windows.Forms.Label();
            this.PIOR_avgWaitingTime_label = new System.Windows.Forms.Label();
            this.PIOR_sumTurnAroundTime_label = new System.Windows.Forms.Label();
            this.PIOR_sumWaitingTime_label = new System.Windows.Forms.Label();
            this.PIOR_Process_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PIOR_Process_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PIOR_Time_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PIOR_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.PIOR_Time_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PIOR_Process_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PIOR_Time_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PIOR_Reset_btn = new System.Windows.Forms.Button();
            this.PIOR_Mode_Label = new System.Windows.Forms.Label();
            this.PIOR_Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.PIOR_Piority_label = new System.Windows.Forms.Label();
            this.PIOR_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIOR_Jump_checkBox = new System.Windows.Forms.CheckBox();
            this.PIOR_CurrentSlot_label = new System.Windows.Forms.Label();
            this.PIOR_Slot_label = new System.Windows.Forms.Label();
            this.PIOR_Live_checkBox = new System.Windows.Forms.CheckBox();
            this.PIOR_Version_checkBox = new System.Windows.Forms.CheckBox();
            this.PIOR_NoOfProcesses_Label = new System.Windows.Forms.Label();
            this.PIOR_BurstTime_label = new System.Windows.Forms.Label();
            this.PIOR_ArrivalTime_label = new System.Windows.Forms.Label();
            this.PIOR_Insert_btn = new System.Windows.Forms.Button();
            this.PIOR_Ok_btn = new System.Windows.Forms.Button();
            this.SJF = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SJF_trackBar = new System.Windows.Forms.TrackBar();
            this.SJF_avgTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.SJF_avgWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.SJF_sumTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.SJF_sumWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.SJF_BurstTime_textbook = new System.Windows.Forms.TextBox();
            this.SJF_ArrivalTime_textbook = new System.Windows.Forms.TextBox();
            this.SJF_NoOfProcesses_textbook = new System.Windows.Forms.TextBox();
            this.SJF_avgTurnAroundTime_label = new System.Windows.Forms.Label();
            this.SJF_avgWaitingTime_label = new System.Windows.Forms.Label();
            this.SJF_sumTurnAroundTime_label = new System.Windows.Forms.Label();
            this.SJF_sumWaitingTime_label = new System.Windows.Forms.Label();
            this.SJF_Process_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SJF_Process_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.SJF_Time_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.SJF_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.SJF_Time_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SJF_Process_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SJF_Time_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SJF_Reset_btn = new System.Windows.Forms.Button();
            this.SJF_Mode_Label = new System.Windows.Forms.Label();
            this.SJF_Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.SJF_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SJF_Jump_checkBox = new System.Windows.Forms.CheckBox();
            this.SJF_CurrentSlot_label = new System.Windows.Forms.Label();
            this.SJF_Slot_label = new System.Windows.Forms.Label();
            this.SJF_Live_checkBox = new System.Windows.Forms.CheckBox();
            this.SJF_Version_checkBox = new System.Windows.Forms.CheckBox();
            this.SJF_NoOfProcesses_Label = new System.Windows.Forms.Label();
            this.SJF_BurstTime_label = new System.Windows.Forms.Label();
            this.SJF_ArrivalTime_label = new System.Windows.Forms.Label();
            this.SJF_Insert_btn = new System.Windows.Forms.Button();
            this.SJF_Ok_btn = new System.Windows.Forms.Button();
            this.FCFS = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FCFS_trackBar = new System.Windows.Forms.TrackBar();
            this.FCFS_Process_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FCFS_Process_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.FCFS_Time_flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.FCFS_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.FCFS_Time_flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FCFS_Process_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FCFS_Time_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FCFS_avgTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.FCFS_avgWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.FCFS_sumTurnAroundTime_textBox = new System.Windows.Forms.TextBox();
            this.FCFS_sumWaitingTime_textBox = new System.Windows.Forms.TextBox();
            this.FCFS_BurstTime_textbook = new System.Windows.Forms.TextBox();
            this.FCFS_ArrivalTime_textbook = new System.Windows.Forms.TextBox();
            this.FCFS_NoOfProcesses_textbook = new System.Windows.Forms.TextBox();
            this.FCFS_avgTurnAroundTime_label = new System.Windows.Forms.Label();
            this.FCFS_avgWaitingTime_label = new System.Windows.Forms.Label();
            this.FCFS_sumTurnAroundTime_label = new System.Windows.Forms.Label();
            this.FCFS_Reset_btn = new System.Windows.Forms.Button();
            this.FCFS_Mode_Label = new System.Windows.Forms.Label();
            this.FCFS_Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.FCFS_sumWaitingTime_label = new System.Windows.Forms.Label();
            this.FCFS_dataGridView = new System.Windows.Forms.DataGridView();
            this.FCFS_PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCFS_ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCFS_BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCFS_Jump_checkBox = new System.Windows.Forms.CheckBox();
            this.FCFS_CurrentSlot_label = new System.Windows.Forms.Label();
            this.FCFS_Slot_label = new System.Windows.Forms.Label();
            this.FCFS_Live_checkBox = new System.Windows.Forms.CheckBox();
            this.FCFS_NoOfProcesses_Label = new System.Windows.Forms.Label();
            this.FCFS_BurstTime_label = new System.Windows.Forms.Label();
            this.FCFS_ArrivalTime_label = new System.Windows.Forms.Label();
            this.FCFS_Insert_btn = new System.Windows.Forms.Button();
            this.FCFS_Ok_btn = new System.Windows.Forms.Button();
            this.PIO_NoOfProcesses_textbook = new System.Windows.Forms.TabControl();
            this.Round_Robin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RR_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RR_dataGridView)).BeginInit();
            this.Priority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIOR_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIOR_dataGridView)).BeginInit();
            this.SJF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SJF_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SJF_dataGridView)).BeginInit();
            this.FCFS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCFS_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCFS_dataGridView)).BeginInit();
            this.PIO_NoOfProcesses_textbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // SJF_Timer
            // 
            this.SJF_Timer.Interval = 1000;
            this.SJF_Timer.Tick += new System.EventHandler(this.SJF_Timer_Tick);
            // 
            // FCFS_Timer
            // 
            this.FCFS_Timer.Interval = 1000;
            this.FCFS_Timer.Tick += new System.EventHandler(this.FCFS_Timer_Tick);
            // 
            // PIOR_Timer
            // 
            this.PIOR_Timer.Interval = 1000;
            this.PIOR_Timer.Tick += new System.EventHandler(this.PIOR_Timer_Tick);
            // 
            // RR_Timer
            // 
            this.RR_Timer.Interval = 1000;
            this.RR_Timer.Tick += new System.EventHandler(this.RR_Timer_Tick);
            // 
            // Round_Robin
            // 
            this.Round_Robin.Controls.Add(this.panel7);
            this.Round_Robin.Controls.Add(this.panel8);
            this.Round_Robin.Controls.Add(this.RR_trackBar);
            this.Round_Robin.Controls.Add(this.RR_avgTurnAroundTime_textBox);
            this.Round_Robin.Controls.Add(this.RR_avgWaitingTime_textBox);
            this.Round_Robin.Controls.Add(this.RR_sumTurnAroundTime_textBox);
            this.Round_Robin.Controls.Add(this.RR_sumWaitingTime_textBox);
            this.Round_Robin.Controls.Add(this.RR_QuantamTime_textBox);
            this.Round_Robin.Controls.Add(this.RR_BurstTime_textbook);
            this.Round_Robin.Controls.Add(this.RR_ArrivalTime_textbook);
            this.Round_Robin.Controls.Add(this.RR_NoOfProcesses_textbook);
            this.Round_Robin.Controls.Add(this.RR_avgTurnAroundTime_label);
            this.Round_Robin.Controls.Add(this.RR_avgWaitingTime_label);
            this.Round_Robin.Controls.Add(this.RR_sumTurnAroundTime_label);
            this.Round_Robin.Controls.Add(this.RR_sumWaitingTime_label);
            this.Round_Robin.Controls.Add(this.RR_Process_flowLayoutPanel2);
            this.Round_Robin.Controls.Add(this.RR_Process_flowLayoutPanel3);
            this.Round_Robin.Controls.Add(this.RR_Time_flowLayoutPanel3);
            this.Round_Robin.Controls.Add(this.RR_hScrollBar);
            this.Round_Robin.Controls.Add(this.RR_Time_flowLayoutPanel2);
            this.Round_Robin.Controls.Add(this.RR_Process_flowLayoutPanel);
            this.Round_Robin.Controls.Add(this.RR_Time_flowLayoutPanel);
            this.Round_Robin.Controls.Add(this.RR_Reset_btn);
            this.Round_Robin.Controls.Add(this.RR_Mode_Label);
            this.Round_Robin.Controls.Add(this.RR_Mode_comboBox);
            this.Round_Robin.Controls.Add(this.RR_QuantamTime_Label);
            this.Round_Robin.Controls.Add(this.RR_NoOfProcesses_Label);
            this.Round_Robin.Controls.Add(this.RR_BurstTime_label);
            this.Round_Robin.Controls.Add(this.RR_ArrivalTime_label);
            this.Round_Robin.Controls.Add(this.RR_Insert_btn);
            this.Round_Robin.Controls.Add(this.RR_Ok_btn);
            this.Round_Robin.Controls.Add(this.RR_Jump_checkBox);
            this.Round_Robin.Controls.Add(this.RR_dataGridView);
            this.Round_Robin.Controls.Add(this.RR_Live_checkBox);
            this.Round_Robin.Controls.Add(this.RR_CurrentSlot_label);
            this.Round_Robin.Controls.Add(this.RR_Slot_label);
            this.Round_Robin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round_Robin.Location = new System.Drawing.Point(4, 25);
            this.Round_Robin.Name = "Round_Robin";
            this.Round_Robin.Size = new System.Drawing.Size(1202, 836);
            this.Round_Robin.TabIndex = 3;
            this.Round_Robin.Text = "Round_Robin";
            this.Round_Robin.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(5, 760);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(42, 47);
            this.panel7.TabIndex = 114;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(1049, 759);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(42, 47);
            this.panel8.TabIndex = 113;
            // 
            // RR_trackBar
            // 
            this.RR_trackBar.LargeChange = 3;
            this.RR_trackBar.Location = new System.Drawing.Point(1123, 531);
            this.RR_trackBar.Maximum = 5;
            this.RR_trackBar.Name = "RR_trackBar";
            this.RR_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RR_trackBar.Size = new System.Drawing.Size(56, 245);
            this.RR_trackBar.TabIndex = 111;
            this.RR_trackBar.Scroll += new System.EventHandler(this.RR_trackBar_Scroll);
            // 
            // RR_avgTurnAroundTime_textBox
            // 
            this.RR_avgTurnAroundTime_textBox.Location = new System.Drawing.Point(983, 472);
            this.RR_avgTurnAroundTime_textBox.Name = "RR_avgTurnAroundTime_textBox";
            this.RR_avgTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.RR_avgTurnAroundTime_textBox.TabIndex = 110;
            // 
            // RR_avgWaitingTime_textBox
            // 
            this.RR_avgWaitingTime_textBox.Location = new System.Drawing.Point(983, 431);
            this.RR_avgWaitingTime_textBox.Name = "RR_avgWaitingTime_textBox";
            this.RR_avgWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.RR_avgWaitingTime_textBox.TabIndex = 109;
            // 
            // RR_sumTurnAroundTime_textBox
            // 
            this.RR_sumTurnAroundTime_textBox.Location = new System.Drawing.Point(983, 389);
            this.RR_sumTurnAroundTime_textBox.Name = "RR_sumTurnAroundTime_textBox";
            this.RR_sumTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.RR_sumTurnAroundTime_textBox.TabIndex = 106;
            // 
            // RR_sumWaitingTime_textBox
            // 
            this.RR_sumWaitingTime_textBox.Location = new System.Drawing.Point(983, 348);
            this.RR_sumWaitingTime_textBox.Name = "RR_sumWaitingTime_textBox";
            this.RR_sumWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.RR_sumWaitingTime_textBox.TabIndex = 105;
            // 
            // RR_QuantamTime_textBox
            // 
            this.RR_QuantamTime_textBox.Location = new System.Drawing.Point(311, 143);
            this.RR_QuantamTime_textBox.Name = "RR_QuantamTime_textBox";
            this.RR_QuantamTime_textBox.Size = new System.Drawing.Size(148, 34);
            this.RR_QuantamTime_textBox.TabIndex = 70;
            // 
            // RR_BurstTime_textbook
            // 
            this.RR_BurstTime_textbook.Location = new System.Drawing.Point(303, 310);
            this.RR_BurstTime_textbook.Name = "RR_BurstTime_textbook";
            this.RR_BurstTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.RR_BurstTime_textbook.TabIndex = 66;
            // 
            // RR_ArrivalTime_textbook
            // 
            this.RR_ArrivalTime_textbook.Location = new System.Drawing.Point(304, 264);
            this.RR_ArrivalTime_textbook.Name = "RR_ArrivalTime_textbook";
            this.RR_ArrivalTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.RR_ArrivalTime_textbook.TabIndex = 65;
            // 
            // RR_NoOfProcesses_textbook
            // 
            this.RR_NoOfProcesses_textbook.Location = new System.Drawing.Point(313, 94);
            this.RR_NoOfProcesses_textbook.Name = "RR_NoOfProcesses_textbook";
            this.RR_NoOfProcesses_textbook.Size = new System.Drawing.Size(148, 34);
            this.RR_NoOfProcesses_textbook.TabIndex = 63;
            // 
            // RR_avgTurnAroundTime_label
            // 
            this.RR_avgTurnAroundTime_label.AutoSize = true;
            this.RR_avgTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_avgTurnAroundTime_label.Location = new System.Drawing.Point(716, 472);
            this.RR_avgTurnAroundTime_label.Name = "RR_avgTurnAroundTime_label";
            this.RR_avgTurnAroundTime_label.Size = new System.Drawing.Size(247, 25);
            this.RR_avgTurnAroundTime_label.TabIndex = 108;
            this.RR_avgTurnAroundTime_label.Text = "Average Turnaround  Time";
            // 
            // RR_avgWaitingTime_label
            // 
            this.RR_avgWaitingTime_label.AutoSize = true;
            this.RR_avgWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_avgWaitingTime_label.Location = new System.Drawing.Point(716, 431);
            this.RR_avgWaitingTime_label.Name = "RR_avgWaitingTime_label";
            this.RR_avgWaitingTime_label.Size = new System.Drawing.Size(206, 25);
            this.RR_avgWaitingTime_label.TabIndex = 107;
            this.RR_avgWaitingTime_label.Text = "Average Waiting Time";
            // 
            // RR_sumTurnAroundTime_label
            // 
            this.RR_sumTurnAroundTime_label.AutoSize = true;
            this.RR_sumTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_sumTurnAroundTime_label.Location = new System.Drawing.Point(713, 386);
            this.RR_sumTurnAroundTime_label.Name = "RR_sumTurnAroundTime_label";
            this.RR_sumTurnAroundTime_label.Size = new System.Drawing.Size(215, 25);
            this.RR_sumTurnAroundTime_label.TabIndex = 104;
            this.RR_sumTurnAroundTime_label.Text = "sum of turnaround  time";
            // 
            // RR_sumWaitingTime_label
            // 
            this.RR_sumWaitingTime_label.AutoSize = true;
            this.RR_sumWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RR_sumWaitingTime_label.Location = new System.Drawing.Point(713, 348);
            this.RR_sumWaitingTime_label.Name = "RR_sumWaitingTime_label";
            this.RR_sumWaitingTime_label.Size = new System.Drawing.Size(176, 25);
            this.RR_sumWaitingTime_label.TabIndex = 103;
            this.RR_sumWaitingTime_label.Text = "sum of waiting time";
            // 
            // RR_Process_flowLayoutPanel2
            // 
            this.RR_Process_flowLayoutPanel2.Location = new System.Drawing.Point(62, 579);
            this.RR_Process_flowLayoutPanel2.Name = "RR_Process_flowLayoutPanel2";
            this.RR_Process_flowLayoutPanel2.Size = new System.Drawing.Size(1005, 42);
            this.RR_Process_flowLayoutPanel2.TabIndex = 100;
            // 
            // RR_Process_flowLayoutPanel3
            // 
            this.RR_Process_flowLayoutPanel3.Location = new System.Drawing.Point(62, 672);
            this.RR_Process_flowLayoutPanel3.Name = "RR_Process_flowLayoutPanel3";
            this.RR_Process_flowLayoutPanel3.Size = new System.Drawing.Size(1005, 42);
            this.RR_Process_flowLayoutPanel3.TabIndex = 101;
            // 
            // RR_Time_flowLayoutPanel3
            // 
            this.RR_Time_flowLayoutPanel3.Location = new System.Drawing.Point(26, 624);
            this.RR_Time_flowLayoutPanel3.Name = "RR_Time_flowLayoutPanel3";
            this.RR_Time_flowLayoutPanel3.Size = new System.Drawing.Size(1069, 42);
            this.RR_Time_flowLayoutPanel3.TabIndex = 102;
            // 
            // RR_hScrollBar
            // 
            this.RR_hScrollBar.Location = new System.Drawing.Point(26, 804);
            this.RR_hScrollBar.Name = "RR_hScrollBar";
            this.RR_hScrollBar.Size = new System.Drawing.Size(1028, 27);
            this.RR_hScrollBar.TabIndex = 96;
            this.RR_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RR_hScrollBar_Scroll);
            // 
            // RR_Time_flowLayoutPanel2
            // 
            this.RR_Time_flowLayoutPanel2.Location = new System.Drawing.Point(26, 531);
            this.RR_Time_flowLayoutPanel2.Name = "RR_Time_flowLayoutPanel2";
            this.RR_Time_flowLayoutPanel2.Size = new System.Drawing.Size(1069, 42);
            this.RR_Time_flowLayoutPanel2.TabIndex = 99;
            // 
            // RR_Process_flowLayoutPanel
            // 
            this.RR_Process_flowLayoutPanel.AutoScroll = true;
            this.RR_Process_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RR_Process_flowLayoutPanel.Location = new System.Drawing.Point(45, 767);
            this.RR_Process_flowLayoutPanel.Name = "RR_Process_flowLayoutPanel";
            this.RR_Process_flowLayoutPanel.Size = new System.Drawing.Size(1007, 58);
            this.RR_Process_flowLayoutPanel.TabIndex = 98;
            this.RR_Process_flowLayoutPanel.WrapContents = false;
            // 
            // RR_Time_flowLayoutPanel
            // 
            this.RR_Time_flowLayoutPanel.AutoScroll = true;
            this.RR_Time_flowLayoutPanel.Location = new System.Drawing.Point(26, 721);
            this.RR_Time_flowLayoutPanel.Name = "RR_Time_flowLayoutPanel";
            this.RR_Time_flowLayoutPanel.Size = new System.Drawing.Size(1065, 64);
            this.RR_Time_flowLayoutPanel.TabIndex = 97;
            this.RR_Time_flowLayoutPanel.WrapContents = false;
            // 
            // RR_Reset_btn
            // 
            this.RR_Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RR_Reset_btn.Location = new System.Drawing.Point(504, 31);
            this.RR_Reset_btn.Name = "RR_Reset_btn";
            this.RR_Reset_btn.Size = new System.Drawing.Size(101, 42);
            this.RR_Reset_btn.TabIndex = 74;
            this.RR_Reset_btn.Text = "Reset";
            this.RR_Reset_btn.UseVisualStyleBackColor = true;
            this.RR_Reset_btn.Click += new System.EventHandler(this.RR_Reset_btn_Click);
            // 
            // RR_Mode_Label
            // 
            this.RR_Mode_Label.AutoSize = true;
            this.RR_Mode_Label.Location = new System.Drawing.Point(89, 34);
            this.RR_Mode_Label.Name = "RR_Mode_Label";
            this.RR_Mode_Label.Size = new System.Drawing.Size(75, 29);
            this.RR_Mode_Label.TabIndex = 73;
            this.RR_Mode_Label.Text = "Mode";
            // 
            // RR_Mode_comboBox
            // 
            this.RR_Mode_comboBox.FormattingEnabled = true;
            this.RR_Mode_comboBox.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.RR_Mode_comboBox.Location = new System.Drawing.Point(190, 31);
            this.RR_Mode_comboBox.Name = "RR_Mode_comboBox";
            this.RR_Mode_comboBox.Size = new System.Drawing.Size(121, 37);
            this.RR_Mode_comboBox.TabIndex = 72;
            this.RR_Mode_comboBox.SelectedIndexChanged += new System.EventHandler(this.RR_Mode_comboBox_SelectedIndexChanged);
            // 
            // RR_QuantamTime_Label
            // 
            this.RR_QuantamTime_Label.AutoSize = true;
            this.RR_QuantamTime_Label.Location = new System.Drawing.Point(89, 148);
            this.RR_QuantamTime_Label.Name = "RR_QuantamTime_Label";
            this.RR_QuantamTime_Label.Size = new System.Drawing.Size(172, 29);
            this.RR_QuantamTime_Label.TabIndex = 71;
            this.RR_QuantamTime_Label.Text = "Quantum Time";
            // 
            // RR_NoOfProcesses_Label
            // 
            this.RR_NoOfProcesses_Label.AutoSize = true;
            this.RR_NoOfProcesses_Label.Location = new System.Drawing.Point(91, 99);
            this.RR_NoOfProcesses_Label.Name = "RR_NoOfProcesses_Label";
            this.RR_NoOfProcesses_Label.Size = new System.Drawing.Size(191, 29);
            this.RR_NoOfProcesses_Label.TabIndex = 69;
            this.RR_NoOfProcesses_Label.Text = "No of Processes";
            // 
            // RR_BurstTime_label
            // 
            this.RR_BurstTime_label.AutoSize = true;
            this.RR_BurstTime_label.Location = new System.Drawing.Point(93, 309);
            this.RR_BurstTime_label.Name = "RR_BurstTime_label";
            this.RR_BurstTime_label.Size = new System.Drawing.Size(130, 29);
            this.RR_BurstTime_label.TabIndex = 68;
            this.RR_BurstTime_label.Text = "Burst Time";
            // 
            // RR_ArrivalTime_label
            // 
            this.RR_ArrivalTime_label.AutoSize = true;
            this.RR_ArrivalTime_label.Location = new System.Drawing.Point(91, 264);
            this.RR_ArrivalTime_label.Name = "RR_ArrivalTime_label";
            this.RR_ArrivalTime_label.Size = new System.Drawing.Size(142, 29);
            this.RR_ArrivalTime_label.TabIndex = 67;
            this.RR_ArrivalTime_label.Text = "Arrival Time";
            // 
            // RR_Insert_btn
            // 
            this.RR_Insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RR_Insert_btn.Location = new System.Drawing.Point(221, 364);
            this.RR_Insert_btn.Name = "RR_Insert_btn";
            this.RR_Insert_btn.Size = new System.Drawing.Size(101, 42);
            this.RR_Insert_btn.TabIndex = 64;
            this.RR_Insert_btn.Text = "Insert";
            this.RR_Insert_btn.UseVisualStyleBackColor = true;
            this.RR_Insert_btn.Click += new System.EventHandler(this.RR_Insert_btn_Click);
            // 
            // RR_Ok_btn
            // 
            this.RR_Ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RR_Ok_btn.Location = new System.Drawing.Point(221, 199);
            this.RR_Ok_btn.Name = "RR_Ok_btn";
            this.RR_Ok_btn.Size = new System.Drawing.Size(101, 42);
            this.RR_Ok_btn.TabIndex = 62;
            this.RR_Ok_btn.Text = "OK";
            this.RR_Ok_btn.UseVisualStyleBackColor = true;
            this.RR_Ok_btn.Click += new System.EventHandler(this.RR_Ok_btn_Click);
            // 
            // RR_Jump_checkBox
            // 
            this.RR_Jump_checkBox.AutoSize = true;
            this.RR_Jump_checkBox.Location = new System.Drawing.Point(548, 320);
            this.RR_Jump_checkBox.Name = "RR_Jump_checkBox";
            this.RR_Jump_checkBox.Size = new System.Drawing.Size(100, 33);
            this.RR_Jump_checkBox.TabIndex = 55;
            this.RR_Jump_checkBox.Text = "JUMP";
            this.RR_Jump_checkBox.UseVisualStyleBackColor = true;
            this.RR_Jump_checkBox.CheckedChanged += new System.EventHandler(this.RR_Jump_checkBox_CheckedChanged);
            // 
            // RR_dataGridView
            // 
            this.RR_dataGridView.AllowUserToAddRows = false;
            this.RR_dataGridView.AllowUserToDeleteRows = false;
            this.RR_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.RR_dataGridView.ColumnHeadersHeight = 29;
            this.RR_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RR_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.RR_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.RR_dataGridView.Location = new System.Drawing.Point(705, 15);
            this.RR_dataGridView.Name = "RR_dataGridView";
            this.RR_dataGridView.ReadOnly = true;
            this.RR_dataGridView.RowHeadersWidth = 51;
            this.RR_dataGridView.RowTemplate.Height = 24;
            this.RR_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RR_dataGridView.Size = new System.Drawing.Size(362, 317);
            this.RR_dataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.HeaderText = "PID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.HeaderText = "Arrival";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 109;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.HeaderText = "Burst";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 97;
            // 
            // RR_Live_checkBox
            // 
            this.RR_Live_checkBox.AutoSize = true;
            this.RR_Live_checkBox.Location = new System.Drawing.Point(548, 260);
            this.RR_Live_checkBox.Name = "RR_Live_checkBox";
            this.RR_Live_checkBox.Size = new System.Drawing.Size(85, 33);
            this.RR_Live_checkBox.TabIndex = 50;
            this.RR_Live_checkBox.Text = "LIVE";
            this.RR_Live_checkBox.UseVisualStyleBackColor = true;
            this.RR_Live_checkBox.CheckedChanged += new System.EventHandler(this.RR_Live_checkBox_CheckedChanged);
            // 
            // RR_CurrentSlot_label
            // 
            this.RR_CurrentSlot_label.AutoSize = true;
            this.RR_CurrentSlot_label.Location = new System.Drawing.Point(1079, 804);
            this.RR_CurrentSlot_label.Name = "RR_CurrentSlot_label";
            this.RR_CurrentSlot_label.Size = new System.Drawing.Size(26, 29);
            this.RR_CurrentSlot_label.TabIndex = 52;
            this.RR_CurrentSlot_label.Text = "0";
            // 
            // RR_Slot_label
            // 
            this.RR_Slot_label.AutoSize = true;
            this.RR_Slot_label.Location = new System.Drawing.Point(1147, 803);
            this.RR_Slot_label.Name = "RR_Slot_label";
            this.RR_Slot_label.Size = new System.Drawing.Size(51, 29);
            this.RR_Slot_label.TabIndex = 51;
            this.RR_Slot_label.Text = "slot";
            // 
            // Priority
            // 
            this.Priority.Controls.Add(this.panel5);
            this.Priority.Controls.Add(this.panel6);
            this.Priority.Controls.Add(this.PIOR_trackBar);
            this.Priority.Controls.Add(this.PIOR_avgTurnAroundTime_textBox);
            this.Priority.Controls.Add(this.PIOR_avgWaitingTime_textBox);
            this.Priority.Controls.Add(this.PIOR_sumTurnAroundTime_textBox);
            this.Priority.Controls.Add(this.PIOR_sumWaitingTime_textBox);
            this.Priority.Controls.Add(this.PIOR_Piority_textbook);
            this.Priority.Controls.Add(this.PIOR_BurstTime_textbook);
            this.Priority.Controls.Add(this.PIOR_ArrivalTime_textbook);
            this.Priority.Controls.Add(this.PIOR_NoOfProcesses_textbook);
            this.Priority.Controls.Add(this.PIOR_avgTurnAroundTime_label);
            this.Priority.Controls.Add(this.PIOR_avgWaitingTime_label);
            this.Priority.Controls.Add(this.PIOR_sumTurnAroundTime_label);
            this.Priority.Controls.Add(this.PIOR_sumWaitingTime_label);
            this.Priority.Controls.Add(this.PIOR_Process_flowLayoutPanel2);
            this.Priority.Controls.Add(this.PIOR_Process_flowLayoutPanel3);
            this.Priority.Controls.Add(this.PIOR_Time_flowLayoutPanel3);
            this.Priority.Controls.Add(this.PIOR_hScrollBar);
            this.Priority.Controls.Add(this.PIOR_Time_flowLayoutPanel2);
            this.Priority.Controls.Add(this.PIOR_Process_flowLayoutPanel);
            this.Priority.Controls.Add(this.PIOR_Time_flowLayoutPanel);
            this.Priority.Controls.Add(this.PIOR_Reset_btn);
            this.Priority.Controls.Add(this.PIOR_Mode_Label);
            this.Priority.Controls.Add(this.PIOR_Mode_comboBox);
            this.Priority.Controls.Add(this.PIOR_Piority_label);
            this.Priority.Controls.Add(this.PIOR_dataGridView);
            this.Priority.Controls.Add(this.PIOR_Jump_checkBox);
            this.Priority.Controls.Add(this.PIOR_CurrentSlot_label);
            this.Priority.Controls.Add(this.PIOR_Slot_label);
            this.Priority.Controls.Add(this.PIOR_Live_checkBox);
            this.Priority.Controls.Add(this.PIOR_Version_checkBox);
            this.Priority.Controls.Add(this.PIOR_NoOfProcesses_Label);
            this.Priority.Controls.Add(this.PIOR_BurstTime_label);
            this.Priority.Controls.Add(this.PIOR_ArrivalTime_label);
            this.Priority.Controls.Add(this.PIOR_Insert_btn);
            this.Priority.Controls.Add(this.PIOR_Ok_btn);
            this.Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority.Location = new System.Drawing.Point(4, 25);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(1202, 836);
            this.Priority.TabIndex = 2;
            this.Priority.Text = "Priority";
            this.Priority.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(8, 760);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(42, 47);
            this.panel5.TabIndex = 112;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(1054, 760);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(42, 47);
            this.panel6.TabIndex = 111;
            // 
            // PIOR_trackBar
            // 
            this.PIOR_trackBar.LargeChange = 3;
            this.PIOR_trackBar.Location = new System.Drawing.Point(1123, 531);
            this.PIOR_trackBar.Maximum = 5;
            this.PIOR_trackBar.Name = "PIOR_trackBar";
            this.PIOR_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.PIOR_trackBar.Size = new System.Drawing.Size(56, 245);
            this.PIOR_trackBar.TabIndex = 110;
            this.PIOR_trackBar.Scroll += new System.EventHandler(this.PIOR_trackBar_Scroll);
            // 
            // PIOR_avgTurnAroundTime_textBox
            // 
            this.PIOR_avgTurnAroundTime_textBox.Location = new System.Drawing.Point(1032, 471);
            this.PIOR_avgTurnAroundTime_textBox.Name = "PIOR_avgTurnAroundTime_textBox";
            this.PIOR_avgTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.PIOR_avgTurnAroundTime_textBox.TabIndex = 109;
            // 
            // PIOR_avgWaitingTime_textBox
            // 
            this.PIOR_avgWaitingTime_textBox.Location = new System.Drawing.Point(1032, 430);
            this.PIOR_avgWaitingTime_textBox.Name = "PIOR_avgWaitingTime_textBox";
            this.PIOR_avgWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.PIOR_avgWaitingTime_textBox.TabIndex = 108;
            // 
            // PIOR_sumTurnAroundTime_textBox
            // 
            this.PIOR_sumTurnAroundTime_textBox.Location = new System.Drawing.Point(1032, 388);
            this.PIOR_sumTurnAroundTime_textBox.Name = "PIOR_sumTurnAroundTime_textBox";
            this.PIOR_sumTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.PIOR_sumTurnAroundTime_textBox.TabIndex = 105;
            // 
            // PIOR_sumWaitingTime_textBox
            // 
            this.PIOR_sumWaitingTime_textBox.Location = new System.Drawing.Point(1032, 347);
            this.PIOR_sumWaitingTime_textBox.Name = "PIOR_sumWaitingTime_textBox";
            this.PIOR_sumWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.PIOR_sumWaitingTime_textBox.TabIndex = 104;
            // 
            // PIOR_Piority_textbook
            // 
            this.PIOR_Piority_textbook.Location = new System.Drawing.Point(333, 320);
            this.PIOR_Piority_textbook.Name = "PIOR_Piority_textbook";
            this.PIOR_Piority_textbook.Size = new System.Drawing.Size(148, 34);
            this.PIOR_Piority_textbook.TabIndex = 55;
            // 
            // PIOR_BurstTime_textbook
            // 
            this.PIOR_BurstTime_textbook.Location = new System.Drawing.Point(333, 273);
            this.PIOR_BurstTime_textbook.Name = "PIOR_BurstTime_textbook";
            this.PIOR_BurstTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.PIOR_BurstTime_textbook.TabIndex = 39;
            // 
            // PIOR_ArrivalTime_textbook
            // 
            this.PIOR_ArrivalTime_textbook.Location = new System.Drawing.Point(333, 228);
            this.PIOR_ArrivalTime_textbook.Name = "PIOR_ArrivalTime_textbook";
            this.PIOR_ArrivalTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.PIOR_ArrivalTime_textbook.TabIndex = 38;
            // 
            // PIOR_NoOfProcesses_textbook
            // 
            this.PIOR_NoOfProcesses_textbook.Location = new System.Drawing.Point(332, 152);
            this.PIOR_NoOfProcesses_textbook.Name = "PIOR_NoOfProcesses_textbook";
            this.PIOR_NoOfProcesses_textbook.Size = new System.Drawing.Size(148, 34);
            this.PIOR_NoOfProcesses_textbook.TabIndex = 36;
            // 
            // PIOR_avgTurnAroundTime_label
            // 
            this.PIOR_avgTurnAroundTime_label.AutoSize = true;
            this.PIOR_avgTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIOR_avgTurnAroundTime_label.Location = new System.Drawing.Point(765, 471);
            this.PIOR_avgTurnAroundTime_label.Name = "PIOR_avgTurnAroundTime_label";
            this.PIOR_avgTurnAroundTime_label.Size = new System.Drawing.Size(247, 25);
            this.PIOR_avgTurnAroundTime_label.TabIndex = 107;
            this.PIOR_avgTurnAroundTime_label.Text = "Average Turnaround  Time";
            // 
            // PIOR_avgWaitingTime_label
            // 
            this.PIOR_avgWaitingTime_label.AutoSize = true;
            this.PIOR_avgWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIOR_avgWaitingTime_label.Location = new System.Drawing.Point(765, 430);
            this.PIOR_avgWaitingTime_label.Name = "PIOR_avgWaitingTime_label";
            this.PIOR_avgWaitingTime_label.Size = new System.Drawing.Size(206, 25);
            this.PIOR_avgWaitingTime_label.TabIndex = 106;
            this.PIOR_avgWaitingTime_label.Text = "Average Waiting Time";
            // 
            // PIOR_sumTurnAroundTime_label
            // 
            this.PIOR_sumTurnAroundTime_label.AutoSize = true;
            this.PIOR_sumTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIOR_sumTurnAroundTime_label.Location = new System.Drawing.Point(762, 385);
            this.PIOR_sumTurnAroundTime_label.Name = "PIOR_sumTurnAroundTime_label";
            this.PIOR_sumTurnAroundTime_label.Size = new System.Drawing.Size(235, 25);
            this.PIOR_sumTurnAroundTime_label.TabIndex = 103;
            this.PIOR_sumTurnAroundTime_label.Text = "Sum of Turnaround  Time";
            // 
            // PIOR_sumWaitingTime_label
            // 
            this.PIOR_sumWaitingTime_label.AutoSize = true;
            this.PIOR_sumWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIOR_sumWaitingTime_label.Location = new System.Drawing.Point(761, 347);
            this.PIOR_sumWaitingTime_label.Name = "PIOR_sumWaitingTime_label";
            this.PIOR_sumWaitingTime_label.Size = new System.Drawing.Size(194, 25);
            this.PIOR_sumWaitingTime_label.TabIndex = 102;
            this.PIOR_sumWaitingTime_label.Text = "Sum of Waiting Time";
            // 
            // PIOR_Process_flowLayoutPanel2
            // 
            this.PIOR_Process_flowLayoutPanel2.Location = new System.Drawing.Point(66, 574);
            this.PIOR_Process_flowLayoutPanel2.Name = "PIOR_Process_flowLayoutPanel2";
            this.PIOR_Process_flowLayoutPanel2.Size = new System.Drawing.Size(1005, 42);
            this.PIOR_Process_flowLayoutPanel2.TabIndex = 93;
            // 
            // PIOR_Process_flowLayoutPanel3
            // 
            this.PIOR_Process_flowLayoutPanel3.Location = new System.Drawing.Point(66, 667);
            this.PIOR_Process_flowLayoutPanel3.Name = "PIOR_Process_flowLayoutPanel3";
            this.PIOR_Process_flowLayoutPanel3.Size = new System.Drawing.Size(1005, 42);
            this.PIOR_Process_flowLayoutPanel3.TabIndex = 94;
            // 
            // PIOR_Time_flowLayoutPanel3
            // 
            this.PIOR_Time_flowLayoutPanel3.Location = new System.Drawing.Point(30, 619);
            this.PIOR_Time_flowLayoutPanel3.Name = "PIOR_Time_flowLayoutPanel3";
            this.PIOR_Time_flowLayoutPanel3.Size = new System.Drawing.Size(1069, 42);
            this.PIOR_Time_flowLayoutPanel3.TabIndex = 95;
            // 
            // PIOR_hScrollBar
            // 
            this.PIOR_hScrollBar.Location = new System.Drawing.Point(30, 803);
            this.PIOR_hScrollBar.Name = "PIOR_hScrollBar";
            this.PIOR_hScrollBar.Size = new System.Drawing.Size(1028, 27);
            this.PIOR_hScrollBar.TabIndex = 89;
            this.PIOR_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PIOR_hScrollBar_Scroll);
            // 
            // PIOR_Time_flowLayoutPanel2
            // 
            this.PIOR_Time_flowLayoutPanel2.Location = new System.Drawing.Point(30, 526);
            this.PIOR_Time_flowLayoutPanel2.Name = "PIOR_Time_flowLayoutPanel2";
            this.PIOR_Time_flowLayoutPanel2.Size = new System.Drawing.Size(1069, 42);
            this.PIOR_Time_flowLayoutPanel2.TabIndex = 92;
            // 
            // PIOR_Process_flowLayoutPanel
            // 
            this.PIOR_Process_flowLayoutPanel.AutoScroll = true;
            this.PIOR_Process_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PIOR_Process_flowLayoutPanel.Location = new System.Drawing.Point(49, 766);
            this.PIOR_Process_flowLayoutPanel.Name = "PIOR_Process_flowLayoutPanel";
            this.PIOR_Process_flowLayoutPanel.Size = new System.Drawing.Size(1007, 58);
            this.PIOR_Process_flowLayoutPanel.TabIndex = 91;
            this.PIOR_Process_flowLayoutPanel.WrapContents = false;
            // 
            // PIOR_Time_flowLayoutPanel
            // 
            this.PIOR_Time_flowLayoutPanel.AutoScroll = true;
            this.PIOR_Time_flowLayoutPanel.Location = new System.Drawing.Point(30, 720);
            this.PIOR_Time_flowLayoutPanel.Name = "PIOR_Time_flowLayoutPanel";
            this.PIOR_Time_flowLayoutPanel.Size = new System.Drawing.Size(1066, 64);
            this.PIOR_Time_flowLayoutPanel.TabIndex = 90;
            this.PIOR_Time_flowLayoutPanel.WrapContents = false;
            // 
            // PIOR_Reset_btn
            // 
            this.PIOR_Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIOR_Reset_btn.Location = new System.Drawing.Point(504, 31);
            this.PIOR_Reset_btn.Name = "PIOR_Reset_btn";
            this.PIOR_Reset_btn.Size = new System.Drawing.Size(101, 42);
            this.PIOR_Reset_btn.TabIndex = 80;
            this.PIOR_Reset_btn.Text = "Reset";
            this.PIOR_Reset_btn.UseVisualStyleBackColor = true;
            this.PIOR_Reset_btn.Click += new System.EventHandler(this.PIOR_Reset_btn_Click);
            // 
            // PIOR_Mode_Label
            // 
            this.PIOR_Mode_Label.AutoSize = true;
            this.PIOR_Mode_Label.Location = new System.Drawing.Point(89, 34);
            this.PIOR_Mode_Label.Name = "PIOR_Mode_Label";
            this.PIOR_Mode_Label.Size = new System.Drawing.Size(75, 29);
            this.PIOR_Mode_Label.TabIndex = 79;
            this.PIOR_Mode_Label.Text = "Mode";
            // 
            // PIOR_Mode_comboBox
            // 
            this.PIOR_Mode_comboBox.FormattingEnabled = true;
            this.PIOR_Mode_comboBox.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.PIOR_Mode_comboBox.Location = new System.Drawing.Point(190, 31);
            this.PIOR_Mode_comboBox.Name = "PIOR_Mode_comboBox";
            this.PIOR_Mode_comboBox.Size = new System.Drawing.Size(121, 37);
            this.PIOR_Mode_comboBox.TabIndex = 78;
            this.PIOR_Mode_comboBox.SelectedIndexChanged += new System.EventHandler(this.PIOR_Mode_comboBox_SelectedIndexChanged);
            // 
            // PIOR_Piority_label
            // 
            this.PIOR_Piority_label.AutoSize = true;
            this.PIOR_Piority_label.Location = new System.Drawing.Point(108, 320);
            this.PIOR_Piority_label.Name = "PIOR_Piority_label";
            this.PIOR_Piority_label.Size = new System.Drawing.Size(80, 29);
            this.PIOR_Piority_label.TabIndex = 56;
            this.PIOR_Piority_label.Text = "Piority";
            // 
            // PIOR_dataGridView
            // 
            this.PIOR_dataGridView.AllowUserToAddRows = false;
            this.PIOR_dataGridView.AllowUserToDeleteRows = false;
            this.PIOR_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.PIOR_dataGridView.ColumnHeadersHeight = 29;
            this.PIOR_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PIOR_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column2});
            this.PIOR_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PIOR_dataGridView.Location = new System.Drawing.Point(705, 15);
            this.PIOR_dataGridView.Name = "PIOR_dataGridView";
            this.PIOR_dataGridView.ReadOnly = true;
            this.PIOR_dataGridView.RowHeadersWidth = 51;
            this.PIOR_dataGridView.RowTemplate.Height = 24;
            this.PIOR_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PIOR_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PIOR_dataGridView.Size = new System.Drawing.Size(468, 317);
            this.PIOR_dataGridView.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "PID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Arrival";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 109;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "Burst";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 97;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.HeaderText = "Piority";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 109;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Remaining";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // PIOR_Jump_checkBox
            // 
            this.PIOR_Jump_checkBox.AutoSize = true;
            this.PIOR_Jump_checkBox.Location = new System.Drawing.Point(506, 93);
            this.PIOR_Jump_checkBox.Name = "PIOR_Jump_checkBox";
            this.PIOR_Jump_checkBox.Size = new System.Drawing.Size(100, 33);
            this.PIOR_Jump_checkBox.TabIndex = 51;
            this.PIOR_Jump_checkBox.Text = "JUMP";
            this.PIOR_Jump_checkBox.UseVisualStyleBackColor = true;
            this.PIOR_Jump_checkBox.CheckedChanged += new System.EventHandler(this.PIOR_Jump_checkBox_CheckedChanged);
            // 
            // PIOR_CurrentSlot_label
            // 
            this.PIOR_CurrentSlot_label.AutoSize = true;
            this.PIOR_CurrentSlot_label.Location = new System.Drawing.Point(1079, 803);
            this.PIOR_CurrentSlot_label.Name = "PIOR_CurrentSlot_label";
            this.PIOR_CurrentSlot_label.Size = new System.Drawing.Size(26, 29);
            this.PIOR_CurrentSlot_label.TabIndex = 50;
            this.PIOR_CurrentSlot_label.Text = "0";
            // 
            // PIOR_Slot_label
            // 
            this.PIOR_Slot_label.AutoSize = true;
            this.PIOR_Slot_label.Location = new System.Drawing.Point(1147, 803);
            this.PIOR_Slot_label.Name = "PIOR_Slot_label";
            this.PIOR_Slot_label.Size = new System.Drawing.Size(51, 29);
            this.PIOR_Slot_label.TabIndex = 49;
            this.PIOR_Slot_label.Text = "slot";
            // 
            // PIOR_Live_checkBox
            // 
            this.PIOR_Live_checkBox.AutoSize = true;
            this.PIOR_Live_checkBox.Location = new System.Drawing.Point(320, 93);
            this.PIOR_Live_checkBox.Name = "PIOR_Live_checkBox";
            this.PIOR_Live_checkBox.Size = new System.Drawing.Size(85, 33);
            this.PIOR_Live_checkBox.TabIndex = 48;
            this.PIOR_Live_checkBox.Text = "LIVE";
            this.PIOR_Live_checkBox.UseVisualStyleBackColor = true;
            this.PIOR_Live_checkBox.CheckedChanged += new System.EventHandler(this.PIOR_Live_checkBox_CheckedChanged);
            // 
            // PIOR_Version_checkBox
            // 
            this.PIOR_Version_checkBox.AutoSize = true;
            this.PIOR_Version_checkBox.Location = new System.Drawing.Point(101, 93);
            this.PIOR_Version_checkBox.Name = "PIOR_Version_checkBox";
            this.PIOR_Version_checkBox.Size = new System.Drawing.Size(144, 33);
            this.PIOR_Version_checkBox.TabIndex = 45;
            this.PIOR_Version_checkBox.Text = "Preemtive";
            this.PIOR_Version_checkBox.UseVisualStyleBackColor = true;
            this.PIOR_Version_checkBox.CheckedChanged += new System.EventHandler(this.PIOR_Version_checkBox_CheckedChanged);
            // 
            // PIOR_NoOfProcesses_Label
            // 
            this.PIOR_NoOfProcesses_Label.AutoSize = true;
            this.PIOR_NoOfProcesses_Label.Location = new System.Drawing.Point(97, 157);
            this.PIOR_NoOfProcesses_Label.Name = "PIOR_NoOfProcesses_Label";
            this.PIOR_NoOfProcesses_Label.Size = new System.Drawing.Size(191, 29);
            this.PIOR_NoOfProcesses_Label.TabIndex = 42;
            this.PIOR_NoOfProcesses_Label.Text = "No of Processes";
            // 
            // PIOR_BurstTime_label
            // 
            this.PIOR_BurstTime_label.AutoSize = true;
            this.PIOR_BurstTime_label.Location = new System.Drawing.Point(105, 273);
            this.PIOR_BurstTime_label.Name = "PIOR_BurstTime_label";
            this.PIOR_BurstTime_label.Size = new System.Drawing.Size(130, 29);
            this.PIOR_BurstTime_label.TabIndex = 41;
            this.PIOR_BurstTime_label.Text = "Burst Time";
            // 
            // PIOR_ArrivalTime_label
            // 
            this.PIOR_ArrivalTime_label.AutoSize = true;
            this.PIOR_ArrivalTime_label.Location = new System.Drawing.Point(104, 228);
            this.PIOR_ArrivalTime_label.Name = "PIOR_ArrivalTime_label";
            this.PIOR_ArrivalTime_label.Size = new System.Drawing.Size(142, 29);
            this.PIOR_ArrivalTime_label.TabIndex = 40;
            this.PIOR_ArrivalTime_label.Text = "Arrival Time";
            // 
            // PIOR_Insert_btn
            // 
            this.PIOR_Insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIOR_Insert_btn.Location = new System.Drawing.Point(255, 379);
            this.PIOR_Insert_btn.Name = "PIOR_Insert_btn";
            this.PIOR_Insert_btn.Size = new System.Drawing.Size(101, 42);
            this.PIOR_Insert_btn.TabIndex = 37;
            this.PIOR_Insert_btn.Text = "Insert";
            this.PIOR_Insert_btn.UseVisualStyleBackColor = true;
            this.PIOR_Insert_btn.Click += new System.EventHandler(this.PIOR_Insert_btn_Click);
            // 
            // PIOR_Ok_btn
            // 
            this.PIOR_Ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIOR_Ok_btn.Location = new System.Drawing.Point(528, 150);
            this.PIOR_Ok_btn.Name = "PIOR_Ok_btn";
            this.PIOR_Ok_btn.Size = new System.Drawing.Size(68, 42);
            this.PIOR_Ok_btn.TabIndex = 35;
            this.PIOR_Ok_btn.Text = "OK";
            this.PIOR_Ok_btn.UseVisualStyleBackColor = true;
            this.PIOR_Ok_btn.Click += new System.EventHandler(this.PIOR_Ok_btn_Click);
            // 
            // SJF
            // 
            this.SJF.Controls.Add(this.panel3);
            this.SJF.Controls.Add(this.panel4);
            this.SJF.Controls.Add(this.SJF_trackBar);
            this.SJF.Controls.Add(this.SJF_avgTurnAroundTime_textBox);
            this.SJF.Controls.Add(this.SJF_avgWaitingTime_textBox);
            this.SJF.Controls.Add(this.SJF_sumTurnAroundTime_textBox);
            this.SJF.Controls.Add(this.SJF_sumWaitingTime_textBox);
            this.SJF.Controls.Add(this.SJF_BurstTime_textbook);
            this.SJF.Controls.Add(this.SJF_ArrivalTime_textbook);
            this.SJF.Controls.Add(this.SJF_NoOfProcesses_textbook);
            this.SJF.Controls.Add(this.SJF_avgTurnAroundTime_label);
            this.SJF.Controls.Add(this.SJF_avgWaitingTime_label);
            this.SJF.Controls.Add(this.SJF_sumTurnAroundTime_label);
            this.SJF.Controls.Add(this.SJF_sumWaitingTime_label);
            this.SJF.Controls.Add(this.SJF_Process_flowLayoutPanel2);
            this.SJF.Controls.Add(this.SJF_Process_flowLayoutPanel3);
            this.SJF.Controls.Add(this.SJF_Time_flowLayoutPanel3);
            this.SJF.Controls.Add(this.SJF_hScrollBar);
            this.SJF.Controls.Add(this.SJF_Time_flowLayoutPanel2);
            this.SJF.Controls.Add(this.SJF_Process_flowLayoutPanel);
            this.SJF.Controls.Add(this.SJF_Time_flowLayoutPanel);
            this.SJF.Controls.Add(this.SJF_Reset_btn);
            this.SJF.Controls.Add(this.SJF_Mode_Label);
            this.SJF.Controls.Add(this.SJF_Mode_comboBox);
            this.SJF.Controls.Add(this.SJF_dataGridView);
            this.SJF.Controls.Add(this.SJF_Jump_checkBox);
            this.SJF.Controls.Add(this.SJF_CurrentSlot_label);
            this.SJF.Controls.Add(this.SJF_Slot_label);
            this.SJF.Controls.Add(this.SJF_Live_checkBox);
            this.SJF.Controls.Add(this.SJF_Version_checkBox);
            this.SJF.Controls.Add(this.SJF_NoOfProcesses_Label);
            this.SJF.Controls.Add(this.SJF_BurstTime_label);
            this.SJF.Controls.Add(this.SJF_ArrivalTime_label);
            this.SJF.Controls.Add(this.SJF_Insert_btn);
            this.SJF.Controls.Add(this.SJF_Ok_btn);
            this.SJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF.Location = new System.Drawing.Point(4, 25);
            this.SJF.Name = "SJF";
            this.SJF.Padding = new System.Windows.Forms.Padding(3);
            this.SJF.Size = new System.Drawing.Size(1202, 836);
            this.SJF.TabIndex = 1;
            this.SJF.Text = "SJF";
            this.SJF.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(7, 764);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 47);
            this.panel3.TabIndex = 106;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1052, 759);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 47);
            this.panel4.TabIndex = 105;
            // 
            // SJF_trackBar
            // 
            this.SJF_trackBar.LargeChange = 3;
            this.SJF_trackBar.Location = new System.Drawing.Point(1123, 531);
            this.SJF_trackBar.Maximum = 5;
            this.SJF_trackBar.Name = "SJF_trackBar";
            this.SJF_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SJF_trackBar.Size = new System.Drawing.Size(56, 245);
            this.SJF_trackBar.TabIndex = 104;
            this.SJF_trackBar.Scroll += new System.EventHandler(this.SJF_trackBar_Scroll);
            // 
            // SJF_avgTurnAroundTime_textBox
            // 
            this.SJF_avgTurnAroundTime_textBox.Location = new System.Drawing.Point(985, 467);
            this.SJF_avgTurnAroundTime_textBox.Name = "SJF_avgTurnAroundTime_textBox";
            this.SJF_avgTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.SJF_avgTurnAroundTime_textBox.TabIndex = 101;
            // 
            // SJF_avgWaitingTime_textBox
            // 
            this.SJF_avgWaitingTime_textBox.Location = new System.Drawing.Point(985, 426);
            this.SJF_avgWaitingTime_textBox.Name = "SJF_avgWaitingTime_textBox";
            this.SJF_avgWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.SJF_avgWaitingTime_textBox.TabIndex = 100;
            // 
            // SJF_sumTurnAroundTime_textBox
            // 
            this.SJF_sumTurnAroundTime_textBox.Location = new System.Drawing.Point(985, 384);
            this.SJF_sumTurnAroundTime_textBox.Name = "SJF_sumTurnAroundTime_textBox";
            this.SJF_sumTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.SJF_sumTurnAroundTime_textBox.TabIndex = 97;
            // 
            // SJF_sumWaitingTime_textBox
            // 
            this.SJF_sumWaitingTime_textBox.Location = new System.Drawing.Point(985, 343);
            this.SJF_sumWaitingTime_textBox.Name = "SJF_sumWaitingTime_textBox";
            this.SJF_sumWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.SJF_sumWaitingTime_textBox.TabIndex = 96;
            // 
            // SJF_BurstTime_textbook
            // 
            this.SJF_BurstTime_textbook.Location = new System.Drawing.Point(333, 273);
            this.SJF_BurstTime_textbook.Name = "SJF_BurstTime_textbook";
            this.SJF_BurstTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.SJF_BurstTime_textbook.TabIndex = 20;
            // 
            // SJF_ArrivalTime_textbook
            // 
            this.SJF_ArrivalTime_textbook.Location = new System.Drawing.Point(333, 228);
            this.SJF_ArrivalTime_textbook.Name = "SJF_ArrivalTime_textbook";
            this.SJF_ArrivalTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.SJF_ArrivalTime_textbook.TabIndex = 19;
            // 
            // SJF_NoOfProcesses_textbook
            // 
            this.SJF_NoOfProcesses_textbook.Location = new System.Drawing.Point(332, 152);
            this.SJF_NoOfProcesses_textbook.Name = "SJF_NoOfProcesses_textbook";
            this.SJF_NoOfProcesses_textbook.Size = new System.Drawing.Size(148, 34);
            this.SJF_NoOfProcesses_textbook.TabIndex = 16;
            // 
            // SJF_avgTurnAroundTime_label
            // 
            this.SJF_avgTurnAroundTime_label.AutoSize = true;
            this.SJF_avgTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF_avgTurnAroundTime_label.Location = new System.Drawing.Point(718, 467);
            this.SJF_avgTurnAroundTime_label.Name = "SJF_avgTurnAroundTime_label";
            this.SJF_avgTurnAroundTime_label.Size = new System.Drawing.Size(247, 25);
            this.SJF_avgTurnAroundTime_label.TabIndex = 99;
            this.SJF_avgTurnAroundTime_label.Text = "Average Turnaround  Time";
            // 
            // SJF_avgWaitingTime_label
            // 
            this.SJF_avgWaitingTime_label.AutoSize = true;
            this.SJF_avgWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF_avgWaitingTime_label.Location = new System.Drawing.Point(718, 426);
            this.SJF_avgWaitingTime_label.Name = "SJF_avgWaitingTime_label";
            this.SJF_avgWaitingTime_label.Size = new System.Drawing.Size(206, 25);
            this.SJF_avgWaitingTime_label.TabIndex = 98;
            this.SJF_avgWaitingTime_label.Text = "Average Waiting Time";
            // 
            // SJF_sumTurnAroundTime_label
            // 
            this.SJF_sumTurnAroundTime_label.AutoSize = true;
            this.SJF_sumTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF_sumTurnAroundTime_label.Location = new System.Drawing.Point(715, 381);
            this.SJF_sumTurnAroundTime_label.Name = "SJF_sumTurnAroundTime_label";
            this.SJF_sumTurnAroundTime_label.Size = new System.Drawing.Size(235, 25);
            this.SJF_sumTurnAroundTime_label.TabIndex = 95;
            this.SJF_sumTurnAroundTime_label.Text = "Sum of Turnaround  Time";
            // 
            // SJF_sumWaitingTime_label
            // 
            this.SJF_sumWaitingTime_label.AutoSize = true;
            this.SJF_sumWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJF_sumWaitingTime_label.Location = new System.Drawing.Point(714, 343);
            this.SJF_sumWaitingTime_label.Name = "SJF_sumWaitingTime_label";
            this.SJF_sumWaitingTime_label.Size = new System.Drawing.Size(194, 25);
            this.SJF_sumWaitingTime_label.TabIndex = 94;
            this.SJF_sumWaitingTime_label.Text = "Sum of Waiting Time";
            // 
            // SJF_Process_flowLayoutPanel2
            // 
            this.SJF_Process_flowLayoutPanel2.Location = new System.Drawing.Point(61, 575);
            this.SJF_Process_flowLayoutPanel2.Name = "SJF_Process_flowLayoutPanel2";
            this.SJF_Process_flowLayoutPanel2.Size = new System.Drawing.Size(1005, 42);
            this.SJF_Process_flowLayoutPanel2.TabIndex = 91;
            // 
            // SJF_Process_flowLayoutPanel3
            // 
            this.SJF_Process_flowLayoutPanel3.Location = new System.Drawing.Point(61, 668);
            this.SJF_Process_flowLayoutPanel3.Name = "SJF_Process_flowLayoutPanel3";
            this.SJF_Process_flowLayoutPanel3.Size = new System.Drawing.Size(1005, 42);
            this.SJF_Process_flowLayoutPanel3.TabIndex = 92;
            // 
            // SJF_Time_flowLayoutPanel3
            // 
            this.SJF_Time_flowLayoutPanel3.Location = new System.Drawing.Point(33, 620);
            this.SJF_Time_flowLayoutPanel3.Name = "SJF_Time_flowLayoutPanel3";
            this.SJF_Time_flowLayoutPanel3.Size = new System.Drawing.Size(1069, 42);
            this.SJF_Time_flowLayoutPanel3.TabIndex = 93;
            // 
            // SJF_hScrollBar
            // 
            this.SJF_hScrollBar.Location = new System.Drawing.Point(30, 807);
            this.SJF_hScrollBar.Name = "SJF_hScrollBar";
            this.SJF_hScrollBar.Size = new System.Drawing.Size(1028, 27);
            this.SJF_hScrollBar.TabIndex = 87;
            this.SJF_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SJF_hScrollBar_Scroll);
            // 
            // SJF_Time_flowLayoutPanel2
            // 
            this.SJF_Time_flowLayoutPanel2.Location = new System.Drawing.Point(33, 527);
            this.SJF_Time_flowLayoutPanel2.Name = "SJF_Time_flowLayoutPanel2";
            this.SJF_Time_flowLayoutPanel2.Size = new System.Drawing.Size(1069, 42);
            this.SJF_Time_flowLayoutPanel2.TabIndex = 90;
            // 
            // SJF_Process_flowLayoutPanel
            // 
            this.SJF_Process_flowLayoutPanel.AutoScroll = true;
            this.SJF_Process_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SJF_Process_flowLayoutPanel.Location = new System.Drawing.Point(49, 768);
            this.SJF_Process_flowLayoutPanel.Name = "SJF_Process_flowLayoutPanel";
            this.SJF_Process_flowLayoutPanel.Size = new System.Drawing.Size(1007, 58);
            this.SJF_Process_flowLayoutPanel.TabIndex = 89;
            this.SJF_Process_flowLayoutPanel.WrapContents = false;
            // 
            // SJF_Time_flowLayoutPanel
            // 
            this.SJF_Time_flowLayoutPanel.AutoScroll = true;
            this.SJF_Time_flowLayoutPanel.Location = new System.Drawing.Point(30, 721);
            this.SJF_Time_flowLayoutPanel.Name = "SJF_Time_flowLayoutPanel";
            this.SJF_Time_flowLayoutPanel.Size = new System.Drawing.Size(1075, 64);
            this.SJF_Time_flowLayoutPanel.TabIndex = 88;
            this.SJF_Time_flowLayoutPanel.WrapContents = false;
            // 
            // SJF_Reset_btn
            // 
            this.SJF_Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SJF_Reset_btn.Location = new System.Drawing.Point(504, 31);
            this.SJF_Reset_btn.Name = "SJF_Reset_btn";
            this.SJF_Reset_btn.Size = new System.Drawing.Size(101, 42);
            this.SJF_Reset_btn.TabIndex = 81;
            this.SJF_Reset_btn.Text = "Reset";
            this.SJF_Reset_btn.UseVisualStyleBackColor = true;
            this.SJF_Reset_btn.Click += new System.EventHandler(this.SJF_Reset_btn_Click);
            // 
            // SJF_Mode_Label
            // 
            this.SJF_Mode_Label.AutoSize = true;
            this.SJF_Mode_Label.Location = new System.Drawing.Point(89, 34);
            this.SJF_Mode_Label.Name = "SJF_Mode_Label";
            this.SJF_Mode_Label.Size = new System.Drawing.Size(75, 29);
            this.SJF_Mode_Label.TabIndex = 77;
            this.SJF_Mode_Label.Text = "Mode";
            // 
            // SJF_Mode_comboBox
            // 
            this.SJF_Mode_comboBox.FormattingEnabled = true;
            this.SJF_Mode_comboBox.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.SJF_Mode_comboBox.Location = new System.Drawing.Point(190, 31);
            this.SJF_Mode_comboBox.Name = "SJF_Mode_comboBox";
            this.SJF_Mode_comboBox.Size = new System.Drawing.Size(121, 37);
            this.SJF_Mode_comboBox.TabIndex = 76;
            this.SJF_Mode_comboBox.SelectedIndexChanged += new System.EventHandler(this.SJF_Mode_comboBox_SelectedIndexChanged);
            // 
            // SJF_dataGridView
            // 
            this.SJF_dataGridView.AllowUserToAddRows = false;
            this.SJF_dataGridView.AllowUserToDeleteRows = false;
            this.SJF_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.SJF_dataGridView.ColumnHeadersHeight = 29;
            this.SJF_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SJF_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1});
            this.SJF_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SJF_dataGridView.Location = new System.Drawing.Point(705, 15);
            this.SJF_dataGridView.Name = "SJF_dataGridView";
            this.SJF_dataGridView.ReadOnly = true;
            this.SJF_dataGridView.RowHeadersWidth = 51;
            this.SJF_dataGridView.RowTemplate.Height = 24;
            this.SJF_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SJF_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SJF_dataGridView.Size = new System.Drawing.Size(362, 317);
            this.SJF_dataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "PID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 81;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Arrival";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Burst";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 97;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Remaining Time";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 220;
            // 
            // SJF_Jump_checkBox
            // 
            this.SJF_Jump_checkBox.AutoSize = true;
            this.SJF_Jump_checkBox.Location = new System.Drawing.Point(506, 93);
            this.SJF_Jump_checkBox.Name = "SJF_Jump_checkBox";
            this.SJF_Jump_checkBox.Size = new System.Drawing.Size(100, 33);
            this.SJF_Jump_checkBox.TabIndex = 31;
            this.SJF_Jump_checkBox.Text = "JUMP";
            this.SJF_Jump_checkBox.UseVisualStyleBackColor = true;
            this.SJF_Jump_checkBox.CheckedChanged += new System.EventHandler(this.SJF_Jump_checkBox_CheckedChanged);
            // 
            // SJF_CurrentSlot_label
            // 
            this.SJF_CurrentSlot_label.AutoSize = true;
            this.SJF_CurrentSlot_label.Location = new System.Drawing.Point(1079, 803);
            this.SJF_CurrentSlot_label.Name = "SJF_CurrentSlot_label";
            this.SJF_CurrentSlot_label.Size = new System.Drawing.Size(26, 29);
            this.SJF_CurrentSlot_label.TabIndex = 30;
            this.SJF_CurrentSlot_label.Text = "0";
            // 
            // SJF_Slot_label
            // 
            this.SJF_Slot_label.AutoSize = true;
            this.SJF_Slot_label.Location = new System.Drawing.Point(1147, 803);
            this.SJF_Slot_label.Name = "SJF_Slot_label";
            this.SJF_Slot_label.Size = new System.Drawing.Size(51, 29);
            this.SJF_Slot_label.TabIndex = 29;
            this.SJF_Slot_label.Text = "slot";
            // 
            // SJF_Live_checkBox
            // 
            this.SJF_Live_checkBox.AutoSize = true;
            this.SJF_Live_checkBox.Location = new System.Drawing.Point(320, 93);
            this.SJF_Live_checkBox.Name = "SJF_Live_checkBox";
            this.SJF_Live_checkBox.Size = new System.Drawing.Size(85, 33);
            this.SJF_Live_checkBox.TabIndex = 27;
            this.SJF_Live_checkBox.Text = "LIVE";
            this.SJF_Live_checkBox.UseVisualStyleBackColor = true;
            this.SJF_Live_checkBox.CheckedChanged += new System.EventHandler(this.SJF_Live_checkBox_CheckedChanged);
            // 
            // SJF_Version_checkBox
            // 
            this.SJF_Version_checkBox.AutoSize = true;
            this.SJF_Version_checkBox.Location = new System.Drawing.Point(101, 93);
            this.SJF_Version_checkBox.Name = "SJF_Version_checkBox";
            this.SJF_Version_checkBox.Size = new System.Drawing.Size(144, 33);
            this.SJF_Version_checkBox.TabIndex = 26;
            this.SJF_Version_checkBox.Text = "Preemtive";
            this.SJF_Version_checkBox.UseVisualStyleBackColor = true;
            this.SJF_Version_checkBox.CheckedChanged += new System.EventHandler(this.SJF_Version_checkBox_CheckedChanged);
            // 
            // SJF_NoOfProcesses_Label
            // 
            this.SJF_NoOfProcesses_Label.AutoSize = true;
            this.SJF_NoOfProcesses_Label.Location = new System.Drawing.Point(97, 157);
            this.SJF_NoOfProcesses_Label.Name = "SJF_NoOfProcesses_Label";
            this.SJF_NoOfProcesses_Label.Size = new System.Drawing.Size(191, 29);
            this.SJF_NoOfProcesses_Label.TabIndex = 23;
            this.SJF_NoOfProcesses_Label.Text = "No of Processes";
            // 
            // SJF_BurstTime_label
            // 
            this.SJF_BurstTime_label.AutoSize = true;
            this.SJF_BurstTime_label.Location = new System.Drawing.Point(105, 273);
            this.SJF_BurstTime_label.Name = "SJF_BurstTime_label";
            this.SJF_BurstTime_label.Size = new System.Drawing.Size(130, 29);
            this.SJF_BurstTime_label.TabIndex = 22;
            this.SJF_BurstTime_label.Text = "Burst Time";
            // 
            // SJF_ArrivalTime_label
            // 
            this.SJF_ArrivalTime_label.AutoSize = true;
            this.SJF_ArrivalTime_label.Location = new System.Drawing.Point(104, 228);
            this.SJF_ArrivalTime_label.Name = "SJF_ArrivalTime_label";
            this.SJF_ArrivalTime_label.Size = new System.Drawing.Size(142, 29);
            this.SJF_ArrivalTime_label.TabIndex = 21;
            this.SJF_ArrivalTime_label.Text = "Arrival Time";
            // 
            // SJF_Insert_btn
            // 
            this.SJF_Insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SJF_Insert_btn.Location = new System.Drawing.Point(255, 349);
            this.SJF_Insert_btn.Name = "SJF_Insert_btn";
            this.SJF_Insert_btn.Size = new System.Drawing.Size(101, 42);
            this.SJF_Insert_btn.TabIndex = 18;
            this.SJF_Insert_btn.Text = "Insert";
            this.SJF_Insert_btn.UseVisualStyleBackColor = true;
            this.SJF_Insert_btn.Click += new System.EventHandler(this.SJF_Insert_btn_Click);
            // 
            // SJF_Ok_btn
            // 
            this.SJF_Ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SJF_Ok_btn.Location = new System.Drawing.Point(528, 150);
            this.SJF_Ok_btn.Name = "SJF_Ok_btn";
            this.SJF_Ok_btn.Size = new System.Drawing.Size(68, 42);
            this.SJF_Ok_btn.TabIndex = 15;
            this.SJF_Ok_btn.Text = "OK";
            this.SJF_Ok_btn.UseVisualStyleBackColor = true;
            this.SJF_Ok_btn.Click += new System.EventHandler(this.SJF_Ok_btn_Click);
            // 
            // FCFS
            // 
            this.FCFS.AutoScroll = true;
            this.FCFS.Controls.Add(this.panel1);
            this.FCFS.Controls.Add(this.panel2);
            this.FCFS.Controls.Add(this.FCFS_trackBar);
            this.FCFS.Controls.Add(this.FCFS_Process_flowLayoutPanel2);
            this.FCFS.Controls.Add(this.FCFS_Process_flowLayoutPanel3);
            this.FCFS.Controls.Add(this.FCFS_Time_flowLayoutPanel3);
            this.FCFS.Controls.Add(this.FCFS_hScrollBar);
            this.FCFS.Controls.Add(this.FCFS_Time_flowLayoutPanel2);
            this.FCFS.Controls.Add(this.FCFS_Process_flowLayoutPanel);
            this.FCFS.Controls.Add(this.FCFS_Time_flowLayoutPanel);
            this.FCFS.Controls.Add(this.FCFS_avgTurnAroundTime_textBox);
            this.FCFS.Controls.Add(this.FCFS_avgWaitingTime_textBox);
            this.FCFS.Controls.Add(this.FCFS_sumTurnAroundTime_textBox);
            this.FCFS.Controls.Add(this.FCFS_sumWaitingTime_textBox);
            this.FCFS.Controls.Add(this.FCFS_BurstTime_textbook);
            this.FCFS.Controls.Add(this.FCFS_ArrivalTime_textbook);
            this.FCFS.Controls.Add(this.FCFS_NoOfProcesses_textbook);
            this.FCFS.Controls.Add(this.FCFS_avgTurnAroundTime_label);
            this.FCFS.Controls.Add(this.FCFS_avgWaitingTime_label);
            this.FCFS.Controls.Add(this.FCFS_sumTurnAroundTime_label);
            this.FCFS.Controls.Add(this.FCFS_Reset_btn);
            this.FCFS.Controls.Add(this.FCFS_Mode_Label);
            this.FCFS.Controls.Add(this.FCFS_Mode_comboBox);
            this.FCFS.Controls.Add(this.FCFS_sumWaitingTime_label);
            this.FCFS.Controls.Add(this.FCFS_dataGridView);
            this.FCFS.Controls.Add(this.FCFS_Jump_checkBox);
            this.FCFS.Controls.Add(this.FCFS_CurrentSlot_label);
            this.FCFS.Controls.Add(this.FCFS_Slot_label);
            this.FCFS.Controls.Add(this.FCFS_Live_checkBox);
            this.FCFS.Controls.Add(this.FCFS_NoOfProcesses_Label);
            this.FCFS.Controls.Add(this.FCFS_BurstTime_label);
            this.FCFS.Controls.Add(this.FCFS_ArrivalTime_label);
            this.FCFS.Controls.Add(this.FCFS_Insert_btn);
            this.FCFS.Controls.Add(this.FCFS_Ok_btn);
            this.FCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS.Location = new System.Drawing.Point(4, 25);
            this.FCFS.Name = "FCFS";
            this.FCFS.Padding = new System.Windows.Forms.Padding(3);
            this.FCFS.Size = new System.Drawing.Size(1202, 836);
            this.FCFS.TabIndex = 0;
            this.FCFS.Text = "FCFS";
            this.FCFS.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 746);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 47);
            this.panel1.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1073, 746);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 47);
            this.panel2.TabIndex = 103;
            // 
            // FCFS_trackBar
            // 
            this.FCFS_trackBar.LargeChange = 3;
            this.FCFS_trackBar.Location = new System.Drawing.Point(1123, 531);
            this.FCFS_trackBar.Maximum = 5;
            this.FCFS_trackBar.Name = "FCFS_trackBar";
            this.FCFS_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FCFS_trackBar.Size = new System.Drawing.Size(56, 245);
            this.FCFS_trackBar.TabIndex = 101;
            this.FCFS_trackBar.Scroll += new System.EventHandler(this.FCFS_trackBar_Scroll);
            // 
            // FCFS_Process_flowLayoutPanel2
            // 
            this.FCFS_Process_flowLayoutPanel2.Location = new System.Drawing.Point(77, 557);
            this.FCFS_Process_flowLayoutPanel2.Name = "FCFS_Process_flowLayoutPanel2";
            this.FCFS_Process_flowLayoutPanel2.Size = new System.Drawing.Size(1005, 42);
            this.FCFS_Process_flowLayoutPanel2.TabIndex = 98;
            // 
            // FCFS_Process_flowLayoutPanel3
            // 
            this.FCFS_Process_flowLayoutPanel3.Location = new System.Drawing.Point(77, 651);
            this.FCFS_Process_flowLayoutPanel3.Name = "FCFS_Process_flowLayoutPanel3";
            this.FCFS_Process_flowLayoutPanel3.Size = new System.Drawing.Size(1005, 42);
            this.FCFS_Process_flowLayoutPanel3.TabIndex = 99;
            // 
            // FCFS_Time_flowLayoutPanel3
            // 
            this.FCFS_Time_flowLayoutPanel3.Location = new System.Drawing.Point(47, 603);
            this.FCFS_Time_flowLayoutPanel3.Name = "FCFS_Time_flowLayoutPanel3";
            this.FCFS_Time_flowLayoutPanel3.Size = new System.Drawing.Size(1069, 42);
            this.FCFS_Time_flowLayoutPanel3.TabIndex = 100;
            // 
            // FCFS_hScrollBar
            // 
            this.FCFS_hScrollBar.Location = new System.Drawing.Point(47, 788);
            this.FCFS_hScrollBar.Name = "FCFS_hScrollBar";
            this.FCFS_hScrollBar.Size = new System.Drawing.Size(1028, 27);
            this.FCFS_hScrollBar.TabIndex = 94;
            this.FCFS_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FCFS_hScrollBar_Scroll);
            // 
            // FCFS_Time_flowLayoutPanel2
            // 
            this.FCFS_Time_flowLayoutPanel2.Location = new System.Drawing.Point(46, 510);
            this.FCFS_Time_flowLayoutPanel2.Name = "FCFS_Time_flowLayoutPanel2";
            this.FCFS_Time_flowLayoutPanel2.Size = new System.Drawing.Size(1069, 42);
            this.FCFS_Time_flowLayoutPanel2.TabIndex = 97;
            // 
            // FCFS_Process_flowLayoutPanel
            // 
            this.FCFS_Process_flowLayoutPanel.AutoScroll = true;
            this.FCFS_Process_flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FCFS_Process_flowLayoutPanel.Location = new System.Drawing.Point(66, 750);
            this.FCFS_Process_flowLayoutPanel.Name = "FCFS_Process_flowLayoutPanel";
            this.FCFS_Process_flowLayoutPanel.Size = new System.Drawing.Size(1007, 58);
            this.FCFS_Process_flowLayoutPanel.TabIndex = 96;
            this.FCFS_Process_flowLayoutPanel.WrapContents = false;
            // 
            // FCFS_Time_flowLayoutPanel
            // 
            this.FCFS_Time_flowLayoutPanel.AutoScroll = true;
            this.FCFS_Time_flowLayoutPanel.Location = new System.Drawing.Point(47, 704);
            this.FCFS_Time_flowLayoutPanel.Name = "FCFS_Time_flowLayoutPanel";
            this.FCFS_Time_flowLayoutPanel.Size = new System.Drawing.Size(1068, 64);
            this.FCFS_Time_flowLayoutPanel.TabIndex = 95;
            this.FCFS_Time_flowLayoutPanel.WrapContents = false;
            // 
            // FCFS_avgTurnAroundTime_textBox
            // 
            this.FCFS_avgTurnAroundTime_textBox.Location = new System.Drawing.Point(985, 471);
            this.FCFS_avgTurnAroundTime_textBox.Name = "FCFS_avgTurnAroundTime_textBox";
            this.FCFS_avgTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.FCFS_avgTurnAroundTime_textBox.TabIndex = 90;
            // 
            // FCFS_avgWaitingTime_textBox
            // 
            this.FCFS_avgWaitingTime_textBox.Location = new System.Drawing.Point(985, 430);
            this.FCFS_avgWaitingTime_textBox.Name = "FCFS_avgWaitingTime_textBox";
            this.FCFS_avgWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.FCFS_avgWaitingTime_textBox.TabIndex = 89;
            // 
            // FCFS_sumTurnAroundTime_textBox
            // 
            this.FCFS_sumTurnAroundTime_textBox.Location = new System.Drawing.Point(985, 388);
            this.FCFS_sumTurnAroundTime_textBox.Name = "FCFS_sumTurnAroundTime_textBox";
            this.FCFS_sumTurnAroundTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.FCFS_sumTurnAroundTime_textBox.TabIndex = 86;
            // 
            // FCFS_sumWaitingTime_textBox
            // 
            this.FCFS_sumWaitingTime_textBox.Location = new System.Drawing.Point(985, 347);
            this.FCFS_sumWaitingTime_textBox.Name = "FCFS_sumWaitingTime_textBox";
            this.FCFS_sumWaitingTime_textBox.Size = new System.Drawing.Size(88, 34);
            this.FCFS_sumWaitingTime_textBox.TabIndex = 85;
            // 
            // FCFS_BurstTime_textbook
            // 
            this.FCFS_BurstTime_textbook.Location = new System.Drawing.Point(333, 273);
            this.FCFS_BurstTime_textbook.Name = "FCFS_BurstTime_textbook";
            this.FCFS_BurstTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.FCFS_BurstTime_textbook.TabIndex = 10;
            // 
            // FCFS_ArrivalTime_textbook
            // 
            this.FCFS_ArrivalTime_textbook.Location = new System.Drawing.Point(333, 228);
            this.FCFS_ArrivalTime_textbook.Name = "FCFS_ArrivalTime_textbook";
            this.FCFS_ArrivalTime_textbook.Size = new System.Drawing.Size(148, 34);
            this.FCFS_ArrivalTime_textbook.TabIndex = 9;
            // 
            // FCFS_NoOfProcesses_textbook
            // 
            this.FCFS_NoOfProcesses_textbook.Location = new System.Drawing.Point(332, 152);
            this.FCFS_NoOfProcesses_textbook.Name = "FCFS_NoOfProcesses_textbook";
            this.FCFS_NoOfProcesses_textbook.Size = new System.Drawing.Size(148, 34);
            this.FCFS_NoOfProcesses_textbook.TabIndex = 6;
            // 
            // FCFS_avgTurnAroundTime_label
            // 
            this.FCFS_avgTurnAroundTime_label.AutoSize = true;
            this.FCFS_avgTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS_avgTurnAroundTime_label.Location = new System.Drawing.Point(718, 471);
            this.FCFS_avgTurnAroundTime_label.Name = "FCFS_avgTurnAroundTime_label";
            this.FCFS_avgTurnAroundTime_label.Size = new System.Drawing.Size(247, 25);
            this.FCFS_avgTurnAroundTime_label.TabIndex = 88;
            this.FCFS_avgTurnAroundTime_label.Text = "Average Turnaround  Time";
            // 
            // FCFS_avgWaitingTime_label
            // 
            this.FCFS_avgWaitingTime_label.AutoSize = true;
            this.FCFS_avgWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS_avgWaitingTime_label.Location = new System.Drawing.Point(718, 430);
            this.FCFS_avgWaitingTime_label.Name = "FCFS_avgWaitingTime_label";
            this.FCFS_avgWaitingTime_label.Size = new System.Drawing.Size(206, 25);
            this.FCFS_avgWaitingTime_label.TabIndex = 87;
            this.FCFS_avgWaitingTime_label.Text = "Average Waiting Time";
            // 
            // FCFS_sumTurnAroundTime_label
            // 
            this.FCFS_sumTurnAroundTime_label.AutoSize = true;
            this.FCFS_sumTurnAroundTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS_sumTurnAroundTime_label.Location = new System.Drawing.Point(715, 385);
            this.FCFS_sumTurnAroundTime_label.Name = "FCFS_sumTurnAroundTime_label";
            this.FCFS_sumTurnAroundTime_label.Size = new System.Drawing.Size(215, 25);
            this.FCFS_sumTurnAroundTime_label.TabIndex = 83;
            this.FCFS_sumTurnAroundTime_label.Text = "sum of turnaround  time";
            // 
            // FCFS_Reset_btn
            // 
            this.FCFS_Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FCFS_Reset_btn.Location = new System.Drawing.Point(504, 31);
            this.FCFS_Reset_btn.Name = "FCFS_Reset_btn";
            this.FCFS_Reset_btn.Size = new System.Drawing.Size(101, 42);
            this.FCFS_Reset_btn.TabIndex = 82;
            this.FCFS_Reset_btn.Text = "Reset";
            this.FCFS_Reset_btn.UseVisualStyleBackColor = true;
            this.FCFS_Reset_btn.Click += new System.EventHandler(this.FCFS_Reset_btn_Click);
            // 
            // FCFS_Mode_Label
            // 
            this.FCFS_Mode_Label.AutoSize = true;
            this.FCFS_Mode_Label.Location = new System.Drawing.Point(89, 34);
            this.FCFS_Mode_Label.Name = "FCFS_Mode_Label";
            this.FCFS_Mode_Label.Size = new System.Drawing.Size(75, 29);
            this.FCFS_Mode_Label.TabIndex = 75;
            this.FCFS_Mode_Label.Text = "Mode";
            // 
            // FCFS_Mode_comboBox
            // 
            this.FCFS_Mode_comboBox.FormattingEnabled = true;
            this.FCFS_Mode_comboBox.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.FCFS_Mode_comboBox.Location = new System.Drawing.Point(190, 31);
            this.FCFS_Mode_comboBox.Name = "FCFS_Mode_comboBox";
            this.FCFS_Mode_comboBox.Size = new System.Drawing.Size(121, 37);
            this.FCFS_Mode_comboBox.TabIndex = 74;
            this.FCFS_Mode_comboBox.SelectedIndexChanged += new System.EventHandler(this.FCFS_Mode_comboBox_SelectedIndexChanged);
            // 
            // FCFS_sumWaitingTime_label
            // 
            this.FCFS_sumWaitingTime_label.AutoSize = true;
            this.FCFS_sumWaitingTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCFS_sumWaitingTime_label.Location = new System.Drawing.Point(715, 347);
            this.FCFS_sumWaitingTime_label.Name = "FCFS_sumWaitingTime_label";
            this.FCFS_sumWaitingTime_label.Size = new System.Drawing.Size(176, 25);
            this.FCFS_sumWaitingTime_label.TabIndex = 37;
            this.FCFS_sumWaitingTime_label.Text = "sum of waiting time";
            // 
            // FCFS_dataGridView
            // 
            this.FCFS_dataGridView.AllowUserToAddRows = false;
            this.FCFS_dataGridView.AllowUserToDeleteRows = false;
            this.FCFS_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.FCFS_dataGridView.ColumnHeadersHeight = 29;
            this.FCFS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FCFS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FCFS_PID,
            this.FCFS_ArrivalTime,
            this.FCFS_BurstTime});
            this.FCFS_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FCFS_dataGridView.Location = new System.Drawing.Point(705, 15);
            this.FCFS_dataGridView.Name = "FCFS_dataGridView";
            this.FCFS_dataGridView.ReadOnly = true;
            this.FCFS_dataGridView.RowHeadersWidth = 51;
            this.FCFS_dataGridView.RowTemplate.Height = 24;
            this.FCFS_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FCFS_dataGridView.Size = new System.Drawing.Size(362, 317);
            this.FCFS_dataGridView.TabIndex = 1;
            // 
            // FCFS_PID
            // 
            this.FCFS_PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FCFS_PID.HeaderText = "PID";
            this.FCFS_PID.MinimumWidth = 6;
            this.FCFS_PID.Name = "FCFS_PID";
            this.FCFS_PID.ReadOnly = true;
            this.FCFS_PID.Width = 81;
            // 
            // FCFS_ArrivalTime
            // 
            this.FCFS_ArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FCFS_ArrivalTime.HeaderText = "Arrival";
            this.FCFS_ArrivalTime.MinimumWidth = 6;
            this.FCFS_ArrivalTime.Name = "FCFS_ArrivalTime";
            this.FCFS_ArrivalTime.ReadOnly = true;
            this.FCFS_ArrivalTime.Width = 109;
            // 
            // FCFS_BurstTime
            // 
            this.FCFS_BurstTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FCFS_BurstTime.HeaderText = "Burst";
            this.FCFS_BurstTime.MinimumWidth = 6;
            this.FCFS_BurstTime.Name = "FCFS_BurstTime";
            this.FCFS_BurstTime.ReadOnly = true;
            this.FCFS_BurstTime.Width = 97;
            // 
            // FCFS_Jump_checkBox
            // 
            this.FCFS_Jump_checkBox.AutoSize = true;
            this.FCFS_Jump_checkBox.Location = new System.Drawing.Point(535, 275);
            this.FCFS_Jump_checkBox.Name = "FCFS_Jump_checkBox";
            this.FCFS_Jump_checkBox.Size = new System.Drawing.Size(100, 33);
            this.FCFS_Jump_checkBox.TabIndex = 36;
            this.FCFS_Jump_checkBox.Text = "JUMP";
            this.FCFS_Jump_checkBox.UseVisualStyleBackColor = true;
            this.FCFS_Jump_checkBox.CheckedChanged += new System.EventHandler(this.FCFS_Jump_checkBox_CheckedChanged);
            // 
            // FCFS_CurrentSlot_label
            // 
            this.FCFS_CurrentSlot_label.AutoSize = true;
            this.FCFS_CurrentSlot_label.Location = new System.Drawing.Point(1079, 803);
            this.FCFS_CurrentSlot_label.Name = "FCFS_CurrentSlot_label";
            this.FCFS_CurrentSlot_label.Size = new System.Drawing.Size(26, 29);
            this.FCFS_CurrentSlot_label.TabIndex = 33;
            this.FCFS_CurrentSlot_label.Text = "0";
            // 
            // FCFS_Slot_label
            // 
            this.FCFS_Slot_label.AutoSize = true;
            this.FCFS_Slot_label.Location = new System.Drawing.Point(1147, 803);
            this.FCFS_Slot_label.Name = "FCFS_Slot_label";
            this.FCFS_Slot_label.Size = new System.Drawing.Size(51, 29);
            this.FCFS_Slot_label.TabIndex = 32;
            this.FCFS_Slot_label.Text = "slot";
            // 
            // FCFS_Live_checkBox
            // 
            this.FCFS_Live_checkBox.AutoSize = true;
            this.FCFS_Live_checkBox.Location = new System.Drawing.Point(535, 228);
            this.FCFS_Live_checkBox.Name = "FCFS_Live_checkBox";
            this.FCFS_Live_checkBox.Size = new System.Drawing.Size(85, 33);
            this.FCFS_Live_checkBox.TabIndex = 31;
            this.FCFS_Live_checkBox.Text = "LIVE";
            this.FCFS_Live_checkBox.UseVisualStyleBackColor = true;
            this.FCFS_Live_checkBox.CheckedChanged += new System.EventHandler(this.FCFS_Live_checkBox_CheckedChanged);
            // 
            // FCFS_NoOfProcesses_Label
            // 
            this.FCFS_NoOfProcesses_Label.AutoSize = true;
            this.FCFS_NoOfProcesses_Label.Location = new System.Drawing.Point(97, 157);
            this.FCFS_NoOfProcesses_Label.Name = "FCFS_NoOfProcesses_Label";
            this.FCFS_NoOfProcesses_Label.Size = new System.Drawing.Size(191, 29);
            this.FCFS_NoOfProcesses_Label.TabIndex = 13;
            this.FCFS_NoOfProcesses_Label.Text = "No of Processes";
            // 
            // FCFS_BurstTime_label
            // 
            this.FCFS_BurstTime_label.AutoSize = true;
            this.FCFS_BurstTime_label.Location = new System.Drawing.Point(105, 273);
            this.FCFS_BurstTime_label.Name = "FCFS_BurstTime_label";
            this.FCFS_BurstTime_label.Size = new System.Drawing.Size(130, 29);
            this.FCFS_BurstTime_label.TabIndex = 12;
            this.FCFS_BurstTime_label.Text = "Burst Time";
            // 
            // FCFS_ArrivalTime_label
            // 
            this.FCFS_ArrivalTime_label.AutoSize = true;
            this.FCFS_ArrivalTime_label.Location = new System.Drawing.Point(104, 228);
            this.FCFS_ArrivalTime_label.Name = "FCFS_ArrivalTime_label";
            this.FCFS_ArrivalTime_label.Size = new System.Drawing.Size(142, 29);
            this.FCFS_ArrivalTime_label.TabIndex = 11;
            this.FCFS_ArrivalTime_label.Text = "Arrival Time";
            // 
            // FCFS_Insert_btn
            // 
            this.FCFS_Insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FCFS_Insert_btn.Location = new System.Drawing.Point(255, 349);
            this.FCFS_Insert_btn.Name = "FCFS_Insert_btn";
            this.FCFS_Insert_btn.Size = new System.Drawing.Size(101, 42);
            this.FCFS_Insert_btn.TabIndex = 8;
            this.FCFS_Insert_btn.Text = "Insert";
            this.FCFS_Insert_btn.UseVisualStyleBackColor = true;
            this.FCFS_Insert_btn.Click += new System.EventHandler(this.FCFS_Insert_btn_Click);
            // 
            // FCFS_Ok_btn
            // 
            this.FCFS_Ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FCFS_Ok_btn.Location = new System.Drawing.Point(528, 150);
            this.FCFS_Ok_btn.Name = "FCFS_Ok_btn";
            this.FCFS_Ok_btn.Size = new System.Drawing.Size(68, 42);
            this.FCFS_Ok_btn.TabIndex = 5;
            this.FCFS_Ok_btn.Text = "OK";
            this.FCFS_Ok_btn.UseVisualStyleBackColor = true;
            this.FCFS_Ok_btn.Click += new System.EventHandler(this.FCFS_Ok_btn_Click);
            // 
            // PIO_NoOfProcesses_textbook
            // 
            this.PIO_NoOfProcesses_textbook.Controls.Add(this.FCFS);
            this.PIO_NoOfProcesses_textbook.Controls.Add(this.SJF);
            this.PIO_NoOfProcesses_textbook.Controls.Add(this.Priority);
            this.PIO_NoOfProcesses_textbook.Controls.Add(this.Round_Robin);
            this.PIO_NoOfProcesses_textbook.Location = new System.Drawing.Point(26, 12);
            this.PIO_NoOfProcesses_textbook.Name = "PIO_NoOfProcesses_textbook";
            this.PIO_NoOfProcesses_textbook.SelectedIndex = 0;
            this.PIO_NoOfProcesses_textbook.Size = new System.Drawing.Size(1210, 865);
            this.PIO_NoOfProcesses_textbook.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 889);
            this.Controls.Add(this.PIO_NoOfProcesses_textbook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Scheduler";
            this.Round_Robin.ResumeLayout(false);
            this.Round_Robin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RR_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RR_dataGridView)).EndInit();
            this.Priority.ResumeLayout(false);
            this.Priority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIOR_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIOR_dataGridView)).EndInit();
            this.SJF.ResumeLayout(false);
            this.SJF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SJF_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SJF_dataGridView)).EndInit();
            this.FCFS.ResumeLayout(false);
            this.FCFS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCFS_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCFS_dataGridView)).EndInit();
            this.PIO_NoOfProcesses_textbook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FCFS_Timer;
        private System.Windows.Forms.Timer SJF_Timer;
        private System.Windows.Forms.Timer PIOR_Timer;
        private System.Windows.Forms.Timer RR_Timer;
        private System.Windows.Forms.TabPage Round_Robin;
        private System.Windows.Forms.TrackBar RR_trackBar;
        private System.Windows.Forms.TextBox RR_avgTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox RR_avgWaitingTime_textBox;
        private System.Windows.Forms.TextBox RR_sumTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox RR_sumWaitingTime_textBox;
        private System.Windows.Forms.TextBox RR_QuantamTime_textBox;
        private System.Windows.Forms.TextBox RR_BurstTime_textbook;
        private System.Windows.Forms.TextBox RR_ArrivalTime_textbook;
        private System.Windows.Forms.TextBox RR_NoOfProcesses_textbook;
        private System.Windows.Forms.Label RR_avgTurnAroundTime_label;
        private System.Windows.Forms.Label RR_avgWaitingTime_label;
        private System.Windows.Forms.Label RR_sumTurnAroundTime_label;
        private System.Windows.Forms.Label RR_sumWaitingTime_label;
        private System.Windows.Forms.FlowLayoutPanel RR_Process_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel RR_Process_flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel RR_Time_flowLayoutPanel3;
        private System.Windows.Forms.HScrollBar RR_hScrollBar;
        private System.Windows.Forms.FlowLayoutPanel RR_Time_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel RR_Process_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel RR_Time_flowLayoutPanel;
        private System.Windows.Forms.Button RR_Reset_btn;
        private System.Windows.Forms.Label RR_Mode_Label;
        private System.Windows.Forms.ComboBox RR_Mode_comboBox;
        private System.Windows.Forms.Label RR_QuantamTime_Label;
        private System.Windows.Forms.Label RR_NoOfProcesses_Label;
        private System.Windows.Forms.Label RR_BurstTime_label;
        private System.Windows.Forms.Label RR_ArrivalTime_label;
        private System.Windows.Forms.Button RR_Insert_btn;
        private System.Windows.Forms.Button RR_Ok_btn;
        private System.Windows.Forms.CheckBox RR_Jump_checkBox;
        private System.Windows.Forms.DataGridView RR_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.CheckBox RR_Live_checkBox;
        private System.Windows.Forms.Label RR_CurrentSlot_label;
        private System.Windows.Forms.Label RR_Slot_label;
        private System.Windows.Forms.TabPage Priority;
        private System.Windows.Forms.TrackBar PIOR_trackBar;
        private System.Windows.Forms.TextBox PIOR_avgTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox PIOR_avgWaitingTime_textBox;
        private System.Windows.Forms.TextBox PIOR_sumTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox PIOR_sumWaitingTime_textBox;
        private System.Windows.Forms.TextBox PIOR_Piority_textbook;
        private System.Windows.Forms.TextBox PIOR_BurstTime_textbook;
        private System.Windows.Forms.TextBox PIOR_ArrivalTime_textbook;
        private System.Windows.Forms.TextBox PIOR_NoOfProcesses_textbook;
        private System.Windows.Forms.Label PIOR_avgTurnAroundTime_label;
        private System.Windows.Forms.Label PIOR_avgWaitingTime_label;
        private System.Windows.Forms.Label PIOR_sumTurnAroundTime_label;
        private System.Windows.Forms.Label PIOR_sumWaitingTime_label;
        private System.Windows.Forms.FlowLayoutPanel PIOR_Process_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel PIOR_Process_flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel PIOR_Time_flowLayoutPanel3;
        private System.Windows.Forms.HScrollBar PIOR_hScrollBar;
        private System.Windows.Forms.FlowLayoutPanel PIOR_Time_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel PIOR_Process_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel PIOR_Time_flowLayoutPanel;
        private System.Windows.Forms.Button PIOR_Reset_btn;
        private System.Windows.Forms.Label PIOR_Mode_Label;
        private System.Windows.Forms.ComboBox PIOR_Mode_comboBox;
        private System.Windows.Forms.Label PIOR_Piority_label;
        private System.Windows.Forms.DataGridView PIOR_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox PIOR_Jump_checkBox;
        private System.Windows.Forms.Label PIOR_CurrentSlot_label;
        private System.Windows.Forms.Label PIOR_Slot_label;
        private System.Windows.Forms.CheckBox PIOR_Live_checkBox;
        private System.Windows.Forms.CheckBox PIOR_Version_checkBox;
        private System.Windows.Forms.Label PIOR_NoOfProcesses_Label;
        private System.Windows.Forms.Label PIOR_BurstTime_label;
        private System.Windows.Forms.Label PIOR_ArrivalTime_label;
        private System.Windows.Forms.Button PIOR_Insert_btn;
        private System.Windows.Forms.Button PIOR_Ok_btn;
        private System.Windows.Forms.TabPage SJF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar SJF_trackBar;
        private System.Windows.Forms.TextBox SJF_avgTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox SJF_avgWaitingTime_textBox;
        private System.Windows.Forms.TextBox SJF_sumTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox SJF_sumWaitingTime_textBox;
        private System.Windows.Forms.TextBox SJF_BurstTime_textbook;
        private System.Windows.Forms.TextBox SJF_ArrivalTime_textbook;
        private System.Windows.Forms.TextBox SJF_NoOfProcesses_textbook;
        private System.Windows.Forms.Label SJF_avgTurnAroundTime_label;
        private System.Windows.Forms.Label SJF_avgWaitingTime_label;
        private System.Windows.Forms.Label SJF_sumTurnAroundTime_label;
        private System.Windows.Forms.Label SJF_sumWaitingTime_label;
        private System.Windows.Forms.FlowLayoutPanel SJF_Process_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel SJF_Process_flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel SJF_Time_flowLayoutPanel3;
        private System.Windows.Forms.HScrollBar SJF_hScrollBar;
        private System.Windows.Forms.FlowLayoutPanel SJF_Time_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel SJF_Process_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SJF_Time_flowLayoutPanel;
        private System.Windows.Forms.Button SJF_Reset_btn;
        private System.Windows.Forms.Label SJF_Mode_Label;
        private System.Windows.Forms.ComboBox SJF_Mode_comboBox;
        private System.Windows.Forms.DataGridView SJF_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox SJF_Jump_checkBox;
        private System.Windows.Forms.Label SJF_CurrentSlot_label;
        private System.Windows.Forms.Label SJF_Slot_label;
        private System.Windows.Forms.CheckBox SJF_Live_checkBox;
        private System.Windows.Forms.CheckBox SJF_Version_checkBox;
        private System.Windows.Forms.Label SJF_NoOfProcesses_Label;
        private System.Windows.Forms.Label SJF_BurstTime_label;
        private System.Windows.Forms.Label SJF_ArrivalTime_label;
        private System.Windows.Forms.Button SJF_Insert_btn;
        private System.Windows.Forms.Button SJF_Ok_btn;
        private System.Windows.Forms.TabPage FCFS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar FCFS_trackBar;
        private System.Windows.Forms.FlowLayoutPanel FCFS_Process_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel FCFS_Process_flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel FCFS_Time_flowLayoutPanel3;
        private System.Windows.Forms.HScrollBar FCFS_hScrollBar;
        private System.Windows.Forms.FlowLayoutPanel FCFS_Time_flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel FCFS_Process_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel FCFS_Time_flowLayoutPanel;
        private System.Windows.Forms.TextBox FCFS_avgTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox FCFS_avgWaitingTime_textBox;
        private System.Windows.Forms.TextBox FCFS_sumTurnAroundTime_textBox;
        private System.Windows.Forms.TextBox FCFS_sumWaitingTime_textBox;
        private System.Windows.Forms.TextBox FCFS_BurstTime_textbook;
        private System.Windows.Forms.TextBox FCFS_ArrivalTime_textbook;
        private System.Windows.Forms.TextBox FCFS_NoOfProcesses_textbook;
        private System.Windows.Forms.Label FCFS_avgTurnAroundTime_label;
        private System.Windows.Forms.Label FCFS_avgWaitingTime_label;
        private System.Windows.Forms.Label FCFS_sumTurnAroundTime_label;
        private System.Windows.Forms.Button FCFS_Reset_btn;
        private System.Windows.Forms.Label FCFS_Mode_Label;
        private System.Windows.Forms.ComboBox FCFS_Mode_comboBox;
        private System.Windows.Forms.Label FCFS_sumWaitingTime_label;
        private System.Windows.Forms.DataGridView FCFS_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCFS_PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCFS_ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCFS_BurstTime;
        private System.Windows.Forms.CheckBox FCFS_Jump_checkBox;
        private System.Windows.Forms.Label FCFS_CurrentSlot_label;
        private System.Windows.Forms.Label FCFS_Slot_label;
        private System.Windows.Forms.CheckBox FCFS_Live_checkBox;
        private System.Windows.Forms.Label FCFS_NoOfProcesses_Label;
        private System.Windows.Forms.Label FCFS_BurstTime_label;
        private System.Windows.Forms.Label FCFS_ArrivalTime_label;
        private System.Windows.Forms.Button FCFS_Insert_btn;
        private System.Windows.Forms.Button FCFS_Ok_btn;
        private System.Windows.Forms.TabControl PIO_NoOfProcesses_textbook;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}

