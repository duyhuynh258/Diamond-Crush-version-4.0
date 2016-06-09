
using ClassLibrary1;
using Diamond_Crush;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformTest.Properties;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        private int _specialGemFrame = 0;
        private bool _isBooming = false;
        private int _fireGemFrame = 0;
        private int _boomAnimationFrame = 0;
        private uint[] _targetScore;
        private bool _isHarmmerChosen, _isFlashChosen, _isSandClockChosen;
        public static uint _score = 0;
        private uint _scoreInOneMove = 0;
        private uint _explodeWave = 0;
        private uint _normalGemFrameIndex = 0;
        private uint _whiteGemFrameIndex = 0;
        private uint _explodeGemFrameIndex = 0;
        private CGemBase[,] _gem;
        private List<CGemBase> _proccessingGem;
        private List<CGemBase>[] _explodeGemList;
        private List<CGemBase> _updatedGemList;
        private bool[] _colToCheckExplode;
        private bool _isMouseClickListening;
        private bool _isExploding = false;
        private int _swapSpeed;
        private SwapInfo _lastSwapInfo;
        private SoundPlayer[] _crushSound;
        private SoundPlayer _finalCrushSound;
        private SoundPlayer _thunderSound;
        private SoundPlayer _victorySound;
        private SoundPlayer _gameOverSound;
        private SoundPlayer _clockSound;
        private SoundPlayer _boomSound;
        private SoundPlayer _specilaGemExplodeSound;
        private SoundPlayer _lightningSound;
        private CImageBase _butBack;
        private CImageBase _lifeCount;
        private CImageBase _goldCount;
        private CImageBase[] _vertLightning;
        private CImageBase[] _horizLightning;
        private int _explodeGroupCount = 0;
        private bool _isSpecialGemExplode = false;
        private bool _isFlashExplode = false;
        private bool []_isVertElectricExplode;
        private bool []_isHorzElectricExplode;
        private enum SwapInfo
        {
            RightSwap,
            LeftSwap,
            UpSwap,
            DownSwap,
            NullSwap
        }
        private enum ExplodeType
        {
            NotExplode,
            AllLeft,
            AllRight,
            AllAbove,
            AllBelow,
            Balance,
            NullType,
            BigBalance,
            ThreeLeft,
            ThreeRight,
            TwoLeftOneRight,
            TwoRightOneLeft,
            ThreeAbove,
            ThreeBelow,
            TwoAboveOneBelow,
            TwoBelowOneAbove,
            TMatch, 
            LeftTMatch,
            RightTMatch,
            UpSideDownTMatch
        }
        private CImageBase _harmmer, _flash, _sandClock;
        public Form1(uint lvID)
        {
            InitializeComponent();
            _updatedGemList = new List<CGemBase>();
            this.Text = "Diamond Crush level " + (lvID+1).ToString();
            life_count_lab.Text = CUser.Instance()._lifeCount.ToString();
            gold_count_lab.Text = CUser.Instance()._goldCount.ToString();
            _isHarmmerChosen = false;
            _isFlashChosen = false;
            _isSandClockChosen = false;
            _lifeCount = new CImageBase(Resources.heart_40x40) { Left = 80, Top = 10 };
            _goldCount = new CImageBase(Resources.coin_40x40) { Left = 80, Top = 50 };
            _explodeGemList = new List<CGemBase>[8];
            _targetScore = new uint[9];
            _victorySound = new SoundPlayer(Resources.Final_Fantasy_VII___Victory_Fanfare);
            _clockSound = new SoundPlayer(Resources.clock);
            _crushSound = new SoundPlayer[5];
            _gameOverSound = new SoundPlayer(Resources.smb_gameover);
            _boomSound = new SoundPlayer(Resources.explode);
            _thunderSound = new SoundPlayer(Resources.Thunder);
            _lightningSound = new SoundPlayer(Resources.Electric_Arcs);
            _finalCrushSound = new SoundPlayer(Resources.Sword_Swipe_And_Klang_02);
            _specilaGemExplodeSound = new SoundPlayer(Resources.Space_Gun_07);
            _crushSound[0] = new SoundPlayer(Resources.Sword_Movement_Single_01);
            _crushSound[1] = new SoundPlayer(Resources.Sword_Movement_Single_02);
            _crushSound[2] = new SoundPlayer(Resources.Sword_Movement_Single_03);
            _crushSound[3] = new SoundPlayer(Resources.Sword_Movement_Single_04);
            _crushSound[4] = new SoundPlayer(Resources.Sword_Movement_Single_05);
            _proccessingGem = new List<CGemBase>();
            _butBack = new CImageBase(Resources.but_back_75x75) { Left = 10, Top = 10 };
            _harmmer = new CImageBase(Resources.harmer_75x75);
            _flash = new CImageBase(Resources.flash_50x75);
            _vertLightning = new CImageBase[6];
            _horizLightning = new CImageBase[6];
            _vertLightning[0] = new CImageBase(Resources.vert_Lightning_0);
            _vertLightning[1] = new CImageBase(Resources.vert_Lightning_1);
            _vertLightning[2] = new CImageBase(Resources.vert_Lightning_2);
            _vertLightning[3] = new CImageBase(Resources.vert_Lightning_3);
            _vertLightning[4] = new CImageBase(Resources.vert_Lightning_4);
            _vertLightning[5] = new CImageBase(Resources.vert_Lightning_5);
            _horizLightning[0] = new CImageBase(Resources.horiz_lightning_0);
            _horizLightning[1] = new CImageBase(Resources.horiz_lightning_1);
            _horizLightning[2] = new CImageBase(Resources.horiz_lightning_2);
            _horizLightning[3] = new CImageBase(Resources.horiz_lightning_3);
            _horizLightning[4] = new CImageBase(Resources.horiz_lightning_4);
            _horizLightning[5] = new CImageBase(Resources.horiz_lightning_5);
            _sandClock = new CImageBase(Resources.bonus_time_50x75);
            for (uint i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0:
                        _targetScore[i] = 40000;

                        break;
                    case 1:
                        _targetScore[i] = 30000;
                        break;
                    case 2:
                        _targetScore[i] = 12000;
                        break;
                    case 3:
                        _targetScore[i] = 5000;
                        break;
                    case 4:
                        _targetScore[i] = 9000;
                        break;
                    case 5:
                        _targetScore[i] = 12000;
                        break;
                    case 6:
                        _targetScore[i] = 15000;
                        break;
                    case 7:
                        _targetScore[i] = 18000;
                        break;
                    case 8:
                        _targetScore[i] = 20000;
                        break;
                }
            }
            this.label3.Text += "    "+_targetScore[lvID].ToString();
            this.label4.Text += "    " + CUser.Instance().GetLevel((int)lvID)._highestScore;
            AutoSetItemCount();
            _colToCheckExplode = new bool[8];
            _isVertElectricExplode = new bool[8];
            _isHorzElectricExplode = new bool[8];
            for(int i = 0; i < 8; i++)
            {
                _isVertElectricExplode[i] = false;
                _isHorzElectricExplode[i] = false;
                _colToCheckExplode[i] = false;
                _explodeGemList[i] = new List<CGemBase>();

            }
            CGemBase._elementSelectedExist = false;
            _isMouseClickListening = true;
            _swapSpeed = 0;
            _gem = new CGemBase[8, 8];
            for (uint i = 0; i < 8; i++)
                for (uint j = 0; j < 8; j++)
                {
                    _gem[i, j] = new CGemBase(SetLocationFromOriginal(i, j), i, j, (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100)%(lvID + 4 > 7 ? 7 : lvID + 4));
                }
            foreach(var gem in _gem)
            {
                while (IsRowMatch(gem)!= ExplodeType.NotExplode || IsColunmMatch(gem)!= ExplodeType.NotExplode)
                {
                    gem._gemType = (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100) %(lvID+4>7?7:lvID+4);
                }
            }
        }
        private void AutoSetItemCount()
        {
            this.harmmer_count_lab.Text = CUser.Instance()._harmmerCount.ToString() + " left";
            this.flash_count_lab.Text = CUser.Instance()._flashCount.ToString() + " left";
            this.sandClock_count_lab.Text = CUser.Instance()._sandClockCount.ToString() + " left";
        }
        public Form1()
        {
            InitializeComponent();
            _explodeGemList = new List<CGemBase>[8];
            _colToCheckExplode = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                _colToCheckExplode[i] = false;
                _explodeGemList[i] = new List<CGemBase>();

            }
            CGemBase._elementSelectedExist = false;
            _isMouseClickListening = true;
            _swapSpeed = 0;
            _gem = new CGemBase[8, 8];
            for (uint i = 0; i < 8; i++)
                for (uint j = 0; j < 8; j++)
                {
                    _gem[i, j] = new CGemBase(SetLocationFromOriginal(i, j), i, j, (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100));
                }
            foreach (var gem in _gem)
            {
                while (IsRowMatch(gem) != ExplodeType.NotExplode || IsColunmMatch(gem) != ExplodeType.NotExplode)
                {
                    gem._gemType = (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100) % 7;
                }
            }
        }
        Point SetLocationFromOriginal(uint row, uint col)
        {
            uint modRow = row % 8;
            uint modCol = col % 8;
            int x = label1.Location.X;
            int y = label1.Location.Y;
            x = x + (int)modCol * 50;
            y = y + (int)modRow * 50;
            return new Point(x, y);
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Draw_64_Gem(g, e);
            TextFormatFlags flag = TextFormatFlags.HorizontalCenter;
            Font font = new Font("Arial", 14, FontStyle.Regular);
            TextRenderer.DrawText(g, ""+_score.ToString(), font
                , new Rectangle(this.label2.Location.X+this.label2.Width, this.label2.Location.Y, 100, 20), SystemColors.ControlText, flag);
            DrawUsingItemAnimation(g);
            base.OnPaint(e);
        }
        private void Draw_64_Gem(Graphics g, PaintEventArgs e)
        {
            for (uint i = 0; i < 8; i++)
                for (uint j = 0; j < 8; j++)
                {
                    if (_gem[i, j]._isSpecialGem == true)
                    {
                        special_gem_imgList.Draw(g, _gem[i, j]._location.X - 5, _gem[i, j]._location.Y - 5, _specialGemFrame);
                    }
                   
                    if (CGemBase._elementSelectedExist == true && CGemBase._elementSelected._row == i && CGemBase._elementSelected._column == j)
                    {
                        var SelectedEle = new CGemBase(CGemBase._elementSelected);
                        sprite_ImageList.Draw(g, SelectedEle._location, 7);
                        DrawSelectedAnimation(g, SelectedEle);
                    }
                    else if (ExplodeGemIndexSearch(_explodeGemList[j], i, j) && _isExploding == true)
                    {
                        if (_explodeGemFrameIndex < 6)
                        {
                            if (_isSpecialGemExplode == true)
                            {
                                special_gem_imgList.Draw(g, _gem[i, j]._location, _specialGemFrame);
                            }
                            DrawExplodeGem(g, _gem[i, j]);
                            if (_isFlashExplode == true)
                            {
                                var flash = new CImageBase(Resources.flash_50x75) { Left= _gem[i,j]._location.X,Top= _gem[i,j]._location.Y-12};
                                flash.DrawSprite(g);
                            }
                            if (_isVertElectricExplode[j] == true)
                            {
                                DrawVertLightningAnimation(g, (int)_explodeGemFrameIndex, _gem[0, j]._location);
                            }
                            if (_isHorzElectricExplode[i] == true)
                            {
                                DrawHorizLightningAnimation(g, (int)_explodeGemFrameIndex, _gem[i, 0]._location);
                            }
                        }
                        else
                        {
                            
                            boom_imgList.Draw(g, _gem[i, j]._location, _boomAnimationFrame);
                            if (_isVertElectricExplode[j] == true)
                            {
                                DrawVertLightningAnimation(g, (int)_explodeGemFrameIndex % 6, _gem[0, j]._location);
                            }
                            if (_isHorzElectricExplode[i] == true)
                            {
                                DrawHorizLightningAnimation(g, (int)_explodeGemFrameIndex % 6, _gem[i, 0]._location);
                            }
                        }
                    }
                    else if (_gem[i, j]._isVerticalElectric == true)
                    {
                        verticalElectric_gem_imgList.Draw(g, _gem[i, j]._location.X, _gem[i, j]._location.Y, (int)_gem[i, j]._gemType);
                    }
                    else if (_gem[i, j]._isHorizontalElectric == true)
                    {
                        horizElectric_gem_imgList.Draw(g, _gem[i, j]._location.X, _gem[i, j]._location.Y, (int)_gem[i, j]._gemType);
                    }
                    else
                    {
                        sprite_ImageList.Draw(g, _gem[i, j]._location.X, _gem[i, j]._location.Y, (int)_gem[i, j]._gemType);
                    }
                    if (_gem[i, j]._isFireGem == true&&_isBooming==false)
                    {
                        fire_gem_imgList.Draw(g, _gem[i, j]._location, _fireGemFrame);
                    }
                }
        }
        private void DrawSelectedAnimation(Graphics g, CGemBase selectedGem)
        {
            switch (selectedGem._gemType)
            {
                case 0:
                    if (selectedGem._isVerticalElectric==true)
                    {
                        vertElectric_green_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_green_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else green_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    break;
                case 1:
                    if (selectedGem._isVerticalElectric == true)
                    {
                        vertElectric_red_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_red_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else
                        red_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    break;
                case 2:
                    if (selectedGem._isVerticalElectric == true)
                    {
                        vertElectric_blue_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_blue_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else
                        blue_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    break;
                case 3:
                    if (selectedGem._isVerticalElectric == true)
                    {
                        vertElectric_orange_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_orange_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else
                        orange_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    break;
                case 4:
                    if (selectedGem._isVerticalElectric == true)
                    {
                        vertElectric_purple_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_purple_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else
                        purple_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    break;
                case 5:
                    if (selectedGem._isVerticalElectric == true)
                    {
                        vertElectric_yellow_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_yellow_imgList.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    }
                    else
                        yellow_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex);
                    break;
                case 6:
                    if (selectedGem._isVerticalElectric == true)
                    {
                        vertElectric_white_imgList.Draw(g, selectedGem._location, (int)_whiteGemFrameIndex);
                    }
                    else if (selectedGem._isHorizontalElectric == true)
                    {
                        horizElectric_green_imgList.Draw(g, selectedGem._location, (int)_whiteGemFrameIndex);
                    }
                    else
                        white_Selected.Draw(g, selectedGem._location, (int)_whiteGemFrameIndex);
                    break;
            }
        }
        private void DrawExplodeGem(Graphics g, CGemBase ExplodeGem)
        {
            switch (ExplodeGem._gemType)
            {
                case 0: greenExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 1:
                    redExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 2:
                    blueExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 3:
                    orangeExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 4:
                    purpleExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 5:
                    yellowExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 6:
                    whiteExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
            }
            
        }
        private void DrawUsingItemAnimation(Graphics g)
        {
            if (_isHarmmerChosen == true)
            {
                _harmmer.Left = _curMouseLocation.X-37;
                _harmmer.Top = _curMouseLocation.Y-37;
                _harmmer.DrawSprite(g);
            } else if (_isFlashChosen == true)
            {
                _flash.Left = _curMouseLocation.X-25;
                _flash.Top = _curMouseLocation.Y-37;
                _flash.DrawSprite(g);
            } else if (_isSandClockChosen == true)
            {
                _sandClock.Left = _curMouseLocation.X-25;
                _sandClock.Top = _curMouseLocation.Y-37;
                _sandClock.DrawSprite(g);
            }
        }
        private void DrawVertLightningAnimation(Graphics g, int frame,Point location)
        {
            for(int i = 0; i < 6; i++)
            {
                _vertLightning[i].Left = location.X;
                _vertLightning[i].Top = location.Y;
            }
            _vertLightning[frame].DrawSprite(g);
        }
        private void DrawHorizLightningAnimation(Graphics g, int frame, Point location)
        {
            for (int i = 0; i < 6; i++)
            {
                _horizLightning[i].Left = location.X;
                _horizLightning[i].Top = location.Y;
            }
            _horizLightning[frame].DrawSprite(g);
        }
        private bool ExplodeGemIndexSearch(List<CGemBase> explodeGemList, uint row,uint col)
        {
            foreach(var gem in explodeGemList)
            {
                if (gem._row == row && gem._column == col) return true;
            }
            return false;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            _isFlashChosen = false;
            _isHarmmerChosen = false;
        }
        private CGemBase GetGemByLocation(int x, int y)
        {
            return _gem[y / 50, x / 50];
        }

        private void timer_selectedSpriteAnimation_Tick(object sender, EventArgs e)
        {
            if (CGemBase._elementSelectedExist == true)
            {
                if(CGemBase._elementSelected._gemType!=6)
                {
                    _normalGemFrameIndex++;
                    if (_normalGemFrameIndex / 10 == 1) _normalGemFrameIndex = 0;
                }
                else
                {
                    _whiteGemFrameIndex++;
                    if (_whiteGemFrameIndex / 20 == 1) _whiteGemFrameIndex = 0;
                }
                Invalidate();
            }
            _specialGemFrame++;
            if (_specialGemFrame / 4 == 1)
            {
                _specialGemFrame = 0;
            }
            _fireGemFrame++;
            if (_fireGemFrame / 32 == 1)
            {
                _fireGemFrame = 0;
            }
            Invalidate();
        }


        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isMouseClickListening == true)
            {
                _isMouseClickListening = false;
                var currGem = new CGemBase(GetGemByLocation(e.X, e.Y));
                if (_isHarmmerChosen == true)
                {
                    var gem = GetGemByLocation(e.X, e.Y);
                    AddExplodeGem( gem);
                    _isHarmmerChosen = false;
                    CUser.Instance()._harmmerCount--;
                    CUser.UpdateOfflineItemCount();
                    timer_using_item_animation.Stop();
                    AutoSetItemCount();
                    _isExploding = true;
                    _explodeWave++;
                    timer_Explode.Start();
                }
                else if (_isFlashChosen == true)
                {
                    _isFlashExplode = true;
                    _thunderSound.Play();
                    timer_sound_count.Start();
                    _monoSound = true;
                    var gem = GetGemByLocation(e.X, e.Y);
                    for(int i=0;i<8;i++)
                    {
                        for(int j = 0; j < 8; j++)
                        {
                            if (_gem[i, j]._gemType == gem._gemType)
                            {
                                AddExplodeGem (_gem[i, j]);
                            }
                        }
                    }
                    _isFlashChosen = false;
                    CUser.Instance()._flashCount--;
                    CUser.UpdateOfflineItemCount();
                    AutoSetItemCount();
                    timer_using_item_animation.Stop();
                    _isExploding = true;
                    _explodeWave++;
                    timer_Explode.Start();
                }
                else if (CGemBase._elementSelectedExist == true)
                {
                    var selectedGem = new CGemBase(CGemBase._elementSelected);
                    if (GetGemByLocation(e.X, e.Y).IsSwapable(CGemBase._elementSelected) == false)
                    {
                        CGemBase._elementSelected = GetGemByLocation(e.X, e.Y);
                        _isMouseClickListening = true;
                    }
                    else if (GetGemByLocation(e.X, e.Y).IsSwapable(CGemBase._elementSelected) == true)
                    {
                        // Selected Gem's location is added first.
                        _proccessingGem = new List<CGemBase>();
                        _proccessingGem.Add(selectedGem);
                        _proccessingGem.Add(currGem);
                        CGemBase._elementSelectedExist = false;
                        timer_GoSwap.Start();
                    }
                }
                else if (CGemBase._elementSelectedExist == false)
                {
                    CGemBase._elementSelected = GetGemByLocation(e.X, e.Y);
                    CGemBase._elementSelectedExist = true;
                    //timer_selectedSpriteAnimation.Start();
                    _isMouseClickListening = true;
                }
            }

        }


        private void timer_swappingGem_Tick(object sender, EventArgs e)
        {
            _swapSpeed += 5;
            if (GoSwap(_swapSpeed))
            {
                uint gem0Col = _proccessingGem[0]._column;
                uint gem0Row = _proccessingGem[0]._row;
                uint gem1Row = _proccessingGem[1]._row;
                uint gem1Col = _proccessingGem[1]._column;

                SwapExceptLocation(_gem[gem0Row, gem0Col],_gem[gem1Row, gem1Col]);
                if((_gem[gem0Row,gem0Col]._isSpecialGem==true && _gem[gem1Row, gem1Col]._isSpecialGem==false)
                    || (_gem[gem0Row, gem0Col]._isSpecialGem == false && _gem[gem1Row, gem1Col]._isSpecialGem == true))
                {
                    _isSpecialGemExplode = true;
                    _isExploding = true;
                    for(int k = 0; k < 2; k++)
                    {
                        if (_gem[_proccessingGem[k]._row, _proccessingGem[k]._column]._isSpecialGem == true)
                        {
                            if(_gem[_proccessingGem[1-k]._row, _proccessingGem[1 - k]._column]._isFireGem)
                            {
                                _isBooming = true;
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 8; j++)
                                    {
                                        if (_gem[i, j]._gemType
                                            == _gem[_proccessingGem[1 - k]._row, _proccessingGem[1 - k]._column]._gemType)
                                        {
                                            _gem[i, j]._isFireGem = true;
                                        }
                                    }
                                }
                            }
                            else if(_gem[_proccessingGem[1 - k]._row, _proccessingGem[1 - k]._column]._isVerticalElectric)
                            {
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 8; j++)
                                    {
                                        if (_gem[i, j]._gemType
                                            == _gem[_proccessingGem[1 - k]._row, _proccessingGem[1 - k]._column]._gemType)
                                        {
                                            _gem[i, j]._isVerticalElectric = true;
                                        }
                                    }
                                }
                            }
                            else if (_gem[_proccessingGem[1 - k]._row, _proccessingGem[1 - k]._column]._isHorizontalElectric)
                            {
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 8; j++)
                                    {
                                        if (_gem[i, j]._gemType
                                            == _gem[_proccessingGem[1 - k]._row, _proccessingGem[1 - k]._column]._gemType)
                                        {
                                            _gem[i, j]._isHorizontalElectric = true;
                                        }
                                    }
                                }
                            }
                            for (int i = 0; i < 8; i++)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (_gem[i, j]._gemType 
                                        == _gem[_proccessingGem[1 - k]._row, _proccessingGem[1 - k]._column]._gemType)
                                    {
                                        AddExplodeGem(_gem[i, j]);
                                    }
                                }
                            }
                            _gem[_proccessingGem[k]._row, _proccessingGem[k]._column]._isSpecialGem = false;
                        }

                    }
                }
                else if(_gem[gem0Row, gem0Col]._isSpecialGem && _gem[gem1Row, gem1Col]._isSpecialGem)
                {
                    _isExploding = true;
                    _isSpecialGemExplode = true;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            AddExplodeGem(_gem[i, j]);
                        }
                    }
                }
                else if((_gem[gem0Row,gem0Col]._isVerticalElectric|| _gem[gem0Row, gem0Col]._isHorizontalElectric)
                    && (_gem[gem1Row,gem1Col]._isVerticalElectric|| _gem[gem1Row, gem1Col]._isHorizontalElectric))
                {
                    _isVertElectricExplode[gem1Col] = true;
                    _isHorzElectricExplode[gem1Row] = true;
                    _isExploding = true;
                    for(int i = 0; i < 8; i++)
                    {
                        AddExplodeGem(_gem[i, gem1Col]);
                        AddExplodeGem(_gem[gem1Row, i]);
                    }
                }
                else if(((_gem[gem0Row, gem0Col]._isVerticalElectric || _gem[gem0Row, gem0Col]._isHorizontalElectric) && _gem[gem1Row, gem1Col]._isFireGem)
                    ||(_gem[gem0Row, gem0Col] ._isFireGem && (_gem[gem1Row, gem1Col]._isVerticalElectric || _gem[gem1Row, gem1Col]._isHorizontalElectric)))
                {
                    _isBooming = true;
                    _isExploding = true;
                    
                    var g = _gem[gem1Row,gem1Col];
                    var mMin = (g._row == 0 ? 0 : (g._row - 1));
                    var mMax = (g._row == 7 ? 7 : (g._row + 1));
                    var nMin = (g._column == 0 ? 0 : (g._column - 1));
                    var nMax = (g._column == 7 ? 7 : (g._column + 1));
                    for(uint m= mMin;m<= mMax; m++)
                    {
                        for(int i = 0; i < 8; i++)
                        {
                            AddExplodeGem(_gem[m, i]);
                        }
                        _isVertElectricExplode[m] = true;
                    }
                    for (uint n = nMin; n <= nMax; n++)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            AddExplodeGem(_gem[i,n]);
                        }
                        _isHorzElectricExplode[n] = true;
                    }
                }
                else if(_gem[gem1Row, gem1Col]._isFireGem&& _gem[gem0Row, gem0Col]._isFireGem)
                {
                    _isBooming = true;
                    _isExploding = true;

                    var g = _gem[gem1Row, gem1Col];
                    var mMin = (g._row == 0 ? 0 : (g._row - 1));
                    var mMax = (g._row == 7 ? 7 : (g._row + 1));
                    var nMin = (g._column == 0 ? 0 : (g._column - 1));
                    var nMax = (g._column == 7 ? 7 : (g._column + 1));
                    for (uint m = mMin; m <= mMax; m++)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            AddExplodeGem(_gem[m, i]);
                        }
                    }
                    for (uint n = nMin; n <= nMax; n++)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            AddExplodeGem(_gem[i, n]);
                        }
                    }
                }
                else
                {
                    CheckExplode(gem1Row, gem1Col);
                    CheckExplode(gem0Row, gem0Col);
                }
                
                if (_isExploding == true)
                {
                    _explodeWave++;
                    timer_Explode.Start();
                    CGemBase._elementSelectedExist = false;
                   // timer_selectedSpriteAnimation.Stop();
                    //consider mouseClick=true;
                }else if (_isExploding == false)
                {
                    SwapExceptLocation(_gem[gem0Row, gem0Col],_gem[gem1Row, gem1Col]);
                    timer_SwapBack.Start();
                }
                timer_GoSwap.Stop();

            }
            Invalidate();
        }
        private void SwapExceptLocation(CGemBase gem1, CGemBase gem2)
        {
            var gem3 = new CGemBase(gem2);
            gem2._gemType = gem1._gemType;
            gem2._location = gem1._location;
            gem2._isSpecialGem = gem1._isSpecialGem;
            gem2._isFireGem = gem1._isFireGem;
            gem2._isVerticalElectric = gem1._isVerticalElectric;
            gem2._isHorizontalElectric = gem1._isHorizontalElectric;
            gem1._gemType = gem3._gemType;
            gem1._location = gem3._location;
            gem1._isSpecialGem = gem3._isSpecialGem;
            gem1._isFireGem = gem3._isFireGem;
            gem1._isVerticalElectric = gem3._isVerticalElectric;
            gem1._isHorizontalElectric = gem3._isHorizontalElectric;
        }
        private void CheckExplode(uint row, uint col)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < _explodeGemList[i].Count; j++)
                {
                    if (_explodeGemList[i][j]._row==row&& i == col) return;
                }
            }
            CheckRowMatchType(_gem[row, col]);
        }
        private void CheckRowMatchType(CGemBase gem)
        {
            var row = gem._row;
            var col = gem._column;
            _explodeGroupCount=1;
            switch (IsRowMatch(_gem[row, col]))
            {

                case ExplodeType.AllLeft:
                    {
                        
                        AddExplodeGem(_gem[row, col - 2]);
                        AddExplodeGem(_gem[row, col - 1]);
                        _isExploding = true;
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            AddExplodeGem(_gem[row, col]);
                        }
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                                _gem[row, col]._isFireGem = true;
                        }
                        break;
                    }
                case ExplodeType.AllRight:
                    {
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            AddExplodeGem(_gem[row, col]);
                        } 
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                                _gem[row, col]._isFireGem = true;
                        }
                        AddExplodeGem( _gem[row, col + 1]);
                        AddExplodeGem(_gem[row, col + 2]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.Balance:
                    {
                        
                        AddExplodeGem(_gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            AddExplodeGem(_gem[row, col]);
                        }
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                                _gem[row, col]._isFireGem = true;
                        }
                        AddExplodeGem(_gem[row, col + 1]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.BigBalance:
                    {
                        _explodeGroupCount--;
                        AddExplodeGem( _gem[row, col - 2]);
                        AddExplodeGem( _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        //AddExplodeGem( _gem[row, col]);
                        AddExplodeGem(_gem[row, col + 1]);
                        AddExplodeGem( _gem[row, col + 2]);
                        _isExploding = true;
                        _gem[row, col]._isSpecialGem = true;
                        break;
                    }
                case ExplodeType.ThreeLeft:
                    {
                        AddExplodeGem(_gem[row, col - 3]);
                        AddExplodeGem(_gem[row, col - 2]);
                        AddExplodeGem( _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[row, col]._isVerticalElectric = true;
                        }
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                            _gem[row, col]._isFireGem = true;
                        }
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeRight:
                    {
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[row, col]._isVerticalElectric = true;
                        }
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                                _gem[row, col]._isFireGem = true;
                        }
                        AddExplodeGem( _gem[row, col + 1]);
                        AddExplodeGem( _gem[row, col + 2]);
                        AddExplodeGem( _gem[row, col + 3]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoLeftOneRight:
                    {
                        AddExplodeGem( _gem[row, col - 2]);
                        AddExplodeGem( _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[row, col]._isVerticalElectric = true;
                        }
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                                _gem[row, col]._isFireGem = true;
                        }
                        AddExplodeGem( _gem[row, col + 1]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoRightOneLeft:
                    {
                        AddExplodeGem( _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[row, col]._isVerticalElectric = true;
                        }
                        else
                        {
                            if (CheckNotNormalGemMatch(row, col)) ;
                            else
                                _gem[row, col]._isFireGem = true;
                        }
                        AddExplodeGem( _gem[row, col + 1]);
                        AddExplodeGem( _gem[row, col + 2]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.NotExplode:
                    {
                        _explodeGroupCount--;
                        CheckColMatchType(_gem[row, col]);
                        break;
                    }

            }
        }
        private void CheckColMatchType(CGemBase gem)
        {
            var col = gem._column;
            var row = gem._row;
            _explodeGroupCount++;
            switch (IsColunmMatch(_gem[row, col]))
            {
                case ExplodeType.AllAbove:
                    {
                        AddExplodeGem(_gem[row - 2, col]);
                        AddExplodeGem( _gem[row - 1, col]);
                        if (_explodeGroupCount < 2)
                        {
                            AddExplodeGem(_gem[row, col]);
                        }
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.AllBelow:
                    {
                        if (_explodeGroupCount < 2)
                        {
                            AddExplodeGem(_gem[row, col]);
                        }
                        AddExplodeGem( _gem[row + 1, col]);
                        AddExplodeGem( _gem[row + 2, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.Balance:
                    {
                        AddExplodeGem( _gem[row - 1, col]);
                        if (_explodeGroupCount < 2)
                        {
                            AddExplodeGem(_gem[row, col]);
                        }
                        AddExplodeGem( _gem[row + 1, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.BigBalance:
                    {
                        _explodeGroupCount--;
                        AddExplodeGem(_gem[row - 2, col]);
                        AddExplodeGem(_gem[row - 1, col]);
                        //AddExplodeGem( _gem[row, col]);
                        AddExplodeGem( _gem[row + 1, col]);
                        AddExplodeGem( _gem[row + 2, col]);
                        _gem[row, col]._isSpecialGem = true;
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeAbove:
                    {
                        AddExplodeGem( _gem[row - 3, col]);
                        AddExplodeGem( _gem[row - 2, col]);
                        AddExplodeGem( _gem[row - 1, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[gem._row, gem._column]._isHorizontalElectric=true;
                        }
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeBelow:
                    {
                        if (_explodeGroupCount < 2)
                        {
                            _gem[gem._row, gem._column]._isHorizontalElectric = true;
                        }
                        AddExplodeGem( _gem[row + 1, col]);
                        AddExplodeGem( _gem[row + 2, col]);
                        AddExplodeGem( _gem[row + 3, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoAboveOneBelow:
                    {
                        AddExplodeGem( _gem[row - 2, col]);
                        AddExplodeGem( _gem[row - 1, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[gem._row, gem._column]._isHorizontalElectric = true;
                        }
                        AddExplodeGem(_gem[row + 1, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoBelowOneAbove:
                    {
                        AddExplodeGem( _gem[row - 1, col]);
                        if (_explodeGroupCount < 2)
                        {
                            _gem[gem._row, gem._column]._isHorizontalElectric = true;
                        }
                        AddExplodeGem(_gem[row + 1, col]);
                        AddExplodeGem(_gem[row + 2, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.NotExplode:
                    {
                        _explodeGroupCount--;
                        break;
                    }
            }
        }
        private bool CheckNotNormalGemMatch(uint row, uint col)
        {
            if (_gem[row, col]._isFireGem || _gem[row, col]._isSpecialGem
                            || _gem[row, col]._isVerticalElectric || _gem[row, col]._isHorizontalElectric)
            {
                AddExplodeGem(_gem[row, col]);
                return true;
            }
            return false;
        }
        private void AddExplodeGem(CGemBase gem)
        {
            var col = gem._column;
            var listGem = _explodeGemList[col];
            for(int i = 0; i < listGem.Count; i++)
            {
                if (listGem[i]._row == gem._row && listGem[i]._column == gem._column)
                    return;
            }
            if (gem._isSpecialGem == true)
            {
                _isSpecialGemExplode = true;
                _specilaGemExplodeSound.Play();
                _gem[gem._row, gem._column]._isSpecialGem = false;
                foreach (var g in _gem)
                {
                    if (g._gemType == gem._gemType)
                    {
                        AddExplodeGem(g);
                    }
                }
            }
            else if (gem._isFireGem == true)
            {
                _gem[gem._row, gem._column]._isFireGem = false;
                _isBooming = true;
                var g = gem;
                var mMin = (g._row == 0 ? 0 : (g._row - 1));
                var mMax = (g._row == 7 ? 7 : (g._row + 1));
                var nMin = (g._column == 0 ? 0 : (g._column - 1));
                var nMax = (g._column == 7 ? 7 : (g._column + 1));
                for (uint m = mMin; m <= mMax; m++)
                {
                    for (uint n = nMin; n <= nMax; n++)
                    {
                        AddExplodeGem(_gem[m, n]);
                    }
                }
            }
            else if (gem._isVerticalElectric == true)
            {
                _lightningSound.Play();
                _gem[gem._row, gem._column]._isVerticalElectric = false;
                _isVertElectricExplode[gem._column] = true;
                for(int i = 0; i < 8; i++)
                {
                    AddExplodeGem(_gem[i, gem._column]);
                }
            }
            else if (gem._isHorizontalElectric == true)
            {
                _lightningSound.Play();
                _gem[gem._row, gem._column]._isHorizontalElectric = false;
                _isHorzElectricExplode[gem._row] = true;
                for (int i = 0; i < 8; i++)
                {
                    AddExplodeGem(_gem[gem._row, i]);
                }
            }
            else
            {
                _explodeGemList[col].Add(gem);
                return;
            }

        }
        private bool GoSwap(int speed)
        {
            uint gem0Col = _proccessingGem[0]._column;
            uint gem0Row = _proccessingGem[0]._row;
            uint gem1Row = _proccessingGem[1]._row;
            uint gem1Col = _proccessingGem[1]._column;
            if (_gem[gem0Row, gem0Col]._location == _proccessingGem[1]._location)
            {
                return true;
            }
            if (_proccessingGem[0].IsRightOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapLeft(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.LeftSwap;
            }
            else if (_proccessingGem[0].IsLeftOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapRight(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.RightSwap;
            }
            else if (_proccessingGem[0].IsHeadOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapDown(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.DownSwap;
            }
            else if (_proccessingGem[0].IsBottomOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapUp(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.UpSwap;
            }
            return false;
        }

        private void timer_SwapBack_Tick(object sender, EventArgs e)
        {
            _swapSpeed -= 5;
            if (SwapBack(_swapSpeed))
            {
                timer_SwapBack.Stop();
                _proccessingGem.Clear();
                CGemBase._elementSelectedExist = false;
                //timer_selectedSpriteAnimation.Stop();
                _isMouseClickListening = true;
            }
            Invalidate();
        }
        private bool SwapBack(int speed)
        {
            uint gem0Col = _proccessingGem[0]._column;
            uint gem0Row = _proccessingGem[0]._row;
            uint gem1Row = _proccessingGem[1]._row;
            uint gem1Col = _proccessingGem[1]._column;
            if (_gem[gem0Row, gem0Col]._location == _proccessingGem[0]._location)
            {
                return true;
            }
            if (_lastSwapInfo == SwapInfo.RightSwap)
            {
                _gem[gem0Row, gem0Col].SwapLeft(_gem[gem1Row, gem1Col], speed);
            } else if (_lastSwapInfo == SwapInfo.LeftSwap)
            {
                _gem[gem0Row, gem0Col].SwapRight(_gem[gem1Row, gem1Col], speed);
            }
            else if (_lastSwapInfo == SwapInfo.UpSwap)
            {
                _gem[gem0Row, gem0Col].SwapDown(_gem[gem1Row, gem1Col], speed);
            }
            else if (_lastSwapInfo == SwapInfo.DownSwap)
            {
                _gem[gem0Row, gem0Col].SwapUp(_gem[gem1Row, gem1Col], speed);
            }
            return false;
        }
        private ExplodeType IsRowMatch(CGemBase checkingGem)
        {
            var type = checkingGem._gemType;
            var row = checkingGem._row;
            var col = checkingGem._column;
            if (col > 1 && col < 6)
            {
                if(type==_gem[row,col-2]._gemType&&type==_gem[row,col+2]._gemType
                    &&type == _gem[row, col - 1]._gemType && type == _gem[row, col + 1]._gemType)
                {
                    return ExplodeType.BigBalance;
                }
            }
            if (col > 2)
            {
                if (type == _gem[row, col - 2]._gemType && type == _gem[row, col - 1]._gemType
                    && type == _gem[row, col - 3]._gemType)
                    return ExplodeType.ThreeLeft;
            }
            if (col <5)
            {
                if (type == _gem[row, col + 2]._gemType && type == _gem[row, col + 1]._gemType
                    && type == _gem[row, col + 3]._gemType)
                    return ExplodeType.ThreeRight;
            }
            if (col > 1 && col < 7)
            {
                if (type == _gem[row, col - 2]._gemType && type == _gem[row, col - 1]._gemType
                    && _gem[row, col + 1]._gemType == type)
                    return ExplodeType.TwoLeftOneRight;
            }
            if (col > 0 && col < 6)
            {
                if (type == _gem[row, col + 2]._gemType && _gem[row, col + 1]._gemType == type
                    && type == _gem[row, col - 1]._gemType)
                    return ExplodeType.TwoRightOneLeft;
            }
            if (col > 0 && col < 7)
            {
                if(type == _gem[row, col - 1]._gemType && type == _gem[row, col + 1]._gemType)
                    return ExplodeType.Balance;
            }
            if(col >1)
            {
                if(type == _gem[row, col - 2]._gemType && type == _gem[row, col - 1]._gemType)
                    return ExplodeType.AllLeft;
            }
            if (col < 6 )
            {
                if(type == _gem[row, col + 2]._gemType && _gem[row, col + 1]._gemType == type)
                    return ExplodeType.AllRight;
            }
            return ExplodeType.NotExplode;

        }
        private ExplodeType IsColunmMatch(CGemBase checkingGem)
        {
            var type = checkingGem._gemType;
            var row = checkingGem._row;
            var col = checkingGem._column;
            if (row > 1 && row < 6)
            {
                if (type == _gem[row - 1, col]._gemType && type == _gem[row + 1, col]._gemType
                    && type == _gem[row - 2, col]._gemType && type == _gem[row + 2, col]._gemType)
                    return ExplodeType.BigBalance;
            }
            if (row > 2)
            {
                if (type == _gem[row - 2, col]._gemType && type == _gem[row - 1, col]._gemType
                    && type == _gem[row - 3, col]._gemType)
                    return ExplodeType.ThreeAbove;
            }
            if (row < 5)
            {
                if (_gem[row + 2, col]._gemType == type && type == _gem[row + 1, col]._gemType
                    && _gem[row + 3, col]._gemType == type)
                    return ExplodeType.ThreeBelow;
            }
            if (row > 1 && row < 7)
            {
                if (type == _gem[row - 2, col]._gemType && type == _gem[row - 1, col]._gemType
                    && type == _gem[row + 1, col]._gemType)
                    return ExplodeType.TwoAboveOneBelow;
            }
            if (row < 6 && row > 0)
            {
                if (_gem[row + 2, col]._gemType == type && type == _gem[row + 1, col]._gemType
                    && type == _gem[row - 1, col]._gemType)
                    return ExplodeType.TwoBelowOneAbove;
            }
            if (row > 0 && row < 7 )
            {
                if(type == _gem[row - 1, col]._gemType && type == _gem[row + 1, col]._gemType)
                    return ExplodeType.Balance;
            }
            if (row > 1  )
            {
                if(type == _gem[row - 2, col]._gemType && type == _gem[row - 1, col]._gemType)
                    return ExplodeType.AllAbove;
            }
            if (row < 6 )
            {
                if (_gem[row + 2, col]._gemType == type && type == _gem[row + 1, col]._gemType)
                    return ExplodeType.AllBelow;
            }
            return ExplodeType.NotExplode;
        }

        private void timer_Explode_Tick(object sender, EventArgs e)
        {
            
            _explodeGemFrameIndex++;
            if (_explodeGemFrameIndex > 1)
            {
                _isFlashExplode = false;
            }
            if (_explodeGemFrameIndex  >= 6)
            {
                if (_isBooming == true)
                {
                    timer_boom_animation.Start();
                    Invalidate();
                }
                else
                {
                    _isSpecialGemExplode = false;
                    for(int i = 0; i < 8; i++)
                    {
                        _isVertElectricExplode[i] = false;
                        _isHorzElectricExplode[i] = false;
                    }
                    timer_Explode.Stop();
                    // _explodeGemList.Clear();
                    // _isMouseClickListening = true;
                    // _explodeGemFrameIndex = 0;
                    if (_monoSound == false)
                    {
                        if (_explodeWave < 6)
                        {
                            _crushSound[_explodeWave - 1].Play();
                        }
                        else _finalCrushSound.Play();
                    }
                    _isExploding = false;
                    CGemBase._elementSelectedExist = false;
                    _lastSwapInfo = SwapInfo.NullSwap;
                    _normalGemFrameIndex = 0;
                    _whiteGemFrameIndex = 0;
                    _swapSpeed = 0;
                    UpdateOldGemAndAddNewGemAttribute();
                    SetScoreInOneMove();
                    timer_updateScreen.Start();
                }
                
            }
            else Invalidate();

        }
        private void SetScoreInOneMove()
        {
            for(int i = 0; i < 8; i++)
            {
                _scoreInOneMove += (uint)(_explodeGemList[i].Count) * _explodeWave*60;
            }
        }
        private uint SearchLowestRowExplodeGem(List<CGemBase> gemList)
        {
            uint Lowest = 0;
            foreach(var gem in gemList)
            {
                if (gem._row > Lowest)
                {
                    Lowest = gem._row;
                }
            }
            return Lowest;
        }
        private void UpdateOldGemAndAddNewGemAttribute()
        {
            int [] not_normal_gem_count = new int[8];
            for (int i = 0; i < 8; i++)
            {
                not_normal_gem_count[i] = 0;
            }
            for(int i = 0; i < 8; i++)
            {
                var maxRowIndex = SearchLowestRowExplodeGem(_explodeGemList[i]);
                for(int j = (int)maxRowIndex;j>=_explodeGemList[i].Count ; j--)
                {
                    if (j > 0)
                    {
                        int gemmFlag = j - 1;
                        while (ExistInExplodeListOrDoneUpdate(_gem[gemmFlag, i]))
                        {
                            gemmFlag--;
                        }
                        _gem[j, i]._location = _gem[gemmFlag, i]._location;
                        SwapExceptLocation(_gem[j, i], _gem[gemmFlag, i]);
                        _updatedGemList.Add(_gem[gemmFlag, i]);
                    }
                }
                for(int j = 0; j < _explodeGemList[i].Count; j++)
                {
                    _gem[j,i] = new CGemBase(
                        new Point((int)(this.label1.Location.X + (50 * i)), (_explodeGemList[i].Count-1-j)*-50)
                        , (uint)j
                        , (uint)i
                        , (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100)%(CLevel._currLevel.LevelID + 4>7?7: CLevel._currLevel.LevelID + 4));
                    _colToCheckExplode[i] = true;
                }
                _updatedGemList.Clear();
            }
        }
        private bool ExistInExplodeListOrDoneUpdate(CGemBase gem)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < _explodeGemList[i].Count; j++)
                {
                    if (gem._row == _explodeGemList[i][j]._row && gem._column == _explodeGemList[i][j]._column)
                    {
                        return true;
                    }
                }
            }
            for(int i = 0; i < _updatedGemList.Count; i++)
            {
                if (gem._row == _updatedGemList[i]._row && gem._column == _updatedGemList[i]._column)
                {
                    return true;
                }
            }
            return false;
        }
        private void UpdateOldGemLocation(int speed)
        {
            for (int i =0; i < 8; i++)
            {
                for(int j= (int)SearchLowestRowExplodeGem(_explodeGemList[i]); j>=_explodeGemList[i].Count;j--)
                {
                    if (_gem[j, i]._location.Y < 150 + 50 * j)
                    {
                        _gem[j, i]._location = new Point(_gem[j, i]._location.X, _gem[j, i]._location.Y + speed);
                    }
                }
            }
        }
        private void UpdateNewGemLocation(int speed)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = _explodeGemList[i].Count-1; j>=0 ; j--)
                {
                    if (_gem[j, i]._location.Y < 150 + 50 * j)
                    {
                        _gem[j, i]._location = new Point(_gem[j, i]._location.X, _gem[j, i]._location.Y + speed);
                    }
                }
            }
        }
        private void timer_updateScreen_Tick(object sender, EventArgs e)
        {
            var updateSuccessfullyColCount = 0;
            UpdateOldGemLocation(25);
            UpdateNewGemLocation(25);
            Invalidate();      
            for(int i = 0; i < 8; i++)
            {
                if (_gem[0, i]._location.Y == this.label1.Location.Y)
                {
                    updateSuccessfullyColCount++;
                }
            }
            if(updateSuccessfullyColCount==8)
            {
                timer_updateScreen.Stop();
                ReInitialize();
                for(int i = 0; i < 8; i++)
                {
                    if (_colToCheckExplode[i] == true)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            CheckExplode((uint)j,(uint)i);
                        }
                    }
                    _colToCheckExplode[i] = false;
                }
                if (_isExploding == true)
                {
                    timer_Explode.Start();
                    _isMouseClickListening = false;
                    _explodeWave++;
                }
                else _explodeWave = 0;
            }
        }
        private void ReInitialize()
        {
            _isMouseClickListening = true;
            _lastSwapInfo = SwapInfo.NullSwap;
            _explodeGemFrameIndex = 0;
            foreach(var list in _explodeGemList)
            {
                list.Clear();
            }
            _proccessingGem.Clear();
            CGemBase._elementSelectedExist = false;
            _isExploding = false;
            timer_GoSwap.Stop();
            timer_Explode.Stop();
            timer_updateScreen.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_scoreCount_Tick(object sender, EventArgs e)
        {
            if (_scoreInOneMove > 0)
            {
                if (CLevel._currLevel.LevelID > 2)
                {
                    _score += 20;
                    _scoreInOneMove -= 20;
                    Invalidate();
                }
                else
                {
                    _score += 60;
                    _scoreInOneMove -= 60;
                    Invalidate();
                }
            }
        }

        private void timer_gameTimeLimit_Tick(object sender, EventArgs e)
        {
            if (timer_updateScreen.Enabled == false)
            {
                this.progressBar1.Value -= 1;
            }
            if (this.progressBar1.Value == 0)
            {
                timer_gameTimeLimit.Stop();
                
                if (_score > _targetScore[CLevel._currLevel.LevelID])
                {
                    uint star = 1;
                    uint gold = 0;
                    ReInitialize();
                    _victorySound.Play();
                    if (_score > CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestScore)
                    {
                        if (_score > _targetScore[CLevel._currLevel.LevelID] + 1000)
                        {
                            star++;
                        }
                        if (_score > _targetScore[CLevel._currLevel.LevelID] + 3000)
                        {
                            star++;
                        }
                        if (star > CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestStar)
                        {
                            gold=(star - CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestStar) * 50;
                            CUser.Instance()._goldCount += gold;
                            CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestStar=star;
                        }
                        MessageBox.Show("New high score : "+_score.ToString()+"\n You earn "+gold.ToString()+" gold. Congratulation!" );
                    }
                    else
                    {
                        MessageBox.Show("You win! Last time you do better!");
                    }
                    if (CUser.Instance()._currLevel == CLevel._currLevel.LevelID )
                    {
                        CUser.Instance()._currLevel++;
                    }
                    if (CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestScore < _score)
                    {
                        CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestScore = _score; 
                    }
                    CUser.UpdateOfflineUserInfo();
                    CLevel.UpdateOfflineLevelInfo((int)CLevel._currLevel.LevelID);
                    this.Close();

                }
                else
                {
                    ReInitialize();
                    _gameOverSound.Play();
                    MessageBox.Show("Game over!");
                    this.Close();
                }

            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            _victorySound.Stop();
            _score = 0;
        }

        private void but_back_picBox_Click(object sender, EventArgs e)
        {
            this.Close();
            CUser.Instance()._lifeCount--;
            CUser.UpdateOfflineUserInfo();
            MessageBox.Show("You have just lost 1 life.");
            this.Dispose();
        }
        private Point _curMouseLocation;

        private void timer_using_item_animation_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            _curMouseLocation = new Point(e.X + this.label1.Location.X, e.Y + this.label1.Location.Y);
        }

        private void timer_not_normal_gem_Tick(object sender, EventArgs e)
        {

        }

        private void timer_boom_animation_Tick(object sender, EventArgs e)
        {
            _boomAnimationFrame++;
            if (_boomAnimationFrame == 5)
            {
                _monoSound = true;
                _boomSound.Play();
            }
            if (_boomAnimationFrame / 18 == 1)
            {
                _boomAnimationFrame = 0;
                _isBooming = false;
                timer_boom_animation.Stop();
                _monoSound = false;
            }
            else
                Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isHarmmerChosen = false;
            _isFlashChosen = false;
            _isSandClockChosen = false;
            if (CUser.Instance()._flashCount > 0)
            {
                _isFlashChosen = true;
                
                timer_using_item_animation.Start();
            }
            else
            {
                MessageBox.Show("You don't have any flash. Go to shop to find this item.");
            }
            
        }
        private double _soundDuration = 0;
        private void timer_sound_count_Tick(object sender, EventArgs e)
        {
            _soundDuration+=0.5;
            if (_soundDuration == 1.5)
            {
                _monoSound = false;
                _thunderSound.Stop();
                timer_sound_count.Stop();
                _soundDuration = 0;
            }
        }

        private bool _monoSound = false;
        private void button3_Click(object sender, EventArgs e)
        {
            _isHarmmerChosen = false;
            _isFlashChosen = false;
            _isSandClockChosen = false;
            if (CUser.Instance()._sandClockCount > 0)
            {
                _clockSound.Play();
                if (progressBar1.Value > 50)
                {
                    progressBar1.Value = 100;
                }
                else
                {
                    progressBar1.Value += 50;
                }
                CUser.Instance()._sandClockCount--;
                CUser.UpdateOfflineItemCount();
                AutoSetItemCount();
            }
            else
            {
                MessageBox.Show("You don't have any sand clock. Go to shop to find this item.");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _isFlashChosen = false;
            _isSandClockChosen = false;
            if (CUser.Instance()._harmmerCount > 0)
            {
                _isHarmmerChosen = true;
                timer_using_item_animation.Start();
            }
            else
            {
                MessageBox.Show("You don't have any harmmer. Go to shop to find this item.");
            }
        }
    }
}
