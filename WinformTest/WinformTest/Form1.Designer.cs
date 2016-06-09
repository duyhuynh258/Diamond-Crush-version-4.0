namespace WinformTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.sprite_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer_selectedSpriteAnimation = new System.Windows.Forms.Timer(this.components);
            this.green_Selected = new System.Windows.Forms.ImageList(this.components);
            this.red_Selected = new System.Windows.Forms.ImageList(this.components);
            this.blue_Selected = new System.Windows.Forms.ImageList(this.components);
            this.orange_Selected = new System.Windows.Forms.ImageList(this.components);
            this.purple_Selected = new System.Windows.Forms.ImageList(this.components);
            this.yellow_Selected = new System.Windows.Forms.ImageList(this.components);
            this.white_Selected = new System.Windows.Forms.ImageList(this.components);
            this.timer_GoSwap = new System.Windows.Forms.Timer(this.components);
            this.timer_SwapBack = new System.Windows.Forms.Timer(this.components);
            this.timer_Explode = new System.Windows.Forms.Timer(this.components);
            this.greenExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.redExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.blueExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.orangeExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.purpleExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.yellowExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.whiteExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer_updateScreen = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer_scoreCount = new System.Windows.Forms.Timer(this.components);
            this.timer_gameTimeLimit = new System.Windows.Forms.Timer(this.components);
            this.butt_imgList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.life_count_lab = new System.Windows.Forms.Label();
            this.gold_count_lab = new System.Windows.Forms.Label();
            this.harmmer_count_lab = new System.Windows.Forms.Label();
            this.flash_count_lab = new System.Windows.Forms.Label();
            this.sandClock_count_lab = new System.Windows.Forms.Label();
            this.timer_using_item_animation = new System.Windows.Forms.Timer(this.components);
            this.fire_gem_imgList = new System.Windows.Forms.ImageList(this.components);
            this.special_gem_imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer_not_normal_gem = new System.Windows.Forms.Timer(this.components);
            this.boom_imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer_boom_animation = new System.Windows.Forms.Timer(this.components);
            this.timer_sound_count = new System.Windows.Forms.Timer(this.components);
            this.verticalElectric_gem_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_green_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_red_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_blue_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_orange_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_purple_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_yellow_imgList = new System.Windows.Forms.ImageList(this.components);
            this.vertElectric_white_imgList = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_back_picBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.life_count_picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.horizElectric_gem_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_green_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_red_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_blue_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_orange_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_purple_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_yellow_imgList = new System.Windows.Forms.ImageList(this.components);
            this.horizElectric_white_imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.but_back_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_count_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sprite_ImageList
            // 
            this.sprite_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sprite_ImageList.ImageStream")));
            this.sprite_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.sprite_ImageList.Images.SetKeyName(0, "green_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(1, "red_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(2, "blue_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(3, "orange_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(4, "purple_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(5, "yellow_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(6, "white_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(7, "selectedBoundBox_50x50.png");
            // 
            // timer_selectedSpriteAnimation
            // 
            this.timer_selectedSpriteAnimation.Enabled = true;
            this.timer_selectedSpriteAnimation.Interval = 115;
            this.timer_selectedSpriteAnimation.Tick += new System.EventHandler(this.timer_selectedSpriteAnimation_Tick);
            // 
            // green_Selected
            // 
            this.green_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("green_Selected.ImageStream")));
            this.green_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.green_Selected.Images.SetKeyName(0, "0.png");
            this.green_Selected.Images.SetKeyName(1, "1.png");
            this.green_Selected.Images.SetKeyName(2, "2.png");
            this.green_Selected.Images.SetKeyName(3, "3.png");
            this.green_Selected.Images.SetKeyName(4, "4.png");
            this.green_Selected.Images.SetKeyName(5, "5.png");
            this.green_Selected.Images.SetKeyName(6, "6.png");
            this.green_Selected.Images.SetKeyName(7, "7.png");
            this.green_Selected.Images.SetKeyName(8, "8.png");
            this.green_Selected.Images.SetKeyName(9, "9.png");
            // 
            // red_Selected
            // 
            this.red_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("red_Selected.ImageStream")));
            this.red_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.red_Selected.Images.SetKeyName(0, "0.png");
            this.red_Selected.Images.SetKeyName(1, "1.png");
            this.red_Selected.Images.SetKeyName(2, "2.png");
            this.red_Selected.Images.SetKeyName(3, "3.png");
            this.red_Selected.Images.SetKeyName(4, "4.png");
            this.red_Selected.Images.SetKeyName(5, "5.png");
            this.red_Selected.Images.SetKeyName(6, "6.png");
            this.red_Selected.Images.SetKeyName(7, "7.png");
            this.red_Selected.Images.SetKeyName(8, "8.png");
            this.red_Selected.Images.SetKeyName(9, "9.png");
            // 
            // blue_Selected
            // 
            this.blue_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blue_Selected.ImageStream")));
            this.blue_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.blue_Selected.Images.SetKeyName(0, "0.png");
            this.blue_Selected.Images.SetKeyName(1, "1.png");
            this.blue_Selected.Images.SetKeyName(2, "2.png");
            this.blue_Selected.Images.SetKeyName(3, "3.png");
            this.blue_Selected.Images.SetKeyName(4, "4.png");
            this.blue_Selected.Images.SetKeyName(5, "5.png");
            this.blue_Selected.Images.SetKeyName(6, "6.png");
            this.blue_Selected.Images.SetKeyName(7, "7.png");
            this.blue_Selected.Images.SetKeyName(8, "8.png");
            this.blue_Selected.Images.SetKeyName(9, "9.png");
            // 
            // orange_Selected
            // 
            this.orange_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("orange_Selected.ImageStream")));
            this.orange_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.orange_Selected.Images.SetKeyName(0, "0.png");
            this.orange_Selected.Images.SetKeyName(1, "1.png");
            this.orange_Selected.Images.SetKeyName(2, "2.png");
            this.orange_Selected.Images.SetKeyName(3, "3.png");
            this.orange_Selected.Images.SetKeyName(4, "4.png");
            this.orange_Selected.Images.SetKeyName(5, "5.png");
            this.orange_Selected.Images.SetKeyName(6, "6.png");
            this.orange_Selected.Images.SetKeyName(7, "7.png");
            this.orange_Selected.Images.SetKeyName(8, "8.png");
            this.orange_Selected.Images.SetKeyName(9, "9.png");
            // 
            // purple_Selected
            // 
            this.purple_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("purple_Selected.ImageStream")));
            this.purple_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.purple_Selected.Images.SetKeyName(0, "0.png");
            this.purple_Selected.Images.SetKeyName(1, "1.png");
            this.purple_Selected.Images.SetKeyName(2, "2.png");
            this.purple_Selected.Images.SetKeyName(3, "3.png");
            this.purple_Selected.Images.SetKeyName(4, "4.png");
            this.purple_Selected.Images.SetKeyName(5, "5.png");
            this.purple_Selected.Images.SetKeyName(6, "6.png");
            this.purple_Selected.Images.SetKeyName(7, "7.png");
            this.purple_Selected.Images.SetKeyName(8, "8.png");
            this.purple_Selected.Images.SetKeyName(9, "9.png");
            // 
            // yellow_Selected
            // 
            this.yellow_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yellow_Selected.ImageStream")));
            this.yellow_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.yellow_Selected.Images.SetKeyName(0, "0.png");
            this.yellow_Selected.Images.SetKeyName(1, "1.png");
            this.yellow_Selected.Images.SetKeyName(2, "2.png");
            this.yellow_Selected.Images.SetKeyName(3, "3.png");
            this.yellow_Selected.Images.SetKeyName(4, "4.png");
            this.yellow_Selected.Images.SetKeyName(5, "5.png");
            this.yellow_Selected.Images.SetKeyName(6, "6.png");
            this.yellow_Selected.Images.SetKeyName(7, "7.png");
            this.yellow_Selected.Images.SetKeyName(8, "8.png");
            this.yellow_Selected.Images.SetKeyName(9, "9.png");
            // 
            // white_Selected
            // 
            this.white_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("white_Selected.ImageStream")));
            this.white_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.white_Selected.Images.SetKeyName(0, "0.png");
            this.white_Selected.Images.SetKeyName(1, "1.png");
            this.white_Selected.Images.SetKeyName(2, "2.png");
            this.white_Selected.Images.SetKeyName(3, "3.png");
            this.white_Selected.Images.SetKeyName(4, "4.png");
            this.white_Selected.Images.SetKeyName(5, "5.png");
            this.white_Selected.Images.SetKeyName(6, "6.png");
            this.white_Selected.Images.SetKeyName(7, "7.png");
            this.white_Selected.Images.SetKeyName(8, "8.png");
            this.white_Selected.Images.SetKeyName(9, "9.png");
            this.white_Selected.Images.SetKeyName(10, "10.png");
            this.white_Selected.Images.SetKeyName(11, "11.png");
            this.white_Selected.Images.SetKeyName(12, "12.png");
            this.white_Selected.Images.SetKeyName(13, "13.png");
            this.white_Selected.Images.SetKeyName(14, "14.png");
            this.white_Selected.Images.SetKeyName(15, "15.png");
            this.white_Selected.Images.SetKeyName(16, "16.png");
            this.white_Selected.Images.SetKeyName(17, "17.png");
            this.white_Selected.Images.SetKeyName(18, "18.png");
            this.white_Selected.Images.SetKeyName(19, "19.png");
            // 
            // timer_GoSwap
            // 
            this.timer_GoSwap.Interval = 50;
            this.timer_GoSwap.Tick += new System.EventHandler(this.timer_swappingGem_Tick);
            // 
            // timer_SwapBack
            // 
            this.timer_SwapBack.Interval = 50;
            this.timer_SwapBack.Tick += new System.EventHandler(this.timer_SwapBack_Tick);
            // 
            // timer_Explode
            // 
            this.timer_Explode.Interval = 35;
            this.timer_Explode.Tick += new System.EventHandler(this.timer_Explode_Tick);
            // 
            // greenExplode_imgList
            // 
            this.greenExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("greenExplode_imgList.ImageStream")));
            this.greenExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.greenExplode_imgList.Images.SetKeyName(0, "0.png");
            this.greenExplode_imgList.Images.SetKeyName(1, "1.png");
            this.greenExplode_imgList.Images.SetKeyName(2, "2.png");
            this.greenExplode_imgList.Images.SetKeyName(3, "3.png");
            this.greenExplode_imgList.Images.SetKeyName(4, "4.png");
            this.greenExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // redExplode_imgList
            // 
            this.redExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("redExplode_imgList.ImageStream")));
            this.redExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.redExplode_imgList.Images.SetKeyName(0, "0.png");
            this.redExplode_imgList.Images.SetKeyName(1, "1.png");
            this.redExplode_imgList.Images.SetKeyName(2, "2.png");
            this.redExplode_imgList.Images.SetKeyName(3, "3.png");
            this.redExplode_imgList.Images.SetKeyName(4, "4.png");
            this.redExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // blueExplode_imgList
            // 
            this.blueExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blueExplode_imgList.ImageStream")));
            this.blueExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.blueExplode_imgList.Images.SetKeyName(0, "0.png");
            this.blueExplode_imgList.Images.SetKeyName(1, "1.png");
            this.blueExplode_imgList.Images.SetKeyName(2, "2.png");
            this.blueExplode_imgList.Images.SetKeyName(3, "3.png");
            this.blueExplode_imgList.Images.SetKeyName(4, "4.png");
            this.blueExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // orangeExplode_imgList
            // 
            this.orangeExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("orangeExplode_imgList.ImageStream")));
            this.orangeExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.orangeExplode_imgList.Images.SetKeyName(0, "0.png");
            this.orangeExplode_imgList.Images.SetKeyName(1, "1.png");
            this.orangeExplode_imgList.Images.SetKeyName(2, "2.png");
            this.orangeExplode_imgList.Images.SetKeyName(3, "3.png");
            this.orangeExplode_imgList.Images.SetKeyName(4, "4.png");
            this.orangeExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // purpleExplode_imgList
            // 
            this.purpleExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("purpleExplode_imgList.ImageStream")));
            this.purpleExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.purpleExplode_imgList.Images.SetKeyName(0, "0.png");
            this.purpleExplode_imgList.Images.SetKeyName(1, "1.png");
            this.purpleExplode_imgList.Images.SetKeyName(2, "2.png");
            this.purpleExplode_imgList.Images.SetKeyName(3, "3.png");
            this.purpleExplode_imgList.Images.SetKeyName(4, "4.png");
            this.purpleExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // yellowExplode_imgList
            // 
            this.yellowExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yellowExplode_imgList.ImageStream")));
            this.yellowExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.yellowExplode_imgList.Images.SetKeyName(0, "0.png");
            this.yellowExplode_imgList.Images.SetKeyName(1, "1.png");
            this.yellowExplode_imgList.Images.SetKeyName(2, "2.png");
            this.yellowExplode_imgList.Images.SetKeyName(3, "3.png");
            this.yellowExplode_imgList.Images.SetKeyName(4, "4.png");
            this.yellowExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // whiteExplode_imgList
            // 
            this.whiteExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("whiteExplode_imgList.ImageStream")));
            this.whiteExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.whiteExplode_imgList.Images.SetKeyName(0, "0.png");
            this.whiteExplode_imgList.Images.SetKeyName(1, "1.png");
            this.whiteExplode_imgList.Images.SetKeyName(2, "2.png");
            this.whiteExplode_imgList.Images.SetKeyName(3, "3.png");
            this.whiteExplode_imgList.Images.SetKeyName(4, "4.png");
            this.whiteExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // timer_updateScreen
            // 
            this.timer_updateScreen.Interval = 35;
            this.timer_updateScreen.Tick += new System.EventHandler(this.timer_updateScreen_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(97, 564);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 26);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 100;
            // 
            // timer_scoreCount
            // 
            this.timer_scoreCount.Enabled = true;
            this.timer_scoreCount.Interval = 1;
            this.timer_scoreCount.Tick += new System.EventHandler(this.timer_scoreCount_Tick);
            // 
            // timer_gameTimeLimit
            // 
            this.timer_gameTimeLimit.Enabled = true;
            this.timer_gameTimeLimit.Interval = 600;
            this.timer_gameTimeLimit.Tick += new System.EventHandler(this.timer_gameTimeLimit_Tick);
            // 
            // butt_imgList
            // 
            this.butt_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("butt_imgList.ImageStream")));
            this.butt_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.butt_imgList.Images.SetKeyName(0, "but_home_75x75.png");
            this.butt_imgList.Images.SetKeyName(1, "but_play_75x75.png");
            this.butt_imgList.Images.SetKeyName(2, "but_replay_75x75.png");
            this.butt_imgList.Images.SetKeyName(3, "but_resume_75x75.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target         : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last score   :";
            // 
            // life_count_lab
            // 
            this.life_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.life_count_lab.Location = new System.Drawing.Point(131, 11);
            this.life_count_lab.Name = "life_count_lab";
            this.life_count_lab.Size = new System.Drawing.Size(80, 40);
            this.life_count_lab.TabIndex = 5;
            this.life_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gold_count_lab
            // 
            this.gold_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold_count_lab.Location = new System.Drawing.Point(131, 50);
            this.gold_count_lab.Name = "gold_count_lab";
            this.gold_count_lab.Size = new System.Drawing.Size(80, 40);
            this.gold_count_lab.TabIndex = 5;
            this.gold_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // harmmer_count_lab
            // 
            this.harmmer_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harmmer_count_lab.Location = new System.Drawing.Point(546, 239);
            this.harmmer_count_lab.Name = "harmmer_count_lab";
            this.harmmer_count_lab.Size = new System.Drawing.Size(75, 20);
            this.harmmer_count_lab.TabIndex = 8;
            this.harmmer_count_lab.Text = "0 left";
            this.harmmer_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flash_count_lab
            // 
            this.flash_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash_count_lab.Location = new System.Drawing.Point(627, 239);
            this.flash_count_lab.Name = "flash_count_lab";
            this.flash_count_lab.Size = new System.Drawing.Size(75, 20);
            this.flash_count_lab.TabIndex = 8;
            this.flash_count_lab.Text = "0 left";
            this.flash_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sandClock_count_lab
            // 
            this.sandClock_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sandClock_count_lab.Location = new System.Drawing.Point(689, 239);
            this.sandClock_count_lab.Name = "sandClock_count_lab";
            this.sandClock_count_lab.Size = new System.Drawing.Size(75, 20);
            this.sandClock_count_lab.TabIndex = 8;
            this.sandClock_count_lab.Text = "0 left";
            this.sandClock_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_using_item_animation
            // 
            this.timer_using_item_animation.Interval = 50;
            this.timer_using_item_animation.Tick += new System.EventHandler(this.timer_using_item_animation_Tick);
            // 
            // fire_gem_imgList
            // 
            this.fire_gem_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fire_gem_imgList.ImageStream")));
            this.fire_gem_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.fire_gem_imgList.Images.SetKeyName(0, "burning_0.png");
            this.fire_gem_imgList.Images.SetKeyName(1, "burning_1.png");
            this.fire_gem_imgList.Images.SetKeyName(2, "burning_2.png");
            this.fire_gem_imgList.Images.SetKeyName(3, "burning_3.png");
            this.fire_gem_imgList.Images.SetKeyName(4, "burning_4.png");
            this.fire_gem_imgList.Images.SetKeyName(5, "burning_5.png");
            this.fire_gem_imgList.Images.SetKeyName(6, "burning_6.png");
            this.fire_gem_imgList.Images.SetKeyName(7, "burning_7.png");
            this.fire_gem_imgList.Images.SetKeyName(8, "burning_8.png");
            this.fire_gem_imgList.Images.SetKeyName(9, "burning_9.png");
            this.fire_gem_imgList.Images.SetKeyName(10, "burning_10.png");
            this.fire_gem_imgList.Images.SetKeyName(11, "burning_11.png");
            this.fire_gem_imgList.Images.SetKeyName(12, "burning_12.png");
            this.fire_gem_imgList.Images.SetKeyName(13, "burning_13.png");
            this.fire_gem_imgList.Images.SetKeyName(14, "burning_14.png");
            this.fire_gem_imgList.Images.SetKeyName(15, "burning_15.png");
            this.fire_gem_imgList.Images.SetKeyName(16, "burning_16.png");
            this.fire_gem_imgList.Images.SetKeyName(17, "burning_17.png");
            this.fire_gem_imgList.Images.SetKeyName(18, "burning_18.png");
            this.fire_gem_imgList.Images.SetKeyName(19, "burning_19.png");
            this.fire_gem_imgList.Images.SetKeyName(20, "burning_20.png");
            this.fire_gem_imgList.Images.SetKeyName(21, "burning_21.png");
            this.fire_gem_imgList.Images.SetKeyName(22, "burning_22.png");
            this.fire_gem_imgList.Images.SetKeyName(23, "burning_23.png");
            this.fire_gem_imgList.Images.SetKeyName(24, "burning_24.png");
            this.fire_gem_imgList.Images.SetKeyName(25, "burning_25.png");
            this.fire_gem_imgList.Images.SetKeyName(26, "burning_26.png");
            this.fire_gem_imgList.Images.SetKeyName(27, "burning_27.png");
            this.fire_gem_imgList.Images.SetKeyName(28, "burning_28.png");
            this.fire_gem_imgList.Images.SetKeyName(29, "burning_29.png");
            this.fire_gem_imgList.Images.SetKeyName(30, "burning_30.png");
            this.fire_gem_imgList.Images.SetKeyName(31, "burning_31.png");
            // 
            // special_gem_imgList
            // 
            this.special_gem_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("special_gem_imgList.ImageStream")));
            this.special_gem_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.special_gem_imgList.Images.SetKeyName(0, "special_60x60_0.png");
            this.special_gem_imgList.Images.SetKeyName(1, "special_60x60_1.png");
            this.special_gem_imgList.Images.SetKeyName(2, "special_60x60_2.png");
            this.special_gem_imgList.Images.SetKeyName(3, "special_60x60_3.png");
            // 
            // timer_not_normal_gem
            // 
            this.timer_not_normal_gem.Tick += new System.EventHandler(this.timer_not_normal_gem_Tick);
            // 
            // boom_imgList
            // 
            this.boom_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("boom_imgList.ImageStream")));
            this.boom_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.boom_imgList.Images.SetKeyName(0, "boom_0.png");
            this.boom_imgList.Images.SetKeyName(1, "boom_1.png");
            this.boom_imgList.Images.SetKeyName(2, "boom_2.png");
            this.boom_imgList.Images.SetKeyName(3, "boom_3.png");
            this.boom_imgList.Images.SetKeyName(4, "boom_4.png");
            this.boom_imgList.Images.SetKeyName(5, "boom_5.png");
            this.boom_imgList.Images.SetKeyName(6, "boom_6.png");
            this.boom_imgList.Images.SetKeyName(7, "boom_7.png");
            this.boom_imgList.Images.SetKeyName(8, "boom_8.png");
            this.boom_imgList.Images.SetKeyName(9, "boom_9.png");
            this.boom_imgList.Images.SetKeyName(10, "boom_10.png");
            this.boom_imgList.Images.SetKeyName(11, "boom_11.png");
            this.boom_imgList.Images.SetKeyName(12, "boom_12.png");
            this.boom_imgList.Images.SetKeyName(13, "boom_13.png");
            this.boom_imgList.Images.SetKeyName(14, "boom_14.png");
            this.boom_imgList.Images.SetKeyName(15, "boom_15.png");
            this.boom_imgList.Images.SetKeyName(16, "boom_16.png");
            this.boom_imgList.Images.SetKeyName(17, "boom_17.png");
            // 
            // timer_boom_animation
            // 
            this.timer_boom_animation.Interval = 50;
            this.timer_boom_animation.Tick += new System.EventHandler(this.timer_boom_animation_Tick);
            // 
            // timer_sound_count
            // 
            this.timer_sound_count.Interval = 500;
            this.timer_sound_count.Tick += new System.EventHandler(this.timer_sound_count_Tick);
            // 
            // verticalElectric_gem_imgList
            // 
            this.verticalElectric_gem_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("verticalElectric_gem_imgList.ImageStream")));
            this.verticalElectric_gem_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.verticalElectric_gem_imgList.Images.SetKeyName(0, "0.png");
            this.verticalElectric_gem_imgList.Images.SetKeyName(1, "0.png");
            this.verticalElectric_gem_imgList.Images.SetKeyName(2, "0.png");
            this.verticalElectric_gem_imgList.Images.SetKeyName(3, "0.png");
            this.verticalElectric_gem_imgList.Images.SetKeyName(4, "0.png");
            this.verticalElectric_gem_imgList.Images.SetKeyName(5, "0.png");
            this.verticalElectric_gem_imgList.Images.SetKeyName(6, "0.png");
            // 
            // vertElectric_green_imgList
            // 
            this.vertElectric_green_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_green_imgList.ImageStream")));
            this.vertElectric_green_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_green_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_green_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_green_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_green_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_green_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_green_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_green_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_green_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_green_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_green_imgList.Images.SetKeyName(9, "9.png");
            // 
            // vertElectric_red_imgList
            // 
            this.vertElectric_red_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_red_imgList.ImageStream")));
            this.vertElectric_red_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_red_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_red_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_red_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_red_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_red_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_red_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_red_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_red_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_red_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_red_imgList.Images.SetKeyName(9, "9.png");
            // 
            // vertElectric_blue_imgList
            // 
            this.vertElectric_blue_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_blue_imgList.ImageStream")));
            this.vertElectric_blue_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_blue_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_blue_imgList.Images.SetKeyName(9, "9.png");
            // 
            // vertElectric_orange_imgList
            // 
            this.vertElectric_orange_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_orange_imgList.ImageStream")));
            this.vertElectric_orange_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_orange_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_orange_imgList.Images.SetKeyName(9, "9.png");
            // 
            // vertElectric_purple_imgList
            // 
            this.vertElectric_purple_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_purple_imgList.ImageStream")));
            this.vertElectric_purple_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_purple_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_purple_imgList.Images.SetKeyName(9, "9.png");
            // 
            // vertElectric_yellow_imgList
            // 
            this.vertElectric_yellow_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_yellow_imgList.ImageStream")));
            this.vertElectric_yellow_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_yellow_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_yellow_imgList.Images.SetKeyName(9, "9.png");
            // 
            // vertElectric_white_imgList
            // 
            this.vertElectric_white_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vertElectric_white_imgList.ImageStream")));
            this.vertElectric_white_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.vertElectric_white_imgList.Images.SetKeyName(0, "0.png");
            this.vertElectric_white_imgList.Images.SetKeyName(1, "1.png");
            this.vertElectric_white_imgList.Images.SetKeyName(2, "2.png");
            this.vertElectric_white_imgList.Images.SetKeyName(3, "3.png");
            this.vertElectric_white_imgList.Images.SetKeyName(4, "4.png");
            this.vertElectric_white_imgList.Images.SetKeyName(5, "5.png");
            this.vertElectric_white_imgList.Images.SetKeyName(6, "6.png");
            this.vertElectric_white_imgList.Images.SetKeyName(7, "7.png");
            this.vertElectric_white_imgList.Images.SetKeyName(8, "8.png");
            this.vertElectric_white_imgList.Images.SetKeyName(9, "9.png");
            this.vertElectric_white_imgList.Images.SetKeyName(10, "10.png");
            this.vertElectric_white_imgList.Images.SetKeyName(11, "11.png");
            this.vertElectric_white_imgList.Images.SetKeyName(12, "12.png");
            this.vertElectric_white_imgList.Images.SetKeyName(13, "13.png");
            this.vertElectric_white_imgList.Images.SetKeyName(14, "14.png");
            this.vertElectric_white_imgList.Images.SetKeyName(15, "15.png");
            this.vertElectric_white_imgList.Images.SetKeyName(16, "16.png");
            this.vertElectric_white_imgList.Images.SetKeyName(17, "17.png");
            this.vertElectric_white_imgList.Images.SetKeyName(18, "18.png");
            this.vertElectric_white_imgList.Images.SetKeyName(19, "19.png");
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WinformTest.Properties.Resources.bonus_time_50x75;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(702, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 75);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WinformTest.Properties.Resources.flash_50x75;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(637, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 75);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WinformTest.Properties.Resources.harmer_75x75;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(546, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_back_picBox
            // 
            this.but_back_picBox.BackColor = System.Drawing.Color.Transparent;
            this.but_back_picBox.BackgroundImage = global::WinformTest.Properties.Resources.but_back_75x75;
            this.but_back_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_back_picBox.Location = new System.Drawing.Point(10, 10);
            this.but_back_picBox.Name = "but_back_picBox";
            this.but_back_picBox.Size = new System.Drawing.Size(75, 75);
            this.but_back_picBox.TabIndex = 6;
            this.but_back_picBox.TabStop = false;
            this.but_back_picBox.UseWaitCursor = true;
            this.but_back_picBox.Click += new System.EventHandler(this.but_back_picBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinformTest.Properties.Resources.coin_40x40;
            this.pictureBox1.Location = new System.Drawing.Point(85, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // life_count_picBox
            // 
            this.life_count_picBox.BackColor = System.Drawing.Color.Transparent;
            this.life_count_picBox.BackgroundImage = global::WinformTest.Properties.Resources.heart_40x40;
            this.life_count_picBox.Location = new System.Drawing.Point(85, 10);
            this.life_count_picBox.Name = "life_count_picBox";
            this.life_count_picBox.Size = new System.Drawing.Size(40, 40);
            this.life_count_picBox.TabIndex = 6;
            this.life_count_picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::WinformTest.Properties.Resources.grid_diamond_container_400x400;
            this.label1.Location = new System.Drawing.Point(144, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 400);
            this.label1.TabIndex = 0;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // horizElectric_gem_imgList
            // 
            this.horizElectric_gem_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_gem_imgList.ImageStream")));
            this.horizElectric_gem_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_gem_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_gem_imgList.Images.SetKeyName(1, "0.png");
            this.horizElectric_gem_imgList.Images.SetKeyName(2, "0.png");
            this.horizElectric_gem_imgList.Images.SetKeyName(3, "0.png");
            this.horizElectric_gem_imgList.Images.SetKeyName(4, "0.png");
            this.horizElectric_gem_imgList.Images.SetKeyName(5, "0.png");
            this.horizElectric_gem_imgList.Images.SetKeyName(6, "0.png");
            // 
            // horizElectric_green_imgList
            // 
            this.horizElectric_green_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_green_imgList.ImageStream")));
            this.horizElectric_green_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_green_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_green_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_green_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_green_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_green_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_green_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_green_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_green_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_green_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_green_imgList.Images.SetKeyName(9, "9.png");
            // 
            // horizElectric_red_imgList
            // 
            this.horizElectric_red_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_red_imgList.ImageStream")));
            this.horizElectric_red_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_red_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_red_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_red_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_red_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_red_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_red_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_red_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_red_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_red_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_red_imgList.Images.SetKeyName(9, "9.png");
            // 
            // horizElectric_blue_imgList
            // 
            this.horizElectric_blue_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_blue_imgList.ImageStream")));
            this.horizElectric_blue_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_blue_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_blue_imgList.Images.SetKeyName(9, "9.png");
            // 
            // horizElectric_orange_imgList
            // 
            this.horizElectric_orange_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_orange_imgList.ImageStream")));
            this.horizElectric_orange_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_orange_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_orange_imgList.Images.SetKeyName(9, "9.png");
            // 
            // horizElectric_purple_imgList
            // 
            this.horizElectric_purple_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_purple_imgList.ImageStream")));
            this.horizElectric_purple_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_purple_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_purple_imgList.Images.SetKeyName(9, "9.png");
            // 
            // horizElectric_yellow_imgList
            // 
            this.horizElectric_yellow_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_yellow_imgList.ImageStream")));
            this.horizElectric_yellow_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_yellow_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_yellow_imgList.Images.SetKeyName(9, "9.png");
            // 
            // horizElectric_white_imgList
            // 
            this.horizElectric_white_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("horizElectric_white_imgList.ImageStream")));
            this.horizElectric_white_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.horizElectric_white_imgList.Images.SetKeyName(0, "0.png");
            this.horizElectric_white_imgList.Images.SetKeyName(1, "1.png");
            this.horizElectric_white_imgList.Images.SetKeyName(2, "2.png");
            this.horizElectric_white_imgList.Images.SetKeyName(3, "3.png");
            this.horizElectric_white_imgList.Images.SetKeyName(4, "4.png");
            this.horizElectric_white_imgList.Images.SetKeyName(5, "5.png");
            this.horizElectric_white_imgList.Images.SetKeyName(6, "6.png");
            this.horizElectric_white_imgList.Images.SetKeyName(7, "7.png");
            this.horizElectric_white_imgList.Images.SetKeyName(8, "8.png");
            this.horizElectric_white_imgList.Images.SetKeyName(9, "9.png");
            this.horizElectric_white_imgList.Images.SetKeyName(10, "10.png");
            this.horizElectric_white_imgList.Images.SetKeyName(11, "11.png");
            this.horizElectric_white_imgList.Images.SetKeyName(12, "12.png");
            this.horizElectric_white_imgList.Images.SetKeyName(13, "13.png");
            this.horizElectric_white_imgList.Images.SetKeyName(14, "14.png");
            this.horizElectric_white_imgList.Images.SetKeyName(15, "15.png");
            this.horizElectric_white_imgList.Images.SetKeyName(16, "16.png");
            this.horizElectric_white_imgList.Images.SetKeyName(17, "17.png");
            this.horizElectric_white_imgList.Images.SetKeyName(18, "18.png");
            this.horizElectric_white_imgList.Images.SetKeyName(19, "19.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.ControlBox = false;
            this.Controls.Add(this.sandClock_count_lab);
            this.Controls.Add(this.flash_count_lab);
            this.Controls.Add(this.harmmer_count_lab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_back_picBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.life_count_picBox);
            this.Controls.Add(this.gold_count_lab);
            this.Controls.Add(this.life_count_lab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 640);
            this.MinimumSize = new System.Drawing.Size(780, 640);
            this.Name = "Form1";
            this.Text = "Diamond Crush";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.but_back_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_count_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList sprite_ImageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_selectedSpriteAnimation;
        private System.Windows.Forms.ImageList green_Selected;
        private System.Windows.Forms.ImageList red_Selected;
        private System.Windows.Forms.ImageList blue_Selected;
        private System.Windows.Forms.ImageList orange_Selected;
        private System.Windows.Forms.ImageList purple_Selected;
        private System.Windows.Forms.ImageList yellow_Selected;
        private System.Windows.Forms.ImageList white_Selected;
        private System.Windows.Forms.Timer timer_GoSwap;
        private System.Windows.Forms.Timer timer_SwapBack;
        private System.Windows.Forms.Timer timer_Explode;
        private System.Windows.Forms.ImageList greenExplode_imgList;
        private System.Windows.Forms.ImageList redExplode_imgList;
        private System.Windows.Forms.ImageList blueExplode_imgList;
        private System.Windows.Forms.ImageList orangeExplode_imgList;
        private System.Windows.Forms.ImageList purpleExplode_imgList;
        private System.Windows.Forms.ImageList yellowExplode_imgList;
        private System.Windows.Forms.ImageList whiteExplode_imgList;
        private System.Windows.Forms.Timer timer_updateScreen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer_scoreCount;
        private System.Windows.Forms.Timer timer_gameTimeLimit;
        private System.Windows.Forms.ImageList butt_imgList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label life_count_lab;
        private System.Windows.Forms.Label gold_count_lab;
        private System.Windows.Forms.PictureBox life_count_picBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox but_back_picBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label harmmer_count_lab;
        private System.Windows.Forms.Label flash_count_lab;
        private System.Windows.Forms.Label sandClock_count_lab;
        private System.Windows.Forms.Timer timer_using_item_animation;
        private System.Windows.Forms.ImageList fire_gem_imgList;
        private System.Windows.Forms.ImageList special_gem_imgList;
        private System.Windows.Forms.Timer timer_not_normal_gem;
        private System.Windows.Forms.ImageList boom_imgList;
        private System.Windows.Forms.Timer timer_boom_animation;
        private System.Windows.Forms.Timer timer_sound_count;
        private System.Windows.Forms.ImageList verticalElectric_gem_imgList;
        private System.Windows.Forms.ImageList vertElectric_green_imgList;
        private System.Windows.Forms.ImageList vertElectric_red_imgList;
        private System.Windows.Forms.ImageList vertElectric_blue_imgList;
        private System.Windows.Forms.ImageList vertElectric_orange_imgList;
        private System.Windows.Forms.ImageList vertElectric_purple_imgList;
        private System.Windows.Forms.ImageList vertElectric_yellow_imgList;
        private System.Windows.Forms.ImageList vertElectric_white_imgList;
        private System.Windows.Forms.ImageList horizElectric_gem_imgList;
        private System.Windows.Forms.ImageList horizElectric_green_imgList;
        private System.Windows.Forms.ImageList horizElectric_red_imgList;
        private System.Windows.Forms.ImageList horizElectric_blue_imgList;
        private System.Windows.Forms.ImageList horizElectric_orange_imgList;
        private System.Windows.Forms.ImageList horizElectric_purple_imgList;
        private System.Windows.Forms.ImageList horizElectric_yellow_imgList;
        private System.Windows.Forms.ImageList horizElectric_white_imgList;
    }
}

